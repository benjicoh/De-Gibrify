|  |
| --- |
| VISITAG SURPOINT™ Module with EPU |
| Instructions for Use and Release Notes |
|  |

|  |
| --- |
| UG-5430-018H (01A) |
| March 2025 |
| Please read this document carefully before using the CARTO™ 3 System. |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © by Biosense Webster, Inc. All rights reserved.

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

24 March 2025

Table of Contents

[VISITAG SURPOINT™ Module with EPU 1](#_Toc193731560)

[Overview 1](#_Toc193731561)

[About this Document 1](#_Toc193731562)

[Connecting the VISITAG SURPOINT™ EPU 1](#_Toc193731563)

[VISITAG SURPOINT™ EPU Connection Status 2](#_Toc193731564)

[Troubleshooting the EPU Connection 2](#_Toc193731565)

[Safety Information 3](#_Toc193731566)

[VISITAG™ Stability Algorithm 4](#_Toc193731567)

[Recommended Settings for Tag Index Workflow 4](#_Toc193731568)

[Tag Index Indication 5](#_Toc193731569)

# VISITAG SURPOINT™ Module with EPU

https://bwiildita.sharepoint.com/sites/prod/Topics/surpoint\_epu\_intro\_v7\_EN.xml

## Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/surpoint\_overview\_8p1\_EN.xml

The **VISITAG SURPOINT™ Module** adds a Tag Index to the CARTO VISITAG™ Module. This Tag Index combines parameters of ablation power, contact force, and duration of RF application during ablation, using a proprietary formula. [[1]](#footnote-1)

The VISITAG SURPOINT™ Module with EPU requires an external device, the VISITAG SURPOINT™ External Processing Unit (EPU). The VISITAG SURPOINT™ EPU processes data from the CARTO™ 3 System, and returns the value of the Tag Index.

This version of the VISITAG SURPOINT™ Module with EPU is compatible with CARTO™ 3 System, Version 8.0 and higher.

## About this Document

https://bwiildita.sharepoint.com/sites/prod/Topics/surpoint\_about\_epu\_8p1\_EN.xml

This document provides information for the setup and operation of the VISITAG SURPOINT™ Module and the EPU. Some pictures might differ from the ones appearing in your system. However, functionality is the same.

* Refer to the *Instructions for Use* of the VISITAG SURPOINT™ EPU before using it with the CARTO™ 3 System.

The EPU *Instructions for Use* contains information on installing, connecting, and caring for the EPU. In addition, it contains a summary of clinical studies using the Tag Index.

* For details regarding operation of the CARTO™ 3 System and the CARTO VISITAG™ Module, refer to the documentation provided with your System.
* Refer to the *Instructions for Use* of the ablation catheter before application of RF energy.

## Connecting the VISITAG SURPOINT™ EPU

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_SurPoint\_EPU\_V6p5\_EN.xml

The VISITAG SURPOINT™ EPU must be connected securely to the CARTO™ 3 System Workstation before use. For details, refer to the *Instructions for Use* of the VISITAG SURPOINT™ EPU.

![surpoint_epu.jpg](data:image/jpeg;base64...)

Figure 1: VISITAG SURPOINT™ EPU

### VISITAG SURPOINT™ EPU Connection Status

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_index\_connectionIssues\_EN.xml

The connection status of the device is indicated in the CARTO™ 3 System Status panel.

Table 1: Connection Status

| Icon | Status | Description |
| --- | --- | --- |
| ![Icon_connected_epu.png](data:image/png;base64...) | Connected | The VISITAG SURPOINT™ EPU is connected to the CARTO™ 3 System Workstation. Data is flowing normally between the devices. |
| ![Icon_disconnected_epu.png](data:image/png;base64...) | Disconnected | The VISITAG SURPOINT™ EPU is disconnected.  The CARTO™ 3 System cannot display Tag Index values. |

### Troubleshooting the EPU Connection

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_index\_epu\_troubleshooting\_EN.xml

The disconnection icon indicates that the USB cable is disconnected, or that some other communication error has occurred.

In this communication state, the VISITAG SURPOINT™ EPU loses power and its connection to the CARTO™ 3 System Workstation.

When data can no longer flow to and from the VISITAG SURPOINT™ EPU:

* The status icon shows the disconnection.
* The Tag Index graph cannot be updated.
* The Tag Index value cannot be updated in the Cumulative Data popup or the Readings Dashboard. N/A is displayed.
* If coloring is based on the Tag Index value, VISITAG™ Locations are colored gray.

All other parameters are still updated in the Graphs Viewer, Cumulative Data popup, and Readings Dashboard.

![spnt_display_errors.png](data:image/png;base64...)

Figure 2: Cumulative Data Popup when VISITAG SURPOINT™ EPU Is Disconnected

If this occurs:

1. Disconnect the USB cable (if connected) and reconnect it to the CARTO™ 3 System Workstation.
2. Exit the study.
3. Either start a new study or continue the previous study in Review mode.
4. If this did not restore the connection, restart the CARTO™ 3 System Workstation.

If the connection is still not restored, contact your Biosense Webster Representative.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The loss of Tag Index indication does not affect other system functionality. You can continue the Study without it. |

## Safety Information

https://bwiildita.sharepoint.com/sites/prod/Topics/Safety\_surpoint\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO™ 3 System also apply while using this module. In addition, the following considerations apply:

* The CARTO VISITAG™ Module provides access to data collected during the application of RF energy.

From FDA

* The Tag Index values should not be used to guide RF energy delivery.
* Before application of RF energy, refer to the *Instructions for Use* (IFU) of the ablation catheter.
* Before applying energy for ablation, visually verify correctness of the tip position of the mapping catheter in relation to the visualized map. Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.). Failure to do so might result in incorrect placement of the catheter.

D-V6-1.16.1

* When the Respiration Adjustment mode is active, and the Gated (ACCURESP™) VISITAG™ Stability algorithm is selected, positions are accumulated at the end-expiration phase. This leads to a delay in display of all CARTO VISITAG™ Module information. Take this delay into account when treating areas where immediate feedback is important.

## VISITAG™ Stability Algorithm

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_epu\_recommendations\_compensated\_8p1\_EN.xml

There are two algorithms available for adjusting for movement due to respiration when the Respiration Adjustment option is selected. The Stability+ algorithm is a continuous analysis of catheter movement. The Gated algorithm depends on ACCURESP™ Respiration Gating Training. Stability+ is active by default.

When Stability+ is active, Respiration Adjustment does not depend on the respiration rate. VISITAG™ Sites will appear faster: If the catheter is stable before the ablation session begins, Stability+ takes up to 2 seconds to optimize and display CARTO VISITAG™ Module information after an ablation session begins. Otherwise, it can take up to 5 seconds for the VISITAG™ Site(s) to display.

Refer to the CARTO VISITAG™ Module chapter of the CARTO™ 3 System *Instructions for Use* for details.

## Recommended Settings for Tag Index Workflow

https://bwiildita.sharepoint.com/sites/prod/Topics/surpoint\_RcommendedForTagIndex\_EN.xml

It is recommended that Tag Index be used only when delivering RF as point-by-point ablation sessions. This will result in a single VISITAG™ Site for each ablation session.

|  |  |
| --- | --- |
| ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**   * The data provided by the CARTO VISITAG™ module does not indicate the effectiveness of RF energy application.   FDA-related text. Do not change.   * Equivalent Tag Index values do not represent equivalent RF lesion size. |

The following settings are recommended to support the use of the Tag Index workflow when using the Gated stability algorithm. These settings take the Respiration Adjustment delay when the Gated stability algorithm is active into account. These recommended settings are also provided in the VISITAG Preferences dialog box when the Gated stability algorithm is selected.

For an explanation of the parameters included in the recommended settings, refer to the *CARTO VISITAG™ Module User Guide*. For additional information on optimal device performance (ODP), click Tools > VISITAG SURPOINT™ ODP.

Table 2: Recommended Settings for CARTO VISITAG™ Module When Using Tag Index

| Parameter | Recommended Value |
| --- | --- |
| Respiration Adjustment[[2]](#footnote-2) | Enabled |
| Maximum Distance Change | 2-3 mm |
| Minimum Time | 3 s |
| Force Over Time: Time | 25% |
| Force Over Time: Minimum Force | 3 g |
| Site Tag Size, for a maximum inter-site distance of 6 mm  (Choose Site Tag Size setting in the VISITAG™ Toolbar) | 3 mm |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Gated (ACCURESP™) Stability Algorithm only:  If the catheter meets the recommended values for location and force stability filters when applying RF, the VISITAG™ Site will be displayed 3 seconds after the RF starts and an end respiratory phase was detected.  When the Respiration Adjustment mode is active, positions are displayed and updated in the map viewers *at the end-expiration phase*. |

If the Respiration Adjustment option cannot be used, follow the steps below:

|  |  |
| --- | --- |
| 1. | Ensure that the catheter stability indication is displayed between ablation sessions. |
| 2. | Clear the Respiration Adjustment option. |
| 3. | Place the ablation catheter in a stable location. |
| 4. | Increase the position stability range to the minimal value which reflects the catheter movement during the respiratory cycle. Monitor the stability indicator while increasing the stability range until the indicator shows that stability is achieved. This is the recommended value.  ![visiTag_statusIcon_catheterStable_6-3.png](data:image/png;base64...) |
| 5. | Deliver RF energy as point-by-point ablation sessions. |

## Tag Index Indication

https://bwiildita.sharepoint.com/sites/prod/Topics/visiTag\_index\_toolbar\_epu\_8p1\_EN.xml

When the VISITAG SURPOINT™ Module with EPU is installed, the Tag Index value is always calculated when the parameters are available.

During RF application, when the VISITAG™ filter thresholds are met, the Tag Index value appears on the Readings Dashboard. (Label: ![visiTag_ablationIndex_icon_6-3.png](data:image/png;base64...))

![visiTag_rf_toolbar_indication_US_6p5.png](data:image/png;base64...)

Figure 3: Tag Index Indication on Readings Dashboard

REP4611 PL25

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When a progress bar is indicating that the system is processing a large number of points, there may be a delay in refreshing the Readings Dashboard. Take this delay into account when treating areas where immediate feedback is important. |

The Tag Index value can display next to the catheter tip in the Main Map Viewer. Refer to the CARTO VISITAG™ Module chapter of the CARTO™ 3 System *Instructions for Use* for details.

Tag Index coloring is based on a continuous gradient. If the Stability+ Stability Algorithm is active, white tags may also appear. See the CARTO VISITAG™ Module chapter of the *Instructions for Use* for details.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The Tag Index Color Scale can only be used in Automatic mode. It cannot be set manually. |

![VisiTag_ablIndex_colorScale_v6p6.png](data:image/png;base64...)

Figure 4: Tag Index Color Scale

The Tag Index value is displayed in the Cumulative Data Popup.

![visiTag_cummulativeData_tagIndex_7p3.png](data:image/png;base64...)

Figure 5: Cumulative Data Popup with Tag Index Value

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The Tag Index value is updated continuously in the Readings Dashboard during ablation and in the Graphs Viewer after the VISITAG™ Site is created. |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) | Biosense Webster (Israel) Ltd.  4 Hatnufa Street  Yokneam 2066717  ISRAEL  Tel: +972 (4) 813 1111 |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) 0344 |  |

![_TBCO11;B=20;W=168.00pt;H=39.60pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5430-018HREV01A](data:None;base64...)

![](data:image/png;base64...)

1. Where the module is available and installed [↑](#footnote-ref-1)
2. Not required when low tidal ventilation (e.g., jet ventilation) is in use. [↑](#footnote-ref-2)