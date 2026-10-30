#  元智鳥鳥圖鑑｜ASP.NET Core MVC 專案

##  專案簡介

「元智鳥鳥圖鑑」是一個以 ASP.NET Core MVC 架構開發的網頁應用程式，透過網站呈現鳥類資訊，提供使用者瀏覽及管理鳥類資料的功能。

本專案整合前端網頁設計、後端程式邏輯與資料庫操作，實作 MVC 架構的應用，藉此熟悉網站開發流程及資料庫整合方式。

##  使用技術

| 類別 | 技術 |
|---|---|
| 後端 | C#、ASP.NET Core MVC |
| 前端 | HTML、CSS、JavaScript、Razor |
| UI 框架 | Bootstrap |
| 資料庫 | Microsoft SQL Server |
| ORM | Entity Framework Core |
| 開發工具 | Visual Studio |

##  主要功能

### 1. 鳥類資料瀏覽
- 顯示鳥類相關資訊。
- 呈現鳥類名稱、英文名稱、分類、介紹及圖片。
- 提供鳥類詳細資料頁面。

### 2. 鳥類資料管理
- 新增鳥類資料。
- 查看鳥類詳細資訊。
- 編輯既有鳥類資料。
- 刪除鳥類資料。

### 3. 鳥類資訊呈現
- 使用圖片與文字呈現鳥類資訊。
- 透過網頁介面整理及展示鳥類資料。
- 提供鳥類相關圖表頁面。

### 4. 使用者登入
- 提供登入及登出功能。
- 使用 Session 管理登入狀態。

##  專案架構

```text
project/
├── Controllers/       # 控制器：處理網站請求與功能邏輯
├── Data/              # 資料庫 Context
├── Migrations/        # Entity Framework 資料庫遷移
├── Models/            # 資料模型
├── ViewModel/         # 畫面資料模型
├── Views/             # Razor 網頁畫面
├── wwwroot/           # CSS、JavaScript、圖片及前端套件
├── Properties/        # 專案啟動設定
├── appsettings.json   # 應用程式設定
├── Program.cs         # 應用程式進入點
└── project.csproj     # 專案套件與建置設定
```

##  資料庫設計

本專案使用 Microsoft SQL Server 儲存鳥類資料，並透過 Entity Framework Core 操作資料庫。

主要資料表：`TableBirds1131603`

| 欄位 | 說明 |
|---|---|
| BirdID | 鳥類編號 |
| BirdName | 鳥類中文名稱 |
| EnglishName | 鳥類英文名稱 |
| Category | 鳥類分類 |
| Description | 鳥類介紹 |
| ImagePath | 鳥類圖片路徑 |
| FoundLocation | 發現地點 |

##  執行方式

1. 安裝 Visual Studio 與 .NET SDK。
2. 下載或 Clone 本專案。
3. 使用 Visual Studio 開啟 `project.csproj`。
4. 安裝專案所需的 NuGet 套件。
5. 準備可使用的 SQL Server 資料庫。
6. 使用本機安全設定提供資料庫連線字串 `ConnectionStrings:CmsContext`。
7. 確認資料庫及 Migration 設定後，執行專案。

**注意：** 本專案不提供資料庫帳號及密碼。請自行設定本機資料庫連線資訊，不要將真實密碼提交至 GitHub。

##  專案學習收穫

透過本專案，我學習並實作：

- ASP.NET Core MVC 架構及 Model、View、Controller 的分工。
- C# 後端程式設計與網站功能開發。
- Entity Framework Core 與 SQL Server 資料庫整合。
- CRUD（新增、查詢、修改、刪除）資料管理功能。
- Razor View、HTML、CSS 與 JavaScript 前端頁面設計。
- 使用 GitHub 進行程式碼版本管理與作品集整理。

##  專案展示

操作展示影片：**(https://1drv.ms/v/c/1399f5e413a18f44/IQALrv4Wc0wqTplbNDYaERicAXk0Mj7BJd6IMLghlFnrbUE?e=MPwVov)**



---

*本專案為大學課程學習與實作作品，主要用於展示 ASP.NET Core MVC 網站開發及資料庫整合能力。*
