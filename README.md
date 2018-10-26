# 密码热键（Secure Hot Key）

本项目提取自银行网银自动密码输入器（实现公司出纳快速 K 宝付款）。

通过密码热键，你可以定义 F8/F9 两个热键的内容，只需按下热键内容自动输入，并可以自动回车。

支持网银的 IE 密码控件输入，非程序事件，采用驱动级键盘控制。

## 功能

- F8/F9 热键
- 自动回车提交
- 支持所有输入框（游戏、IE 密码控件等）

## 系统要求

- windows（x86/x64），测试环境为：windows7 64 位 专业版
- 使用 visual studio 2015 编译

## 安装步骤

- 下载[interception](https://github.com/oblitum/interception/releases/latest)
- 解压后，打开“command line installer”文件夹，通过 cmd 运行 install-interception
- 运行时，要求 interception.dll 位于应用相同文件夹
- 正确使用 interception 的 x64、x86 版本

```
install-interception /install
```

- 重启

## 编译步骤

- 复制 interception 的“library/XXX/interception.dll”链接库到应用执行的同一目录，XXX：为对应平台（x64/x86），请按系统版本进行选择。
- 使用 visual studio 进行编译

## 问题

- 快捷使用标准注册方式实现，未使用 SetWindowsHookEx 方法，有些软件会失效（如：农业银行 K 宝在电脑启动时即使用 SetWindowsHookEx，工作时直接忽略其它应用的 Hook）
- 已知问题：interception 工作时需要提前人工触发一下实体键盘才会正确发送键盘消息，只需要触发一次

## Licence

MIT licence, 请同时遵守 Interception 的 License
