# FS.FullCalendar

## [FullCalendar (React)](https://fullcalendar.io/demos) made for F# in the style of Feliz

[![NuGet version (FS.FullCalendar)](https://img.shields.io/nuget/v/FS.FullCalendar.svg?style=flat-square)](https://www.nuget.org/packages/FS.FullCalendar/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/FS.FullCalendar.svg)](https://www.nuget.org/packages/FS.FullCalendar/)

### Please check [all FullCalendar docs](https://fullcalendar.io/docs#toc) for further component usage and properties

![2025-03-1410-32-04-ezgif com-video-to-gif-converter](https://github.com/user-attachments/assets/20289af4-fecc-40eb-9bc7-2b546dcab413)

(code for this gif [here](https://github.com/sydsutton/FS.FluentUI/wiki/FullCalendar-Calendar--Draggable))

### Simple example of a Calendar implementation:

```fsharp
open Feliz
open System
open FS.FullCalendar

FullCalendar.Calendar [
    calendar.plugins [
        Plugin.dayGridPlugin
        Plugin.timeGridPlugin
        Plugin.interactionPlugin
    ]
    calendar.initialView.dayGridMonth
    calendar.nowIndicator true
    calendar.validRange [ range.start (DateTime.Today.AddDays -7); range.end' (DateTime.Today.AddDays 7)]
    calendar.headerToolbar [
        headerToolbar.start "today prev,next"
        headerToolbar.center "title"
        headerToolbar.end' "myCustomButton, dayGridMonth,timeGridWeek,timeGridDay,list"
    ]
    calendar.dayHeaderFormat [
        dateFormat.weekday.short
    ]
    calendar.customButtons [
        "myCustomButton",
        [
            customButton.text "Add event"
            customButton.click (fun _ _ -> printf "Joke's on you, I don't do anything")
        ]
    ]
    calendar.events "https://fullcalendar.io/api/demo-feeds/events.json?start=2/23/2025&end=4/5/2025"
]
```

## Installation

Current NPM dependencies:
#### Primary dependency:
* @fullcalendar/react

#### Secondary dependencies, depending on what plugins you want to use:
* @fullcalendar/daygrid
* @fullcalendar/interaction
* @fullcalendar/timegrid
* @fullcalendar/bootstrap5
* @fullcalendar/bootstrap
* @fullcalendar/multimonth
* @fullcalendar/list
* @fullcalendar/moment

Install into your Client.fsproj project using [Femto](https://github.com/Zaid-Ajaj/Femto) (recommended)
```bash
cd ./{path to Client}

# when using femto as a global CLI tool
femto install FS.FullCalendar

# when using femto as a local CLI tool
dotnet femto install FS.FullCalendar
```
This will install the nuget package and afterwards automatically installs the required npm packages used by this binding.

> Femto will detect whether you are using paket and will install the package using paket into the dependency group of the project

You can install the library manually if you want by first installing the nuget package
```bash
cd ./{path to your project}
dotnet add package FS.FullCalendar
npm install @fullcalendar/react @fullcalendar/daygrid @fullcalendar/interaction @fullcalendar/timegrid @fullcalendar/bootstrap5 @fullcalendar/bootstrap @fullcalendar/multimonth @fullcalendar/list @fullcalendar/moment
```
