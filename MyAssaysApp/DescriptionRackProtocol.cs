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

namespace MyAssaysApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The DescriptionRackProtocol recording.
    /// </summary>
    [TestModule("953784d0-38d7-4130-850c-209af87c4718", ModuleType.Recording, 1)]
    public partial class DescriptionRackProtocol : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MyAssaysAppRepository repository.
        /// </summary>
        public static MyAssaysAppRepository repo = MyAssaysAppRepository.Instance;

        static DescriptionRackProtocol instance = new DescriptionRackProtocol();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DescriptionRackProtocol()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DescriptionRackProtocol Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop\\MyAssays.Desktop.Explorer.exe' with arguments '' in normal mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop\\MyAssays.Desktop.Explorer.exe", "", "C:\\Program Files (x86)\\MyAssays\\MyAssays Desktop", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Name your protocol and optionally provide a description.') on item 'NewProtocolWizard.SomeContainer.NameYourProtocolAndOptionallyProvid'.", repo.NewProtocolWizard.SomeContainer.NameYourProtocolAndOptionallyProvidInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.NameYourProtocolAndOptionallyProvidInfo, "Text", "Name your protocol and optionally provide a description.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Name:') on item 'NewProtocolWizard.SomeContainer.Name'.", repo.NewProtocolWizard.SomeContainer.NameInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.NameInfo, "Text", "Name:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'NewProtocolWizard.SomeContainer.SomeElement'.", repo.NewProtocolWizard.SomeContainer.SomeElementInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.SomeElementInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Description:') on item 'NewProtocolWizard.SomeContainer.Description'.", repo.NewProtocolWizard.SomeContainer.DescriptionInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.DescriptionInfo, "Text", "Description:");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.NewProtocolWizard.SomeContainer.Self, false, new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'NewProtocolWizard.SomeContainer.SomeElement1'.", repo.NewProtocolWizard.SomeContainer.SomeElement1Info, new RecordItemIndex(6));
            Validate.Exists(repo.NewProtocolWizard.SomeContainer.SomeElement1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Results Naming...') on item 'NewProtocolWizard.SomeContainer.ResultsNaming'.", repo.NewProtocolWizard.SomeContainer.ResultsNamingInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.ResultsNamingInfo, "Text", "Results Naming...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer.ResultsNaming' at Center.", repo.NewProtocolWizard.SomeContainer.ResultsNamingInfo, new RecordItemIndex(8));
            repo.NewProtocolWizard.SomeContainer.ResultsNaming.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Please specify the destination for results files:') on item 'ResultsNaming.SomeContainer.PleaseSpecifyTheDestinationForResul'.", repo.ResultsNaming.SomeContainer.PleaseSpecifyTheDestinationForResulInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.PleaseSpecifyTheDestinationForResulInfo, "Text", "Please specify the destination for results files:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ResultsNaming.SomeContainer.SomeRadioButton'.", repo.ResultsNaming.SomeContainer.SomeRadioButtonInfo, new RecordItemIndex(10));
            Validate.Exists(repo.ResultsNaming.SomeContainer.SomeRadioButtonInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsNaming.SomeContainer.SomeRadioButton2' at Center.", repo.ResultsNaming.SomeContainer.SomeRadioButton2Info, new RecordItemIndex(11));
            repo.ResultsNaming.SomeContainer.SomeRadioButton2.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ResultsNaming.SomeContainer.SomeRadioButton2'.", repo.ResultsNaming.SomeContainer.SomeRadioButton2Info, new RecordItemIndex(12));
            Validate.Exists(repo.ResultsNaming.SomeContainer.SomeRadioButton2Info);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.ResultsNaming.SomeContainer.Self, false, new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Folder:') on item 'ResultsNaming.SomeContainer.Folder'.", repo.ResultsNaming.SomeContainer.FolderInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.FolderInfo, "Text", "Folder:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Filename:') on item 'ResultsNaming.SomeContainer.Filename'.", repo.ResultsNaming.SomeContainer.FilenameInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.FilenameInfo, "Text", "Filename:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'ResultsNaming.SomeContainer.TestSettingsWhenOKIsClicked'.", repo.ResultsNaming.SomeContainer.TestSettingsWhenOKIsClickedInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.TestSettingsWhenOKIsClickedInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ResultsNaming.SomeContainer.SomeElement'.", repo.ResultsNaming.SomeContainer.SomeElementInfo, new RecordItemIndex(17));
            Validate.Exists(repo.ResultsNaming.SomeContainer.SomeElementInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'ResultsNaming.SomeContainer.SomeElement1'.", repo.ResultsNaming.SomeContainer.SomeElement1Info, new RecordItemIndex(18));
            Validate.Exists(repo.ResultsNaming.SomeContainer.SomeElement1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Browse...') on item 'ResultsNaming.SomeContainer.Browse'.", repo.ResultsNaming.SomeContainer.BrowseInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.BrowseInfo, "Text", "Browse...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Manage...') on item 'ResultsNaming.SomeContainer.Manage1'.", repo.ResultsNaming.SomeContainer.Manage1Info, new RecordItemIndex(20));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.Manage1Info, "Text", "Manage...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Manage...') on item 'ResultsNaming.SomeContainer.Manage'.", repo.ResultsNaming.SomeContainer.ManageInfo, new RecordItemIndex(21));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.ManageInfo, "Text", "Manage...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Cancel') on item 'ResultsNaming.SomeContainer.Cancel'.", repo.ResultsNaming.SomeContainer.CancelInfo, new RecordItemIndex(22));
            Validate.Attribute(repo.ResultsNaming.SomeContainer.CancelInfo, "Text", "Cancel");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ResultsNaming.SomeContainer.ButtonOK' at Center.", repo.ResultsNaming.SomeContainer.ButtonOKInfo, new RecordItemIndex(23));
            repo.ResultsNaming.SomeContainer.ButtonOK.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Next') on item 'NewProtocolWizard.SomeContainer.Next1'.", repo.NewProtocolWizard.SomeContainer.Next1Info, new RecordItemIndex(24));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.Next1Info, "Text", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer.Next1' at Center.", repo.NewProtocolWizard.SomeContainer.Next1Info, new RecordItemIndex(25));
            repo.NewProtocolWizard.SomeContainer.Next1.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Review the configuration summary; press Finish to create the protocol.') on item 'NewProtocolWizard.SomeContainer.ReviewTheConfigurationSummaryPress'.", repo.NewProtocolWizard.SomeContainer.ReviewTheConfigurationSummaryPressInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.ReviewTheConfigurationSummaryPressInfo, "Text", "Review the configuration summary; press Finish to create the protocol.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Protocol name:') on item 'NewProtocolWizard.SomeContainer.ProtocolName'.", repo.NewProtocolWizard.SomeContainer.ProtocolNameInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.ProtocolNameInfo, "Text", "Protocol name:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Layout dimensions:') on item 'NewProtocolWizard.SomeContainer.LayoutDimensions'.", repo.NewProtocolWizard.SomeContainer.LayoutDimensionsInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.LayoutDimensionsInfo, "Text", "Layout dimensions:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Measurements:') on item 'NewProtocolWizard.SomeContainer.Measurements'.", repo.NewProtocolWizard.SomeContainer.MeasurementsInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.MeasurementsInfo, "Text", "Measurements:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Data source:') on item 'NewProtocolWizard.SomeContainer.DataSource'.", repo.NewProtocolWizard.SomeContainer.DataSourceInfo, new RecordItemIndex(30));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.DataSourceInfo, "Text", "Data source:");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Checked='True') on item 'NewProtocolWizard.SomeContainer.LaunchProtocol'.", repo.NewProtocolWizard.SomeContainer.LaunchProtocolInfo, new RecordItemIndex(31));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.LaunchProtocolInfo, "Checked", "True");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", repo.NewProtocolWizard.SomeContainer.Self, false, new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Finish') on item 'NewProtocolWizard.SomeContainer.Finish'.", repo.NewProtocolWizard.SomeContainer.FinishInfo, new RecordItemIndex(33));
            Validate.Attribute(repo.NewProtocolWizard.SomeContainer.FinishInfo, "Text", "Finish");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'NewProtocolWizard.SomeContainer.Finish' at CenterRight.", repo.NewProtocolWizard.SomeContainer.FinishInfo, new RecordItemIndex(34));
            repo.NewProtocolWizard.SomeContainer.Finish.Click(Location.CenterRight);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolMyEndpoint12x8Protocol2.SomeContainer.Ribbon' at 37;56.", repo.ProtocolMyEndpoint12x8Protocol2.SomeContainer.RibbonInfo, new RecordItemIndex(35));
            repo.ProtocolMyEndpoint12x8Protocol2.SomeContainer.Ribbon.Click("37;56");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'ProtocolMyEndpoint12x8Protocol2.SomeContainer.ControlLabel' at Center.", repo.ProtocolMyEndpoint12x8Protocol2.SomeContainer.ControlLabelInfo, new RecordItemIndex(36));
            repo.ProtocolMyEndpoint12x8Protocol2.SomeContainer.ControlLabel.Click();
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
