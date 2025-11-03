|  |
| --- |
| CARTOSOUND™ FAM Module |
| Instructions for Use and Release Notes |
|  |

|  |
| --- |
| () |
| September 2025 |
|  |

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

21 September 2025

Table of Contents

[Overview 1](#_Toc209356328)

[Module Development 1](#_Toc209356329)

[Working with the CARTOSOUND™ FAM Module 2](#_Toc209356330)

[Supported Ultrasound Systems 3](#_Toc209356331)

[Safety Considerations 4](#_Toc209356332)

[CARTOSOUND™ FAM Module Warnings 4](#_Toc209356333)

[CARTOSOUND™ FAM Module Installation 5](#_Toc209356334)

[Starting the CARTOSOUND™ FAM Module 6](#_Toc209356335)

[Beginning a New Study with the CARTOSOUND™ FAM Module 6](#_Toc209356336)

[The Ultrasound Window 7](#_Toc209356337)

[Setting Frame Gating 9](#_Toc209356338)

[Editing and Adding Input Frames 10](#_Toc209356339)

[The Point List 11](#_Toc209356340)

[Performing a Study with the CARTOSOUND™ FAM Module 13](#_Toc209356341)

[Guidelines and Limitations 13](#_Toc209356342)

[Recommended Workflow for a CARTOSOUND™ FAM Study 16](#_Toc209356343)

[Troubleshooting 20](#_Toc209356344)

# Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Overview\_V8\_EN.xml

REP12775 1.0: 6.1

The CARTOSOUND™ FAM Module is used to reconstruct an editable 3D volume with automatic 3D segmentation of the Left Atrium (LA) anatomies—LA Body, LA Appendage (LAA), Left Superior Pulmonary Vein (LSPV), Right Superior Pulmonary Vein (RSPV), Left Inferior Pulmonary Vein (LIPV), and Right Inferior Pulmonary Vein (RIPV)—based on a series of 2D ultrasound gated input frames acquired from the Right Atrium (RA, Fossa Ovalis) and the Right Ventricular Outflow Tract (RVOT). The input frames are taken from user-acquired clips and gated by default to the end-expiration phase and to the LA max volume (end of the T wave ±2 frames).

The CARTOSOUND™ FAM Module simplifies the workflow of ultrasound-based cardiac anatomy mapping by eliminating manual contouring and providing an enhanced Fast Anatomical Mapping (FAM) workflow. The CARTOSOUND™ FAM Module incorporates a Deep Learning (DL) algorithm developed by Siemens Healthineers.

In addition to the 3D volume reconstructed, the CARTOSOUND™ FAM Module identifies the LA anatomies using automatic contouring overlaid on the corresponding 2D ultrasound frames and provides 3D automatic segmentation and tagging of the relevant anatomies.

The CARTOSOUND™ FAM map is used as a baseline reconstruction of the LA chamber. The acquired volume can be further optimized using existing CARTO™ 3 System FAM mapping tools, including magnetic sensor based navigational catheters.

![CSoundFAM_uls8_3D_Reconstruction.png](data:image/png;base64...)

Figure 1: CARTOSOUND™ FAM Module 3D Reconstruction

The CARTOSOUND™ FAM Module is an automated version of the CARTOSOUND™ Module and requires the CARTOSOUND™ Module to be installed and activated. Refer to the *CARTOSOUND™ Module User Guide* for detailed instructions on using the CARTOSOUND™ Module.

## Module Development

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Module\_Development\_EN.xml

The CARTOSOUND™ FAM Module incorporates a Deep Learning (DL) algorithm developed by Siemens Healthineers. Data for training and validation of the DL algorithm was collected from diverse locations and populations, using a variety of ultrasound system settings, scanners, and Catheters.

LA volume is recommended as a reliable indicator of LA size. In the reviewed literature, the calculated LA volume range is 51.6 ml to 209.7 ml.

The database of reviewed studies used for the CARTOSOUND™ FAM Module's DL algorithm comprised 607 patients broken down as described in [Table 1: " Average, Standard Deviation, and Range of LA volume in Training, Testing, and Validation Datasets"](#target9000001).

Table 1: Average, Standard Deviation, and Range of LA volume in Training, Testing, and Validation Datasets

| Database | Number of cases (% of total cases) | LA Volume (AVG ± SD) | Range (AVG ± 1.96\*SD) |
| --- | --- | --- | --- |
| Training Set | 544 (90%) | 96.35 ml ± 31.83 ml | 33.61 ml–158.7 ml |
| Testing Set | 41 (6%) | 103.35 ml ± 24.87 ml | 54.6 ml–152.1 ml |
| Validation Set | 22 (4%) | 129.63 ml ± 30.11 ml | 70.6 ml–188.6 ml |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  For the LA volume range values, measurements of average ±1.96 standard deviation (95% confidence interval) should be used. To calculate LA Volume range values, 1.96 SD is subtracted/added from/to the Average, accordingly. |

## Working with the CARTOSOUND™ FAM Module

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Concept\_V8\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  This section describes a general workflow using the CARTOSOUND™ FAM Module. For step-by-step instructions, see ["Recommended Workflow for a CARTOSOUND™ FAM Study"](#target9000002). |

Input Frames for reconstruction and segmentation are taken from user-acquired ultrasound video clips that visualize the LA anatomies. When you acquire an ultrasound video clip with the CARTOSOUND™ FAM Module, an ultrasound frame is gated by default to the end-expiration phase and to the maximal LA volume (end of the T wave ±2 frames), according to default system settings. You can change the default settings for all gated input frames (see ["Setting Frame Gating"](#target9000003)). In any clip, you can select a frame that better reflects the maximal volume of the LA or the visualized anatomy or add input frames (see ["Editing and Adding Input Frames"](#target9000004)).

REP14517 ID# D-13, D-20, CARTOSOUND FAM FRS, ID# 394

For best results, acquire clips as follows:

* At least 2-3 frames with good visualization of the PVs and LAA Ostia.
* At least 5-8 frames with good visualization of the LA Body and roof.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The CARTO™ 3 System will not display a 3D reconstruction of other anatomical structures without sufficient ultrasound imaging.   REP15522 slide 6   * In the segmentation, if a Left Common PV (LCPV) is identified, the LSPV and LIPV are combined into an LCPV. |

Input Frames are added to the active FAM map, displayed in the Point List, and tagged (see ["The Point List"](#target9000005)). Input Frames can be moved and copied between maps. Deleted Input Frames can be restored from the Recycle Bin.

Once you have at least 10 frames, you can create a model of the mapped anatomy based on the ultrasound images. After the model is reconstructed in the Main viewer, the frames used for the reconstruction are marked UF (Used Frame) in the Point List. Segmented anatomies are displayed without anatomical structure coloring, by default. The LAA reconstruction is not displayed, by default. (That is, the LAA appears cut off by the anatomical structure curve). You can set how anatomical structures are displayed from the Display menu.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The FAM map can be displayed in the Stable visualization mode only. * The fan can be displayed in either real-time or Gated visualization mode. |

## Supported Ultrasound Systems

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Compatible\_Sys\_V8\_EN.xml

The CARTO™ 3 System can display ultrasound images acquired from a compatible ultrasound system.

REP12775, 7.3.1.2

The CARTOSOUND™ FAM Module has been optimized for use with one of the following ultrasound system models[[1]](#footnote-1):

* Siemens ACUSON SC2000™ Ultrasound System
* Siemens ACUSON P500™ Ultrasound System
* Siemens ACUSON Origin™ Ultrasound System
* GE Healthcare's Vivid™ iq and Vivid™ S70/S60/S70N/S60N ultrasound systems

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The CARTO™ 3 System displays a notification if the ultrasound images are *not* acquired from one of the recommended ultrasound systems. * The CARTOSOUND™ FAM Module supports Standard View modes only. All other modes, such as Flip, Upside-down, Doppler, Dual or Quad are *not* supported. |

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Using an ultrasound machine that is not listed here might produce lower quality images and affect the quality of the CARTOSOUND™ FAM reconstruction. |

# Safety Considerations

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Safety\_EN.xml

When using the System with the CARTOSOUND™ FAM module, all instructions relating to use of the CARTOSOUND™ FAM Module must be followed to ensure proper accuracy and safety.

Refer to the CARTO™ 3 System *Instructions for Use* for additional safety information.

## CARTOSOUND™ FAM Module Warnings

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Warnings\_V8\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO™ 3 System also apply while using this module. In addition, the following considerations apply:

* Always verify the mapping catheter tip position in relation to the ultrasound contours in the map:
  + When working with maps that combine 3D reconstructions based on ultrasound data (model or contours) with standard mapping points.
  + When comparing the display in the Main Map Viewer with the anatomy as displayed in ultrasound frame images.
  + Before applying RF energy.
* Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.). Failure to do so might result in incorrect placement of the catheter.

REP14517 ID# D-13

* If anatomical coverage is limited, the CARTOSOUND™ FAM Module might create a less predictable map. Validate the reconstruction and modify as needed.

REP14517 ID# D-14, D-15

* Frame gating is dependent on the respiratory cycle identified by the ACCURESP™ Module. Additionally, the respiratory cycle may affect the identified reference annotation in the end-expiration phase. Train respiration gating before acquiring input frames and to validate the reconstruction and modify as needed.
* The CARTOSOUND™ FAM Module has been validated for use with the ultrasound systems specified in ["Supported Ultrasound Systems"](#target9000006). Images received from other ultrasound systems might result in inaccurate reconstruction. Verify that you are working with a supported ultrasound system.

REP14517 ID# D-18

* Ultrasound imaging depth must be within a range of 90-120 mm. Depths exceeding this range may result in less spatial detail, resulting in reconstruction that requires additional mapping.

REP14517 ID# D-19

* Input frames must have optimal image quality of the visualized LA anatomies. Inferior image quality might result in a less predictable map that might be smaller or larger than the actual anatomy.

REP14517 ID# D-20, D-21, D-22

* Always validate the 3D reconstruction, 2D contours, auto-segmentation and tagging before performing ablation.

# CARTOSOUND™ FAM Module Installation

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Module\_Installation\_EN.xml

A Biosense Webster representative is responsible for the installation and initial configuration of the module.

The use of the CARTOSOUND™ FAM Module requires that the basic CARTOSOUND™ Module be installed, activated, and that the CARTO™ 3 System be configured by a Biosense Webster representative to work with the ultrasound system used on site.

# Starting the CARTOSOUND™ FAM Module

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Starting\_Module\_EN.xml

A study with the CARTOSOUND™ FAM Module is started in the Study Setup screen.

Interactivity with the Ultrasound Window and its commands is enabled when a supported catheter from the SOUNDSTAR™ Ultrasound Catheter family (referred to as the SOUNDSTAR™ Catheter) is detected by the CARTO™ 3 System.

## Beginning a New Study with the CARTOSOUND™ FAM Module

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_UltrasoundStudy\_beginNew\_v8\_EN.xml

|  |  |  |  |
| --- | --- | --- | --- |
| 1. | Connect the SOUNDSTAR™ Catheter to the ULTRASOUND Catheter Socket on the PIU via the SOUNDSTAR™ Catheter extension cable.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  You can begin a study without a mapping catheter connected. | |
| 2. | In the Connected Machines field of the Study Setup Guide, select the specific ultrasound system being used for the study.  ![studySetup_ultrasoundList_v8.png](data:image/png;base64...)   * Available options depend on the ultrasound system(s) installed. * The default setting is <No Ultrasound>.  |  |  | | --- | --- | | ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Even if you have several systems of the same model at your site, each ultrasound system is set up with its own specific operating parameters when installed. In the Study Setup screen, verify that the selected ultrasound system is the system that you will work with. Failure to select the correct ultrasound option in the Study Setup screen might affect CARTO™ 3 System performance. | |
| 3. | In the Map Setup screen, set the following:   * Map Type – set to FAM * Reference Channels – it is recommended to set BS II (with or without ARA) as the reference channel.  |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If using a different channel, it is recommended to offset the reference in the Frame Gating settings so that gating will still be at maximal LA volume (end of the T wave ±2 frames). |   Proceed with other Setup screens as for a standard CARTO™ 3 Study.  Only 1 map is required for a CARTOSOUND™ FAM study. |
| 4. | Click Initialize in the Map Setup screen. |
| 5. | In the Mapping View, open the ultrasound window in one of the following ways:   * ![layoutButton.png](data:image/png;base64...) Select the U/S, Main Map, Point List pre-defined layout * From the Window menu, select Ultrasound Window   The Ultrasound window appears. |

## The Ultrasound Window

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_UltrasoundViewer\_v8\_EN.xml

When using the CARTOSOUND™ FAM Module, the Ultrasound window provides the following functions:

* Acquiring 3-second ultrasound clips with an input frame that is gated by default to the end-expiration phase and to the LA max volume (end of the T wave ±2 frames).
* Adjusting the Frame Gating to a frame that reflects the maximal volume of the LA, if there is a clearer frame in the clip or adding Input Frames.
* Creating the CARTOSOUND™ FAM 3D reconstruction based on the acquired input frames.
* Displaying automatic 2D contours added to the corresponding 2D ultrasound frame and assigning them to the active map for overlaid display in the 3D reconstruction. The 2D contour represents the cross section of the corresponding 2D ultrasound frame and the 3D reconstruction.
* CARTOSOUND™ Module functionality available with the CARTOSOUND™ FAM Module: marking manual contours on the ultrasound image and assigning them to the active map for overlaid display in the 3D reconstruction.

![CSoundFAM_uls_window_v8.png](data:image/png;base64...)

Figure 2: Ultrasound window with CARTOSOUND™ FAM

| Icon | Function |
| --- | --- |
| ![tools_general.png](data:image/png;base64...) | Open a list of map display options. (Refer to the CARTOSOUND™ Module User Guide.) |
| ![CSoundFAM_Acquire_button.png](data:image/png;base64...) | Pause the ultrasound image and create a 3-second video clip.  When paused, the button changes to ![CSoundFAM_Continue_button.png](data:image/png;base64...). Click to resume the live ultrasound image display. |
| ![CSoundFAM_NF_indicator.png](data:image/png;base64...) | Indicates the number of Input Frames created. |
| ![uls8_FAM_frame_settings.png](data:image/png;base64...) | Display and modify the Frame Gating settings.  See ["Setting Frame Gating"](#target9000007). |
| ![CSoundFAM_CreateModel_button.png](data:image/png;base64...) | Create a 3D reconstruction of the anatomies based on the acquired Input Frames. This button is enabled after 10 input frames are created. |
| ![uls7-5_select_ECGchannel.png](data:image/png;base64...) | Open a drop-down menu to select one additional ECG channel to display beneath the Reference Channel. |
| ![uls7-5_playback.png](data:image/png;base64...) | Start/stop the 3-sec video clip playback. The slider indicates the current frame. |
| ![SND_FAM_ULS_error_mode.png](data:image/png;base64...) | Error mode icon when in Live mode but the ultrasound is not available. |
| 1 | Live - indicates real-time images streaming from the ultrasound system. When the image is live, a solid yellow line frames the Ultrasound Viewer.  Review - indicates the displayed image is an acquired clip. When the image is in Review mode, a dashed yellow line frames the Ultrasound Viewer. |
| 2 | The Ultrasound window Toolbar, with options for creating/editing/deleting manual contours (refer to the CARTOSOUND™ Module User Guide). When working in the CARTOSOUND™ FAM Module, manual contours can be assigned to a map, but only as floating contours. |
| 3 | Show or hide contours. |
| 4 | Show or hide the selected frame in any map viewer. |
| 5 | CL displays the current cycle length of the currently displayed frame. |
| 6 | Reference channel of the current clip. |
| 7 | This bar represents the timeline of the 3-sec video clip. After respiration gating is trained the bar is colored yellow/orange to reflect the respiration gating status. |
| 8 | The blue line shows the gated input frame.  If you return to live mode to acquire another clip, this will be the input frame that is used.  If you use the slider at the bottom to select a different frame and approve it using the green check mark, the input frame is updated.  You can add input frames for a clip.  See ["Editing and Adding Input Frames"](#target9000008). |

## Setting Frame Gating

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Setting\_Gating\_Default\_EN.xml

When you acquire a clip, an Input Frame is gated to the end-expiration phase and to the maximal LA volume (end of the T wave ±2 frames), according to the default Frame Gating settings.

You can change the default settings if required, as follows:

|  |  |
| --- | --- |
| 1. | After acquiring a clip, in the Ultrasound viewer, click ![uls8_FAM_frame_settings.png](data:image/png;base64...) to display the Frame Gating settings.  ![CSoundFAM_Frame_Gating_Settings_v8.png](data:image/png;base64...) |
| 2. | From the list, select the gating method:   * % shift of CL * mSec shift of CL |
| 3. | Set a value for a percentage or specified milliseconds relative to the Cycle Length. |
| 4. | If you want the input frame to be calculated only after the respiration phase is final (with a delay of up to 3 seconds), select the Verified Respiration check box.  If you want the input frame to be calculated as soon as the clip is acquired, leave the Verified Respiration check box cleared. |
| 5. | Click OK to activate the new settings or click Cancel to return to the previous settings. |

## Editing and Adding Input Frames

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Editing\_Frames\_EN.xml

After acquiring a clip, the frame determined by the Frame Gating settings is displayed with a blue slider with the Reference Channel.

![CSoundFAM_Default_gated_frame.png](data:image/png;base64...)

Figure 3: Default Frame Gating

To delete the frame, click the red **X**. Deleted frames are moved to the Recycle Bin but can be restored.

If you click Continue to return to Live mode without canceling, the frame is saved.

To select a different frame as the input frame, adjust the slider position. The new frame is marked with a dotted line until you click the green check mark to save it. Click **+** to keep the original frame and add the selected frame as an additional frame. You can add frames from the same clip in this way, until you are ready to click Continue to return to Live mode and acquire additional clips.

![CSoundFAM_Add_Gated_Frame.png](data:image/png;base64...)

Figure 4: Editing Frame Gating

## The Point List

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_AutoTagging\_EN.xml

Before Model creation, input frames are displayed in the Point List with a New Frame (NF) tag. After 3D Model reconstruction, the tag on the input frames changes to UF to signify Used Frame.

After 3D reconstruction, input frames with contours of the detected anatomical structures are added to the Point List, with a tag in the Tag column specifying the anatomical structure.

![CSoundFAM_PointList.png](data:image/png;base64...)

Figure 5: Point List After Model Creation

In Review mode, when you select a frame with anatomical tagging, the frame is displayed in the Ultrasound viewer displaying the anatomical structure contour with coloring specified in the Contour Tag dialog box.

|  |  |
| --- | --- |
| ![contour_tag_db_7-5.png](data:image/png;base64...)  Figure 6: Contour Tag dialog box (Basic)  Click ![expand.png](data:image/png;base64...) to expand the dialog box and enable Tag Setup. | ![tagSetup7-5.png](data:image/png;base64...)  Figure 7: Tag Setup (Expanded) |

# Performing a Study with the CARTOSOUND™ FAM Module

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_Performing\_a\_Study\_Title\_EN.xml

Mapping with the CARTOSOUND™ FAM module can be performed using only the SOUNDSTAR™ Catheter connected, or with both a SOUNDSTAR™ Catheter and a standard mapping catheter.

## Guidelines and Limitations

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_SupportedViews\_Limitations\_EN.xml

Source: CartoSound FAM 2D ICE Auto Contouring Atlas

The CARTOSOUND™ FAM Module has been trained for most standard LA views for atrial fibrillation procedures.

| Supported View | Recommendation | Example |
| --- | --- | --- |
| Left Atrial Appendage | The LAA is seen by rotating the catheter clockwise from the Home View (Right Atrium/Fossa Ovalis).  The inter-atrial septum (IAS), mitral valve (MV), and LAA will usually come into view just past the left ventricular outflow tract (LVOT). The LAA is visualized in the same plane as the MV and will appear as an "out-pouching" from the LA. | ![ULS_LAA_view.png](data:image/png;base64...) |
| Left Pulmonary Vein | From the LAA view, rotate the catheter clockwise (posterior) to see the anterior ostium of the left pulmonary veins (LPVs). The left inferior pulmonary vein (LIPV) and the left superior pulmonary vein (LSPV) are usually seen in the same place. Occasionally you will only see one pulmonary vein. | ![ULS_1LPV_view.png](data:image/png;base64...) |
|  | Slight clockwise rotation will open both PVs into the "pant leg" view. This will show the mid-level ostium of the LPVs. | ![ULS_2LPVs_view.png](data:image/png;base64...) |
|  | Continued clockwise rotation past the "pant leg" view will show the posterior ostium of the PVs. | ![ULS_PV_Posterior_Ostium_view.png](data:image/png;base64...) |
| Left Atrial Posterior Wall | From the LPVs, rotate the catheter clockwise (posterior). Acquire 1-2 frames ensuring full coverage of the posterior wall. Begin just posterior to the posterior ostium of the LPVs. | ![ULS_LA_Posterior_Wall_view.png](data:image/png;base64...) |
|  | Continue slight clockwise rotation to visualize the mid posterior wall in multiple planes. Structures visualized from this position could include the esophagus and the descending aorta. | ![ULS_LA_Posterior_Wall2_view.png](data:image/png;base64...) |
|  | Continue clockwise rotation just past the mid-point to acquire a frame of the right side posterior wall, just before the right PVs. | ![ULS_LA_Right_Posterior_Wall_view.png](data:image/png;base64...) |
| Right Pulmonary Vein | Advance the catheter higher in the right atrium (RA) to the level of the superior vena cava (SVC) and clockwise slightly past the posterior wall to visualize the posterior ostium of the RPVs. Visualize landmarks such as the right pulmonary artery to ensure that you are high enough in the RA. | ![ULS_RPV1_view.png](data:image/png;base64...) |
|  | Rotate the catheter clockwise and apply right steering to get the long axis of the RPVs. | ![ULS_RPV2_view.png](data:image/png;base64...) |
|  | In the neutral position (with no tilt applied), continue to rotate the catheter clockwise towards the SVC to view the distal portion of the RSPV. | ![ULS_Distal_RSPV_view.png](data:image/png;base64...) |
| Anterior Wall and Roof of Left Atrium | With the catheter positioned high in the RA, rotate the catheter counterclockwise from the RPVs to visualize the anterior wall and the roof of the LA. | ![ULS_LA_AnteriorWall_Roof_view.png](data:image/png;base64...) |
|  | Additionally, you can apply a slight posterior tilt to lean the catheter away from the septum and better visualize the LA roof. | ![ULS_LA_AnteriorWall_Roof2_view.png](data:image/png;base64...) |
| Mid-Ridge | From the right ventricular outflow tract (RVOT), rotate the catheter clockwise posteriorly until the left atrium appears in view. | ![ULS_LA_from_RVOT_view.png](data:image/png;base64...) |
|  | From the RVOT at the mid-point of the LA, continue clockwise rotation superiorly to view the high ridge; the Aortic Valve, the Pulmonary Artery, the Coumadin ridge, LAA, and LSPV. | ![ULS_LA_High_Ridge_view.png](data:image/png;base64...) |

CARTOSOUND™ FAM Module Limitations

FRS #530, REP14517 ID# D-19

The CARTOSOUND™ FAM Module does not support:

* Left Ventricle (LV) imaging
* Esophagus imaging
* Views of the LIPV with the LAA from the Right Ventricular Outflow Tract (RVOT)
* Views with large Right Pulmonary Arteries and with relatively little of the LA or RSPV
* LA with and uncommon anatomical variation (for example, Middle Right Pulmonary Vein (MRPV), 5th PV, or Roof/Chimney veins)
* Views acquired from inside the LA
* Images acquired from the upper part of the Superior Vena Cava (SVC)
* Frames with color and other Doppler imaging modes

The CARTOSOUND™ FAM Module does not support imaging of other Catheters or medical devices within the Field of View (FOV).

![CSoundFAM_CatheterInView.png](data:image/png;base64...)

Figure 8: Devices in Ultrasound System Image

CARTOSOUND™ FAM Module Input frames must fulfill the following conditions:

* Blood pool and tissue in the image must be well-delineated (minimize the noise in the image)
* Images acquired with a scanning depth in the range of 90-120 mm

## Recommended Workflow for a CARTOSOUND™ FAM Study

https://bwiildita.sharepoint.com/sites/prod/Topics/CSoundFAM\_UltrasoundStudy\_Perform\_V8\_EN.xml

An ultrasound study is performed with the SOUNDSTAR™ Catheter, for diagnostic purposes. Later in the study, you can connect an ablation mapping catheter for therapeutic purposes.

You can work with both catheters connected, or with only one catheter connected.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  It is recommended to work using the SOUNDSTAR™ Catheter for mapping, before placing another catheter in the heart. This prevents possible artifacts that could interfere with interpretation of the edges of the ultrasound images. |

|  |  |
| --- | --- |
| 1. | Prepare the patient as for a standard CARTOSOUND™ Procedure. |
| 2. | Turn on the ultrasound system and proceed as follows:   |  |  | | --- | --- | | 2.1 | Connect the SOUNDSTAR™ Catheter to the ultrasound system as per that system's instructions. | | 2.2 | Select the correct work mode and presets on the ultrasound system. | |
| 3. | Connect the SOUNDSTAR™ Catheter to the ULTRASOUND socket on the PIU. |
| 4. | Tune the ultrasound system scanner for optimal image quality of the visualized LA anatomies.  Recommended ultrasound scanning depth is within a range of 90-120 mm.  REP14517 ID# D-18,19 |
| 5. | Set up the study in the Study Setup and Map Setup screens, as described in ["Beginning a New Study with the CARTOSOUND™ FAM Module"](#target9000009). |
| 6. | Verify that Show Fan Outline is enabled in the Ultrasound window Tools. |
| 7. | Train the ACCURESP™ Module.  REP14517 ID# D-16 |
| 8. | Navigate the SOUNDSTAR™ Catheter gently to the RA (Fossa Ovalis) and/or the RVOT and rotate (clockwise or counterclockwise) to visualize each of the inner anatomical structures.   |  |  | | --- | --- | | ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Acquire ultrasound clips and frames according to the guidelines described in ["Guidelines and Limitations"](#target9000010). Acquiring ultrasound clips from unspecified locations may result in incorrect map reconstruction. | |
| 9. | In the Ultrasound window, click Acquire to acquire an ultrasound clip.  An Input Frame is gated according to the settings. |
| 10. | If required, modify the Input Frame or add a New Input Frame by selecting the best anatomical frame at maximal volume available in the end-expiration phase or add input frames to the clip (see ["Editing and Adding Input Frames"](#target9000011)).  REP14517 ID# D-14  The Input Frame is added to the map and displayed in the Point List. |
| 11. | Continue acquiring clips and adding New Input Frames that cover the required anatomy needed to create the reconstruction, until Create Model is enabled.  ![CSoundFAM_uls8_before_3D_Reconstruction.png](data:image/png;base64...)  Acquire at least 2-3 frames with good visualization of each LA structure: LAA, RSPV, RIPV, LSPV, and LIPV and 5-8 frames for the LA Body and roof. All frames must have good visualization of the PVs and LAA Ostia as described in ["Guidelines and Limitations"](#target9000012).  It is recommended to acquire additional frames visualizing the LAA ostium/ridge and LSPV from the RVOT.  Ensure good coverage of the entire LA chamber.  There must be a minimum of 10 Input Frames to activate the Create Model button.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The CARTOSOUND™ FAM Module can take up to 1 minute to create the reconstruction. To cancel model creation, click Cancel Auto-Detection. | |

The reconstruction is displayed in the Main Map viewer. Segmented anatomies are displayed without 2D contouring or anatomical structure coloring, by default. The LAA reconstruction is not displayed, by default. (That is, the LAA appears cut off by the anatomical structure curve).

![snd_Reconstruction_with_Segmentation_Displayed_LAA_Hidden.png](data:image/jpeg;base64...)

Figure 9: Example of Reconstruction with Segmentation Displayed and LAA Hidden

To set how anatomical structures are displayed, select Display > Anatomical Structure and display the required anatomies.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  The displayed segmentation lines between the LA and its adjacent anatomies do not signify ablation lines.  REP14517 #D21 |

# Troubleshooting

https://bwiildita.sharepoint.com/sites/prod/Topics/Troubleshooting\_CSoundFAM\_V8\_EN.xml

Table 2: Known Issues

| Issue | Workaround | Number |
| --- | --- | --- |
| When using a Vivid™*iq* ultrasound system, CARTOSOUND™ FAM may fail to run a second time after adding frames in the RVOT view. | N/A | 203251 |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) | Yokneam 2066717 |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![_TBCO11;B=20;W=176.25pt;H=39.75pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5462-0182HREV01A](data:None;base64...)

![](data:image/png;base64...)

1. Consult your Biosense Webster representative regarding the availability of compatible devices in your country. [↑](#footnote-ref-1)