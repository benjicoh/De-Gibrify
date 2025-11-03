|  |  |
| --- | --- |
| OPTRELL™ 48 Catheter Support | |
| Instructions for Use and Release Notes |  |
|  |  |

|  |
| --- |
| UG-5404-018H (01A) |
| March 2024 |
| Please read this document carefully before using the CARTO™ 3 System. |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![](data:image/png;base64...) © 2021 - 2024 by Biosense Webster, Inc. All rights reserved.

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

25 March 2024

Table of Contents

[OPTRELL™ Mapping Catheter Support 1](#_Toc159144631)

[Overview 1](#_Toc159144632)

[About This Release 1](#_Toc159144633)

[About This Document 1](#_Toc159144634)

[About the OPTRELL™ Mapping Catheter 2](#_Toc159144635)

[Safety Information 2](#_Toc159144636)

[Connecting the OPTRELL™ Mapping Catheter to the SPU 2](#_Toc159144637)

[CARTO™ 3 System Interface with the OPTRELL™ 48 Mapping Catheter 3](#_Toc159144638)

[Catheter Setup Screen 3](#_Toc159144639)

[OPTRELL™ 48 Mapping Catheter Visualization 4](#_Toc159144640)

[Out of Sheath Indication 5](#_Toc159144641)

[TPI Functionality 6](#_Toc159144642)

[Local Conduction Vectors (LCV) 6](#_Toc159144643)

[Recording System Connections 9](#_Toc159144644)

[Troubleshooting 10](#_Toc159144645)

# OPTRELL™ Mapping Catheter Support

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Introduction\_EN.xml

## Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Overview\_EN.xml

**OPTRELL™ Mapping Catheter Support** provides visualization of the OPTRELL™ Mapping Catheter and display of signals in the CARTO™ 3 System. The OPTRELL™ Mapping Catheter can be used for all standard functionality, including mapping (both FAM and EA) and pacing.

The System supports 48 unipolar ECG channels and 42 adjacent bipolar channels along the splines. The System supports visualization of an extended shaft electrode (electrode S3), in addition to electrode S1 and electrode S2. In the Recording System, 36 channels are available for visualization and pacing.

### About This Release

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_About\_Release\_EN.xml

OPTRELL™ Mapping Catheters are compatible only with a dedicated CARTO™ 3 Workstation, with software version 7.5 or higher installed. This is based on CARTO™ 3 System V7.5.1.

The OPTRELL™ Mapping Catheter can be used with most modules, with the following exceptions:

* CARTOFINDER™ Module is not supported (part of the CARTO PRIME™ Module).
* Pairing visualization of OPTRELL™ Mapping Catheters with the CARTO VIZIGO™ Sheath is not supported.

### About This Document

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_About\_document\_EN.xml

This document provides information regarding use of the CARTO™ 3 System with OPTRELL™ Mapping Catheters.

* Refer to the *Instructions for Use* (IFU) of the catheter before using this catheter with the CARTO™ 3 System.
* Refer to the *CARTO™ Signal Processing Unit (SPU) Instructions for Use* for details on connecting the SPU to the PIU.
* Refer to the *CARTO™ 3 System Instructions for Use* for further information about the system.

This includes SPU-related functionality such as status indication, TRUEref™ functionality, the SPU smoothing filter, and error messages.

### About the OPTRELL™ Mapping Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Catheter\_Specifications\_EN.xml

The OPTRELL™ Mapping Catheter is a triple-loop diagnostic catheter, with 2.4 × 2.4 spacing (in spline and across spline). It is available and supported in both D-F and F-J curves.

![OPTRELL_Catheter.png](data:image/png;base64...)

Figure 1: OPTRELL™ Mapping Catheter

## Safety Information

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Safety\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO™ 3 System also apply while using this module. In addition, the following consideration applies:

REP13141 D-2, D-3

REP11406 D-62, D-63, A-96, D-97, D-98

* While mapping and before applying RF energy, check the catheter tip position in relation to the map. Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.).

## Connecting the OPTRELL™ Mapping Catheter to the SPU

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Connect\_to\_Catheter1\_EN.xml

Before connecting the catheter to the SPU, ensure that the SPU is connected and ready for use. The LED is green and the green connection icon appears on the System status bar.

|  |  |
| --- | --- |
| 1. | Connect the catheter to the SPU extension cable connector.![OCTARAY_SPU_Extension_Cable.png](data:image/png;base64...) |
| 2. | Connect the SPU extension cable to the SPU. ![OCTARAY_SPU_and_Extension_Cable.png](data:image/png;base64...) |

The catheter is now connected to the SPU through the SPU extension cable connector.

## CARTO™ 3 System Interface with the OPTRELL™ 48 Mapping Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_interface\_EN.xml

![OPTRELL_GUI.png](data:image/png;base64...)

Figure 2: CARTO™ 3 Study with the OPTRELL™ Mapping Catheter

### Catheter Setup Screen

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Setup\_Screens\_EN.xml

When the OPTRELL™ Mapping Catheter is connected to the SPU and/or defined in the template, both 20A and 20B sockets are displayed under the catheter image in the Catheter Setup screen. The label for the socket is automatically set to SPU.

You can change the text of the label for the socket, as well as other visualization settings for the OPTRELL™ Mapping Catheter. For example, in the Color Per Spline section, set the spline color for the OPTRELL™ Mapping Catheter to a single color for all splines, or choose to display a different color for each spline.

To change the orientation of the catheter image, center-click the image and rotate.

![optrell_Catheter_Setup_screen_c7p3.png](data:image/png;base64...)

Figure 3: Catheter Setup Screen with OPTRELL™ Mapping Catheter Connected

### OPTRELL™ 48 Mapping Catheter Visualization

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_cath\_vis\_EN.xml

The OPTRELL™ Mapping Catheter has 3 loops: Spline A and Spline D; Spline B and Spline E; Spline C and Spline F. Electrodes on each spline are numbered from distal (1) to proximal (8).

There are 3 shaft electrodes: S1(distal), S2, and S3 (proximal).

![optrell_catheter_vis.png](data:image/png;base64...)

Figure 4: OPTRELL™ 48 Mapping Catheter Visualization

In-sheath impedance-based detection is supported for all electrodes.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When entering the chamber with the OPTRELL™ Catheter, use a real-time imaging modality such as fluoroscopy or ultrasound to visualize the catheter.   * Ensure that the chest patches are positioned properly. They must be placed an adequate distance apart, and they must encircle the heart without overlapping. Use the Location Setup screen to view placement. * If possible, build the matrix with the catheter that will be used for mapping. Using a different catheter may affect visualization. |

### Out of Sheath Indication

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_out\_of\_sheath\_EN.xml

In situations where the catheter is partially out of the sheath but visualization is not possible, the tip of the shaft visualization is highlighted. This can occur when the catheter is first exiting the sheath, or in situations where conditions prevent visualization (for example, inadequate matrix). The indication disappears when the splines are visualized.

![in_sheath_7p5.png](data:image/png;base64...)

Figure 5: OPTRELL™ Catheter with Out of Sheath Indication

This indication is on by default. It can be turned off and on in the Catheter Setup screen using the Show Out of Sheath Indication checkbox.

![OPTRELL_out_of_sheath_indication_checkbox.jpg](data:image/jpeg;base64...)

Figure 6: Catheter Setup Screen with Show Out of Sheath Indication Checkbox Highlighted

The catheter is available for mapping and building the matrix when the S1 electrode is out of the sheath.

### TPI Functionality

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_TPI-Functionality\_EN.xml

With **Tissue Proximity Technology**, the CARTO™ 3 System uses impedance measurements to determine an electrode's proximity to cardiac tissue. If the distance is less than the radius of the electrode, the electrode is considered to be touching.

Tissue Proximity Indication (TPI) is active by default.

REP9626: V7 1.8.10 (From OCTARAY™)

TPI impedance calculation is not available for the following electrodes, as they are not directly connected to the PIU:

* A3, B3, C3, D3, E3, F3
* A6, B6, C6, D6, E6, F6

A *Virtual TPI* calculation is performed for these unsupported electrodes based on the TPI status of neighboring electrodes. When both neighboring electrodes along the spline of any of the unsupported electrodes are in close proximity (positive TPI status), the unsupported electrode is considered positive as well. For example, if both electrodes A2 and A4 are positive, A3 is also considered to be positive.

Virtual TPI is automatically available when TPI is active and does not require any additional user configuration. Virtual TPI affects all TPI functionality, including status indication and filtered point acquisition.

### Local Conduction Vectors (LCV)

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_LCV\_7p5\_EN.xml

Local Conduction Vectors (LCV) tool displays real-time information on conduction direction, propagation velocity, and low voltage areas for the OPTRELL™ Catheter 3D image.

The LCV feature is only available when mapping criterion is set to WaveFront or Late Annotation, and an LCV-supported catheter is set and configured as the mapping catheter.

To access the LCV settings, right-click the map and select Catheter Vector Setup. The Catheter Conduction Vector Setup window appears.

![Catheter_Conduction_Vector_Setup_1.png](data:image/png;base64...)

Figure 7: Catheter Conduction Vector Setup

Table 1: Catheter Conduction Setup

| Setting | Description |
| --- | --- |
| Catheter Conduction Velocity Vectors | Visualization of local conduction vectors is enabled by default. Clear the checkbox to hide the vectors. This can be set for each map viewer.  The vectors appear thicker and shorter for areas of relative slow conduction, and thinner and longer for areas of relative fast/normal conduction. |
| Color | LAT (default): reflects the range of colors for the local conduction under the catheter surface from earliest to latest.  Solid: removes color, making arrows appear gray. |
| Size | needs FRS ref  Vector size scale values range from 1 to 11. Default is 5. |
| Bipolar scar threshold (mV) | A dark gray disk appears on top of the electrode when the catheter is in the proximity of a low voltage area and only while the electrode has positive tissue touch indication with TPI.  ![gray%20discs.jpg](data:image/jpeg;base64...)  needs FRS ref  The default threshold is set to 0.15 mV.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  This is not the same as the Bipolar scar threshold in the Scar Settings preferences. | |

There are 3 distinct velocity types: **slow conduction** area, **fast/normal conduction** area, **no conduction** (scar area):

![C3_V7p5_vectors_and_scar_indication.png](data:image/png;base64...)

Figure 8: Vector Velocity Indication

When visualization of local conduction vectors is enabled, you can display vectors for the catheter shadow for a point. Right-click the map viewer background and select Show Catheter > LCV. The vectors appear on top of the catheter shadow, and the vectors appear less saturated.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When choosing Show Catheter and editing a point, velocity vectors will be recalculated retrospectively based on the new parameters. |

Velocity vectors on the catheter shadow will change when point values are changed by:

* Reference annotation
* WOI borders
* VWOI borders
* Mapping annotation
* Late Boundary

You can display LCV on both map viewers, and on every map coloring type. They are also displayed on the following:

* Propagation/ Ripple display
* Glass mode
* Anatomical structure
* Merged images

## Recording System Connections

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_8p0\_Recording\_System\_Connections\_EN.xml

REP9626: V7 1.8.2 (From OCTARAY)

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  The CARTO™ 3 System can be connected to the Recording System with the direct cable or the indirect cable for 36 channels. When using the indirect cable, verify that the pins are connected correctly. Incorrect connection may result in stimulation routing to the wrong electrodes. |

REP13141: A1 (IFU indicates OPTRELL's connectivity and pacing limitation )

REP11406: A-96 (IFU indicates OPTRELL's connectivity and pacing limitation)

The following electrodes are not transferred to the Recording System:

* A3, B3, C3, D3, E3, F3
* A6, B6, C6, D6, E6, F6

![OPTRELL_Catheter_blockedElectrodes.png](data:image/png;base64...)

Figure 9: OPTRELL™ Mapping Catheter Unsupported Electrodes

The table below presents the correspondence between the electrode number displayed in the CARTO™ 3 System and the Recording System.

REP9626: V7 1.8.1 (From OCTARAY)

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*   * Verify that the recording system configuration is correct. Incorrect configuration may result in noise on the signals or stimulation routing to the wrong electrode. * Do not pace through or connect 20 POLE A channels 17-20 to the Recording System. |

Table 2: Recording System Connections

| Electrode# | PIU Socket | Electrode# | PIU Socket |
| --- | --- | --- | --- |
| A1 | 20 POLE A MAG\_1 | D1 | 20 POLE A MAG\_4 |
| A2 | 20 POLE A MAG\_8 | D2 | 20 POLE A MAG\_9 |
| A4 | 20 POLE B MAG\_20 | D4 | 20 POLE A MAG\_14 |
| A5 | 20 POLE B MAG\_15 | D5 | 20 POLE A MAG\_15 |
| A7 | 20 POLE A MAG\_11 | D7 | 20 POLE B MAG\_10 |
| A8 | 20 POLE B MAG\_6 | D8 | 20 POLE B MAG\_3 |
| B1 | 20 POLE A MAG\_2 | E1 | 20 POLE A MAG\_5 |
| B2 | 20 POLE A MAG\_7 | E2 | 20 POLE A MAG\_12 |
| B4 | 20 POLE B MAG\_19 | E4 | 20 POLE B MAG\_18 |
| B5 | 20 POLE B MAG\_16 | E5 | 20 POLE B MAG\_13 |
| B7 | 20 POLE B MAG\_12 | E7 | 20 POLE B MAG\_7 |
| B8 | 20 POLE B MAG\_5 | E8 | 20 POLE B MAG\_2 |
| C1 | 20 POLE A MAG\_3 | F1 | 20 POLE A MAG\_6 |
| C2 | 20 POLE B MAG\_2 | F2 | 20 POLE A MAG\_11 |
| C4 | 20 POLE A MAG\_13 | F4 | 20 POLE B MAG\_17 |
| C5 | 20 POLE A MAG\_16 | F5 | 20 POLE B MAG\_14 |
| C7 | 20 POLE B MAG\_9 | F7 | 20 POLE B MAG\_8 |
| C8 | 20 POLE B MAG\_4 | F8 | 20 POLE B MAG\_1 |

## Troubleshooting

https://bwiildita.sharepoint.com/sites/prod/Topics/OPTRELL\_48\_Troubleshooting\_8p2\_EN.xml

| Issue | Workaround | Number |
| --- | --- | --- |
| False positive Tissue Proximity Indication may appear on random OPTRELL™ Mapping Catheter electrodes after pacing is routed to the OPTRELL™ Mapping Catheter. | Set routing to None and then move the catheter to refresh the Tissue Proximity Indication. | 198005 |
| When displaying electrode numbers, if the Odd option is selected, even electrode numbers are displayed. If the Even option is selected, odd electrode numbers are displayed. | Be aware that this occurs. | 198073 |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![_TBCO11;B=20;W=168.00pt;H=39.75pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5404-018HREV01A](data:None;base64...)

![](data:image/png;base64...)