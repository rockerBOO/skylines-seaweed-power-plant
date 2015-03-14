using ICities;
using UnityEngine;

namespace SeaweedPowerPlant {
    public class SeaweedPowerPlantMod : IUserMod { 
        public string Name {
            get { return "Seaweed Power Plant"; } 
        } 

        public string Description {
            get { return "Farm and process seaweed into power."; } 
        } 
    }




    public class SeaweedPowerPlant {

        public override int OnGetConstructionCost(int originalConstructionCost, Service service, SubService subService, Level level) {
            return originalConstructionCost * 2;
        }

        public override int OnGetMaintenanceCost(int originalMaintenanceCost, Service service, SubService subService, Level level) {
            return originalMaintenanceCost * 2;
        }

        public override int OnGetRelocationCost(int constructionCost, int relocationCost, Service service, SubService subService, Level level) {
            return relocationCost;
        }

        public override int OnGetRefundAmount(int constructionCost, int refundAmount, Service service, SubService subService, Level level) {
            return refundAmount;
        }

        public override void OnCreated(<IRelatedManager> instance) {

        }

        public void OnReleased() {

            
        }
    }
} 