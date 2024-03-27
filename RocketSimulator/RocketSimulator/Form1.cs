using RocketSimulator.Commands;
using RocketSimulator.Components;

namespace RocketSimulator
{
    public partial class Form1 : Form
    {
        Dictionary<PictureBox, IControlComponent> buttonActions = new Dictionary<PictureBox, IControlComponent>();
        Dictionary<ScrollBar, (IControlComponent, Label)> analogActions = new Dictionary<ScrollBar, (IControlComponent, Label)>();
        Dictionary<Component, PictureBox> rocketComponents = new Dictionary<Component, PictureBox>();
        Dictionary<PictureBox, bool> buttonStates = new Dictionary<PictureBox, bool>();

        Dictionary<Sensor, ProgressBar> sensorValues = new Dictionary<Sensor, ProgressBar>();

        PowerSystem power;
        PowerSystemCommand powerSystem;

        DistanceSensor distanceSensor;
        ControlPanel controlPanel = new ControlPanel();

        int completedPlanets = 0;
        int planetsToComplete = 3;

        void AddCommand(PictureBox control, IControlComponent controlComponent, PictureBox image, Component component)
        {
            buttonActions.Add(control, controlComponent);
            buttonStates.Add(control, false);
            rocketComponents.Add(component, image);
        }

        void AddAnalogCommand(ScrollBar control, IControlComponent controlComponent, Label valueLabel, PictureBox image, Component component)
        {
            analogActions.Add(control, (controlComponent, valueLabel));
            rocketComponents.Add(component, image);
        }

        void AddSensor(PictureBox control, IControlComponent controlComponent, PictureBox image, Sensor sensor, ProgressBar visualValue)
        {
            AddCommand(control, controlComponent, image, sensor);
            sensorValues.Add(sensor, visualValue);
        }

        void NewGame()
        {
            foreach (var sensor in sensorValues)
                sensor.Key.reset();

            powerSystem.reset();
            completedPlanets = 0;
            isSimulationOn = true;
            gameOverLabel.Visible = gameOverReasonLabel.Visible = newGameButton.Visible = false;
            onPlanet = false;
            UpdateMissionCompleted();
        }

        void UpdateMissionCompleted()
        {
            missionCompletionLabel.Text = $"{completedPlanets} / {planetsToComplete}";

            missionCompletionProgressBar.Maximum = (400 + completedPlanets * 150);
        }

        bool onPlanet = false;
        void Continue()
        {
            gameOverLabel.Visible = gameOverReasonLabel.Visible = newGameButton.Visible = false;
            onPlanet = false;
            isSimulationOn = true;
        }

        void PlanetReached()
        {
            completedPlanets++;
            missionCompletionProgressBar.Value = 0;
            distanceSensor.reset();
            powerSystem.reset();

            UpdateMissionCompleted();

            isSimulationOn = false;
            newGameButton.Text = "CONTINUE";
            gameOverLabel.Text = $"Planet {completedPlanets} reached";
            gameOverLabel.ForeColor = Color.Orange;
            gameOverReasonLabel.Text = $"Next planet: Planet {completedPlanets + 1}";
            gameOverLabel.Visible = gameOverReasonLabel.Visible = newGameButton.Visible = true;
            onPlanet = true;

            if (completedPlanets >= planetsToComplete)
                GameOverSuccess();
        }

        void EndGame(string message)
        {
            isSimulationOn = false;
            newGameButton.Text = "NEW GAME";
            gameOverReasonLabel.Text = message;
            gameOverLabel.Visible = gameOverReasonLabel.Visible = newGameButton.Visible = true;
            onPlanet = false;
        }

        void GameOverSuccess()
        {
            gameOverLabel.Text = "Success!";
            gameOverLabel.ForeColor = Color.Green;
            EndGame("Mission completed successfully");
        }

        void GameOver(string message)
        {
            gameOverLabel.Text = "GAME OVER";
            gameOverLabel.ForeColor = Color.Red;
            EndGame(message);
        }

