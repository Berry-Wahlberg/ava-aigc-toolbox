# 翻译脚本 - 用于自动化文档翻译
# 使用说明：
# 1. 确保已安装必要的翻译API库
# 2. 设置API密钥
# 3. 运行脚本：.	ranslate-docs.ps1

# 配置
$sourceLang = "en"
$targetLangs = @("fr", "es", "it", "pt", "ru", "ko", "zh-tw", "zh-cn")
$sourceDir = "docs/localization/en-us"

# 翻译函数（这里使用占位符，实际使用时需要替换为真实的翻译API调用）
function Translate-Text {
    param (
        [string]$text,
        [string]$fromLang,
        [string]$toLang
    )
    
    # 这里是翻译逻辑，实际使用时需要替换为真实的翻译API
    # 例如使用DeepL、Google Translate等API
    
    # 占位符：直接返回原文（实际使用时替换为真实翻译）
    return $text
}

# 递归遍历目录函数
function Translate-Directory {
    param (
        [string]$sourcePath,
        [string]$targetPath,
        [string]$targetLang
    )
    
    # 确保目标目录存在
    if (-not (Test-Path $targetPath)) {
        New-Item -ItemType Directory -Path $targetPath -Force | Out-Null
    }
    
    # 遍历源目录中的所有文件
    $files = Get-ChildItem -Path $sourcePath -File
    foreach ($file in $files) {
        if ($file.Extension -eq ".md") {
            Write-Host "正在翻译文件: $($file.FullName) -> $targetPath\$($file.Name)"
            
            # 读取源文件内容
            $content = Get-Content -Path $file.FullName -Raw
            
            # 替换翻译注释
            switch ($targetLang) {
                "zh-cn" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*以英文版本为准\*\*"
                }
                "zh-tw" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*以英文版本為準\*\*"
                }
                "de" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*Die englische Version ist maßgeblich\*\*"
                }
                "fr" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*La version anglaise est autorisée\*\*"
                }
                "es" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*La versión en inglés es la autoritativa\*\*"
                }
                "it" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*La versione inglese è quella ufficiale\*\*"
                }
                "pt" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*A versão em inglês é a autoritativa\*\*"
                }
                "ru" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*Английская версия является авторитетной\*\*"
                }
                "ko" {
                    $content = $content -replace "\> \*\*English version is authoritative\*\*", "\> \*\*영어 버전이 권위 있습니다\*\*"
                }
            }
            
            # 写入目标文件
            $content | Set-Content -Path "$targetPath\$($file.Name)" -Encoding UTF8
        }
    }
    
    # 递归处理子目录
    $dirs = Get-ChildItem -Path $sourcePath -Directory
    foreach ($dir in $dirs) {
        Translate-Directory -sourcePath "$sourcePath\$($dir.Name)" -targetPath "$targetPath\$($dir.Name)" -targetLang $targetLang
    }
}

# 主脚本
Write-Host "开始文档翻译..."

foreach ($lang in $targetLangs) {
    Write-Host "\n=== 翻译到 $lang ==="
    $targetDir = "docs/localization/$lang"
    Translate-Directory -sourcePath $sourceDir -targetPath $targetDir -targetLang $lang
}

Write-Host "\n翻译完成!"
