using DataProvider.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using static DataProvider.Enums.CarEnums;

namespace DataProvider.Entities
{
    public class Car
    {
        public long? Id { get; set; }
        public string Color { get; set; }
        public Model Type { get; set; }
        public long KmAmount { get; set; }

        private EngineSprocket engineSprocket { get; set; }
        private PoppetValve poppetValve { get; set; }
        private int engineOilLevel { get; set; }

        public Car()
        {
            setInitialEngineOilLevel();
            engineSprocket = new EngineSprocket();
            poppetValve = new PoppetValve();
        }

        public void setInitialEngineOilLevel()
        {
            engineOilLevel = 100;
        }

        public string GetCurrentModel()
        {
            return "This car is a " + this.Type;
        }

        public bool HasSunRoof()
        {
            switch (this.Type)
            {
                case Model.Peugeot208Phase1:
                    return true;
                case Model.QashqaiTekna:
                    return true;
                case Model.QashqaiVisia:
                    return true;
                case Model.QashqaiNConnecta:
                    return false;
                case Model.QashqaiAcenta:
                    return true;
                case Model.ScenicPhase1:
                    return false;
                case Model.ScenicPhase2:
                    return false;
                case Model.Peugeot208Phase2:
                    return true;
                default:
                    return false;
            }
        }

        public bool Start()
        {
            try
            {
                this.engineSprocket.Prime();
                var startOk = this.engineSprocket.Engage();
                if (this.engineOilLevel < 20)
                {
                    throw new Exception("Impossible to start the car, oil level too low");
                }
                return startOk;
            }
            catch (Exception)
            {
                throw new Exception("The engine could not be started");
            }
        }

        public static float GetNumberOfSeats(Model type)
        {
            if (type == Model.QashqaiAcenta)
            {
                return 4;
            }
            if (type == Model.QashqaiNConnecta)
            {
                return 4;
            }
            if (type == Model.QashqaiTekna)
            {
                return 5;
            }
            return 0;
        }
    }
}
