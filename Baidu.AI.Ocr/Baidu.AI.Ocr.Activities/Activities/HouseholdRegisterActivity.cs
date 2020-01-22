﻿using System;
using System.Activities;
using System.Threading;
using System.Threading.Tasks;
using Baidu.AI.Ocr.Activities.Properties;
using Newtonsoft.Json.Linq;
using UiPath.Shared.Activities;

namespace Baidu.AI.Ocr.Activities
{
    [LocalizedDisplayName(nameof(Resources.HouseholdRegisterActivityDisplayName))]
    [LocalizedDescription(nameof(Resources.HouseholdRegisterActivityDescription))]
    public class HouseholdRegisterActivity : BaiduOcrActivityBase
    {
        protected override Task<JObject> InvokeBaiduOcrAsync(Baidu.Aip.Ocr.Ocr baiduOcr, byte[] image, AsyncCodeActivityContext context, CancellationToken cancellationToken)
        {
            return Task.Run(() => baiduOcr.HouseholdRegister(image));
        }
    }
}
