﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace SubmissionCase_E2E
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The InsuredDetails_Vechicle_Information_FooterMapping recording.
    /// </summary>
    [TestModule("f5881cf3-fcd8-467a-a6db-701907a09d9e", ModuleType.Recording, 1)]
    public partial class InsuredDetails_Vechicle_Information_FooterMapping : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static InsuredDetails_Vechicle_Information_FooterMapping instance = new InsuredDetails_Vechicle_Information_FooterMapping();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public InsuredDetails_Vechicle_Information_FooterMapping()
        {
            ID_VI_LicensePlate = "";
            ID_VI_LicensePlateState = "";
            ID_VD_Vin_Year = "";
            ID_VD_VIN_Make = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static InsuredDetails_Vechicle_Information_FooterMapping Instance
        {
            get { return instance; }
        }

#region Variables

        string _ID_VI_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable ID_VI_LicensePlate.
        /// </summary>
        [TestVariable("ca40622f-067c-41be-8f70-0adbbd3bf42d")]
        public string ID_VI_LicensePlate
        {
            get { return _ID_VI_LicensePlate; }
            set { _ID_VI_LicensePlate = value; }
        }

        string _ID_VI_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable ID_VI_LicensePlateState.
        /// </summary>
        [TestVariable("21b64742-0bc2-44af-b9de-6feb67ff3644")]
        public string ID_VI_LicensePlateState
        {
            get { return _ID_VI_LicensePlateState; }
            set { _ID_VI_LicensePlateState = value; }
        }

        string _ID_VD_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable ID_VD_Vin_Year.
        /// </summary>
        [TestVariable("7e315b0e-30ac-4b2c-9d02-6e4ad06acffb")]
        public string ID_VD_Vin_Year
        {
            get { return _ID_VD_Vin_Year; }
            set { _ID_VD_Vin_Year = value; }
        }

        string _ID_VD_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable ID_VD_VIN_Make.
        /// </summary>
        [TestVariable("3439a3f5-fd2b-49f1-b886-3b39b8b2db1d")]
        public string ID_VD_VIN_Make
        {
            get { return _ID_VD_VIN_Make; }
            set { _ID_VD_VIN_Make = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -480 units.", new RecordItemIndex(0));
            Mouse.ScrollWheel(-480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Footer_ClaimInfo' at 50;13.", repo.ApplicationUnderTest.Footer_ClaimInfoInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.Footer_ClaimInfo.Click("50;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Insured_Info' at 56;6.", repo.ApplicationUnderTest.Insured_InfoInfo, new RecordItemIndex(2));
            repo.ApplicationUnderTest.Insured_Info.Click("56;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -120 units.", new RecordItemIndex(3));
            Mouse.ScrollWheel(-120);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by 240 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Insured Vehicle Information') on item 'ApplicationUnderTest.FooterMappingInsured_Vehicle_Information'.", repo.ApplicationUnderTest.FooterMappingInsured_Vehicle_InformationInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingInsured_Vehicle_InformationInfo, "InnerText", "Insured Vehicle Information");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Vehicle Information') on item 'ApplicationUnderTest.FooterMappingVehicle_Information'.", repo.ApplicationUnderTest.FooterMappingVehicle_InformationInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingVehicle_InformationInfo, "InnerText", "Vehicle Information");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Do you have VIN Number?') on item 'ApplicationUnderTest.FooterMappingDo_you_have_VIN_Number'.", repo.ApplicationUnderTest.FooterMappingDo_you_have_VIN_NumberInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingDo_you_have_VIN_NumberInfo, "InnerText", "Do you have VIN Number?");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='No') on item 'ApplicationUnderTest.FooterMappingNo'.", repo.ApplicationUnderTest.FooterMappingNoInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingNoInfo, "InnerText", "No");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='License plate') on item 'ApplicationUnderTest.FooterMappingLicense_plate'.", repo.ApplicationUnderTest.FooterMappingLicense_plateInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingLicense_plateInfo, "InnerText", "License plate");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_VI_LicensePlate) on item 'ApplicationUnderTest.FooterMappingID_VI_LicensePlate'.", repo.ApplicationUnderTest.FooterMappingID_VI_LicensePlateInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_VI_LicensePlateInfo, "InnerText", ID_VI_LicensePlate);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='License Plate State') on item 'ApplicationUnderTest.FooterMappingLicense_Plate_State'.", repo.ApplicationUnderTest.FooterMappingLicense_Plate_StateInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingLicense_Plate_StateInfo, "InnerText", "License Plate State");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_VI_LicensePlateState) on item 'ApplicationUnderTest.FooterMappingID_VI_State'.", repo.ApplicationUnderTest.FooterMappingID_VI_StateInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_VI_StateInfo, "InnerText", ID_VI_LicensePlateState);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Enter model details manually') on item 'ApplicationUnderTest.FooterMapping_Enter_model_details_manually'.", repo.ApplicationUnderTest.FooterMapping_Enter_model_details_manuallyInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_Enter_model_details_manuallyInfo, "InnerText", "Enter model details manually");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='yourtext') on item 'ApplicationUnderTest.False'.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(14));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.FalseInfo, "InnerText", "yourtext");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Year') on item 'ApplicationUnderTest.FooterMappingYear'.", repo.ApplicationUnderTest.FooterMappingYearInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingYearInfo, "InnerText", "Year");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_VD_Vin_Year) on item 'ApplicationUnderTest.FooterMappingID_VI_Year_Value'.", repo.ApplicationUnderTest.FooterMappingID_VI_Year_ValueInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_VI_Year_ValueInfo, "InnerText", ID_VD_Vin_Year);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Make') on item 'ApplicationUnderTest.FooterMappingMake'.", repo.ApplicationUnderTest.FooterMappingMakeInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingMakeInfo, "InnerText", "Make");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$ID_VD_VIN_Make) on item 'ApplicationUnderTest.FooterMappingID_VI_Make_value'.", repo.ApplicationUnderTest.FooterMappingID_VI_Make_valueInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_VI_Make_valueInfo, "InnerText", ID_VD_VIN_Make);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Model') on item 'ApplicationUnderTest.FooterMappingID_Model'.", repo.ApplicationUnderTest.FooterMappingID_ModelInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_ModelInfo, "InnerText", "Model");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
