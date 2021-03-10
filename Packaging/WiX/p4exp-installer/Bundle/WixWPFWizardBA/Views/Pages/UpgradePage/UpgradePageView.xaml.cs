﻿//  
// Copyright (c) Nick Guletskii and Arseniy Aseev. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.  
//
namespace WixWPFWizardBA.Views.Pages.UpgradePage
{
    using System.Windows.Controls;

    /// <summary>
    ///     Interaction logic for UpgradePageView.xaml
    /// </summary>
    public partial class UpgradePageView : UserControl
    {
        public UpgradePageView(WizardViewModel wizardViewModel)
        {
            this.DataContext = new UpgradePageViewModel(wizardViewModel);
            this.InitializeComponent();
        }
    }
}