        bool isSimulationOn = false;
        System.Windows.Forms.Timer? simulationTimer;
        void StartSimulation()
        {
            UpdateMissionCompleted();

            simulationTimer = new System.Windows.Forms.Timer();
            simulationTimer.Interval = 500;
            simulationTimer.Tick += (s, e) =>
            {
                if (!isSimulationOn)
                    return;

                var energyUsage = 0f;
                foreach (var comp in rocketComponents)
                {
                    energyUsage += comp.Key.EnergyUsage;
                }

                powerSystem.runSimulation(energyUsage);
                powerLevelBar.Value = (int)power.Energy;

                // Turn off all devices if power is off
                if (!power.IsPowerFlowing)
                {
                    foreach (var state in buttonStates)
                    {
                        if (state.Value)
                        {
                            changeComponentState(state.Key, state.Key.Name == "powerLever");
                        }
                    }

                    foreach (var slider in analogActions.Keys)
                        slider.Value = 100;

                }

                foreach (var sensor in sensorValues)
                {
                    sensor.Key.runSimulation();
                    sensor.Value.Value = (int)sensor.Key.getValue();

                    var safe = sensor.Key.isNotSafe();
                    if (safe != 0)
                        GameOver(sensor.Key.Name + (safe < 0 ? " too low" : " too high"));
                }

                if (missionCompletionProgressBar.Value == missionCompletionProgressBar.Maximum)
                {
                    PlanetReached();
                }
            };
            simulationTimer.Start();
        }

        public Form1()
        {
            InitializeComponent();

            var door = new Door("Back");
            AddCommand(doorButton, new DoorCommand(door), doorPictureBox, door);

            var engine = new Engine();
            AddAnalogCommand(enginePowerSlider, new EngineCommand(engine), enginePowerLabel, enginePictureBox, engine);

            distanceSensor = new DistanceSensor(engine, missionCompletionProgressBar, speedLabel);
            sensorValues.Add(distanceSensor, missionCompletionProgressBar);

            var oxygen = new OxygenSensor(door);
            AddSensor(oxygenButton, new OxygenSensorCommand(oxygen), oxygenPictureBox, oxygen, oxygenSensorValue);

            var temp = new TemperatureSensor(door);
            AddSensor(tempButton, new TemperatureSensorCommand(temp), heaterPictureBox, temp, temperatureValueBar);

            power = new PowerSystem();
            powerSystem = new PowerSystemCommand(power);
            AddCommand(powerLever, powerSystem, powerOnBox, power);

            StartSimulation();
        }

        private void changeComponentState(PictureBox c, bool isLever)
        {
            var action = buttonActions[c];
            controlPanel.AddCommand(action);
            controlPanel.Execute();

            var state = buttonStates[c];
            state = !state;
            if (state)
            {
                c.Image = isLever ? Properties.Resources.power_lever_on : Properties.Resources.button_green;
            }
            else
            {
                c.Image = isLever ? Properties.Resources.power_lever_off : Properties.Resources.button_red;
            }
            buttonStates[c] = state;

            foreach (var comp in rocketComponents)
                comp.Value.Image = comp.Key.Image;
        }

        private void reactToButtonClick(object sender)
        {
            if (sender is not PictureBox c)
                return;

            if (!buttonActions.ContainsKey(c) || !buttonStates.ContainsKey(c))
                return;

            var isPowerLever = c.Name == "powerLever";
            if (!power.IsPowerFlowing && !isPowerLever)
                return;

            changeComponentState(c, isPowerLever);
        }

        private void doorButton_Click(object sender, EventArgs e) => reactToButtonClick(sender);
        private void engineButton_Click(object sender, EventArgs e) => reactToButtonClick(sender);
        private void oxygenButton_Click(object sender, EventArgs e) => reactToButtonClick(sender);
        private void tempButton_Click(object sender, EventArgs e) => reactToButtonClick(sender);
        private void powerButton_Click(object sender, EventArgs e) => reactToButtonClick(sender);
        private void powerLever_Click(object sender, EventArgs e) => reactToButtonClick(sender);

        private void enginePowerSlider_Scroll(object sender, EventArgs e)
        {
            if (sender is not ScrollBar sb)
                return;

            if (!analogActions.ContainsKey(sb))
                return;

            var (component, label) = analogActions[sb];

            var value = (100f - sb.Value) / 100f;
            component.Execute(value);
            label.Text = ((int)(value * 100f)).ToString() + "%";

            foreach (var comp in rocketComponents)
                comp.Value.Image = comp.Key.Image;
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            if (onPlanet)
            {
                Continue();
            }
            else
            {
                NewGame();
            }
        }
    }
}