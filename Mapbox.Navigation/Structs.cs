﻿using System;

namespace Mapbox.Navigation
{
public enum ManeuversStyleKitResizingBehavior : long
{
    AspectFit = 0,
    AspectFill = 1,
    Stretch = 2,
    Center = 3
}

public enum MBStyleType : long
{
    DayStyle = 0,
    NightStyle = 1
}

public enum MBFeedbackSource : long
{
    User = 0,
    Reroute = 1,
    Unknown = 2
}

public enum MBFeedbackType : long
{
    General = 0,
    Accident = 1,
    Hazard = 2,
    RoadClosed = 3,
    NotAllowed = 4,
    MissingRoad = 5,
    MissingExit = 6,
    RoutingError = 7,
    ConfusingInstruction = 8,
    ReportTraffic = 9
}
}
