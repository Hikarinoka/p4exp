//  
// Copyright (c) Nick Guletskii and Arseniy Aseev. All rights reserved.  
// Licensed under the MIT License. See LICENSE file in the solution root for full license information.  
//
namespace WixWPFWizardBA.Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.Tools.WindowsInstallerXml.Bootstrapper;
    using Utilities;

    public class PackageInstallationStrategyBase<TParam> : IPackageInstallationStrategy
    {
        private readonly TParam _param;

        public PackageInstallationStrategyBase(IList<Package<TParam>> packageList,
            TParam param)
        {
            this._param = param;
            this.PackageList = packageList;
        }

        public IList<Package<TParam>> PackageList { get; }

        public virtual FeatureState? PlanMsiFeature(LaunchAction launchAction, string packageId, string featureId)
        {
            // Let Burn decide what to do with packages we don't know about
            if (this.PackageList.All(x => x.PackageId != packageId))
                return null;

            // Unless stated otherwise, install the feature.
            return FeatureState.Local;
        }

        public virtual RequestState? PlanPackage(LaunchAction launchAction, string packageId)
        {
            var architecture = SystemInformationUtilities.Is64BitSystem() ? Architecture.X64 : Architecture.X86;
            var packageConfig = this.PackageList.FirstOrDefault(x => x.PackageId == packageId);
            switch (launchAction)
            {
                case LaunchAction.Layout:
                    if (packageConfig == null
                        || packageConfig.AcquireDuringLayout)
                    {
                        return RequestState.Present;
                    }
                    else
                    {
                        return RequestState.None;
                    }
                case LaunchAction.Uninstall:
                    if (packageConfig == null
                        || packageConfig.IsRemovable)
                        return RequestState.Absent;
                    return RequestState.None;
                case LaunchAction.Cache:
                case LaunchAction.Install:
                case LaunchAction.Modify:
                    if (packageConfig == null
                        && packageConfig.AdditionalPredicate(this._param)
                        && (packageConfig.Architectures & architecture) == architecture)
                        return RequestState.Present;
                    else
                        return RequestState.Absent;
                case LaunchAction.Repair:
                    if (packageConfig == null || packageConfig.IsRepairable)
                    {
                        return RequestState.Repair;
                    }
                    return RequestState.None;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            // return null; warning CS0162: Unreachable code detected
        }

        public virtual void DetectAdditionalInformation()
        {
        }

        public virtual string GetPackageNameFromId(string packageId)
        {
            var packageConfig = this.PackageList.FirstOrDefault(x => x.PackageId == packageId);
            if (packageConfig != null)
                return packageConfig.DisplayName;
            return packageId;
        }
    }
}