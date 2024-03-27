#include "DFRobot_BME280.h"  //potrzebne biblioteki
#include "WiFi.h"
#include "Wire.h"
#define SEALEVELPRESSURE_HPA 1015.0f

typedef DFRobot_BME280_IIC    BME; // żeby za każdym razem nie trzeba było używać pełnej nazwy
BME   bme(&Wire, 0x76); //inicjalziacja BME do komunikacji przez i2C po adresie 0x76

const char* ssid     = "NETIASPOT-2.4GHz-5Pdb";
const char* password = "--------";   //Dane połączenia z WiFi - nazwa sieci i hasło(hasło usunąłem ze względów bezpieczeńtwa)

WiFiServer server(80); // ustawienie serwera na porcie 80

float temp, hum, press, alti; //zmiennie temperatury, wilgotności i ciśnienia

String header;  //zmienna dla headera HTML

void setup() {
  Serial.begin(115200);  // start komunikacji przez serial 
  delay(100);
  Serial.println("Project Startup");

  while(bme.begin() != BME::eStatusOK) {   //inicjalizacja sensora BME280 i sprawdzenie czy jest poprawnie podłączony
    Serial.println("bme begin faild");
    delay(1000);
    }
    //Ustawienie jak najlepszej konfiguracji sensora
  bme.setConfigFilter(BME::eConfigFilter_off);       //wyłączenie filtru konfiguracyjnego
  bme.setConfigTStandby(BME::eConfigTStandby_125);    // Ustawienie czasu oszczędzania energii na 125ms
  bme.setCtrlMeasSamplingTemp(BME::eSampling_X8);     //Ustawienie próbkowania pomiaru temperatury na 8
  bme.setCtrlMeasSamplingPress(BME::eSampling_X8);  //Ustawienie próbkowania pomiaru ciśnienia na 8
  bme.setCtrlHumiSampling(BME::eSampling_X8);         //Ustawienie próbkowania pomiaru wilgotności na 8
  bme.setCtrlMeasMode(BME::eCtrlMeasMode_normal);     //normalny tryb pomiaru wartości

  Serial.println("Connecting to WiFi ");
  Serial.println(ssid);
  WiFi.begin(ssid, password);  // Połączenie się z siecią WiFI

  while (WiFi.status() != WL_CONNECTED){        //Czeka na połączenie z WiFi
    delay(5000);
    Serial.println("waiting for connection");
  }
  
  Serial.println("WiFi connection was set successfully");
  Serial.println("WebServer started at IP: ");
  Serial.println(WiFi.localIP());
  server.begin(); //start serwera
}

void loop() {
  float   temp = bme.getTemperature();  //odczyt danych z sensora i wpisanie ich do zmiennych
  uint32_t    press = bme.getPressure();
  float   alti = bme.calAltitude(SEALEVELPRESSURE_HPA, press);
  float   humi = bme.getHumidity();
  WiFiClient client = server.available();  // sprawdzenie, czy klient jest podłączony do serwera
  if (client){
    Serial.println("New client");
    String currentLine = "";
    while(client.connected()){
      if(client.available()){
        char c = client.read(); //odczyt danych z klienta
        Serial.write(c);
        header += c;
        if(c == '\n'){
          if (currentLine.length() == 0) {  //sprawdzenie headera
            client.println("HTTP/1.1 200 OK");
            client.println("Content-type:text/html");
            client.println("Connection: close");
            client.println();
            client.println("<style>");
            client.println(".pretty-table{border-collapse: collapse;width: 100%;margin: 0 auto;}");
            client.println(".pretty-table th, .pretty-table td {border: 1px solid #dddddd;text-align: left;padding: 8px;}");
            client.println(".pretty-table th {background-color: #dddddd;font-size: 1.2em;}");
            client.println(".pretty-table caption{font-size: 1.5em;font-weight: bold;text-align: center;margin-bottom: 10px;}");
            client.println("</style>");
            client.println("<table class='pretty-table'>");
            client.println("<tr>");
            client.println("<th> MEASUREMENT </th>");
            client.println("<th> VALUE </th>");
            client.println("</tr>");
            client.println("<tr>");
            client.println("<th> Temperature in Celcius </th>");
            client.println("<th>" + String(temp) + " *C </th>");
            client.println("</tr>");
            client.println("<tr>");
            client.println("<th> Pressure </th>");
            client.println("<th>" + String(press/100.0f) + " hPa </th>");
            client.println("</tr>");
            client.println("<tr>");
            client.println("<th> Approximately Altitude </th>");
            client.println("<th>" + String(alti) + " meters </th>");
            client.println("</tr>");
            client.println("<tr>");
            client.println("<th> Humidity </th>");
            client.println("<th>" + String(humi) + "% </th>");
            client.println("</tr>");
            client.println("</table>");
            client.println();
            break;
            } else { 
            currentLine = "";
          }
        } else if (c != '\r') {  
          currentLine += c;     
        }
      }
    }
header = "";
client.stop();
Serial.println("Client disconnected");
  }
 }



