
# 激活 Office 说明

若您使用本工具激活失败，首先检查自己操作是否有误，下方说明中有 Office 的激活步骤说明，若您确定您的操作无误但又无法激活 Office，建议检查系统是否有问题。激活成功后，Office 各项功能均可正常使用，可以登录微软账号。

## 目录

---

1. 安装证书（转换授权）
2. 激活证书（激活 Office）
3. 检查 KMS 可用性
4. 查询激活状态
5. 清除 Office 激活信息
6. 常见错误以及解决办法
7. GVLK 列表

## 安装证书

---

安装某个证书以后，即可使用对应该证书的密钥进行激活。
举个例子：比如要转换 Office 2016 Retail -> Office 2016 Volume，直接安装 Office 2016 Volume 许可证即可完成转换。
安装完成后，旧的证书并不会被覆盖，因此通过此操作可以做到多证书授权共存。

点击旁边的省略按钮可以自定义选择并安装证书。

`注意：只有当计算机上安装了基于 Click to Run 版本的 Office 时，OTP 才会读取 Office 证书并在下拉框中显示。否则 OTP 仅会显示内置的 Volume (批量版) 证书。`

## Office 激活方法以及步骤

---

`请注意：所有 Office 365 产品仅可通过登录账号激活，Office Tool Plus 仅支持管理激活，不负责激活。`

### 密钥在线激活步骤

`激活前，请确保您的密钥有效以及 Office 版本对应。`将密钥输入，并点击安装密钥，然后点击激活，Office 将成功激活。此过程亦可以在 Office 内完成。
激活成功后，Office 将会一直保持激活状态。

### 电话激活步骤

安装密钥，`确保其可以用于电话激活`。在安装密钥按钮的菜单中，点击查看安装 ID，使用此 ID 在微软提供的方式内获取 确认 ID，然后安装 确认 ID，若 确认 ID 和 安装 ID 对应，Office 即可成功离线激活。
激活成功后，Office 将会一直保持激活状态。

### KMS 激活步骤

激活前，请确保您的 Office 是批量版，如果不确定，请安装对应的 批量（Volume）证书，比如你要激活 Office 2016 就安装 Office 2016 Volume 证书，`然后设定一个 KMS 地址`，当一切配置无误、网络正常、服务器正常的情况下，点击激活按钮，Office 将会顺利激活。

`KMS 激活成功后，Office 会默认 7 天与服务器连接一次并自动续期，最大持续激活时间为 180 天。此步骤由 Windows 自行完成，无需人工干涉，也没有任何后台程序驻留。`

## 检测 KMS 可用性

---

输入一个 KMS 地址，然后在按钮菜单中点击检测 KMS 可用性。

一般情况下会返回如下的结果：
Connecting to 192.168.123.1:1688 ... successful
Sending activation request (KMS V4) 1 of 1  -> 03612-00206-524-247319-03-1100-14393.0000-2802018

其中 successful 表示可以正常连接到服务器，Sending activation request 则表示服务器可以正常响应激活请求。

如果检测没有返回结果或者返回的结果不完整，则表示此 KMS 服务器或者网络可能存在问题。

## 查询 Office 激活状态

---

点击 *显示激活信息* 可以查询已安装密钥的许可证的信息。
`当许可证状态为 ---已许可--- 时，表示 Office 已激活，其他所有的状态都是未激活。`

## Office 激活信息管理

---

### 卸载 Office 产品密钥

点击 *显示激活信息* 以查询已安装密钥的许可证的信息。

将不需要的授权的最后五位数密钥复制，将其粘贴到密钥框中，然后在按钮菜单中选择卸载密钥，即可清除此激活信息。

