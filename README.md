# PinyinNet
[![Build status](https://ci.appveyor.com/api/projects/status/qsc7d2uwxopdx2d8?svg=true)](https://ci.appveyor.com/project/nepton/securitypassword)
[![CodeQL](https://github.com/nepton/PinyinNet/actions/workflows/codeql.yml/badge.svg)](https://github.com/nepton/PinyinNet/actions/workflows/codeql.yml)
![GitHub issues](https://img.shields.io/github/issues/nepton/PinyinNet.svg)
[![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/nepton/PinyinNet/blob/master/LICENSE)

PinyinNet is a .NET library for converting Chinese characters to pinyin.

## Nuget packages

| Name      | Version                                                                                             | Downloads                                                                                            |
|-----------|-----------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------|
| PinyinNet | [![nuget](https://img.shields.io/nuget/v/PinyinNet.svg)](https://www.nuget.org/packages/PinyinNet/) | [![stats](https://img.shields.io/nuget/dt/PinyinNet.svg)](https://www.nuget.org/packages/PinyinNet/) |

## How to use
Add nuget reference
```
PM> Install-Package PinyinNet
```

PinyinConvert is a static class that contains the following methods:

```C#
// You will get "huan|ying|shi|yong|pin|yin|zhuan|huan|gong|ju";
var pinyin = PinyinConvert.GetPinyin("欢迎使用拼音转换工具");

// You will get "hysypyzhgj"
var firstLetters = PinyinConvert.GetPinyinFirstLetter("欢迎使用拼音转换工具");
```

## Final
Leave a comment on GitHub if you have any questions or suggestions.

Turn on the star if you like this project.

## License
This project is licensed under the MIT License
