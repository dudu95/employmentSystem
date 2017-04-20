using System;

namespace Model
{
   public class EmployerViewModel
    { 
       /// <summary>
		/// construction method
		/// </summary>
		// PK（identity）  
		public Int32 employerId { get;set; }
		// 
		public String name { get;set; }
		// 
		public String site { get;set; }
		// 
		public Int32 companyCateId { get;set; }
        public String cateName { get; set; }

		// 
		public Int32 investmentStateId { get;set; }
        public String stateName { get; set; }

		// 
		public String city { get;set; }
		// 
		public String address { get;set; }
		// 
		public String scale { get;set; }
		// 
		public String intro { get;set; }
		// 
		public String note { get;set; }
		// 
		public String logo { get;set; }

        public Int32 positionId { get; set; }
        // 
        public String position { get; set; }
        // 
        public Int32 workingLifeId { get; set; }

        public String workingLife { get; set; }

        // 
        public Int32 educationId { get; set; }

        public String educationName { get; set; }

        // 
        public String salary { get; set; }
        // 
        public String advantage { get; set; }
        // 
        public String describe { get; set; }


    }
}