![卸载产品密钥](https://coolhub.top/wp-content/uploads/2019/11/卸载产品密钥.png)

### 清除 Office 产品密钥

在密钥管理的按钮菜单中，可以卸载所有密钥。
卸载所有密钥后，Office 会回到未激活的状态，您需要重新激活 Office。

### 清除 Office 许可证

在证书管理的按钮菜单中，可以清除所有许可证。
清除许可证后，第一次打开 Office 应用程序需要修复以重新安装默认的许可证。
或者您可以手动安装许可证，安装完毕后，可以重新激活 Office。

**清除激活状态会将密钥和证书一并清除。**

## 常见错误以及解决办法

---

错误代码：0xC004F074
错误原因：未知
解决办法：重装`原版`系统，并且`不再使用 KMS 破解软件激活 Windows`。

错误代码1：0x8007007B
错误原因：文件名、目录名或卷标语法不正确
错误代码2：0x8007232B
错误原因：DNS 名称不存在
错误代码3：0x8007000D
错误原因：数据无效
解决办法：在工具箱内修复 Office 的激活，然后再设定 KMS 服务器地址，再进行激活操作

错误提示：没有在此计算机上发现 Office 批量许可证
错误原因：没有安装 Office 批量许可证，无法使用 MAK 或者 KMS 激活
解决办法：安装 Office 批量许可证（Volume）

错误提示：软件授权服务报告许可证未安装
错误原因：这个许可证安装的是默认的密钥
解决办法：如果您正在尝试激活试用许可（伪 Office 365），此问题无需解决。
　　　　　否则，您应更换一个有效密钥。

错误提示：软件授权服务报告未找到产品 SKU
错误原因：许可证没有安装，或者密钥和证书不对应
解决办法：安装对应的授权证书，或者更换其他密钥
　　　　　如果您在安装证书过程中出现此错误，则应该按照下面的解决方法操作👇

错误提示1：发生未知错误
错误提示2：软件授权服务报告许可证使用失败
错误原因：Windows Insider 的 Bug，导致 Office 无法正常验证激活信息
解决办法：将 Software Protection 服务停止，然后将 C:\Windows\System32\spp\store_test\2.0 下的三个 (.dat) 文件删除（有一个隐藏的）。然后再重新进行一切激活操作

错误提示：An error occurred while making the connection.
　　　　　错误代码：-2147023838
错误原因：系统关键服务被禁用
解决办法：在“服务”中将 Windows Management Instrumentation 服务启用，启用后，再次尝试操作。

## GVLK 列表

---

使用 GVLK 之前，请确保您的 Office 为批量版
如您不知是否为批量版，请安装对应的 Volume 证书，然后再使用 GVLK
使用 KMS 激活必须要配置一个 KMS 服务器地址，否则无法激活 Office。

获取更多信息请访问 [用于 Office 2019 和 Office 2016 的 KMS 和基于 Active Directory 激活的 GVLK](https://docs.microsoft.com/zh-cn/DeployOffice/vlactivation/gvlks)

```txt
Office 2019 GVLK

Office Pro Plus 2019	NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP
Office Standard 2019	6NWWJ-YQWMR-QKGCB-6TMB3-9D9HK
Project Pro 2019		B4NPR-3FKK7-T2MBV-FRQ4W-PKD2B
Project Std 2019		C4F7P-NCP8C-6CQPT-MQHV9-JXD2M
Visio Pro 2019		9BGNQ-K37YR-RQHF2-38RQ3-7VCBB
Visio Std 2019		7TQNQ-K3YQQ-3PFH7-CCPPM-X4VQ2
Access 2019		9N9PT-27V4Y-VJ2PD-YXFMF-YTFQT
Excel 2019		TMJWT-YYNMB-3BKTF-644FC-RVXBD
Outlook 2019		7HD7K-N4PVK-BHBCQ-YWQRW-XW4VK
PowerPoint 2019	RRNCX-C64HY-W2MM7-MCH9G-TJHMQ
Publisher 2019		G2KWX-3NW6P-PY93R-JXK2T-C9Y9V
Skype for Business	NCJ33-JHBBY-HTK98-MYCV8-HMKHJ
Word 2019		PBX3G-NWMT6-Q7XBW-PYJGG-WXD33

Office 2016 GVLK

Office Pro Plus 2016	XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99
Office Standard 2016	JNRGM-WHDWX-FJJG3-K47QV-DRTFM
Office Mondo 2016	HFTND-W9MK4-8B7MJ-B6C4G-XQBR2
Project Pro 2016		WGT24-HCNMF-FQ7XH-6M8K7-DRTW9
Project Std 2016		D8NRQ-JTYM3-7J2DX-646CT-6836M
Visio Pro 2016		69WXN-MBYV6-22PQG-3WGHK-RM6XC
Visio Std 2016		NY48V-PPYYH-3F4PX-XJRKJ-W4423
Access 2016		GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW
Excel 2016		9C2PK-NWTVB-JMPW8-BFT28-7FTBF
OneNote 2016		DR92N-9HTF2-97XKM-XW2WJ-XW3J6
Outlook 2016		R69KK-NTPKF-7M3Q4-QYBHW-6MT9B
PowerPoint 2016	J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6
Publisher 2016		F47MM-N3XJP-TQXJ9-BP99D-8K837
Skype for Business	869NQ-FJ69K-466HW-QYCP2-DDBV6
Word 2016		WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6
```

### Office 365 Pro Plus Normal Key

DRNV7-VGMM2-B3G9T-4BF84-VMFTK

如果你看不懂上面的是什么意思，那就请不要随便用，反正也不能用来激活 Office。

# Jīhuó Office shuōmíng

ruò nín shǐyòng běn gōngjù jīhuó shībài, shǒuxiān jiǎnchá zìjǐ cāozuò shìfǒu yǒu wù, xiàfāng shuōmíng zhōng yǒu Office de jīhuó bùzhòu shuōmíng, ruò nín quèdìng nín de cāozuò wúwù dàn yòu wúfǎ jīhuó Office, jiànyì jiǎnchá xìtǒng shìfǒu yǒu wèntí. Jīhuó chénggōng hòu,Office gè xiàng gōngnéng jūn kě zhèngcháng shǐyòng, kěyǐ dēnglù wēiruǎn zhànghào.

## Mùlù

---

1. Ānzhuāng zhèngshū (zhuǎnhuàn shòuquán)
2. Jīhuó zhèngshū (jīhuó Office)
3. Jiǎnchá KMS kěyòngxìng
4. Cháxún jīhuó zhuàngtài
5. Qīngchú Office jīhuó xìnxī
6. Chángjiàn cuòwù yǐjí jiějué bànfǎ
7. GVLK lièbiǎo

## ānzhuāng zhèngshū

---

ānzhuāng mǒu gè zhèngshū yǐhòu, jí kě shǐyòng duìyìng gāi zhèngshū de mì yào jìnxíng jīhuó.
Jǔ gè lìzi: Bǐrú yào zhuǎnhuàn Office 2016 Retail -> Office 2016 Volume, zhíjiē ānzhuāng Office 2016 Volume xǔkě zhèng jí kě wánchéng zhuǎnhuàn.
Ānzhuāng wánchéng hòu, jiù de zhèngshū bìng bù huì bèi fùgài, yīncǐ tōngguò cǐ cāozuò kěyǐ zuò dào duō zhèngshū shòuquán gòngcún.

Diǎnjī pángbiān de shěnglüè ànniǔ kěyǐ zì dìngyì xuǎnzé bìng ānzhuāng zhèngshū.

`Zhùyì: Zhǐyǒu dāng jìsuànjī shàng ānzhuāngle jīyú Click to Run bǎnběn de Office shí,OTP cái huì dòu qǔ Office zhèngshū bìng zài xiàlā kuāng zhōng xiǎnshì. Fǒuzé OTP jǐn huì xiǎnshì nèizhì de Volume (pīliàng bǎn) zhèngshū.`

## Office jīhuó fāngfǎ yǐjí bùzhòu

---

`qǐng zhùyì: Suǒyǒu Office 365 chǎnpǐn jǐn kě tōngguò dēnglù zhànghào jīhuó,Office Tool Plus jǐn zhīchí guǎnlǐ jīhuó, bù fùzé jīhuó.`

### Mì yào zàixiàn jīhuó bùzhòu

`jīhuó qián, qǐng quèbǎo nín de mì yào yǒuxiào yǐjí Office bǎnběn duìyìng.`Jiāng mì yào shūrù, bìng diǎnjī ānzhuāng mì yào, ránhòu diǎnjī jīhuó,Office jiāng chénggōng jīhuó. Cǐ guòchéng yì kěyǐ zài Office nèi wánchéng.
Jīhuó chénggōng hòu,Office jiāng huì yīzhí bǎochí jīhuó zhuàngtài.

### Diànhuà jīhuó bùzhòu

ānzhuāng mì yào,`quèbǎo qí kěyǐ yòng yú diànhuà jīhuó `. Zài ānzhuāng mì yào ànniǔ de càidān zhōng, diǎnjī chákàn ānzhuāng ID, shǐyòng cǐ ID zài wēiruǎn tígōng de fāngshì nèi huòqǔ quèrèn ID, ránhòu ānzhuāng quèrèn ID, ruò quèrèn ID hé ānzhuāng ID duìyìng,Office jí kě chénggōng líxiàn jīhuó.
Jīhuó chénggōng hòu,Office jiāng huì yīzhí bǎochí jīhuó zhuàngtài.

### KMS jīhuó bùzhòu

jīhuó qián, qǐng quèbǎo nín de Office shì pīliàng bǎn, rúguǒ bù quèdìng, qǐng ānzhuāng duìyìng de pīliàng (Volume) zhèngshū, bǐrú nǐ yào jīhuó Office 2016 jiù ānzhuāng Office 2016 Volume zhèngshū,`ránhòu shè dìng yīgè KMS dìzhǐ `, dāng yīqiè pèizhì wúwù, wǎngluò zhèngcháng, fúwùqì zhèngcháng de qíngkuàng xià, diǎnjī jīhuó ànniǔ,Office jiāng huì shùnlì jīhuó.

`KMS jīhuó chénggōng hòu,Office huì mòrèn 7 tiān yǔ fúwùqì liánjiē yīcì bìng zìdòng xù qī, zuìdà chíxù jīhuó shíjiān wèi 180 tiān. Cǐ bùzhòu yóu Windows zìxíng wánchéng, wúxū réngōng gānshè, yě méiyǒu rènhé hòutái chéngxù zhù liú.`

## Jiǎncè KMS kěyòngxìng

---

shūrù yīgè KMS dìzhǐ, ránhòu zài ànniǔ càidān zhōng diǎnjī jiǎncè KMS kěyòngxìng.

Yībān qíngkuàng xià huì fǎnhuí rúxià de jiéguǒ:
Connecting to 192.168.123.1:1688... Successful
Sending activation request (KMS V4) 1 of 1  -> 03612-00206-524-247319-03-1100-14393.0000-2802018

Qízhōng successful biǎoshì kěyǐ zhèngcháng liánjiē dào fúwùqì,Sending activation request zé biǎoshì fúwùqì kěyǐ zhèngcháng xiǎngyìng jīhuó qǐngqiú.

Rúguǒ jiǎncè méiyǒu fǎnhuí jiéguǒ huòzhě fǎnhuí de jiéguǒ bù wánzhěng, zé biǎoshì cǐ KMS fúwùqì huòzhě wǎngluò kěnéng cúnzài wèntí.

## Cháxún Office jīhuó zhuàngtài

---

diǎnjī*xiǎnshì jīhuó xìnxī* kěyǐ cháxún yǐ ānzhuāng mì yào de xǔkě zhèng de xìnxī.
`Dāng xǔkě zhèng zhuàngtài wèi ---yǐ xǔkě--- shí, biǎoshì Office yǐ jīhuó, qítā suǒyǒu de zhuàngtài dōu shì wèi jīhuó.`

## Office jīhuó xìnxī guǎnlǐ

---

### xièzài Office chǎnpǐn mì yào

diǎnjī*xiǎnshì jīhuó xìnxī* yǐ cháxún yǐ ānzhuāng mì yào de xǔkě zhèng de xìnxī.

Jiāng bù xūyào de shòuquán de zuìhòu wǔ wèi shù mì yào fùzhì, jiāng qí zhāntiē dào mì yào kuāng zhōng, ránhòu zài ànniǔ càidān zhòng xuǎnzé xièzài mì yào, jí kě qīngchú cǐ jīhuó xìnxī.

![Xièzài chǎnpǐn mì yào](https://Coolhub.Top/wp-content/uploads/2019/11/xièzài chǎnpǐn mì yào.Png)

### qīngchú Office chǎnpǐn mì yào

zài mì yào guǎnlǐ de ànniǔ càidān zhōng, kěyǐ xièzài suǒyǒu mì yào.
Xièzài suǒyǒu mì yào hòu,Office huì huí dào wèi jīhuó de zhuàngtài, nín xūyào chóngxīn jīhuó Office.

### Qīngchú Office xǔkě zhèng

zài zhèngshū guǎnlǐ de ànniǔ càidān zhōng, kěyǐ qīngchú suǒyǒu xǔkě zhèng.
Qīngchú xǔkě zhèng hòu, dì yī cì dǎkāi Office yìngyòng chéngxù xūyào xiūfù yǐ chóngxīn ānzhuāng mòrèn de xǔkě zhèng.
Huòzhě nín kěyǐ shǒudòng ānzhuāng xǔkě zhèng, ānzhuāng wánbì hòu, kěyǐ chóngxīn jīhuó Office.

**Qīngchú jīhuó zhuàngtài huì jiāng mì yào hé zhèngshū yī bìng qīngchú.**

## Chángjiàn cuòwù yǐjí jiějué bànfǎ

---

cuòwù dàimǎ:0XC004F074
cuòwù yuányīn: Wèizhī
jiějué bànfǎ: Zhòng zhuāng `yuánbǎn `xìtǒng, bìngqiě `bù zài shǐyòng KMS pòjiě ruǎnjiàn jīhuó Windows`.

Cuòwù dàimǎ 1:0X8007007B
cuòwù yuányīn: Wénjiàn míng, mùlù míng huò juǎn biāo yǔfǎ bù zhèngquè
cuòwù dàimǎ 2:0X8007232B
cuòwù yuányīn:DNS míngchēng bù cúnzài
cuòwù dàimǎ 3:0X8007000D
cuòwù yuányīn: Shùjù wúxiào
jiějué bànfǎ: Zài gōngjù xiāng nèi xiūfù Office de jīhuó, ránhòu zài shè dìng KMS fúwùqì dìzhǐ, zài jìnxíng jīhuó cāozuò

cuòwù tíshì: Méiyǒu zài cǐ jìsuànjī shàng fāxiàn Office pīliàng xǔkě zhèng
cuòwù yuányīn: Méiyǒu ānzhuāng Office pīliàng xǔkě zhèng, wúfǎ shǐyòng MAK huòzhě KMS jīhuó
jiějué bànfǎ: Ānzhuāng Office pīliàng xǔkě zhèng (Volume)

cuòwù tíshì: Ruǎnjiàn shòuquán fúwù bàogào xǔkě zhèng wèi ānzhuāng
cuòwù yuányīn: Zhège xǔkě zhèng ānzhuāng de shì mòrèn de mì yào
jiějué bànfǎ: Rúguǒ nín zhèngzài chángshì jīhuó shìyòng xǔkě (wěi Office 365), cǐ wèntí wúxū jiějué.
     Fǒuzé, nín yīng gēnghuàn yīgè yǒuxiào mì yào.

Cuòwù tíshì: Ruǎnjiàn shòuquán fúwù bàogào wèi zhǎodào chǎnpǐn SKU
cuòwù yuányīn: Xǔkě zhèng méiyǒu ānzhuāng, huòzhě mì yào hé zhèngshū bù duìyìng
jiějué bànfǎ: Ānzhuāng duìyìng de shòuquán zhèngshū, huòzhě gēnghuàn qítā mì yào
     rúguǒ nín zài ānzhuāng zhèngshū guòchéng zhòng chūxiàn cǐ cuòwù, zé yīnggāi ànzhào xiàmiàn de jiějué fāngfǎ cāozuò 👇

cuòwù tíshì 1: Fāshēng wèizhī cuòwù
cuòwù tíshì 2: Ruǎnjiàn shòuquán fúwù bàogào xǔkě zhèng shǐyòng shībài
cuòwù yuányīn:Windows Insider de Bug, dǎozhì Office wúfǎ zhèngcháng yànzhèng jīhuó xìnxī
jiějué bànfǎ: Jiāng Software Protection fúwù tíngzhǐ, ránhòu jiāng C:\Windows\System32\spp\store_test\2.0 Xià de sān gè (.Dat) wénjiàn shānchú (yǒu yīgè yǐncáng de). Ránhòu zài chóngxīn jìnxíng yīqiè jīhuó cāozuò

cuòwù tíshì:An error occurred while making the connection.
     Cuòwù dàimǎ:-2147023838
Cuòwù yuányīn: Xìtǒng guānjiàn fúwù bèi jìnyòng
jiějué bànfǎ: Zài “fúwù” zhōng jiàng Windows Management Instrumentation fúwù qǐyòng, qǐyòng hòu, zàicì chángshì cāozuò.

## GVLK lièbiǎo

---

shǐyòng GVLK zhīqián, qǐng quèbǎo nín de Office wèi pīliàng bǎn
rú nín bùzhī shìfǒu wèi pīliàng bǎn, qǐng ānzhuāng duì yìng de Volume zhèngshū, ránhòu zài shǐyòng GVLK
shǐyòng KMS jīhuó bìxū yào pèizhì yīgè KMS fúwùqì dìzhǐ, fǒuzé wúfǎ jīhuó Office.

Huòqǔ gèng duō xìnxī qǐng fǎngwèn [yòng yú Office 2019 hé Office 2016 de KMS hé jīyú Active Directory jīhuó de GVLK](https://Docs.Microsoft.Com/zh-cn/DeployOffice/vlactivation/gvlks)

```txt
Office 2019 GVLK

Office Pro Plus 2019	NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP
Office Standard 2019	6NWWJ-YQWMR-QKGCB-6TMB3-9D9HK
Project Pro 2019		B4NPR-3FKK7-T2MBV-FRQ4W-PKD2B
Project Std 2019		C4F7P-NCP8C-6CQPT-MQHV9-JXD2M
Visio Pro 2019		9BGNQ-K37YR-RQHF2-38RQ3-7VCBB
Visio Std 2019		7TQNQ-K3YQQ-3PFH7-CCPPM-X4VQ2
Access 2019		9N9PT-27V4Y-VJ2PD-YXFMF-YTFQT
Excel 2019		TMJWT-YYNMB-3BKTF-644FC-RVXBD
Outlook 2019		7HD7K-N4PVK-BHBCQ-YWQRW-XW4VK
PowerPoint 2019	RRNCX-C64HY-W2MM7-MCH9G-TJHMQ
Publisher 2019		G2KWX-3NW6P-PY93R-JXK2T-C9Y9V
Skype for Business	NCJ33-JHBBY-HTK98-MYCV8-HMKHJ
Word 2019		PBX3G-NWMT6-Q7XBW-PYJGG-WXD33

Office 2016 GVLK

Office Pro Plus 2016	XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99
Office Standard 2016	JNRGM-WHDWX-FJJG3-K47QV-DRTFM
Office Mondo 2016	HFTND-W9MK4-8B7MJ-B6C4G-XQBR2
Project Pro 2016		WGT24-HCNMF-FQ7XH-6M8K7-DRTW9
Project Std 2016		D8NRQ-JTYM3-7J2DX-646CT-6836M
Visio Pro 2016		69WXN-MBYV6-22PQG-3WGHK-RM6XC
Visio Std 2016		NY48V-PPYYH-3F4PX-XJRKJ-W4423
Access 2016		GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW
Excel 2016		9C2PK-NWTVB-JMPW8-BFT28-7FTBF
OneNote 2016		DR92N-9HTF2-97XKM-XW2WJ-XW3J6
Outlook 2016		R69KK-NTPKF-7M3Q4-QYBHW-6MT9B
PowerPoint 2016	J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6
Publisher 2016		F47MM-N3XJP-TQXJ9-BP99D-8K837
Skype for Business	869NQ-FJ69K-466HW-QYCP2-DDBV6
Word 2016		WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6
```

### Office 365 Pro Plus Normal Key

DRNV7-VGMM2-B3G9T-4BF84-VMFTK

rúguǒ nǐ kàn bù dǒng shàngmiàn de shì shénme yìsi, nà jiù qǐng bùyào suíbiàn yòng, fǎnzhèng yě bùnéng yòng lái jīhuó Office.
Daha fazla göster
4661/5000
# Office Açıklamasını Etkinleştir

Bu araçla etkinleştiremezseniz, önce işleminizin doğru olup olmadığını kontrol edin Aşağıdaki talimatlar Office'in etkinleştirme adımlarını açıklar.Eğer işleminizin doğru olduğundan eminseniz ancak Office'i etkinleştiremiyorsanız, herhangi bir sorun için sistemi kontrol etmeniz önerilir. Etkinleştirme başarılı olduktan sonra, Office'in tüm işlevleri normal bir şekilde kullanılabilir, Microsoft hesabına giriş yapabilirsiniz.

## dizin

---

1. Sertifikayı yükleyin (dönüşüm yetkisi)
2. Sertifikayı etkinleştirin (Office'i etkinleştirin)
3. KMS kullanılabilirliğini kontrol edin
4. Sorgu etkinleştirme durumu
5. Office etkinleştirme bilgilerini temizleyin
6. Yaygın hatalar ve çözümler
7. GVLK listesi

## Bir sertifika yükleme

---

Bir sertifikayı yükledikten sonra, sertifikayı sağlayan anahtarla etkinleştirebilirsiniz.
Örneğin, Office 2016 Retail -> Office 2016 Volume ürününü dönüştürmek için, dönüştürmeyi tamamlamak üzere doğrudan Office 2016 Cilt lisansını yükleyin.
Kurulum tamamlandıktan sonra eski sertifikanın üzerine yazılmayacaktır, bu sayede bu işlem çoklu sertifika yetkilendirme bir arada bulunabilmektedir.

Seçimi özelleştirmek ve sertifikayı yüklemek için yanındaki üç nokta düğmesini tıklatın.

`Not: OTP, Office sertifikasını okur ve yalnızca bilgisayarın Çalıştırmak için Tıkla sürümünde Office yüklüyse açılan kutuda görüntüler. Aksi takdirde, OTP yalnızca dahili Birim (birim) sertifikasını görüntüler. '

## Office aktivasyon yöntemi ve adımları

---

`Lütfen dikkat: Tüm Office 365 ürünleri yalnızca bir oturum açma hesabıyla etkinleştirilebilir: Office Tool Plus, yalnızca yönetim etkinleştirmesini destekler ve etkinleştirmeden sorumlu değildir. '

### Anahtar çevrimiçi aktivasyon adımı

`Etkinleştirmeden önce, lütfen anahtarınızın geçerli olduğundan ve Office sürümünün uygun olduğundan emin olun. `Anahtarı girin ve Anahtar Yükle'ye tıklayın, ardından Etkinleştir'e tıklayın, Office başarıyla etkinleştirilecektir. Bu işlem ayrıca Ofis içinde de yapılabilir.
Etkinleştirme başarılı olduktan sonra, Office etkin kalacaktır.

### Telefon aktivasyon adımları

Anahtarı takın, `telefon aktivasyonu için kullanılabildiğinden emin olun '. Anahtar düğmesini yükleme menüsünde, Kurulum Kimliğini Göster'i tıklatın, onay kimliğini Microsoft tarafından sağlanan şekilde almak için bu kimliği kullanın ve ardından onay kimliğini yükleyin. Onay kimliği ve yükleme kimliği karşılık gelirse, Office çevrimdışı olarak başarıyla etkinleştirilebilir.
Etkinleştirme başarılı olduktan sonra, Office etkin kalacaktır.

### KMS aktivasyon adımları

Etkinleştirmeden önce lütfen Office'inizin toplu sürüm olduğundan emin olun .. Emin değilseniz, lütfen ilgili Birim sertifikasını kurun Örneğin, Office 2016'yı etkinleştirmek istiyorsanız, Office 2016 Birim sertifikasını yükleyin ve ardından bir KMS adresi belirleyin. Yapılandırma doğruysa, ağ normaldir ve sunucu normalse etkinleştirme düğmesini tıklayın; Office etkinleştirilecektir.

KMS aktivasyonu başarılı olduktan sonra, Office her 7 günde bir sunucuya bağlanacak ve otomatik olarak yenileyecek, maksimum sürekli aktivasyon süresi 180 gündür. Bu adım, Windows tarafından kendisi tarafından insan müdahalesi olmadan ve herhangi bir zindan olmadan yapılır. '

## KMS kullanılabilirliğini algılama

---

Bir KMS adresi girin ve düğme menüsünden KMS Kullanılabilirliğini Algıla'yı tıklayın.

Genel olarak, aşağıdaki sonuçlar iade edilecektir:
192.168.123.1:1688’e bağlanma ... başarılı
Aktivasyon isteği gönderme (KMS V4) 1/1 -> 03612-00206-524-247319-03-1100-14393.0000-2802018

Başarılı olduğunda, sunucunun normal olarak sunucuya bağlanabileceği ve Etkinleştirme isteğinin gönderilmesi, sunucunun etkinleştirme isteğine normal şekilde yanıt verebileceği anlamına gelir.

Test bir sonuç döndürmezse ya da döndürülen sonuç eksikse, bu KMS sunucusunda veya ağında bir sorun olabilir.

## Query Office aktivasyon durumu

---

Yüklü anahtarın lisans bilgilerini sorgulamak için * Etkinleştirme bilgilerini göster * seçeneğine tıklayın.
`Lisans durumu --- İzinli --- olduğunda, Office'in etkin olduğu ve diğer tüm durumların etkin olmadığı anlamına gelir. '

## Office Aktivasyon Bilgi Yönetimi

---

### Office Ürün Anahtarlarını Kaldırma

Yüklü anahtarın lisansı hakkında bilgi sorgulamak için * Etkinleştirme bilgilerini göster * seçeneğine tıklayın.

İstenmeyen yetkilendirmenin son beş basamaklı anahtarını kopyalayın, anahtar kutusuna yapıştırın ve etkinleştirme bilgilerini silmek için düğme menüsünde Anahtar Kaldır'ı seçin.

! [Ürün Anahtarını Kaldır] (https://coolhub.top/wp-content/uploads/2019/11/Uninstall Product Key.png)

### Office Ürün Anahtarlarını Temizle

Anahtar yönetiminin düğme menüsünde, tüm anahtarlar kaldırılabilir.
Tüm anahtarları kaldırdıktan sonra, Office etkin olmayan durumuna döner ve Office'i yeniden etkinleştirmeniz gerekir.

### Clear Office lisansı

Sertifika yönetiminin düğme menüsünden tüm lisanslar silinebilir.
Lisansınızı temizledikten sonra, bir Office uygulamasını ilk açtığınızda, varsayılan lisansı yeniden yüklemek için düzeltmeniz gerekir.
Ya da lisansı manuel olarak kurabilir ve kurulumdan sonra Office'i yeniden etkinleştirebilirsiniz.

** Etkinleştirme durumunu silmek, anahtarı ve sertifikayı birlikte siler. **

## Yaygın hatalar ve çözümler

---

Hata kodu: 0xC004F074
Hatanın nedeni: Bilinmiyor
Çözüm: 'Orijinal' sistemi yeniden yükleyin ve `Windows'u etkinleştirmek için KMS çatlama yazılımını kullanmayın.

Hata kodu 1: 0x8007007B
Neden: Dosya adı, dizin adı veya birim etiketi sözdizimi hatalı.
Hata kodu 2: 0x8007232B
Neden: DNS adı mevcut değil.
Hata kodu 3: 0x8007000D
Hatanın nedeni: geçersiz veri
Çözüm: Office aktivasyonunu araç kutusundan düzeltin, ardından KMS sunucu adresini ayarlayın, ardından etkinleştirin.

Hata mesajı: Bu bilgisayarda Office Toplu Lisans bulunamadı
Neden: Office Toplu Lisans yüklenmemiş ve MAK veya KMS kullanılarak etkinleştirilemiyor
Geçici Çözüm: Office Birimi Lisansını Yükleme (Birim)

Hata mesajı: Yazılım Lisanslama Servis Raporu Lisansı kurulu değil
Neden: Bu lisans varsayılan anahtarla birlikte yüklenir.
Çözüm: Deneme lisansını etkinleştirmeye çalışıyorsanız (sözde Office 365), bu sorunun çözülmesi gerekmez.
Aksi takdirde, geçerli bir anahtarı değiştirmeniz gerekir.

Hata mesajı: Yazılım Yetkilendirme Servisi raporu, ürün SKU'sunu bulamadı
Neden: Lisans yüklü değil veya anahtar ile sertifika uygun değil
Çözüm: İlgili yetkilendirme sertifikasını kurun veya başka bir anahtarı değiştirin.
Sertifikanın yüklenmesi sırasında bu hatayı alırsanız, aşağıdaki geçici çözümü izlemelisiniz

Hata 1: Bilinmeyen bir hata oluştu
Hata 2: Yazılım Yetkilendirme Hizmeti, lisans kullanımının başarısız olduğunu bildirdi
Neden: Windows Insider hatası, Office'in etkinleştirme bilgilerini doğrulamamasına neden oldu
Çözüm: Yazılım Koruma hizmetini durdurun ve C: \ Windows \ System32 \ spp \ store_test \ 2.0 altındaki üç (.dat) dosyasını silin (gizli bir tane var). Sonra tüm aktivasyonları tekrar yap

Hata mesajı: Bağlantı kurulurken bir hata oluştu.
Hata kodu: -2147023838
Neden: Sistem kritik hizmeti devre dışı
Geçici Çözüm: Hizmette Windows Yönetim Araçları hizmetini etkinleştirin ve etkinleştirildiğinde işlemi tekrar deneyin.

## GVLK listesi

---

GVLK'yi kullanmadan önce, Office'in hacimli olduğundan emin olun.
Toplu sürüm olup olmadığını bilmiyorsanız, lütfen ilgili Birim sertifikasını kurun ve sonra GVLK'yi kullanın.
KMS ile etkinleştirme, KMS sunucu adresinin yapılandırılmasını gerektirir, aksi takdirde Office etkinleştirilemez.

Daha fazla bilgi için, lütfen [Office 2019 ve Office 2016 için KMS ve Active Directory Etkinleştirmesi için GVLK] adresini ziyaret edin (https://docs.microsoft.com/en-us/DeployOffice/vlactivation/gvlks)

`Txt
Office 2019 GVLK

Office Pro Plus 2019 NMMKJ-6RK4F-KMJVX-8D9MJ-6MWKP
Office Standardı 2019 6NWWJ-YQWMR-QKGCB-6TMB3-9D9HK
Proje Pro 2019 B4NPR-3FKK7-T2MBV-FRQ4W-PKD2B
Proje Std 2019 C4F7P-NCP8C-6CQPT-MQHV9-JXD2M
Visio Pro 2019 9BGNQ-K37YR-RQHF2-38RQ3-7VCBB
Visio Std 2019 7TQNQ-K3YQQ-3PFH7-CCPPM-X4VQ2
Erişim 2019 9N9PT-27V4Y-VJ2PD-YXFMF-YTFQT
Excel 2019 TMJWT-YYNMB-3BKTF-644FC-RVXBD
Görünüm 2019 7HD7K-N4PVK-BHBCQ-YWQRW-XW4VK
PowerPoint 2019 RRNCX-C64HY-W2MM7-MCH9G-TJHMQ
Yayımcı 2019 G2KWX-3NW6P-PY93R-JXK2T-C9Y9V
İşletmeler için Skype NCJ33-JHBBY-HTK98-MYCV8-HMKHJ
Kelime 2019 PBX3G-NWMT6-Q7XBW-PYJGG-WXD33

Office 2016 GVLK

Ofis Pro Artı 2016 XQNVK-8JYDB-WJ9W3-YJ8YR-WFG99
Ofis Standartları 2016 JNRGM-WHDWX-FJJG3-K47QV-DRTFM
Ofis Mondo 2016 HFTND-W9MK4-8B7MJ-B6C4G-XQBR2
Proje Pro 2016 WGT24-HCNMF-FQ7XH-6M8K7-DRTW9
Proje Std 2016 D8NRQ-JTYM3-7J2DX-646CT-6836M
Visio Pro 2016 69WXN-MBYV6-22PQG-3WGHK-RM6XC
Visio Std 2016 NY48V-PPYYH-3F4PX-XJRKJ-W4423
Erişim 2016 GNH9Y-D2J4T-FJHGG-QRVH7-QPFDW
Excel 2016 9C2PK-NWTVB-JMPW8-BFT28-7FTBF
OneNote 2016 DR92N-9HTF2-97XKM-XW2WJ-XW3J6
Outlook 2016 R69KK-NTPKF-7M3Q4-QYBHW-6MT9B
PowerPoint 2016 J7MQP-HNJ4Y-WJ7YM-PFYGF-BY6C6
Yayımcı 2016 F47MM-N3XJP-TQXJ9-BP99D-8K837
İşletmeler için Skype 869NQ-FJ69K-466HW-QYCP2-DDBV6
Kelime 2016 WXY84-JN2Q9-RBCCQ-3Q3J3-3PFJ6
`

### Office 365 Pro Plus Normal Anahtar

DRNV7-VGMM2-B3G9T-4BF84-VMFTK

Ne anlama geldiğini anlamadıysanız, lütfen yine de kullanmayın, Office'i etkinleştirmek için kullanamazsınız.
Geri bildirim gönder
Geçmiş
Kaydedilenler
Topluluk
