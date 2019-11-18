
# 部署 Office 说明

在这里，您可以管理当前已安装的 Office 产品和语言包。如果没有安装 Office，则可以进行全新安装。**由于微软限制，Office 仅可以安装在系统盘上。**

您可以在版本信息中查询当前每个通道上 Office 发布的版本以及发布日期。查询完毕后，您可以在下载或者安装时选择历史版本。默认安装最新版本。

## 目录

---

1. 安装模块说明
2. 通道设置说明
3. 全新安装说明
4. 增删产品/语言说明
5. Office 365 产品 ID 对照表
6. 安装文件说明
7. Office 配置说明

## 安装模块说明

---

Office 部署工具是微软官方发布的一个用于部署 Office 的工具，其中 Office Tool Plus 几乎支持其所有的参数设定。
Office Tool Plus 模块是我们自行编写的一个安装 Office 的小模块，虽然功能没有 Office 部署工具的全面，但是也可以确保 Office 可以顺利安装。

[Office 部署工具官方网站](https://aka.ms/ODT)

[Office 部署工具的配置选项](https://docs.microsoft.com/zh-cn/DeployOffice/configuration-options-for-the-office-2016-deployment-tool)

[Office 自定义工具](https://config.office.com)

**欲从 Windows 7 上安装 Office 2019 批量版，请务必使用 Office Tool Plus 模块！**

`当您使用 Office 部署工具安装时遇到无法解决的问题，不妨试一下 Office Tool Plus 安装模块哦！`

## 通道设置说明

---

`Office, Visio, Project 2019 批量版产品只支持安装在 Office 2019 企业长期版通道上，并且不可以与其他产品混装（比如 Office 365）`。
如果在安装了 Office 365 的同时也想使用 Visio 的话，请选择 Visio 2016 零售版或 2016 批量版（Project 同理）。

Office 2016/2019 (零售)/365 产品可以选择其他的通道（只要不是 Office 2019 企业长期版就完事了），推荐使用每月通道，不在乎新功能的办公人士可以选择半年通道。**如果您因为使用定向通道或者测试版通道而遇到 Office 出现问题的情况，请自行解决。**

## 全新安装说明

---

全新安装时，点击添加产品，选择一个自己想安装的产品。产品里可能会包含一个或者多个应用程序，如果您不希望安装这些应用程序，请将其取消勾选。**其中，Groove 代表 OneDrive for Business，Lync 代表 Skype for Business。**

全新安装时，如果不指定语言包，则 Office Tool Plus 会默认匹配系统语言。如果 Office 不能完全适配当前系统的语言，则会默认加装 [en-us] - English (US) 作为主要语言。
`当您添加语言时，请确保您选择了一个主要语言。`

全新安装时，**若您选择的是 Office 2019 批量版产品，请确保您的通道是 Office 2019 企业长期版通道，否则会无法正常安装！**Office 2019 零售版可以选择其他通道。

## 增删产品/语言说明

---

当您的计算机上已经安装 Office 时，您可以通过 Office Tool Plus 增删产品。

### 增加产品/语言

如果您需要增加产品或者语言，直接新增产品/语言，并按照自己的想法/要求直接选择即可。`注意：为了避免出现问题，请不要重复安装某个产品/语言。`

### 修改应用程序

如果您需要修改应用程序，请首先选中这个产品，然后将不需要的应用程序取消勾选，将需要添加的选上，然后开始部署即可。

### 卸载产品/语言

在列表中，勾选自己想卸载的产品/语言，随后通过开始部署按钮右侧的菜单，点击 *卸载选中的产品/语言* 即可。

## Office 365 产品 ID 对照表

---

```txt
Office 365 专业增强版	O365ProPlusRetail
Office 365 企业版 E3	O365ProPlusRetail
Office 365 企业版 E4	O365ProPlusRetail
Office 365 企业版 E5	O365ProPlusRetail
Office 365 中型		O365ProPlusRetail
Office 365 商业版	O365BusinessRetail
Office 365 商业高级版	O365BusinessRetail
Office 小型企业高级版	O365SmallBusPremRetail
Office 365 家庭版	O365HomePremRetail
Office 365 个人版	O365HomePremRetail
```

获取更多信息请访问 [Office 部署工具支持的产品 ID](https://docs.microsoft.com/zh-cn/office365/troubleshoot/administration/product-ids-supported-office-deployment-click-to-run)

## 安装文件说明

---

安装文件，顾名思义就是 Office 的安装包。Office Tool Plus 支持从微软的 Office CDN 服务器下载 Office 安装文件并制作成 ISO 文件。下载安装文件后，可以使用离线安装，也可以分享安装文件给其他用户，以便节省带宽或者减少时间耗费。

安装文件包含 Office, Visio 以及 Project，从 Office 2019 企业长期版通道下载的安装文件仅可以用来安装 Office 2019 批量版，其他通道的安装文件可以用于安装 Office 2016, 365 以及 2019 零售版。

若要下载 Office 安装文件，请根据自己的需要配置体系架构，通道，语言默认匹配系统语言。Office Tool Plus 默认设置好，您可以直接开始下载安装文件。

![下载安装文件](https://coolhub.top/wp-content/uploads/2019/11/QQ截图20191107202304-1.png)

### 获取更多信息请访问以下网站

[Office 365 的更新通道概述](https://docs.microsoft.com/zh-cn/DeployOffice/overview-of-update-channels-for-office-365-proplus)

[Office 365 更新历史记录](https://docs.microsoft.com/zh-cn/officeupdates/update-history-office365-proplus-by-date)

[Office 2019 更新频道概述](https://docs.microsoft.com/zh-cn/DeployOffice/office2019/update#update-channel-for-office-2019)

## 下载安装文件

---

Office Tool Plus 除了支持使用 Office 部署工具下载安装文件外，还内置了迅雷程序，方便用户快速下载 Office 安装文件。两者在基本功能上没有什么区别，`但仅有迅雷支持显示下载进度，支持设定速度限制以及支持单独设置代理。`如果迅雷下载出现了问题，请将引擎切换为 Office 部署工具。

### 迅雷下载限速设置

若要在使用迅雷下载时设置速度限制，请在下载时点击下载速度，随后即可在弹出来的提示框中设定限速。若要解除限速，请输入 0。

## Office 配置说明

---

`在部署页面的最右侧，可以呼出 Office 配置面板。`
Office Tool Plus 支持对 Office 的更新通道进行修改，也支持修改 Office 中显示的账户所有者。修改之后，点击保存以应用设置。

如果您的 Office 无法正常使用，可以在此处尝试修复 Office。

**Note：如果你点击了重新读取，左侧的产品和语言数据会重新载入，一些设置将会被重置为默认值。**

# Bùshǔ Office shuōmíng

zài zhèlǐ, nín kěyǐ guǎnlǐ dāngqián yǐ ānzhuāng de Office chǎnpǐn hé yǔyán bāo. Rúguǒ méiyǒu ānzhuāng Office, zé kěyǐ jìnxíng quánxīn ānzhuāng.**Yóuyú wēiruǎn xiànzhì,Office jǐn kěyǐ ānzhuāng zài xìtǒng pán shàng.**

Nín kěyǐ zài bǎnběn xìnxī zhōng cháxún dāngqián měi gè tōngdào shàng Office fābù de bǎnběn yǐjí fābù rìqí. Cháxún wánbì hòu, nín kěyǐ zài xiàzài huòzhě ānzhuāng shí xuǎnzé lìshǐ bǎnběn. Mòrèn ānzhuāng zuìxīn bǎnběn.

## Mùlù

---

1. Ānzhuāng mókuài shuōmíng
2. Tōngdào shèzhì shuōmíng
3. Quánxīn ānzhuāng shuōmíng
4. Zēngshān chǎnpǐn/yǔyán shuōmíng
5. Office 365 chǎnpǐn ID duìzhào biǎo
6. Ānzhuāng wénjiàn shuōmíng
7. Office pèizhì shuōmíng

## ānzhuāng mókuài shuōmíng

---

Office bùshǔ gōngjù shì wēiruǎn guānfāng fābù de yīgè yòng yú bùshǔ Office de gōngjù, qízhōng Office Tool Plus jīhū zhīchí qí suǒyǒu de cānshù shè dìng.
Office Tool Plus mókuài shì wǒmen zìxíng biānxiě de yīgè ānzhuāng Office de xiǎo mókuài, suīrán gōngnéng méiyǒu Office bùshǔ gōngjù de quánmiàn, dànshì yě kěyǐ quèbǎo Office kěyǐ shùnlì ānzhuāng.

[Office bùshǔ gōngjù guānfāng wǎngzhàn](https://Aka.Ms/ODT)

[Office bùshǔ gōngjù de pèizhì xuǎnxiàng](https://Docs.Microsoft.Com/zh-cn/DeployOffice/configuration-options-for-the-office-2016-deployment-tool)

[Office zì dìngyì gōngjù](https://Config.Office.Com)

**yù cóng Windows 7 shàng ānzhuāng Office 2019 pīliàng bǎn, qǐng wùbì shǐyòng Office Tool Plus mókuài!**

`Dāng nín shǐyòng Office bùshǔ gōngjù ānzhuāng shí yù dào wúfǎ jiějué de wèntí, bùfáng shì yīxià Office Tool Plus ānzhuāng mókuài ó!`

## Tōngdào shèzhì shuōmíng

---

`Office, Visio, Project 2019 pīliàng bǎn chǎnpǐn zhǐ zhīchí ānzhuāng zài Office 2019 qǐyè chángqí bǎn tōngdào shàng, bìngqiě bù kěyǐ yǔ qítā chǎnpǐn hùn zhuāng (bǐrú Office 365)`.
Rúguǒ zài ānzhuāngle Office 365 de tóngshí yě xiǎng shǐyòng Visio dehuà, qǐng xuǎnzé Visio 2016 língshòu bǎn huò 2016 pīliàng bǎn (Project tóng lǐ).

Office 2016/2019 (língshòu)/365 chǎnpǐn kěyǐ xuǎnzé qítā de tōngdào (zhǐyào bùshì Office 2019 qǐyè chángqí bǎn jiù wánshìle), tuījiàn shǐyòng měi yuè tōngdào, bùzàihū xīn gōngnéng de bàngōng rénshì kěyǐ xuǎnzé bànnián tōngdào.**Rúguǒ nín yīnwèi shǐyòng dìngxiàng tōngdào huòzhě cèshì bǎn tōngdào ér yù dào Office chūxiàn wèntí de qíngkuàng, qǐng zìxíng jiějué.**

## Quánxīn ānzhuāng shuōmíng

---

quánxīn ānzhuāng shí, diǎnjī tiānjiā chǎnpǐn, xuǎnzé yīgè zìjǐ xiǎng ānzhuāng de chǎnpǐn. Chǎnpǐn lǐ kěnéng huì bāohán yīgè huòzhě duō gè yìngyòng chéngxù, rúguǒ nín bù xīwàng ānzhuāng zhèxiē yìngyòng chéngxù, qǐng jiāng qí qǔxiāo gōu xuǎn.**Qízhōng,Groove dàibiǎo OneDrive for Business,Lync dàibiǎo Skype for Business.**

Quánxīn ānzhuāng shí, rúguǒ bù zhǐdìng yǔyán bāo, zé Office Tool Plus huì mòrèn pǐpèi xìtǒng yǔyán. Rúguǒ Office bùnéng wánquán shì pèi dāngqián xìtǒng de yǔyán, zé huì mòrèn jiā zhuāng [en-us] - English (US) zuòwéi zhǔyào yǔyán.
`Dāng nín tiānjiā yǔyán shí, qǐng quèbǎo nín xuǎnzéle yīgè zhǔyào yǔyán.`

Quánxīn ānzhuāng shí,**ruò nín xuǎnzé de shì Office 2019 pīliàng bǎn chǎnpǐn, qǐng quèbǎo nín de tōngdào shì Office 2019 qǐyè chángqí bǎn tōngdào, fǒuzé huì wúfǎ zhèngcháng ānzhuāng!**Office 2019 língshòu bǎn kěyǐ xuǎnzé qítā tōngdào.

## Zēngshān chǎnpǐn/yǔyán shuōmíng

---

dāng nín de jìsuànjī shàng yǐjīng ānzhuāng Office shí, nín kěyǐ tōngguò Office Tool Plus zēngshān chǎnpǐn.

### Zēngjiā chǎnpǐn/yǔyán

rúguǒ nín xūyào zēngjiā chǎnpǐn huòzhě yǔyán, zhíjiē xīn zēng chǎnpǐn/yǔyán, bìng ànzhào zìjǐ de xiǎngfǎ/yāoqiú zhíjiē xuǎnzé jí kě.`Zhùyì: Wèile bìmiǎn chūxiàn wèntí, qǐng bùyào chóngfù ānzhuāng mǒu gè chǎnpǐn/yǔyán.`

### Xiūgǎi yìngyòng chéngxù

rúguǒ nín xūyào xiūgǎi yìngyòng chéngxù, qǐng shǒuxiān xuǎnzhōng zhège chǎnpǐn, ránhòu jiāng bù xūyào de yìngyòng chéngxù qǔxiāo gōu xuǎn, jiāng xūyào tiānjiā de xuǎn shàng, ránhòu kāishǐ bùshǔ jí kě.

### Xièzài chǎnpǐn/yǔyán

zài lièbiǎo zhōng, gōu xuǎn zìjǐ xiǎng xièzài de chǎnpǐn/yǔyán, suíhòu tōngguò kāishǐ bùshǔ ànniǔ yòu cè de càidān, diǎnjī*xièzài xuǎnzhōng de chǎnpǐn/yǔyán* jí kě.

## Office 365 chǎnpǐn ID duìzhào biǎo

---

```txt
Office 365 zhuānyè zēngqiáng bǎn	O365ProPlusRetail
Office 365 qǐyè bǎn E3	O365ProPlusRetail
Office 365 qǐyè bǎn E4	O365ProPlusRetail
Office 365 qǐyè bǎn E5	O365ProPlusRetail
Office 365 zhōngxíng		O365ProPlusRetail
Office 365 shāngyè bǎn	O365BusinessRetail
Office 365 shāngyè gāojí bǎn	O365BusinessRetail
Office xiǎoxíng qǐyè gāojí bǎn	O365SmallBusPremRetail
Office 365 jiātíng bǎn	O365HomePremRetail
Office 365 gèrén bǎn	O365HomePremRetail
```

huòqǔ gèng duō xìnxī qǐng fǎngwèn [Office bùshǔ gōngjù zhīchí de chǎnpǐn ID](https://Docs.Microsoft.Com/zh-cn/office365/troubleshoot/administration/product-ids-supported-office-deployment-click-to-run)

## ānzhuāng wénjiàn shuōmíng

---

ānzhuāng wénjiàn, gùmíngsīyì jiùshì Office de ānzhuāng bāo.Office Tool Plus zhīchí cóng wēiruǎn de Office CDN fúwùqì xiàzài Office ānzhuāng wénjiàn bìng zhìzuò chéng ISO wénjiàn. Xiàzài ānzhuāng wénjiàn hòu, kěyǐ shǐyòng líxiàn ānzhuāng, yě kěyǐ fēnxiǎng ānzhuāng wénjiàn gěi qítā yònghù, yǐbiàn jiéshěng dàikuān huòzhě jiǎnshǎo shíjiān hàofèi.

Ānzhuāng wénjiàn bāohán Office, Visio yǐjí Project, cóng Office 2019 qǐyè chángqí bǎn tōngdào xiàzài de ānzhuāng wénjiàn jǐn kěyǐ yòng lái ānzhuāng Office 2019 pīliàng bǎn, qítā tōngdào de ānzhuāng wénjiàn kěyǐ yòng yú ānzhuāng Office 2016, 365 yǐjí 2019 língshòu bǎn.

Ruò yào xiàzài Office ānzhuāng wénjiàn, qǐng gēnjù zìjǐ de xūyào pèizhì tǐxì jiàgòu, tōngdào, yǔyán mòrèn pǐpèi xìtǒng yǔyán.Office Tool Plus mòrèn shèzhì hǎo, nín kěyǐ zhíjiē kāishǐ xiàzài ānzhuāng wénjiàn.

![Xiàzài ānzhuāng wénjiàn](https://Coolhub.Top/wp-content/uploads/2019/11/QQ jiétú 20191107202304-1.Png)

### huòqǔ gèng duō xìnxī qǐng fǎngwèn yǐxià wǎngzhàn

[Office 365 de gēngxīn tōngdào gàishù](https://Docs.Microsoft.Com/zh-cn/DeployOffice/overview-of-update-channels-for-office-365-proplus)

[Office 365 gēngxīn lìshǐ jìlù](https://Docs.Microsoft.Com/zh-cn/officeupdates/update-history-office365-proplus-by-date)

[Office 2019 gēngxīn píndào gàishù](https://Docs.Microsoft.Com/zh-cn/DeployOffice/office2019/update#update-channel-for-office-2019)

## xiàzài ānzhuāng wénjiàn

---

Office Tool Plus chúle zhīchí shǐyòng Office bùshǔ gōngjù xiàzài ānzhuāng wénjiàn wài, hái nèizhìle xùnléi chéngxù, fāngbiàn yònghù kuàisù xiàzài Office ānzhuāng wénjiàn. Liǎng zhě zài jīběn gōngnéng shàng méiyǒu shé me qūbié,`dàn jǐn yǒu xùnléi zhīchí xiǎnshì xiàzài jìndù, zhīchí shè dìng sùdù xiànzhì yǐjí zhīchí dāndú shèzhì dàilǐ.`Rúguǒ xùnléi xiàzài chūxiànle wèntí, qǐng jiāng yǐnqíng qiēhuàn wèi Office bùshǔ gōngjù.

### Xùnléi xiàzài xiàn sù shèzhì

ruò yào zài shǐyòng xùnléi xiàzài shí shèzhì sùdù xiànzhì, qǐng zài xiàzài shí diǎnjī xiàzài sùdù, suíhòu jí kě zài dànchū lái de tíshì kuāng zhōng shè dìng xiàn sù. Ruò yào jiěchú xiàn sù, qǐng shūrù 0.

## Office pèizhì shuōmíng

---

`zài bùshǔ yèmiàn de zuì yòu cè, kěyǐ hūchū Office pèizhì miànbǎn.`
Office Tool Plus zhīchí duì Office de gēngxīn tōngdào jìnxíng xiūgǎi, yě zhīchí xiūgǎi Office zhōng xiǎnshì de zhànghù suǒyǒu zhě. Xiūgǎi zhīhòu, diǎnjī bǎocún yǐ yìngyòng shèzhì.

Rúguǒ nín de Office wúfǎ zhèngcháng shǐyòng, kěyǐ zài cǐ chù chángshì xiūfù Office.

**Note: Rúguǒ nǐ diǎnjīle chóngxīn dòu qǔ, zuǒ cè de chǎnpǐn hé yǔyán shùjù huì chóngxīn zài rù, yīxiē shèzhì jiāng huì bèi chóng zhì wèi mòrèn zhí.**
Daha fazla göster
3638/5000
# Office Açıklaması Dağıt

Burada, şu anda yüklü olan Office ürünlerini ve dil paketlerini yönetebilirsiniz. Office yüklü değilse, yeni bir yükleme yapabilirsiniz. ** Microsoft kısıtlamaları nedeniyle, Office yalnızca sistem diskine yüklenebilir. **

Şu anda sürüm bilgisinde bulunan her kanaldaki Office sürümünün sürümünü ve yayınlanma tarihini sorgulayabilirsiniz. Sorgu tamamlandıktan sonra, indirme veya yükleme sırasında geçmiş sürümü seçebilirsiniz. En son sürüm varsayılan olarak yüklenir.

## dizin

---

1. Kurulum modülü açıklaması
2. Kanal ayar talimatları
3. Yeni kurulum talimatları
4. Ürün ekleme ve silme / dil tanımı
5. Office 365 Ürün Kimliği Karşılaştırma Tablosu
6. Kurulum dosyası açıklaması
7. Ofis yapılandırma talimatları

## Kurulum Modülü Açıklama

---

Office Dağıtım Aracı, Office Tool Plus'ın neredeyse tüm parametre ayarlarını desteklediği Office dağıtımı için kullanılan bir Microsoft resmi yayın aracıdır.
Office Tool Plus modülü, Office'i yüklemek için kendimiz yazdığımız küçük bir modüldür.O Office dağıtım aracının tüm işlevlerine sahip olmasa da, Office'in sorunsuz bir şekilde yüklenmesini de sağlar.

[Office Dağıtım Araçları resmi web sitesi] (https://aka.ms/ODT)

[Office Dağıtım Araçları için Yapılandırma Seçenekleri] (https://docs.microsoft.com/en-us/DeployOffice/configuration-options-for-the-office-2016-deployment-tool)

[Office Özelleştirme Aracı] (https://config.office.com)

** Office 2019 Premium Edition'ı Windows 7'den yüklemek için Office Tool Plus modülünü kullandığınızdan emin olun! **

`Office Dağıtım Araçları ile yükleme yaparken çözülmemiş bir sorunla karşılaştığınızda, Office Tool Plus yükleme modülünü deneyin! '

## Kanal Ayarları Açıklama

---

Office, Visio, Project 2019 cilt sürümü yalnızca Office 2019 Enterprise Uzun Vadeli kanalında desteklenir ve diğer ürünlerle (Office 365 gibi) karıştırılamaz.
Office 365'i yüklerken Visio'yu kullanmak istiyorsanız, Visio 2016 Retail veya 2016 Volume (Project) seçeneğini seçin.

Office 2016/2019 (perakende) / 365 ürünleri diğer kanalları seçebilir (Office 2019 kurumsal uzun vadeli sürümü olmadığı sürece), aylık kanalı kullanmanız önerilir ve yeni özellikleri önemsemeyen ofis çalışanları yarım yıllık kanalı seçebilir. ** Office ile ilgili sorun yaşıyorsanız, yönlendirilmiş bir kanal veya bir beta kanalı kullandığınızdan, lütfen kendiniz çözün. **

## Yeni kurulum talimatları

---

Yeni bir kurulum için, Ürün Ekle'ye tıklayın ve kurmak istediğiniz ürünü seçin. Ürün bir veya daha fazla uygulama içerebilir ve kurmak istemiyorsanız işaretini kaldırın. ** Bunlar arasında, Groove OneDrive İş'in ve Lync Skype'ın İşin kısaltmasıdır. **

Yeni bir kurulumda bir dil paketi belirtmezseniz, Office Tool Plus, sistem diliyle varsayılan olarak eşleşir. Office mevcut sistemin diline tam olarak uymuyorsa, [en-us] - İngilizce (ABD) varsayılan olarak ana dil olarak eklenir.
Dil eklerken, bir ana dil seçtiğinizden emin olun. '

Yeni bir kurulum kurarken, ** Office 2019 toplu sürümünü seçtiyseniz, kanalınızın Office 2019 kurumsal uzun vadeli kanal olduğundan emin olun, aksi takdirde düzgün şekilde kurulmaz! ** Office 2019 perakende sürümü diğer kanalları seçebilir.

## Ürün ekle / sil / dil tanımı

---

Office bilgisayarınıza önceden yüklendiğinde, Office Tool Plus aracılığıyla ürünleri ekleyebilir ve kaldırabilirsiniz.

### Ürün / dil ekle

Bir ürün veya dil eklemeniz gerekirse, ürünü / dili doğrudan ekleyin ve doğrudan kendi fikir / gereksinimlerinize göre seçin. `Not: Sorunları önlemek için, lütfen bir ürünü / dili tekrar tekrar kurmayın. '

### Uygulamayı değiştirme

Uygulamayı değiştirmeniz gerekirse, önce ürünü seçin, ardından istenmeyen uygulamaların işaretini kaldırın, eklemek istediklerinizi seçin ve ardından dağıtımı başlatın.

### Ürün / dil kaldırılıyor

Listede, kaldırmak istediğiniz ürünü / dili kontrol edin, ardından Dağıtımı Başlat düğmesinin sağındaki menüyü tıklayın ve * Seçili ürünü / dili kaldır * 'ı tıklayın.

## Office 365 Ürün Kimliği Karşılaştırma Tablosu

---

`Txt
Office 365 Professional Plus O365ProPlusPerakende
Office 365 Kurumsal E3 O365ProPlusPerakende
Office 365 Kurumsal E4 O365ProPlusPerakende
Office 365 Enterprise E5 O365ProPlusPerakende
Office 365 Orta O365ProPlusPerakende
Office 365 Business Edition O365İletişimPerakende
Office 365 Business Premium O365İş Yeri
Office Small Business Premium Sürüm O365KüçükBusPremPerakende
Office 365 Home Edition O365HomePremRetail
Office 365 Kişisel Sürüm O365HomePremRetail
`

Daha fazla bilgi için, lütfen [Office Dağıtım Araçları Desteklenen Ürün Kimlikleri] 'ni ziyaret edin (https://docs.microsoft.com/en-us/office365/troubleshoot/administration/product-ids-supported-office-deployment-click-to- run)

## Kurulum Dosyası Açıklaması

---

Yükleme dosyası, adından da anlaşılacağı gibi, Office için yükleme paketidir. Office Tool Plus, Office yükleme dosyalarının Microsoft Office CDN Sunucusundan indirilmesini ve ISO dosyalarına dönüştürülmesini destekler. Kurulum dosyalarını indirdikten sonra, bant genişliğinden tasarruf etmek veya zaman azaltmak için çevrimdışı kurulumu kullanabilir veya kurulum dosyalarını diğer kullanıcılarla paylaşabilirsiniz.

Yükleme dosyaları arasında Office, Visio ve Project bulunur: Office 2019 Enterprise Uzun Vadeli kanalından indirilen yükleme dosyaları yalnızca Office 2019'u toplu olarak kurmak için kullanılabilir ve diğer kanal yükleme dosyaları Office 2016, 365 ve 2019 perakende satışını yüklemek için kullanılabilir.

Office yükleme dosyalarını indirmek için mimariyi, kanalı ve dili, varsayılan olarak sistem diliyle eşleşecek şekilde yapılandırın. Office Tool Plus varsayılan olarak ayarlanmıştır ve yükleme dosyalarını doğrudan indirmeye başlayabilirsiniz.

! [Kurulum Dosyasını İndir] (https://coolhub.top/wp-content/uploads/2019/11/QQScreenshot 20191107202304-1.png)

### Daha fazla bilgi için, lütfen aşağıdaki web sitesini ziyaret edin

[Office 365 için güncelleme kanalına genel bakış] (https://docs.microsoft.com/en-us/DeployOffice/overview-of-update-channels-for-office-365-proplus)

[Office 365 güncelleme geçmişi] (https://docs.microsoft.com/en-us/officeupdates/update-history-office365-proplus-by-date)

[Office 2019 Güncelleme Kanalına Genel Bakış] (https://docs.microsoft.com/en-us/DeployOffice/office2019/update#update-channel-for-office-2019)

## Kurulum dosyasını indirin

---

Yükleme dosyalarını indirmek için Office Dağıtım Araçları'nın kullanımını desteklemenin yanı sıra, Office Tool Plus ayrıca kullanıcıların Office yükleme dosyalarını hızlı bir şekilde indirmelerini sağlayan bir Thunder programı da içerir. İkisi arasındaki temel işlevlerde fark yoktur, ancak yalnızca Thunder desteği indirme ilerlemesini destekler, hız sınırlarını ayarlamayı ve proxy'yi ayrı olarak ayarlamayı destekler. `Thunder indirme işleminde bir sorun varsa, motoru Office Dağıtım Aracı'na getirin.

### Thunder indirme hızı limit ayarı

Thunder yüklemesini kullanırken hız sınırını ayarlamak için, lütfen indirme sırasında indirme hızını tıklayın ve ardından açılır penceredeki hız sınırını ayarlayın. Hız sınırını iptal etmek için 0 girin.

## Office Yapılandırma Talimatları

---

Dağıtım sayfasının en sağında, Ofis Yapılandırma panelini çağırabilirsiniz. '
Office Tool Plus, Office güncelleme kanalında yapılan değişiklikleri ve Office'te görüntülenen hesap sahibinin değiştirilmesini de destekler. Düzenlendikten sonra ayarları uygulamak için Kaydet'i tıklayın.

Office'iniz çalışmıyorsa, Office'i burada düzeltmeyi deneyebilirsiniz.

** Not: Yeniden oku'yu tıklarsanız, soldaki ürün ve dil verileri yeniden yüklenir ve bazı ayarlar varsayılan değerlerine sıfırlanır. **
Geri bildirim gönder
Geçmiş
Kaydedilenler
Topluluk
