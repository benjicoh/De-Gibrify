|  |
| --- |
|  |
| User Guide |
|  |

|  |
| --- |
| UG-5400-7981 (P01) |
| October 2024 |
| Please read this document carefully before using this module with the CARTO™ 3 System. |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © 2013 - 2024 by Biosense Webster, Inc. All rights reserved.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  *Federal (USA) law restricts this device to sale by or on the order of a physician.* |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Any serious incident that has occurred due to, or during, the use of the product described herein should be reported to Biosense Webster. In Europe a report should also be made to the competent authority of the Member State in which the user and/or patient is established. |

Third-party trademarks used herein are trademarks of their respective owners.

For Biosense Webster patent information, see:

<http://www.biosensewebster.com/virtualpatentmarking>

See the documentation CD accompanying the CARTO™ 3 System for information on third party software notices applicable to this product.

P.N.: ()

29 October 2024

Table of Contents

[CARTO VISITAG™ Module Overview 1](#_Toc181102892)

[VISITAG™ Sites 1](#_Toc181102893)

[Grid Cells 2](#_Toc181102894)

[CARTO VISITAG™ Module Installation 3](#_Toc181102895)

[Safety Information 4](#_Toc181102896)

[CARTO VISITAG™ Module Preferences 5](#_Toc181102897)

[Creating Presets for VISITAG™ Preferences 7](#_Toc181102898)

[Using Global or Multiple Presets 7](#_Toc181102899)

[Minimum Time Filter for Grid Cells 8](#_Toc181102900)

[CARTO VISITAG™ Module Display 9](#_Toc181102901)

[VISITAG™ Toolbar 9](#_Toc181102902)

[Stability and Filter Indications 11](#_Toc181102903)

[VISITAG™ Indication in the Graphs Viewer 12](#_Toc181102904)

[RF Sessions List 13](#_Toc181102905)

[Displaying Cumulative Data 13](#_Toc181102906)

[VISITAG™ Sites and Projections 14](#_Toc181102907)

[Distance Measurement Tool 15](#_Toc181102908)

[Automatic Distance Tool 16](#_Toc181102909)

[CARTO VISITAG™ Module Usage Examples 18](#_Toc181102910)

[Stability+ 19](#_Toc181102911)

[Stability Indication with Stability+ 19](#_Toc181102912)

[White Site Tags 20](#_Toc181102913)

[Site Tag Coloring 21](#_Toc181102914)

[Comparison Between the VISITAG Stability Algorithms 21](#_Toc181102915)

[QMODE+™ Functionality in the CARTO™ 3 System 23](#_Toc181102916)

[Catheter Stability Status 23](#_Toc181102917)

[QMODE+ Sites with Stability+ 23](#_Toc181102918)

[QMODE+™ Sites with the Gated Stability Algorithm 23](#_Toc181102919)

[Graphs Viewer in QMODE+™Ablation Sessions 26](#_Toc181102920)

[Viewing Ablation Session Data 26](#_Toc181102921)

[QMODE+™ Point Tags 26](#_Toc181102922)

# CARTO VISITAG™ Module Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_featureOverview\_v8p3\_EN.xml

The CARTO VISITAG™ Module includes the following features:

* CARTO VISITAG™ Module
* The Stability+ Algorithm
* QMODE+™ Functionality in the CARTO™ 3 System

The CARTO VISITAG™ Module provides the ability to continuously store, track, and quantify ablation catheter positions along with the electrophysiological parameters acquired during RF applications, according to user preferences.[[1]](#footnote-1) Visual Indication can be presented as either VISITAG™ Sites or Grid Cells. Both types of visual indication can be projected onto a map reconstruction. These visual indications do not interfere with the standard manner of acquiring points or applying ABL tags during application of RF energy.

|  |  |
| --- | --- |
| ![DxNoteWarning.png](data:image/png;base64...) | **WARNING**  The CARTO VISITAG™ Module provides access to data collected during the application of RF energy. The data provided by the CARTO VISITAG™ module does not indicate the effectiveness of RF energy application.  REP4611 D-V4-1.22.2, D-V4-1.22.5  During an RF session, monitor data such as catheter location, Graphs Viewer, and Readings Dashboard.  The Cumulative Data Popup window provides access to data collected during the application of RF energy when the VISITAG™ Site or Grid Cell met all the criteria set in the Preferences dialog. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Some pictures might differ from the ones appearing in your system. However, functionality is the same. |

## VISITAG™ Sites

https://bwiildita.sharepoint.com/sites/prod/Topics/VisiTag\_tagOverview\_V8\_EN.xml

Ablation catheter positions that meet the user-defined thresholds for filters such as Location Stability and Force Over Time data[[2]](#footnote-2) are grouped into areas according to their spatial stability.

A VISITAG™ Site (also called VISITAG™ Location) represents a single ablation site, accumulating consecutive catheter positions recorded during application of RF energy when the ablation catheter has met all filter parameters. Catheter movement to a new location (or a location that was visited in a previous session) creates a new VISITAG™ Site. These sites appear as an element similar to ABL Tags.

After the creation of a VISITAG™ Site, if the condition of any of the filter criteria is no longer met, the site breaks and the system starts tracking the conditions for creation of a new VISITAG™ Site.

![VisiTag_site_tags.png](data:image/png;base64...)

Figure 1: Sample Map with VISITAG™ Sites

There are two VISITAG™ stability algorithms available to adjust for movement due to respiration.

* With the standard Gated (ACCURESP™) algorithm, catheter positions are adjusted and brought to the end expiration phase location during the creation of the VISITAG™ Site tag. The final location of the VISITAG™ Site tag will be the average of all catheter locations collected and brought to end expiration.
* The Stability+ algorithm provides a continuous analysis of catheter movement. This can be used instead of the Gated (ACCURESP™) algorithm, which depends on ACCURESP™ Respiration Gating Training. For more information about Stability+ see ["Stability+"](#target9000001).

QMODE+™ Functionality provides a unique type of VISITAG™ Site, which indicates very high power, short duration ablation sessions. These sessions create a distinct QMODE+™ Site which indicates the ablation location. QMODE+™ Sites appear differently depending on which stability algorithm is used. For more information regarding QMODE+™ Sites functionality with each of the algorithms, see ["Catheter Stability Status "](#target9000002).

## Grid Cells

https://bwiildita.sharepoint.com/sites/prod/Topics/VisiTag\_gridCells\_v8\_EN.xml

A Grid Cell represents an accumulation of positions recorded during all the ablation sessions that took place within a 1 mm cube. The Grid Cells appear as small spheres. If Minimum Time is not defined in the current preset, Grid Cells appear after 1 second. Otherwise, they appear when they have met the defined stability time (see ["CARTO VISITAG™ Module Preferences"](#target9000003)). Grid cells do not include data from QMODE+™ ablation sessions.

![VisiTag_grid_cells.png](data:image/png;base64...)

Figure 2: Sample Map with Grid Cells

## CARTO VISITAG™ Module Installation

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_installation\_v4-3\_EN.xml

For certain focal ablation RF generators, a communication link option is available to enable display of RF parameters in the CARTO™ 3 System. For these generators, a Global Port is required. If you do not have this option, contact the Biosense Webster Service and Support Department.

Consult your Biosense Webster representative regarding the availability of compatible devices in your country.

# Safety Information

https://bwiildita.sharepoint.com/sites/prod/Topics/Safety\_visiTag\_v8\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO™ 3 System also apply while using this module. In addition, the following considerations apply:

REP4611 A-V2-11.2.1.4

* The data provided by the CARTO VISITAG™ module does not indicate the effectiveness of RF energy application.

**Gated (ACCURESP™) Stability Algorithm**

1.7.2.2

* When the Respiration Adjustment mode is active, and the Gated (ACCURESP™) VISITAG™ Stability algorithm is selected, positions are accumulated at the end-expiration phase. This leads to a delay in display of all CARTO VISITAG™ Module information. Take this delay into account when treating areas where immediate feedback is important.

**Stability+ Stability Algorithm**

REP14517 D-5, D-5.1

* If the catheter is not stable before ablation begins, Stability+ takes up to 5 seconds to optimize and display CARTO VISITAG™ Module information. If the catheter is stable before ablation begins, Stability+ takes up to 2 seconds to optimize and display CARTO VISITAG™ Module information after an ablation begins.

It takes up to 5 seconds for Stability+ to finalize CARTO VISITAG™ Module information after ablation ends.

REP14517 A-10

* If Stability+ cannot receive required data (for example, due to metal interference or a detached back patch) the algorithm becomes unavailable. If this occurs, a progress indication icon appears in the Readings Dashboard for both stability and Tag Index. In addition, an alert appears. Once the issue is resolved, the algorithm performs a reset, which takes about 20 seconds. During this reset, VISITAG™ Sites might not be created, or they might not contain all of the ablation data. Tag Index values might not be accurate. The alert disappears when the algorithm is available again.

REP14517 A-9

* In rare situations, Stability+ updates its decision about the stability, duration, or location of two sites. If this occurs, the sites are joined retroactively. In this case, the Tag Index and other parameters related to site duration will be updated. This may lead to a coloring update.

AMT, REP14517 D-6, D-6.1

* In very rare situations, Stability+ may not detect the stability. As a result, a VISITAG™ Site will not appear. For example, this might occur if a patch becomes disconnected or if the catheter is out of the mapping zone. During an RF session, monitor data such as catheter location, Graphs Viewer, and Readings Dashboard. Ablation termination decisions should not be based on whether a VISITAG™ site appears.

REP14517 A-5

* In very rare situations, the Stability+ may falsely split the VISITAG™ Site in a manner which does not reflect the catheter stability during ablation. As a result, two VISITAG™ Sites will appear instead of one. Ablation related decisions should be based on clinical judgement.

# CARTO VISITAG™ Module Preferences

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG\_preferences\_v8p3\_EN.xml

Several user-defined preferences can be applied when the CARTO VISITAG™ Module is active. These settings are accessed through the VISITAG tab of the Preferences dialog box (Tools> Preferences).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  During a Study: Settings that require force data are only available if a supported force catheter is used and a compatible module is installed.  In Review Mode: Settings that require force data are available if a compatible module is installed. |

The image and table below describe VISITAG Preferences when using the Stability+ algorithm. When Gated is selected, the Preferences dialog box is slightly different.

![preferences_visitag_stability_no_index.jpg](data:image/jpeg;base64...)

Figure 3: VISITAG Preferences when the Stability+ Algorithm is Selected

|  |  |
| --- | --- |
| VISITAG™ Stability Algorithm selected | REP14517 A-7, A-8  This statement indicates which VISITAG Stability Algorithm is currently selected.  The default setting is Stability+. To use the Gated stability algorithm instead, click Tools > VISITAG™ Stability Algorithm selected > Gated (ACCURESP™). |
| Presets | Presets provide a way to save multiple filter configurations with meaningful names. Presets are defined in the Preferences dialog box, and selected in the VISITAG Toolbar.  The preset cannot be changed during application of RF energy. |
| Respiration Adjustment | To increase accuracy, catheter positions can be adjusted to minimize the respiration effect. Click to use respiration adjustment.  When the Stability+ Algorithm is active, this option is selected by default.  With the standard Gated stability algorithm, catheter positions are adjusted and brought to the end expiration phase location during the creation of the VISITAG™ Site tag. The final location of the VISITAG™ Site tag will be the average of all catheter locations collected and brought to end expiration. This option is disabled if Respiration Gating Training has not been performed.  VISITAG™ Sites that were created before Respiration Gating Training do not have the required data for adjusting their positions to end expiration. Therefore, these sites will not be displayed once this option is selected. To see these VISITAG™ Sites uncheck Respiration Adjustment.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  For scenarios of long apnea, hyper ventilation, and jet ventilation, the performance of the Stability+ Algorithm provides optimal performance with no additional adjustment for respiration required. Uncheck the Respiration Adjustment preference option. | |
| Location Stability | User-defined thresholds for distance change and time define an area in which a catheter is considered to be stable. This filter is available at any time during the study.  The catheter is stable if consecutive positions remain within the threshold for distance from the location mean (Maximum Distance Change), in either direction, for longer than the user-defined time threshold (Minimum Time). Only if these 2 conditions are met will a VISITAG™ Site tag be created. If these conditions are not maintained, the VISITAG™ Site will break.  If the maximum distance change filter is set when using the Gated stability algorithm, and then the stability algorithm is changed to Stability+, the Maximum Distance Change filter is automatically set by the system to 3mm. If the stability algorithm is then changed back to Gated, the Maximum Distance Change is changed back by the system to the original user defined preference. |
| Force Over Time | A VISITAG™ Site is created only if a user-defined minimum force (Minimum Force) was applied at the site over a user-defined minimum percentage of time. If this condition is not met, no VISITAG™ Site will be created. If this condition is not maintained, the VISITAG™ Site will break.  This filter can be used in combination with the Location Stability filter. |
| Show Site Break Indication | This option is only available if you are using Stability+.  If this option is enabled, when a site is broken a white halo appears, indicating the site was broken during ablation. The halo displays for 3 seconds during ablation or when ablation has ended.  A-6  The Stability+ algorithm has a higher instability detection rate than the Gated algorithm, resulting in earlier and more frequent site breakages. |

1.7.5.1.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Filters are applied only after: the filter is selected, the thresholds are set, the preset is saved, and the preset is selected in the VISITAG™ Toolbar. |

1.7.2.2

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When the Respiration Adjustment mode is active, and the Gated (ACCURESP™) VISITAG™ Stability algorithm is selected, positions are accumulated at the end-expiration phase. This leads to a delay in display of all CARTO VISITAG™ Module information. Take this delay into account when treating areas where immediate feedback is important.  Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.). Failure to do so might result in incorrect placement of the catheter. |

## Creating Presets for VISITAG™ Preferences

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_presets\_6p5\_EN.xml

You can save a specific configuration of filters as a preset.

|  |  |
| --- | --- |
| 1. | Click Tools > Preferences.  The Preferences dialog box appears. |
| 2. | Click the VISITAG tab. |
| 3. | Open the Presets list. |
| 4. | Click New. |
| 5. | Enter the name and desired configuration. |
| 6. | Click Save to save the preset and create another preset, or click OK to save the preset and close the dialog box. |

![visitag_presets_4-3.png](data:image/png;base64...)

Figure 4: VISITAG Presets

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  To delete a preset, click ![delete_icon.png](data:image/png;base64...).  The currently selected preset cannot be deleted. |

## Using Global or Multiple Presets

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_presets\_apply\_4.3\_EN.xml

A single preset can be applied globally to all RF sessions, or you can use different presets for each RF application session throughout the study.

To select the way presets are applied, right-click the Presets button on the VISITAG™ Toolbar.

Table 1: Description of VISITAG™ Preset Options

| Option | Description |
| --- | --- |
| Global Preset | * The current preset is used for the entire study. * If you change the preset, all previous sessions are updated accordingly. * If the current preset is edited, the changes are applied to all VISITAG™ data. |
| Multiple Presets | * The current preset is used for the next RF session. * If you change the preset, it will be applied to future sessions. Previous sessions are not affected. * If a preset is edited, the changes are applied to all ablation sessions that use the preset. * When selected, the Preset button on the VISITAG™ Toolbar has an orange border. |

## Minimum Time Filter for Grid Cells

https://bwiildita.sharepoint.com/sites/prod/Topics/visitag\_GridCellTimeFilter\_EN.xml

When Grid Cell Coloring is set to Total Time, Grid Cells can be filtered according to a user-defined minimum time threshold. Grid Cells with accumulated time below the threshold are not displayed.

To set the time threshold, click and move the Color Scale Bar slider to the desired threshold value.

![visitag_GridCellTimeFilter.png](data:image/png;base64...)

Figure 5: Grid Cells with Minimum Time Filter

# CARTO VISITAG™ Module Display

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_displayOptions\_6p5\_EN.xml

## VISITAG™ Toolbar

https://bwiildita.sharepoint.com/sites/prod/Topics/VisiTag\_toolbar\_ref\_v8\_EN.xml

The VISITAG™ Toolbar is used for setting the display options for the VISITAG™ Sites and Grid Cells. Display options include the following:

* Configuration presets
* Coloring according to available parameters
* Projection on map reconstructions
* Size (VISITAG™ Sites only)
* Displaying excluded Grid Cells (Grid Cells only) . Applicable only when using the Gated stability algorithm.
* Distance measurement
* Map source selection

When the option is active, the icon is orange.

Table 2: VISITAG™ Toolbar

| Icon | Tool Tip | Description |
| --- | --- | --- |
| ![VISITAGtoolbar_stbAlgorithm.png](data:image/png;base64...) | Stability+ or Gated | This shows the active VISITAG™ Stability algorithm. |
| ![visiTagToolbar_presets.png](data:image/png;base64...) | N/A | Select and apply filter configuration (defined in the Preferences dialog box)  Right-click to select global or multiple presets.  If no preset is defined, N/A is displayed. |
| ![visiTagToolbar_blue_Locationsize_enabled.png](data:image/png;base64...) | Site Tags On/Off | Click to turn Site Tag on or off.  On by default. |
| ![visiTagToolbar_Locationsize_options.png](data:image/png;base64...) | Choose Site Tag Size | Click the arrow to set the radius for the displayed Site Tag (mm).  This setting affects display size only. It does not indicate lesion size. |
| ![visiTagToolbar_blue_locationColor_enabled.png](data:image/png;base64...) | Site Tag Coloring On/Off | Click to turn Site Tag coloring on or off.  On by default. |
| ![visiTagToolbar_locationColor_options.png](data:image/png;base64...) | Choose Site Tag Coloring | Click the arrow to choose the Site Tag coloring.   |  |  | | --- | --- | | ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**  The Impedance Drop and FTI coloring options are recommended for retrospective use only. | |
| ![VisiTag_ToolBar_SiteTag_v7andEarlier.png](data:image/png;base64...) | Site Tag Projection On/Off | Click to turn Site Tag projection on or off. |
| ![VisiTag_ToolBar_WhiteTags.png](data:image/png;base64...) | White Site Tags On/Off | The option is selectable for the Stability+ Algorithm only.  If this option is active white tags continue to appear after the end of the ablation session.  If this option is not selected, white tags disappear up to 5 seconds after the end of the ablation session. |
| ![VISITAGtoolbar_grid.png](data:image/png;base64...) | Grid On/Off | Click to turn Grid Cell display on or off.  Click the arrow to display additional options:  Grid Projection On/Off  Grid Coloring On/Off - This option is on by default.  Excluded Grid On/Off- When this option is enabled, grid cells are displayed for all catheter ablation locations, even if the catheter was not in the location for the minimum time. |
| ![VisiTag_ToolBar_AutoDistTool.png](data:image/png;base64...) | Automatic Distance Tool | Click to activate automatic measurement between sites, and then select the threshold distance (in millimeters).  By default, this option is not selected.  For details, see ["Automatic Distance Tool"](#target9000004), |
| ![visiTagToolbar_blue_distance.png](data:image/png;base64...) | Distance Tool | Click to activate the Distance Tool according to the current method. |
| ![visiTagToolbar_blue_distance_select.png](data:image/png;base64...) | Choose Distance Tool Method | Click the arrow to select the method: either Standard or Catheter |
| ![visiTag_sourceSelection.png](data:image/png;base64...) | Map names | Select the map source. Can be one specific map, all maps, or the maps that are currently in view. |

Click ![visiTagToolbar_blue_expand.png](data:image/png;base64...) to collapse or expand the toolbar.

Right-click ![visiTagToolbar_blue_expand.png](data:image/png;base64...) to open the Preferences dialog box.

## Stability and Filter Indications

https://bwiildita.sharepoint.com/sites/prod/Topics/VisiTag\_FilterIndication\_v8\_EN.xml

1.7.5.2 V3

REP4611 A-V3-1.7.5.3

The CARTO VISITAG™ Module stability and filter indications appear on the Readings Dashboard.

Table 3: Catheter Stability Status Before and After Application of RF Energy

| Icon | Status |
| --- | --- |
| ![visiTag_statusIcon_notStable_6-3.png](data:image/png;base64...) | Not stable |
| ![visiTag_statusIcon_catheterStable_6-3.png](data:image/png;base64...) | Stable |
| ![visiTag_statusIcon_catheterStable_force_6-3.png](data:image/png;base64...) | The catheter is stable, but has not passed the force threshold. |
| ![visiTag_statusIcon_NA_6-3.png](data:image/png;base64...) | Not available  Range is not set or catheter positions are not available |

During application of RF energy, the stability icon also indicates the status of additional filters. Initially, the icon indicates the stability of the catheter. After stability is achieved, the icon displays the other active filters which have not yet passed their minimal thresholds (only if other filters were selected in the VISITAG™ Preferences). Elapsed time while stable in a given area is also displayed.

Table 4: Catheter Stability Status during Application of RF Energy

| Icon | Status |
| --- | --- |
| ![visiTag_statusIcon_notStable_ABL_6-3.png](data:image/png;base64...) | Not stable |
| ![visiTag_statusIcon_catheterStable_ABL_6-3.png](data:image/png;base64...) | The catheter is stable, but has not passed the time threshold. |
| ![visiTag_statusIcon_catheterStable_force_ABL_6-3.png](data:image/png;base64...) | The catheter is stable, but has not passed the time and force thresholds.  When using a force catheter[[3]](#footnote-3), force is included in the stability indication. |
| ![visiTag_statusIcon_filters_6-3.png](data:image/png;base64...) | Catheter is stable and a site was created.  After a filter passes its minimal threshold, a visual indication is displayed on the map, so its status is no longer indicated in the status icon.  When using the Stability+ Algorithm, this status also appears for white tags. |
| ![PFA_8-1-100_Valid_Index_Data_Not_Available1.png](data:image/png;base64...) | Stability+ is temporarily unavailable. Catheter stability cannot be displayed. |

## VISITAG™ Indication in the Graphs Viewer

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_graphsViewer\_7p3\_EN.xml

When a VISITAG™ Site is selected in a map viewer, an indication appears on the Graphs Viewer representing the start and end of the respective stable site.

![VisiTag_ablation_graph_6-5.png](data:image/png;base64...)

Figure 6: Display of VISITAG™ Site Range in Graphs Viewer

## RF Sessions List

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_sessions\_6p5\_EN.xml

The RF Sessions List of the Graphs Viewer displays the preset that was applied during each session.

* If the Global Preset option is active, the preset cannot be modified from the RF Sessions List.
* If the Multiple Presets option is active, you can manually modify the preset for a specific session.

![visitag_presets_RFsessions_v8p3.jpg](data:image/jpeg;base64...)

Figure 7: RF Sessions List

To select the VISITAG™ sites that are associated with a session, right-click the session and click Select VISITAG™ Locations

![visitag_RFsessions_menu.png](data:image/png;base64...)

Figure 8: RF Sessions List Menu

## Displaying Cumulative Data

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_cummulativeData\_7p3\_EN.xml

Additional data that is acquired during ablation, such as impedance and temperature, can be displayed for each Grid Cell or VISITAG™ Site. The data is displayed in the Cumulative Data Popup window when you double-click a Grid Cell or VISITAG™ Site to select it in one of the map viewers.[[4]](#footnote-4)

If you click a different VISITAG™ Site, the data is updated. The window remains open until you click the x in the upper right corner.

The Cumulative Data Popup window provides access to data collected during the application of RF energy when the VISITAG™ Site or Grid Cell met all the criteria set in the Preferences dialog.

Table 5: Cumulative Data Description

| Value | Description |
| --- | --- |
| ID | An identifier for the selected object |
| Time (sec) | Time stamp |
| Power (W) | Range of values  Median value (VISITAG™ Sites only) |
| Temperature (°C) | Range of values  Median value (VISITAG™ Sites only) |
| Impedance (Ω) | Baseline value to lowest recorded value; impedance drop |
| Force (g) | Range of values  Average value (VISITAG™ Sites only) |
| Force Time Integral (FTI) (g\*sec) | Current value |

![visiTag_cummulativeData_7p3.png](data:image/png;base64...)

Figure 9: Cumulative Data Popup on VISITAG™ Site

If the RF Generator becomes disconnected during ablation, a comment appears in the Cumulative Data popup: \* Lost communication – data might be partial. A red asterisk (\*) appears next to the values requiring input from the generator (power, temperature, impedance).

If the values are not available for another reason and for a defined period of time, N/A is displayed.

![visiTag_cummulativeData_noComm_7p3.png](data:image/png;base64...)

Figure 10: Cumulative Data Popup: No Communication with Generator

## VISITAG™ Sites and Projections

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_overlapping\_7p3\_EN.xml

If you click a VISITAG™ Site or Grid Cell and projections are on, both the location/cell and the projection are selected. This is indicated by a black and orange ring.

![visitags_projection_0pc.png](data:image/png;base64...)

Figure 11: VISITAG™ Site and Projection

REP9626 1.22.1

Multiple VISITAG™ Sites can project to the same place on the map, creating one projection tag for more than one VISITAG™ Site.

If a VISITAG™ Site overlaps another by more than 75% and its projection does not fully overlap another projection:

* When selected, both the VISITAG™ Site and its projection have a double black and orange ring.

Clicking either the projection or the VISITAG™ Site selects both.

* You can double-click either the VISITAG™ Site or its projection to view the Cumulative Data window with data for the selected site.

![visitags_projection_75pc.png](data:image/png;base64...)

If a VISITAG™ Site overlaps another by more than 75% and its projection fully overlaps another projection:

* Only the VISITAG™ Site can be selected. It has a double black and orange ring. There is no indication on the projection.
* The projection coloring matches the stronger VISITAG™ Site.
* You cannot double-click the projection to view the Cumulative Data window.

![visitags_projection_100pc.png](data:image/png;base64...)

If two VISITAG™ Sites overlap another by less than 75% but their projections fully overlap:

* The VISITAG™ Sites can be selected, but there is no indication on the projection.
* The projection coloring matches the stronger VISITAG™ Site.
* You cannot click the projection to select it.
* You cannot double-click the projection to view the Cumulative Data window.

## Distance Measurement Tool

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_distance\_V7-P3\_EN.xml

The Distance Measurement Tool provides two ways to measure the distance.

* **Catheter**: Measures the distance between the real-time ablation catheter tip position and the last VISITAG™ Site that was created. You can also display the distance between the catheter tip and a selected point or VISITAG™ Site within 15 mm.
* **Standard**: Measures the distance between any two selected end points (VISITAG™ Sites, Grid Cells, points, tagged points, or locations on the map). This option is not available during FAM acquisition.

The distance measured is the direct line connecting the center of the object or the catheter tip (not the distance on the map or tissue).

You can activate the tool from the Map Menu or the VISITAG™ Toolbar.

* From the Map, select Distance Measurement - Catheter or Distance Measurement - Standard
* From the toolbar, select Catheter or Standard

In **Standard** mode, click two endpoints. The distance is displayed.

![visitag_siteToSite.png](data:image/png;base64...)

Figure 12: Distance between Two VISITAG™ Site

In **Catheter** mode, the distance between the catheter tip and the last created VISITAG™ Site is automatically displayed. If a new site is created, it becomes the endpoint.

* To measure the distance between the catheter tip and a different VISITAG™ Site, click the site.
* To display the distance between the catheter tip and an EA point, press SHIFT while clicking the point. The point is not selected (map viewers, Point List, or Selected Point Viewer).

In both cases, the object must be within 15 mm of the catheter tip.

![visitag_siteToTip_4-3.png](data:image/png;base64...)

Figure 13: Distance Real-Time Catheter Position and Last VISITAG™ Site

## Automatic Distance Tool

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_AutoDistance\_V8\_EN.xml

The Automatic Distance Tool automatically highlights the Euclidian distance between the centers of two VISITAG™ sites, where the distance is larger than the predefined thresholds. A distance of 12 millimeters or higher between one VISITAG™ site and the next means that these sites belong to separate clusters. Therefore, these distances are not highlighted.

This feature applies to all valid VISITAG™ sites of focal ablations and does *not* apply to the white and gray VISITAG™ sites and the non-focal VISITAG™ tags.

![VisiTag_AutoDistanceTool.png](data:image/png;base64...)

Figure 14: Two VISITAG™ Sites and the Highlighted Distance Between Them

Each section represents one millimeter of Euclidian distance between the VISITAG™ site centers. To see the accurate numeric representation of the distance, click the highlighted distance between the VISITAG™ sites.

![VisiTag_AutoDistanceTool_and_number.png](data:image/png;base64...)

Figure 15: Numeric Representation of the Distance

The distances are recalculated when one or more of the following occurs:

* The VISITAG™ data is recalculated
* VISITAG™ sites are shown or hidden
* There is a change in the map source selection display filter in the VISITAG™ toolbar
* A new VISITAG™ site is created

# CARTO VISITAG™ Module Usage Examples

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_examples\_EN.xml

The following images provide examples of the same Study displayed with different CARTO VISITAG™ settings (including filter thresholds and coloring).

Example 1:

* Stability filter time: 20 s
* Stability filter area: 3 mm
* Coloring: Total Time

![VisiTag_conf1_20sec_3mm_total_time.png](data:image/png;base64...)

Figure 16: CARTO VISITAG™ Options: Example 1

Example 2:

* Stability filter time: 15 s
* Stability filter area: 2 mm
* Coloring: Force Time Integral (FTI)[[5]](#footnote-5)

This example uses a less stringent Catheter Position Stability value. Therefore, more sites are displayed than in the previous examples.

![VisiTag_conf3_15sec_2mm_FTI.png](data:image/png;base64...)

Figure 17: CARTO VISITAG™ Options: Example 2

# Stability+

https://bwiildita.sharepoint.com/sites/prod/Topics/VisitagStabilityAlgorithm\_EN.xml

To set the VISITAG™ stability algorithm, go to Tools > VISITAG™ Stability Algorithm selected. The default is Stability+.

When Stability+ is selected, the System continuously analyzes the overall movement of the catheter, separating the movement due to respiration from the actual catheter movement. This continuous analysis reduces the time for initial indication of stability and the appearance of VISITAG™ Sites.

Claim: support for QMODE+

This algorithm supports all focal ablation types including short duration sessions (such as QMODE+ sessions).

**Considerations when using Stability+:**

* The algorithm requires a training period. This happens automatically in the background either during or after the catheter visualization process while a magnetic sensor-based catheter is in the mapping zone. If a focal ablation catheter is connected while the training is in process, an alert message is displayed until the training period is finished.
* This algorithm measures the distance from the center of the site to the catheter tip location. If the catheter moves beyond a distance of 3 mm, the site breaks. If a site breaks during ablation due to instability, and Show Site Break Indication is enabled (see ["CARTO VISITAG™ Module Preferences"](#target9000005)), a ring (halo) is displayed for up to 3 seconds around the broken site tag. This indication disappears at the end of the ablation session or when a new site appears.

![VisitagStabilityAlgorithm_halo.png](data:image/png;base64...)

* For faster tag appearance, ensure catheter stability before starting ablation.
* For optimal algorithm indication, use point by point ablation sessions.

REP14517 D-5, D-5.1

Claim: velocity

* In the Gated (ACCURESP™) stability algorithm, the maximum distance is based on the standard deviation, whereas in the new Stability+ algorithm, the maximum distance change is 3 mm. This makes Stability+ more sensitive to movement.
* If you switch between algorithms during a study, the System recalculates and presents the VISITAG™ Sites according to the current algorithm. It is not recommended to switch between algorithms during a study. To avoid VISITAG™ Site displacement and their data changes due to new calculation, switch between stability algorithms only in retrospective study.
* If the Maximum Distance Change filter is set using the Gated (ACCURESP™) stability algorithm, and then the stability algorithm is changed to Stability+, the Maximum Distance Change filter is set by the system to 3 mm.
* Stability+ cannot be used on a loaded study which was performed on CARTO™ 3 version 7.5 or earlier.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If you switch to the Gated (ACCURESP™) site stability algorithm and Respiration Gating Training was not performed before the start of the ablation session, VISITAG™ Sites might not appear. For more information see ["CARTO VISITAG™ Module Preferences"](#target9000006). |

## Stability Indication with Stability+

https://bwiildita.sharepoint.com/sites/prod/Topics/Visitag\_stabilityIndication\_comp\_v8\_EN.xml

REP14517 A-10

When Stability+ is active, additional indication appears in the Readings Dashboard if data is not available during ablation.

Table 6: Stability+ Stability Indication

| Icon | Status |
| --- | --- |
| ![stability_data_unavail.png](data:image/png;base64...) | Stability+ is temporarily not available. Catheter stability cannot be displayed. |
| ![stability_data_for_tag_unavail.png](data:image/png;base64...) | Valid data for Tag Index is not available (where the VISITAG SURPOINT™ Module is active). |

## White Site Tags

https://bwiildita.sharepoint.com/sites/prod/Topics/visitag\_display\_WhiteTags\_v8\_EN.xml

Claim: white site tags

If Stability+ is selected, white site tags indicate the first site in an ablation session where the catheter is stable, and before the Minimum Time threshold had been met and the VISITAG™ coloring is applied.

A white site tag might appear if one or more of the following occurs:

* The system defined Maximum Distance Change of 3 mm was met.
* No other VISITAG™ Sites were created during the current ablation session.
* The Minimum Time filter was not met.
* The Force Over Time filter was met (if active).

Once the Minimum Time filter was achieved, the tag is colored according to the current settings. If the Minimum Time threshold is not met, it remains white.

When the White Site Tags On/Off option is selected in the VISITAG Toolbar, the white tags remain after the end of the ablation session. If this option is not selected, white tags disappear up to 5 seconds after the end of the ablation session.

![VISITAG_StbPlus_WhiteTags.png](data:image/png;base64...)

Figure 18: A Sample Map with White VISITAG™ Sites (Left) and White QMODE+™ Sites (Right)

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If Tag Index and White Site Tags On/Off are both selected, the Tag Index becomes available after a white tag is displayed. |

## Site Tag Coloring

https://bwiildita.sharepoint.com/sites/prod/Topics/visitag\_SiteTagColoring\_EN.xml

REP14517 A-10.1

Different coloring methods can be used simultaneously for QMODE+ Sites and VISITAG™ Sites. These are set in separate drop down lists in the Site Tag Coloring On/Off option ![visiTagToolbar_blue_locationColor_enabled.png](data:image/png;base64...) in the VISITAG toolbar.

To enable or disable site tag coloring for both VISITAG™ Sites and QMODE+ Sites together, select the Site Tag Coloring On/Off icon.

To disable coloring for either VISITAG™ Sites or QMODE+ Sites, go to Site Tag Coloring On/Off, select the option for which you want to disable coloring, and then select None.

![visitag_coloring.png](data:image/png;base64...)

Figure 19: Site Tag Coloring Options for the QMODE+ Sites (None - to Disable Coloring)

## Comparison Between the VISITAG Stability Algorithms

https://bwiildita.sharepoint.com/sites/prod/Topics/Visitag\_algorithm\_compare\_v8\_EN.xml

REP14517 A-7

| **Gated (ACCURESP™)** | **Stability+** |
| --- | --- |
| Respiration Gating Training is required. | Training occurs automatically in the background after catheter visualization when a sensor based (TAS) catheter is in the mapping zone. Respiration Gating Training is not required for VISITAG™ Site creation. Training is still required for other features such as gated point acquisition and Exclude Respiration Data for FAM reconstructions. |
| The Maximum Distance Change filter is set by the user and is based on the standard deviation. | The Maximum Distance Change filter set by the System to 3 mm. It is absolute, and not based on standard deviation. This provides a higher detection rate of instability. The Maximum Distance Change filter is not displayed in the Preferences dialog box. |
| There can be a delay of more than one respiration cycle before VISITAG™ Site can be displayed. | Claim: time for tag appearance  If the catheter is stable before the ablation session begins, Stability+ takes up to 2 seconds to optimize and display CARTO VISITAG™ Module information after an ablation session begins. Otherwise, it can take up to 5 seconds for the VISITAG™ Site(s) to display. |
| No indication of the first site if the Minimum Time threshold was not met. | White tags indicate the first site in an ablation session where the catheter is stable, but before the Minimum Time threshold was met and the VISITAG™ or QMODE+ Site Coloring was applied (see ["White Site Tags"](#target9000007)). |
| Minimum Time threshold range: 3 s to 120 s | Minimum Time threshold   * For VISITAG™ Sites, range between 3s to 120 s * For QMODE+ Sites can be either 2 s, 2.5 s, 3 s, or 3.5 s |
| No indication of a break in the site. | A ring (halo) appears around a broken site until a new site appears or the ablation session ends. |
| Grid cells can be displayed even in areas where the catheter was not in the region for the minimum time (Excluded Grid On/Off ). | Excluded grid cells cannot be displayed. |
| The QMODE+ tab is active and the VISITAG™ tab doesn't apply to QMODE+ ablation sessions. | VISITAG™ Preferences apply to all focal VISITAG™ Sites, including QMODE+ Sites. The QMODE+ tab is removed from the Preferences dialog box. |
| QMODE+ Sites are colored red unless the Color according to checkbox in the QMODE+ Preferences dialog box is selected.  In this case, it is colored according to the status, detailed in the QMODE+ Preferences dialog box. For more information see ["QMODE+™ Sites with the Gated Stability Algorithm"](#target9000008) | QMODE+ Sites are colored according to QMODE+ Site coloring settings set in the VISITAG Toolbar, |

These two algorithms have different valid ranges for Maximum Distance Change threshold and Minimum Time threshold. If a preset was set without a QMODE+Minimum Time value, the value will be set to 2 seconds.

# QMODE+™ Functionality in the CARTO™ 3 System

https://bwiildita.sharepoint.com/sites/prod/Topics/qmode\_interface\_v8\_EN.xml

QMODE+™ Functionality provides a unique type of VISITAG™ Site, which indicates very high power, short duration ablation sessions. These sessions create a distinct QMODE+™ Site which indicates the ablation location. QMODE+™ Sites are marked with a textured surface.

QMODE+ ablation sessions do not generate grid information.

## Catheter Stability Status

https://bwiildita.sharepoint.com/sites/prod/Topics/qdot\_stability-indication\_V8\_EN.xml

When using the Gated stability algorithm. during QMODE+™ ablation sessions, the stability status indication shows catheter stability based on the Location Stability filter parameters associated with the active CARTO VISITAG™ Module preset. If the Location Stability filter is not defined, N/A is displayed.

Table 7: Catheter Stability Status During Application of RF Energy

| Stable | Not Stable |
| --- | --- |
| ![visiTag_statusIcon_catheterStable_ABL_6-3.png](data:image/png;base64...) | ![visiTag_statusIcon_notStable_ABL_6-3.png](data:image/png;base64...) |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When using the Gated stability algorithm, site stability duration is not available during QMODE+™ ablation sessions. |

### QMODE+ Sites with Stability+

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_QmodePlus\_EN.xml

Claim: QMODE+ based on VISITAG

For QMODE+ ablation sessions with Stability+, the standard VISITAG Preferences apply. This is indicated in the VISITAG Preferences tab. The QMODE+ tab is removed. QMODE+ Sites are colored according to QMODE+ coloring settings set in the VISITAG Toolbar. For more information see ["Site Tag Coloring"](#target9000009) .

The selected VISITAG preset appears in the ablation session list.

### QMODE+™ Sites with the Gated Stability Algorithm

https://bwiildita.sharepoint.com/sites/prod/Topics/qmode\_visitag\_functionality\_v8p1\_EN.xml

When the Gated stability algorithm is selected, a QMODE+ Session Review Indicator can be added to a QMODE+™ Site. This indicator is used to show whether the total energy applied for that site has passed the user-defined threshold. The indicator is enabled in the QMODE+ tab of the Preferences dialog box.

When using the Gated stability algorithm QMODE+™ Sites are displayed only at the end of each QMODE+™ ablation session.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The QMODE+ Session Review Indicator functionality should be used in a retrospective manner after PVI isolation. |

![qmode_preferences_v7p3.png](data:image/png;base64...)

Figure 20: QMODE+ Preferences

Table 8: Description of QMODE+ Preferences

| Option | Description |
| --- | --- |
| The Respiration Adjustment setting in the active VISITAG™ Preset is ON/OFF. | Presents the current status of the Respiration Adjustment filter, set in the VISITAG tab of the Preferences dialog box.  The Respiration Adjustment setting can be used to minimize the respiration effect on the position of the QMODE+™ Sites. Catheter positions are adjusted and brought to the end-expiration phase location during the creation of the QMODE+™ Sites.   * If the Respiration Adjustment is set to ON: The location of the QMODE+™ Site will be either the closest position to the end-expiration phase, or the first catheter location during the RF session, depending on the timing of the end-expiration phase with respect to the RF session. If the tag is on the first catheter location, it is marked as Resp. Adjusted: No in the Cumulative Data window. * If the Respiration Adjustment is set to OFF: The location of the QMODE+™ Site will be at the first catheter location during the RF session. |
| Color According to | When selected, QMODE+™ Site coloring provides an indicator of the total energy applied. These QMODE+™ Sites will be displayed with a colored, textured surface, according to the total energy applied.  When not selected, or if the option is selected but all parameters are 0, standard QMODE+™ Site coloring is applied. |
| Total energy applied | REP 9626: V7 QMODE 2.0; REP4611 A-V2-11.2.1.4  The Total energy applied threshold allows you to see where less RF energy was applied during an ablation session.  The Total energy applied indicator does not indicate lesion creation or the quality of the lesion. Use your clinical judgement with indicator use and interpretation.  The default value is 0. |

Table 9: QMODE+™ Session Review Indicators

| Color | Description |
| --- | --- |
| ![qmode_visitag_one-parameter-below_v7p3.png](data:image/png;base64...)Does not meet the threshold | If the total energy applied is below the threshold. |
| ![qmode_visitag_all-parameters-above_v7p3.png](data:image/png;base64...)Meets the threshold | If the total energy applied is equal to or above the threshold. |
| ![qmode_visitag_parameter-error_v7p3.png](data:image/png;base64...)Missing data | * There is invalid data. * No data collected for longer than 350 ms during the ablation session. |

Requested by MSO

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A single study can have multiple power levels. |

Less RF energy can be due to one of the following:

* The ablation session was of a shorter duration
* Less power was applied during an ablation due to power titration

If the Total energy applied threshold is changed, the new value is retrospectively applied to the coloring of existing QMODE+™ Sites.

The settings are saved with the study.

If a new template is created, the System saves the Total energy applied value and clears the Color According to check box. If you select the check box again, the System resets the Total energy applied value to 0.

When using the Gated stability algorithm, QMODE+™ ablation sessions are marked as Focal, QMODE+ in the Type column of the RF sessions list. The active Preset for a QMODE+™ session is always the QMODE+ preset. This preset cannot be changed or replaced.

![graphs_qdot_sessions_c3v8.png](data:image/png;base64...)

Figure 21: RF Sessions List

## Graphs Viewer in QMODE+™Ablation Sessions

https://bwiildita.sharepoint.com/sites/prod/Topics/qmode\_graphs\_c3v8\_EN.xml

After a QMODE+™ ablation session, the Graphs Viewer freezes the section of the timeline recorded during the ablation session. The frozen section remains at the left-hand side of the Graphs Viewer until the start of the next ablation session, or until the user resets the view by double-clicking the graph area.

![graphs_qdot_c3v7.png](data:image/png;base64...)

Figure 22: Graphs Viewer after QMODE+™ Ablation Session

## Viewing Ablation Session Data

https://bwiildita.sharepoint.com/sites/prod/Topics/qdot\_ablation-data\_V8\_EN.xml

The Cumulative Data window includes standard ablation session data when working with the QDOT MICRO™ catheter. For QMODE+™ ablation sessions, the data includes the ablation mode respiration adjustment setting, and the results of the ablation parameter calculations.

![cumulative_data_popup_qmode_2_c3v7.png](data:image/png;base64...)

Figure 23: Cumulative Data window for QMODE+™ and QMODE Sites

## QMODE+™ Point Tags

https://bwiildita.sharepoint.com/sites/prod/Topics/qmode\_point\_locations\_c3v7\_EN.xml

If CARTO™ 3 System manual points are acquired during a QMODE+™ ablation session, they will be automatically tagged with a QMODE+ Ablation tag.

![qmode+_visitag_v7p3.png](data:image/png;base64...)

Figure 24: QMODE+™ Ablation Tag (Selected)

QMODE+ Ablation tags are added to the list of available point tags. The tag is automatically applied to any point that was manually acquired during a QMODE+™ ablation session.

![qmode_tags_list_no_PFA.jpg](data:image/jpeg;base64...)

Figure 25: QMODE+™ Ablation Tag in the Tags Dialog Box

In the Point List, the tag appears as QM+.

![point_list_qmode+_c3v7.png](data:image/png;base64...)

Figure 26: QMODE+™ Ablation Points in the Point List

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  In Manual Point Acquisition mode, if the Respiration Adjustment mode is active, the point might be acquired after the end of the ablation session. In this case, the QMODE+™ tag is not applied, and the point is not linked to the ablation session. If this occurs, manually tag the point with a QMODE+™ tag. You can also add a comment in the Point List to refer to the ablation session.  The only setting in the CARTO™ 3 System VISITAG™ Module Preferences tab that is relevant and considered during a QMODE+™ ablation session is the Respiration Adjustment checkbox. |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) 0344 |  |

![](data:image/png;base64...)

1. Where the module is available and installed [↑](#footnote-ref-1)
2. Where available [↑](#footnote-ref-2)
3. Where available [↑](#footnote-ref-3)
4. Settings that require force data are only available if a supported force catheter is used and a compatible module is installed. [↑](#footnote-ref-4)
5. The FTI coloring option is recommended for retrospective use only. [↑](#footnote-ref-5)