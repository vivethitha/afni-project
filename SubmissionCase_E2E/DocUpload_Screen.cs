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
    ///The DocUpload_Screen recording.
    /// </summary>
    [TestModule("1bba4b94-74bf-487d-801d-45aed35114da", ModuleType.Recording, 1)]
    public partial class DocUpload_Screen : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SubmissionCase_E2ERepository repository.
        /// </summary>
        public static SubmissionCase_E2ERepository repo = SubmissionCase_E2ERepository.Instance;

        static DocUpload_Screen instance = new DocUpload_Screen();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DocUpload_Screen()
        {
            S_CaseID = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DocUpload_Screen Instance
        {
            get { return instance; }
        }

#region Variables

        string _S_CaseID;

        /// <summary>
        /// Gets or sets the value of variable S_CaseID.
        /// </summary>
        [TestVariable("e22ef304-6818-46ad-bad2-5ad6d4080e09")]
        public string S_CaseID
        {
            get { return _S_CaseID; }
            set { _S_CaseID = value; }
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

            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.LabelTagYes'", repo.ApplicationUnderTest.LabelTagYesInfo, new ActionTimeout(10000), new RecordItemIndex(0));
            repo.ApplicationUnderTest.LabelTagYesInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Get Value", "Getting attribute 'InnerText' from item 'ApplicationUnderTest.S_case_ID' and assigning its value to variable 'S_CaseID'.", repo.ApplicationUnderTest.S_case_IDInfo, new RecordItemIndex(1));
            S_CaseID = repo.ApplicationUnderTest.S_case_ID.Element.GetAttributeValueText("InnerText");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "User", S_CaseID, new RecordItemIndex(2));
            
            //Report.Log(ReportLevel.Info, "Set value", "Setting attribute TagValue to '$S_CaseID' on item 'ApplicationUnderTest.S_case_ID'.", repo.ApplicationUnderTest.S_case_IDInfo, new RecordItemIndex(3));
            //repo.ApplicationUnderTest.S_case_ID.Element.SetAttributeValue("TagValue", S_CaseID);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CompleteThisAssignment' at 50;15.", repo.ApplicationUnderTest.CompleteThisAssignmentInfo, new RecordItemIndex(4));
            //repo.ApplicationUnderTest.CompleteThisAssignment.Click("50;15");
            //Delay.Milliseconds(200);
            
            // Validation Start
            //Report.Log(ReportLevel.Info, "Section", "Validation Start", new RecordItemIndex(5));
            
            //Report.Log(ReportLevel.Info, "Wait", "Waiting 20s to exist. Associated repository item: 'ApplicationUnderTest.KindlyUploadTheDocumentToProceed'", repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, new ActionTimeout(20000), new RecordItemIndex(6));
            //repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo.WaitForExists(20000);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Kindly upload the document to Proceed') on item 'ApplicationUnderTest.KindlyUploadTheDocumentToProceed'.", repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, new RecordItemIndex(7));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.KindlyUploadTheDocumentToProceedInfo, "InnerText", "Kindly upload the document to Proceed");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='New-Submission') on item 'ApplicationUnderTest.NewSubmission'.", repo.ApplicationUnderTest.NewSubmissionInfo, new RecordItemIndex(8));
            //Validate.AttributeEqual(repo.ApplicationUnderTest.NewSubmissionInfo, "InnerText", "New-Submission");
            //Delay.Milliseconds(100);
            
            // Validaion End
            Report.Log(ReportLevel.Info, "Section", "Validaion End", new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.LabelTagYes' at 13;10.", repo.ApplicationUnderTest.LabelTagYesInfo, new RecordItemIndex(10));
            repo.ApplicationUnderTest.LabelTagYes.Click("13;10");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.PegaCaseManagerPortalGoogleChrome.Screenshot_Window, false, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(12));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CompleteThisAssignment' at 50;15.", repo.ApplicationUnderTest.CompleteThisAssignmentInfo, new RecordItemIndex(13));
            repo.ApplicationUnderTest.CompleteThisAssignment.Click("50;15");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(14));
            Delay.Duration(2000, false);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.Entry_WB'", repo.ApplicationUnderTest.Entry_WBInfo, new ActionTimeout(30000), new RecordItemIndex(15));
            repo.ApplicationUnderTest.Entry_WBInfo.WaitForExists(30000);
            
            // Validation
            Report.Log(ReportLevel.Info, "Section", "Validation", new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Entry WB') on item 'ApplicationUnderTest.Entry_WB'.", repo.ApplicationUnderTest.Entry_WBInfo, new RecordItemIndex(17));
            Validate.AttributeEqual(repo.ApplicationUnderTest.Entry_WBInfo, "InnerText", "Entry WB");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-AdverseInformation') on item 'ApplicationUnderTest.NewSubmission'.", repo.ApplicationUnderTest.NewSubmissionInfo, new RecordItemIndex(18));
            Validate.AttributeEqual(repo.ApplicationUnderTest.NewSubmissionInfo, "InnerText", "Pending-AdverseInformation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Pending-AdverseInformation') on item 'ApplicationUnderTest.PendingAdverseInformation'.", repo.ApplicationUnderTest.PendingAdverseInformationInfo, new RecordItemIndex(19));
            Validate.AttributeEqual(repo.ApplicationUnderTest.PendingAdverseInformationInfo, "InnerText", "Pending-AdverseInformation");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(20));
            Delay.Duration(1000, false);
            
            // Open case from NewBusinessWB
            Report.Log(ReportLevel.Info, "Section", "Open case from NewBusinessWB", new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 1m to exist. Associated repository item: 'ApplicationUnderTest.Dashboard1'", repo.ApplicationUnderTest.Dashboard1Info, new ActionTimeout(60000), new RecordItemIndex(22));
            repo.ApplicationUnderTest.Dashboard1Info.WaitForExists(60000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Dashboard1' at 41;18.", repo.ApplicationUnderTest.Dashboard1Info, new RecordItemIndex(23));
            repo.ApplicationUnderTest.Dashboard1.Click("41;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.CaseManager' at 92;22.", repo.ApplicationUnderTest.CaseManagerInfo, new RecordItemIndex(24));
            repo.ApplicationUnderTest.CaseManager.Click("92;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'ApplicationUnderTest.EntryWB1'", repo.ApplicationUnderTest.EntryWB1Info, new ActionTimeout(30000), new RecordItemIndex(25));
            repo.ApplicationUnderTest.EntryWB1Info.WaitForExists(30000);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.EntryWB1' at Center.", repo.ApplicationUnderTest.EntryWB1Info, new RecordItemIndex(26));
            repo.ApplicationUnderTest.EntryWB1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s to exist. Associated repository item: 'ApplicationUnderTest.EntryWB1_Header'", repo.ApplicationUnderTest.EntryWB1_HeaderInfo, new ActionTimeout(10000), new RecordItemIndex(27));
            repo.ApplicationUnderTest.EntryWB1_HeaderInfo.WaitForExists(10000);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(28));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.ClickToFilter' at 14;13.", repo.ApplicationUnderTest.ClickToFilterInfo, new RecordItemIndex(29));
            repo.ApplicationUnderTest.ClickToFilter.Click("14;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(30));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.SearchToFilter' at 29;17.", repo.ApplicationUnderTest.SearchToFilterInfo, new RecordItemIndex(31));
            repo.ApplicationUnderTest.SearchToFilter.Click("29;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$S_CaseID' with focus on 'ApplicationUnderTest.SearchToFilter'.", repo.ApplicationUnderTest.SearchToFilterInfo, new RecordItemIndex(32));
            repo.ApplicationUnderTest.SearchToFilter.EnsureVisible();
            Keyboard.Press(S_CaseID);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Apply' at 67;14.", repo.ApplicationUnderTest.ApplyInfo, new RecordItemIndex(33));
            repo.ApplicationUnderTest.Apply.Click("67;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(34));
            Delay.Duration(5000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ApplicationUnderTest.Open_Case' at 34;12.", repo.ApplicationUnderTest.Open_CaseInfo, new RecordItemIndex(35));
            repo.ApplicationUnderTest.Open_Case.Click("34;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(36));
            Delay.Duration(3000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(37));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'ApplicationUnderTest'.", repo.ApplicationUnderTest.SelfInfo, new RecordItemIndex(38));
            repo.ApplicationUnderTest.Self.EnsureVisible();
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(39));
            Delay.Duration(5000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
