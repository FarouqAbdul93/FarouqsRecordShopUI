# Farouq's Record Shop UI

A Blazor Web App frontend for the Record Shop inventory system. Built with .NET 8 and Blazor as part of the Northcoders Enterprise Engineering Bootcamp (C# / .NET).

---

## Overview

This frontend connects to the [Record Shop API](https://github.com/FarouqAbdul93/FarouqsRecordShop) and provides a fully interactive UI for browsing, searching, adding, editing, and deleting album records. It was built using Blazor's component model with Auto interactivity mode, covering real-world patterns like HttpClient integration, EditForm validation, cascading parameters, and custom routing.

---

## Tech Stack

- **Blazor Web App (.NET 8)** — Auto interactivity mode
- **Bootstrap** — Styling and layout
- **HttpClient** — Communicates with the backend REST API
- **Blazor EditForm** — Form handling with data annotations validation

---

## Getting Started

### Prerequisites

- Visual Studio 2022
- .NET 8 SDK
- The [Record Shop API](https://github.com/FarouqAbdul93/FarouqsRecordShop) running locally

### Setup

1. Clone the repository:
   ```
   git clone https://github.com/FarouqAbdul93/FarouqsRecordShopUI.git
   ```

2. Make sure the backend API is running first at `https://localhost:7090`.

3. Open the solution in Visual Studio 2022.

4. Run the application. The frontend will be available at `https://localhost:7252`.

---

## Features

- **Homepage** — Welcome page with a randomly featured album on each load
- **All Records** — Browse the full album inventory
- **Record Detail** — View and edit a single album's details
- **Add Record** — Add a new album with full form validation
- **Delete Record** — Delete an album with confirmation step
- **Search** — Search albums by ID, title, or artist name
- **About Page** — Shop history page
- **Custom 404 Page** — Friendly error page for unknown routes

---

## Project Structure

```
FarouqsRecordShopUI/
├── Components/
│   ├── Layout/             # MainLayout, NavMenu, Header, Footer
│   ├── Pages/              # AllRecordsPage, RecordPage, AddRecordPage, SearchPage, Home, About
│   └── Shared/             # RecordsLoader, RecordLoader, RecordSummaryList, RecordSummary,
│                           # RecordDetails, RecordCard, FeaturedRecord, AddRecordForm,
│                           # SearchById, SearchByTitle, SearchByArtist, StatusCode
└── Models/
    └── Album.cs            # Album and NewAlbum models
```

---

## Backend

This frontend requires the Record Shop API to be running locally.

Repo: [FarouqsRecordShop](https://github.com/FarouqAbdul93/FarouqsRecordShop)

---

## Author

**Farouq Abdullah**
- GitHub: [FarouqAbdul93](https://github.com/FarouqAbdul93)
- LinkedIn: [farouq-hassan-abdullah](https://linkedin.com/in/farouq-hassan-abdullah)