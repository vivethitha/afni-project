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
    ///The Adverse1_Vechicle_FooterMapping recording.
    /// </summary>
    [TestModule("d6259560-508a-4efb-9480-650c5c7802b8", ModuleType.Recording, 1)]
    public partial class Adverse1_Vechicle_FooterMapping : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static Adverse1_Vechicle_FooterMapping instance = new Adverse1_Vechicle_FooterMapping();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Adverse1_Vechicle_FooterMapping()
        {
            Adverse1_LicensePlateState = "";
            Adverse1_LicensePlate = "";
            AD1_Vin_Year = "";
            AD1_VIN_Make = "";
            AD1_VIN_Model = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Adverse1_Vechicle_FooterMapping Instance
        {
            get { return instance; }
        }

#region Variables

        string _Adverse1_LicensePlateState;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlateState.
        /// </summary>
        [TestVariable("ea63db3b-e43d-449b-b925-685fdcc2eeb0")]
        public string Adverse1_LicensePlateState
        {
            get { return _Adverse1_LicensePlateState; }
            set { _Adverse1_LicensePlateState = value; }
        }

        string _Adverse1_LicensePlate;

        /// <summary>
        /// Gets or sets the value of variable Adverse1_LicensePlate.
        /// </summary>
        [TestVariable("b260de4a-a643-4c5a-95a7-7a6d645c8032")]
        public string Adverse1_LicensePlate
        {
            get { return _Adverse1_LicensePlate; }
            set { _Adverse1_LicensePlate = value; }
        }

        string _AD1_Vin_Year;

        /// <summary>
        /// Gets or sets the value of variable AD1_Vin_Year.
        /// </summary>
        [TestVariable("61e6d2ae-d412-4e21-912c-538001b721f0")]
        public string AD1_Vin_Year
        {
            get { return _AD1_Vin_Year; }
            set { _AD1_Vin_Year = value; }
        }

        string _AD1_VIN_Make;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Make.
        /// </summary>
        [TestVariable("29da8705-ca29-4ab4-86fc-b0c072460fef")]
        public string AD1_VIN_Make
        {
            get { return _AD1_VIN_Make; }
            set { _AD1_VIN_Make = value; }
        }

        string _AD1_VIN_Model;

        /// <summary>
        /// Gets or sets the value of variable AD1_VIN_Model.
        /// </summary>
        [TestVariable("b3b4d8dc-372e-4d35-a73b-114f6c41e6a7")]
        public string AD1_VIN_Model
        {
            get { return _AD1_VIN_Model; }
            set { _AD1_VIN_Model = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Vehicle Information') on item 'ApplicationUnderTest.FooterMappingVehicle_Information'.", repo.ApplicationUnderTest.FooterMappingVehicle_InformationInfo, new RecordItemIndex(0));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingVehicle_InformationInfo, "InnerText", "Vehicle Information");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.FooterMappingAD_Model' at Center.", repo.ApplicationUnderTest.FooterMappingAD_ModelInfo, new RecordItemIndex(1));
            repo.ApplicationUnderTest.FooterMappingAD_Model.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Do you have VIN Number?') on item 'ApplicationUnderTest.FooterMappingDo_you_have_VIN_Number'.", repo.ApplicationUnderTest.FooterMappingDo_you_have_VIN_NumberInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingDo_you_have_VIN_NumberInfo, "InnerText", "Do you have VIN Number?");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='No') on item 'ApplicationUnderTest.FooterMappingNo'.", repo.ApplicationUnderTest.FooterMappingNoInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingNoInfo, "InnerText", "No");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='License Plate State') on item 'ApplicationUnderTest.FooterMappingLicense_Plate_State'.", repo.ApplicationUnderTest.FooterMappingLicense_Plate_StateInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingLicense_Plate_StateInfo, "InnerText", "License Plate State");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Adverse1_LicensePlateState) on item 'ApplicationUnderTest.FooterMappingdriverVechicleState'.", repo.ApplicationUnderTest.FooterMappingdriverVechicleStateInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingdriverVechicleStateInfo, "InnerText", Adverse1_LicensePlateState);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='License plate') on item 'ApplicationUnderTest.FooterMappingLicense_plate'.", repo.ApplicationUnderTest.FooterMappingLicense_plateInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingLicense_plateInfo, "InnerText", "License plate");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$Adverse1_LicensePlate) on item 'ApplicationUnderTest.FooterMappingdriverVechicleLicensePlate'.", repo.ApplicationUnderTest.FooterMappingdriverVechicleLicensePlateInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingdriverVechicleLicensePlateInfo, "InnerText", Adverse1_LicensePlate);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Enter model details manually') on item 'ApplicationUnderTest.FooterMapping_Enter_model_details_manually'.", repo.ApplicationUnderTest.FooterMapping_Enter_model_details_manuallyInfo, new RecordItemIndex(8));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMapping_Enter_model_details_manuallyInfo, "InnerText", "Enter model details manually");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='') on item 'ApplicationUnderTest.False'.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(9));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FalseInfo, "InnerText", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABEAAAARCAIAAAC0D9CtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAACBSURBVDhP7ZIhDgUhDAUROEKwKAzBch4wcIF1hKsguACCQ/LfJk3WsejNH9E0L52momyt1XsXQrADlFJzTtZak1JSdoDWmjrv/XWAc44EUGvFka/knEkA2EHxlhACCeDvfM8ppVC8JaV0T3POUfF8MUas2YABY8ztjDGe9z7AWvsDXwbznPPLSlMAAAAASUVORK5CYII=') on item 'ApplicationUnderTest.False'.", repo.ApplicationUnderTest.FalseInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FalseInfo, "Src", "data:image/png;base64,iVBORw0KGgoAAAANSUhEUgAAABEAAAARCAIAAAC0D9CtAAAAAXNSR0IArs4c6QAAAARnQU1BAACxjwv8YQUAAAAJcEhZcwAADsMAAA7DAcdvqGQAAACBSURBVDhP7ZIhDgUhDAUROEKwKAzBch4wcIF1hKsguACCQ/LfJk3WsejNH9E0L52momyt1XsXQrADlFJzTtZak1JSdoDWmjrv/XWAc44EUGvFka/knEkA2EHxlhACCeDvfM8ppVC8JaV0T3POUfF8MUas2YABY8ztjDGe9z7AWvsDXwbznPPLSlMAAAAASUVORK5CYII=");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Year') on item 'ApplicationUnderTest.FooterMappingYear'.", repo.ApplicationUnderTest.FooterMappingYearInfo, new RecordItemIndex(11));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingYearInfo, "InnerText", "Year");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$AD1_Vin_Year) on item 'ApplicationUnderTest.FooterMappingdriverVechicleYearValue'.", repo.ApplicationUnderTest.FooterMappingdriverVechicleYearValueInfo, new RecordItemIndex(12));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingdriverVechicleYearValueInfo, "InnerText", AD1_Vin_Year);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Make') on item 'ApplicationUnderTest.FooterMappingMake'.", repo.ApplicationUnderTest.FooterMappingMakeInfo, new RecordItemIndex(13));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingMakeInfo, "InnerText", "Make");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$AD1_VIN_Make) on item 'ApplicationUnderTest.FooterMappingdriverVechicleMakeName'.", repo.ApplicationUnderTest.FooterMappingdriverVechicleMakeNameInfo, new RecordItemIndex(14));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingdriverVechicleMakeNameInfo, "InnerText", AD1_VIN_Make);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Model') on item 'ApplicationUnderTest.FooterMappingID_Model'.", repo.ApplicationUnderTest.FooterMappingID_ModelInfo, new RecordItemIndex(15));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingID_ModelInfo, "InnerText", "Model");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$AD1_VIN_Model) on item 'ApplicationUnderTest.FooterMappingAD_Model'.", repo.ApplicationUnderTest.FooterMappingAD_ModelInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.ApplicationUnderTest.FooterMappingAD_ModelInfo, "InnerText", AD1_VIN_Model);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(17));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
