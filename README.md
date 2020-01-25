# 百度文字识别活动包

![海报](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/docs/images/Poster.png)

[百度AI开放平台](https://ai.baidu.com/)提供多种文字识别，如增值税发票、营业执照、驾驶证等，可以用于多种RPA流程，我也在《RPA开发与应用》（即将出版）中详细讲解了如何在UiPath Studio中识别增值税发票。本代码库的目的是打通UiPath和百度文字识别，让开发者能在UiPath Studio中通过简单的拖放和设置把百度文字识别用到相关流程中，从而加速开发过程。

## 开发计划和状态

#|名称|类型|活动|发布日期|任务状态
---|---|---|---|---|---
1|[增值税发票识别](https://ai.baidu.com/tech/ocr_receipts/vat_invoice)|票据|[VatInvoiceActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/VatInvoiceActivity.cs)|2020-1-12|完成
2|[定额发票识别](https://ai.baidu.com/tech/ocr_receipts/quota_invoice)|票据|[QuotaInvoiceActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/QuotaInvoiceActivity.cs)|2020-1-13|完成
3|[出租车票识别](https://ai.baidu.com/tech/ocr_receipts/taxi_receipt)|票据|[TaxiReceiptActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/TaxiReceiptActivity.cs)|2020-1-13|完成
4|[火车票识别](https://ai.baidu.com/tech/ocr_receipts/train_ticket)|票据|TrainTicketActivity|2020-2-9|计划
5|[身份证识别](https://ai.baidu.com/tech/ocr_cards/idcard)|卡证|[IdCardActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/IdCardActivity.cs)|2020-1-21|完成
6|[户口本识别](https://ai.baidu.com/tech/ocr_cards/household_register)|卡证|[HouseholdRegisterActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/HouseholdRegisterActivity.cs)|2020-1-22|完成
7|[出生医学证明识别](https://ai.baidu.com/tech/ocr_cards/birth_certificate)|卡证|[BirthCertificateActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/BirthCertificateActivity.cs)|2020-1-22|完成
8|[护照识别](https://ai.baidu.com/tech/ocr_cards/passport)|卡证|[PassportActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/PassportActivity.cs)|2020-1-24|完成
9|[港澳通行证识别](https://ai.baidu.com/tech/ocr_cards/HK_Macau_exitentrypermit)|卡证|[HkMacauExitentrypermitActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/HkMacauExitentrypermitActivity.cs)|2020-1-24|完成
10|[台湾通行证识别](https://ai.baidu.com/tech/ocr_cards/taiwan_exitentrypermit)|卡证|[TaiwanExitentrypermitActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/TaiwanExitentrypermitActivity.cs)|2020-1-24|完成
11|[营业执照识别](https://ai.baidu.com/tech/ocr_cards/business)|卡证|BusinessLicenseActivity|2020-2-9|计划
12|[银行卡识别](https://ai.baidu.com/tech/ocr_cards/bankcard)|卡证|BankCardActivity|2020-2-9|计划
13|[行驶证识别](https://ai.baidu.com/tech/ocr_cars/vehicle_license)|汽车场景|VehicleLicenseActivity|2020-2-9|计划
14|[驾驶证识别](https://ai.baidu.com/tech/ocr_cars/driving_license)|汽车场景|DrivingLicenseActivity|2020-2-9|计划
15|[机动车销售发票识别](https://ai.baidu.com/tech/ocr_cars/vehicle_invoice)|汽车场景|VehicleInvoiceActivity|2020-2-9|计划
16|[车辆合格证识别](https://ai.baidu.com/tech/ocr_cars/vehicle_certificate)|汽车场景|VehicleCertificateActivity|2020-2-9|计划

*其他文字识别活动将会陆续排期开发。*

## 安装

![安装百度文字识别活动包](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/docs/images/Install.PNG)

本活动包目前还在开发当中，如果你想在UiPath Studio中提前体验一下，可以到GitHub Releases下载[v0.1.0 Pre-release](https://github.com/allenlooplee/BaiduOcrActivitiesPack/releases/tag/v0.1.0)，然后到UiPath Studio的Manage Packages安装活动包。

*本活动包也将发布到[UiPath Go](https://go.uipath.com/)。*

## 使用

![使用百度文字识别活动](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/docs/images/Use.PNG)

安装好本活动包之后，你会在Activities面板上看到相关的活动，把你想使用的文字识别活动拖到Designer面板，然后在Properties面板上指定你想识别的图片就行了，识别结果将以[JObject](https://github.com/JamesNK/Newtonsoft.Json/blob/master/Src/Newtonsoft.Json/Linq/JObject.cs)对象返回。

*注意：所有文字识别活动都要放在BaiduOcrScope中，在使用文字识别活动之前，你需要在百度AI开放平台注册账号，创建文字识别应用，获取API Key和Secret Key，并填入BaiduOcrScope的相应属性中。*

## 构建

如果你想自行构建或改进代码，你需要安装以下工具：
1. [Visual Studio 2019](https://visualstudio.microsoft.com/)，安装的时候需要[选中Windows Workflow Foundation](https://docs.microsoft.com/en-us/visualstudio/workflow-designer/developing-applications-with-the-workflow-designer?view=vs-2019#install-windows-workflow-foundation)
2. [UiPath Activity Creator](https://marketplace.visualstudio.com/items?itemName=UiPathLabs.UiPathActivitySet)
3. [UiPath Studio](https://www.uipath.com/start-trial)

Visual Studio用来打开[活动包项目](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr.sln)，UiPath Studio用来打开[测试项目](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/tests/Baidu.AI.Ocr.Tests/Main.xaml)。在运行测试项目之前，你需要把文字识别应用的API Key和Secret Key填入BaiduOcrScope活动的相应属性。

如果你想自行创建百度文字识别活动，你需要遵循以下步骤：
1. **创建活动**。在Baidu.AI.Ocr.Activities项目中创建一个Simple Activity，放在Activities文件夹中，并让它继承自[BaiduOcrActivityBase](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/BaiduOcrActivityBase.cs)，你可以仿照[VatInvoiceActivity](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities/Activities/VatInvoiceActivity.cs)来实现新的活动。
2. **本地化活动**。在Baidu.AI.Ocr.Activities项目的Resources.resx中添加DisplayName和Description两项，并把它们应用到活动上，活动在UiPath Studio中显示的名称和描述就来自这两项。
3. **创建活动设计器**。在Baidu.AI.Ocr.Activities.Design项目中创建一个Simple Activity Designer，放在Designers文件夹中。如果你没有特殊需求则不必修改。
4. **创建活动图标**。在Baidu.AI.Ocr.Activities.Design项目的[Themes\Icons.xaml](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities.Design/Themes/Icons.xaml)中添加一个DrawingBrush，并把x:Key的值设为XXXIcon，其中XXX是活动名，如VatInvoiceActivityIcon。
5. **关联活动和活动设计器**。在Baidu.AI.Ocr.Activities.Design项目的[DesignerMetadata.cs](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/Baidu.AI.Ocr/Baidu.AI.Ocr.Activities.Design/DesignerMetadata.cs)中设置活动的类别、设计器和帮助链接。

## 其他代码库和参考资料
* [百度AI开放平台 .NET SDK](https://github.com/Baidu-AIP/dotnet-sdk)
* [JSON.NET](https://github.com/JamesNK/Newtonsoft.Json)
* [百度文字识别API文档](https://ai.baidu.com/ai-doc/OCR/Ek3h7xypm)
* [Quick Start: The 5 minute activity set](https://docs.uipath.com/integrations/docs/quick-start)
* [Windows Workflow Foundation](https://docs.microsoft.com/en-us/dotnet/framework/windows-workflow-foundation/)

## 许可协议

本代码库遵循[MIT许可协议](https://github.com/allenlooplee/BaiduOcrActivitiesPack/blob/master/LICENSE)，可作商业用途。

## 特别声明
* 本活动包并非官方出品，不存在官方支持。
* 本活动包并不包含任何本地模型，你的票据将会发往百度AI开放平台进行文字识别。
* 本活动包并不收取任何费用，百度AI开放平台可能[根据你的使用情况收取费用](https://ai.baidu.com/ai-doc/OCR/Jk3h7xtsd)。
