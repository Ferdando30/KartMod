using UnityEngine;


namespace KartGame.KartSystems {
    
    public class KeyboardInput : BaseInput
    {
        public string TurnInputName = "Horizontal";
        public string AccelerateButtonName = "Accelerate";
        public string BrakeButtonName = "Brake";
        public BrokenKart BrokenKartScript;
        
        public override InputData GenerateInput() {
            
            if(BrokenKartScript.Broken == false)
            {
                return new InputData
                {
                    Accelerate = Input.GetButton(AccelerateButtonName),
                    Brake = Input.GetButton(BrakeButtonName),
                    TurnInput = Input.GetAxis(TurnInputName)
                    
                };
                
            }
            else
            {
                return new InputData
                {
                    Accelerate = false,
                    Brake = false,
                    TurnInput = 0
                };
            }
        }
    }
}

