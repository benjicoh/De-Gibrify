|  |
| --- |
|  |
| Instructions for Use and Release Notes |
|  |

|  |
| --- |
| () |
| September 2025 |
|  |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © 2024 - 2025 by Biosense Webster, Inc. All rights reserved.

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

25 September 2025

Table of Contents

[Overview 1](#_Toc209692161)

[Functional Principles of PFA 1](#_Toc209692162)

[Indications For Use 1](#_Toc209692163)

[VARIPULSE™ Catheters 1](#_Toc209692164)

[TRUPULSE™ Generator 2](#_Toc209692165)

[About This Document 2](#_Toc209692166)

[Safety Information 3](#_Toc209692167)

[Potential Adverse Events 4](#_Toc209692168)

[Generator Connections 5](#_Toc209692169)

[Generator Connection Status 5](#_Toc209692170)

[TRUPULSE™ Status Window 7](#_Toc209692171)

[TRUPULSE™ Generator Connection 7](#_Toc209692172)

[MultiGen Support 8](#_Toc209692173)

[MultiGen Connections 9](#_Toc209692174)

[Setup When Starting with PFA 11](#_Toc209692175)

[Switching from PFA to RFA During a Study 12](#_Toc209692176)

[Switching from RFA to PFA During a Study 13](#_Toc209692177)

[Troubleshooting Generator Connections 13](#_Toc209692178)

[CARTO™ 3 System Interface with VARIPULSE™ Catheter 15](#_Toc209692179)

[Catheter Setup Screen 15](#_Toc209692180)

[Catheter Visualization 18](#_Toc209692181)

[TPI for the VARIPULSE™ Catheter 20](#_Toc209692182)

[VARIPULSE™ Catheter TPI Calibration 21](#_Toc209692183)

[Proximity Indicators for the VARIPULSE™ Catheter 24](#_Toc209692184)

[PFA Sessions 26](#_Toc209692185)

[Readings Dashboard 26](#_Toc209692186)

[Graphs Viewer 28](#_Toc209692187)

[Viewing Signals 29](#_Toc209692188)

[VISITAG™ Sessions with PFA 30](#_Toc209692189)

[VISITAG™ Toolbar 30](#_Toc209692190)

[PFA Preferences 32](#_Toc209692191)

[Connecting Line Indication 35](#_Toc209692192)

[Grids 36](#_Toc209692193)

[Grid Overlap Indication 37](#_Toc209692194)

[Cumulative Data Window 38](#_Toc209692195)

[Manual Point Acquisition 40](#_Toc209692196)

[Map Merge with PFA Support 41](#_Toc209692197)

[General Workflow for the VARIPULSE™ Catheter 42](#_Toc209692198)

[PFA Data Files 43](#_Toc209692199)

[AblationData\_PFA.txt 43](#_Toc209692200)

[Applications\_PFA.txt 44](#_Toc209692201)

[Grids\_PFA.txt 44](#_Toc209692202)

[Sites\_PFA.txt 45](#_Toc209692203)

[VisiTagSessions\_PFA.txt 46](#_Toc209692204)

[Error Handling 47](#_Toc209692205)

[Troubleshooting 48](#_Toc209692206)

# Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/Overview\_PFA\_v8\_EN.xml

The CARTO™ 3 System V8 with Pulsed Field Ablation (PFA) Support enables CARTO™ 3 System procedures with catheter visualization, mapping, and PFA when using a VARIPULSE™ Catheter and TRUPULSE™ Generator.

The CARTO™ 3 System V8 supports PFA when used with a compatible version of the TRUPULSE™ Generator.

## Functional Principles of PFA

https://bwiildita.sharepoint.com/sites/prod/Topics/IRE\_PFA\_FUNCTION\_EN.xml

PFA for cardiac applications employs high voltage and very short duration pulses (PF energy), by a dedicated generator (TRUPULSE™), which results in destabilization of the cellular membranes, creating pores (electroporation) and ultimately leading to cell death.

This CARTO™ 3 System software version supports the TRUPULSE™ Generator. The TRUPULSE™ Generator is a specialized device that delivers pulsed electrical energy which, when used with a compatible catheter, produces electric fields intended to ablate intracardiac tissue, resulting in PFA.

## Indications For Use

https://bwiildita.sharepoint.com/sites/prod/Topics/Indications\_For\_Use\_EN.xml

The intended use of the CARTO™ 3 System is catheter-based cardiac electrophysiological (EP) procedures. The CARTO™ 3 System provides information about the electrical activity of the heart and about catheter location during the procedure. The system can be used on patients who are eligible for a conventional electrophysiological procedure.

The system has no specific contraindications.

## VARIPULSE™ Catheters

https://bwiildita.sharepoint.com/sites/prod/Topics/catheters\_PFA\_varipulse\_EN.xml

This version supports VARIPULSE™ Bi-Directional Catheters, when used with the TRUPULSE™ Generator.

The VARIPULSE™ Bi-Directional Ablation Catheter is a steerable, multi-electrode, circular loop-shaped irrigated catheter with ten electrodes. The distal catheter shaft can be deflected bidirectionally, and the circular loop can be contracted or expanded. The catheter can be used for standard functionality such as FAM acquisition, EA MEM point acquisition, pacing, and building the visualization matrix.

REP14517 A-32

The TRUPULSE™ Generator connects to the CARTO™ 3 System PIU through the 20 POLE A/20 POLE B sockets. See ["Catheter Setup Screen"](#_Catheter_Setup_Screen).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If pacing is routed to the VARIPULSE™ Catheter through the CARTO™ 3 System or recording system, the TRUPULSE™ Generator prevents ablation from this catheter. |

REP14517 D-68

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  During, and shortly after PF application, other catheters might erroneously interpret a PFA noise artifact as pacing. To avoid this, keep other catheters at a distance, or not in the same chamber as the PFA Catheter during PFA. If an erroneous annotation is recorded, it can be deleted. |

Contact your Biosense Webster representative for details of compatible catheters that are available in your country.

## TRUPULSE™ Generator

https://bwiildita.sharepoint.com/sites/prod/Topics/generator\_PFA\_v8\_EN.xml

The TRUPULSE™ Generator can control the delivery of PFA energy to a compatible catheter. The generator includes a touch screen where the user can select the electrodes and apply ablations.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When the ablation electrode is not displayed in the CARTO™ System and the CARTO™ System displays an error, verify that the TRUPULSE™ Generator and the CARTO™ 3 System are connected. See ["Generator Connections"](#target9000002). |

## About This Document

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_About\_This\_Document\_EN.xml

This document provides information for the setup and operation of the CARTO™ 3 System with PFA Support.

* Refer to the *Instructions for Use* (IFU) of the catheter before using this catheter with the CARTO™ 3 System.
* Refer to the documentation provided with the TRUPULSE™ Generator before using the generator with the CARTO™ 3 System.

Some pictures might differ from the ones appearing in your system. However, functionality is the same.

# Safety Information

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Safety\_Info\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO™ 3 System also apply while using this module.

* Each catheter has indications, contraindications, and warnings or precautions that are specific to that catheter. Before using any catheter with the CARTO™ 3 System, please refer to the catheter's *Instructions for Use* (IFU) to obtain information relevant to that specific catheter.

REP14517 D-84 D-85

* The Max. distance value in the PFA Preferences defines the maximum stability distance between 3 applications. The algorithm might not always represent the actual location of the ablation, but rather an approximation. The ablation appears as not having passed the filter threshold if the distance between the 3 applications exceeds the Max. distance. Use common clinical judgment and standard workflow to identify ablation gaps.

REP14517 D-106 D-74 D-75

* Before ablating, visually verify the correctness of the position of the ablation catheter in relation to the required ablation site. Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.). Failure to do so might result in incorrect placement of the catheter.
* Refer to the *Instructions for Use* provided with the TRUPULSE™ Generator before using the generator with the CARTO™ 3 System.
* Refer to the *Instructions for Use* provided with the supported RF generator before using the generator with the CARTO™ 3 System.

REP14517 A-92 A-93

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When TPI filter is enabled, the Grid Overlap Indication is applied only for electrodes that are in proximity to the tissue. See ["PFA Preferences"](#target9000003) and ["Grid Overlap Indication"](#target9000004). |

REP14517 D-90 D-91

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  The Grid Overlap Indication is not related to respiratory gating locations, but rather it is based on the real-time electrode location. The indication takes into consideration only the grids that are associated with the active map.  The Grid Overlap Indication does not take RFA grid cells into account, and future grids that overlap previous RFA grid cells are colored green. The indication is in real-time and represents a rough indication of the location. It does not reflect the final PFA VISITAG™ / Grid location. See ["Grid Overlap Indication"](#target9000005). |

REP14517 D-107

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When the relative position between the patches remains the same but the position of the heart relative to the back patches has changed (for example, after repositioning the patient's head on a pillow or moving the patient's arm without changing the patient's position on the mattress, after the patient coughs, or after the patient is cardioverted), the system does not display a warning and an incorrect map (map shift) might be generated.  This misalignment might cause delivery of PF energy to the blood pool, resulting in excessive PFA delivery that might lead to hemolysis. |

## Potential Adverse Events

https://bwiildita.sharepoint.com/sites/prod/Topics/Potential\_Adverse\_Events\_EN.xml

A number of serious adverse reactions have been documented for catheter ablation procedures including pulmonary embolism, myocardial infarction, stroke, cardiac tamponade, and death. The following complications were also noted to have occurred during the Study or have been reported in the literature:

* **Catheterization/catheter procedure related:** Vascular bleeding/local hematomas, thrombosis, AV fistula, pseudoaneurysm, thromboembolism and vasovagal reactions, cardiac perforation, tamponade, thrombi, air embolism, arrhythmias and valvular damage, pneumothorax and hemothorax.
* **PFA related:** Chest pain/discomfort, ventricular tachyarrhythmia, transient ischemic attack (TIA), cerebrovascular accident (CVA), complete heart block, coronary artery spasm, coronary artery thrombosis, coronary artery dissection, cardiac thromboembolism, pericarditis, cardiac perforation/tamponade, valvular damage, hemolysis, acute renal failure, and increased phosphokinase level.

# Generator Connections

https://bwiildita.sharepoint.com/sites/prod/Topics/Connections\_PFA\_v8\_EN.xml

This version of the CARTO™ 3 System supports three generator configurations:

* TRUPULSE™ Generator only. See ["TRUPULSE™ Generator Connection"](#target9000006).
* RF generator only (nGEN™ or SMARTABLATE™). Refer to the documentation provided with the generator.
* Simultaneous connection of a TRUPULSE™ Generator and an RF generator (either nGEN™ or SMARTABLATE™). In this MultiGen configuration, **only one generator is connected to the PIU**, but both generators are connected to the CARTO™ Workstation **before the Initialization process**. The active generator is selected from the Tools menu. The default setting is TRUPULSE™.

The generators can be switched without exiting the study. See [MultiGen Support](#_MultiGen_Support).

The VARIPULSE™ Catheter connects to the TRUPULSE™ Generator.

The following workstations are supported in this version: HP Z4 G4, Dell 5820, and Dell 5860. For workstation-specific generator configurations, see ["TRUPULSE™ Generator Connection"](#target9000008) and ["MultiGen Connections"](#target9000009).

## Generator Connection Status

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Generator\_Connection\_Status\_EN.xml

A status icon appears in the System Status Panel to indicate the status of the selected generator, including current ablation mode.

![PFA_v8p2_PFA_Generator_Connected.png](data:image/png;base64...)

Figure 1: System Status Panel with PFA Ablation Indication

Table 1: System Status Icons

| Icon | Description |
| --- | --- |
| ![PFA_v8_Generator_Status_PFA1.png](data:image/png;base64...) | The TRUPULSE™ Generator is connected and is the selected generator. |
| ![PFA_v8_Generator_Status_PF_Disconnected1.png](data:image/png;base64...) | TRUPULSE™ Generator is not connected. |
| ![PFA_v8_Generator_Status_RF_Temp1.png](data:image/png;base64...) | The RF generator is connected and is the selected generator. The current ablation mode is Temperature. |
| ![PFA_v8_Generator_Status_RF_Power1.png](data:image/png;base64...) | The RF generator is connected and is the selected generator. The current ablation mode is Power. |
| ![PFA_v8_Generator_Status_Qmode1.png](data:image/png;base64...) | The RF generator is connected, and currently set to QMODE™ ablation mode. |
| ![PFA_v8_Generator_Status_Qmode+1.png](data:image/png;base64...) | The RF generator is connected, and currently set to QMODE+™ ablation mode. |
| ![PFA_v8_Generator_Status_RF_Disconnected.png](data:image/png;base64...) | The RF generator is not connected, |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The TRUPULSE™ generator does not recognize that the CARTO™ 3 System is connected until a CARTO™ 3 study is initialized. |

## TRUPULSE™ Status Window

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Trupulse\_Status\_Window\_EN.xml

The TRUPULSE™ Status window can be opened with the generator status icon and indicates if there is an error or warning in the generator.

![PFA_v8_Generator_Status_Error.png](data:image/png;base64...)

Figure 2: TRUPULSE™ Generator Connection Icon with Error Indication

Click the status icon to view the generator's status in the CARTO™ 3 System.

|  |  |
| --- | --- |
| ![PFA_v8_Generator_Status_Error_in_CARTO1.png](data:image/png;base64...) |  |
| Top section: Up to 3 rows of TRUPULSE™ Generator errors and warnings. |
| Center section: Irrigation and foot pedal status. |
| Lower section: Procedure information (collapsible). |
|  |

## TRUPULSE™ Generator Connection

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Trupulse\_Generator\_Connection\_EN.xml

For details regarding connection of other devices to the TRUPULSE™ Generator, refer to the documentation provided with the generator.

The TRUPULSE™ Generator connects to the CARTO™ 3 Workstation with an Ethernet cable, and to the PIU with a Generator to CARTO™ 3 System cable.

When the generator is connected, indication appears in the CARTO™ 3 System Status panel. See ["Generator Connection Status"](#target9000010).

If using the TRUPULSE™ Generator as a standalone generator (not part of a MultiGen configuration):

* Connect the TRUPULSE™ Generator from the CARTO™ 3 System socket on the generator to the 20 POLE A or 20 POLE B socket on the PIU.
* Connect the TRUPULSE™ Generator to the CARTO™ 3 Workstation with an ethernet cable - from the Docking Station Ethernet port on the generator, to the Navigant port on the Workstation.
* Connect the VARIPULSE™ Catheter to the Catheter socket on the TRUPULSE™ Generator.

## MultiGen Support

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_MultiGen\_Support\_EN.xml

MultiGen Support enables switching between the TRUPULSE™ Generator and the nGEN™ Generator (or other RF generator) without exiting the study.

* Both generators are connected to the CARTO™ 3 System Workstation.
* Only one generator is connected to the PIU. When switching generators, **you must disconnect** the first generator before connecting the second generator.
* The active generator is selected in the Tools menu. By default, the selected generator is TRUPULSE™.
* Use of an SPU with the TRUPULSE™ Generator is not supported as the generator connects to the CARTO™ 3 System's PIU via the 20 POLE A or 20 POLE B socket.

![PFA_v8p2_PFA_Generator_Selection.png](data:image/png;base64...)

Figure 3: Selecting Generators

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If the CARTO™ 3 System detects ablation data from a generator that does not match the current selection, it switches to the active generator and a visualization reset is performed only when Reset Visualization is clicked.  ![PFA_v8p2_Reset_Visualization.png](data:image/png;base64...) |

### MultiGen Connections

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Multigen\_Connections\_EN.xml

The CARTO™ 3 System supports MultiGen connections for the TRUPULSE™ Generator to be connected to the CARTO™ 3 System Workstation simultaneously with either an nGEN™ or SMARTABLATE™ RF Generator.

* For detailed connection information for the TRUPULSE™ Generator, refer to the generator IFU.
* For detailed connection information for the nGEN™ and SMARTABLATE™ generators, refer to their respective IFUs.

Table 2: Standard TRUPULSE™ Connections for HP Z4 G4 and Dell 5820 Workstations

| **MultiGen** Mode | From Generator | To Workstation | Connection Cable |
| --- | --- | --- | --- |
| TRUPULSE™ and nGEN™ | From TRUPULSE™ Docking Station ethernet port on the Generator. | To Workstation USB port, using an ethernet cable and an ethernet-to-USB adapter.  ![PFA_v8p3_USB_Adaptor.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| From nGEN™: Output socket on the Generator. | To Navigant port on the CARTO™ 3 System Workstation.  ![PFA_v8_ethernet_connections.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| TRUPULSE™ and SMARTABLATE™ | From TRUPULSE™ Docking Station ethernet port on the Generator. | To Navigant port on the CARTO™ 3 System Workstation.  ![PFA_v8_ethernet_connections.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| From SMARTABLATE™ Output socket on the Generator. | To CARTO™ 3 Workstation Serial port.  ![PFA_v7.10_5820_Serial_Port.png](data:image/png;base64...) | Serial cable.  ![PFA_8-1-100_Smartable_Cable.png](data:image/png;base64...) |
| The TRUPULSE™ Generator connects to the CARTO™ 3 System PIU from the CARTO™ System socket on the Generator Console to the 20 POLE A or 20 POLE B socket on the PIU.  RF generators connect to the **RF** socket on the CARTO™ PIU. For detailed connection information for RF generators, refer to their respective IFUs. | | 20 POLE A or 20 POLE B socket on the PIU. | Generator to CARTO™ 3 System cable.  ![PFA_v8_Generator_to_System_Cable.png](data:image/png;base64...) |

Table 3: Standard TRUPULSE™ Connections for Dell 5860 Workstation

| **MultiGen** Mode | From Generator | To Workstation | Connection |
| --- | --- | --- | --- |
| TRUPULSE™ and nGEN™ | From TRUPULSE™ Docking Station ethernet port on the Generator. | To 1G ethernet port on the CARTO™ 3 System Workstation  ![PFA_v8p3_Dell_5860.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| nGEN™ Output socket on the Generator. | To Navigant port on the CARTO™ 3 System Workstation  ![PFA_v8_ethernet_connections.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| TRUPULSE™ and SMARTABLATE™ | From TRUPULSE™ Docking Station Ethernet port of the Generator. | To 1G ethernet port on the CARTO™ 3 System Workstation.  ![PFA_v8p3_Dell_5860.png](data:image/png;base64...) | Ethernet (RJ45) Cable.  ![PFA_v8p2_Ethernet_Cable.png](data:image/png;base64...) |
| From nGEN™ Output socket on the Generator. | CARTO™ 3 Workstation Serial port  ![PFA_v7.10_5820_Serial_Port.png](data:image/png;base64...) | Serial cable  ![PFA_8-1-100_Smartable_Cable.png](data:image/png;base64...) |
| The TRUPULSE™ Generator connects to the CARTO™ 3 System PIU from the CARTO™ System socket on the Generator Console to the 20 POLE A or 20 POLE B socket on the PIU.  RF generators connect to the **RF** socket on the CARTO™ PIU. For detailed connection information for RF generators, refer to their respective IFUs. | | 20 POLE A or 20 POLE B socket on the PIU. | Generator to CARTO™ 3 System cable  ![PFA_v8_Generator_to_System_Cable.png](data:image/png;base64...) |

### Setup When Starting with PFA

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Setup\_for\_PFA\_EN.xml

Workstation: Connect both ethernet cables of both generators to the CARTO™ 3 Workstation. (See [MultiGen Connections](#target9000011)).

For generator connections refer to the *Instructions for Use* provided with the generator.

* **PIU**: Connect the TRUPULSE™ Generator from the CARTO™ 3 System socket on the generator to the 20 POLE A or 20 POLE B socket on the PIU
* **Catheter**: Connect the VARIPULSE™ Catheter to the Catheter socket on the TRUPULSE™ Generator.

When beginning the study, generators connected to the CARTO™ 3 Workstation are displayed in the Connected Machines section of the Study Setup screen.

The selected generator is indicated in the System Status Panel (see [Generator Connection Status](#target9000012)).

You can now begin the study according to your standard workflow.

![PFA_v8_Connected_Generators.png](data:image/png;base64...)

Figure 4: Connected Generators in the Study Setup Screen

### Switching from PFA to RFA During a Study

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Switching\_PFA\_to\_RF\_During\_Study\_EN.xml

In some cases, it may be appropriate to switch from the TRUPULSE™ Generator to the RF generator during a study. For instance, this can be done for RF touch-ups to the pulmonary vein isolation (PVI), or in the event of the appearance of an additional arrhythmia.

For generator connections, refer to the *Instructions for Use* provided with the generator.

1. In the Tools menu, switch the generator.

Tools > Generators > nGEN™ (or SMARTABLATE™ - the workflow is the same for both supported RF generators).[[1]](#footnote-1)

A message appears, prompting you to disconnect the TRUPULSE™ Generator.

![PFA_v8p2_Switch_PFA_RF_Generator.png](data:image/png;base64...)

1. Disconnect the TRUPULSE™ Generator from the PIU (cable connected to 20 POLE A or 20 POLE B).
2. Connect the RF generator to the RF Generator socket of the PIU.
3. After verifying that the TRUPULSE™ cable is disconnected from the PIU, click I Approve.

REP14517 D-40 D-41 D-42

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When switching between generators, the CARTO™ 3 System resets the visualization matrix and TPI data. During this time, the reset visualization progress indication appears on the status bar. If use of ACL catheters is needed, the visualization matrix needs to be rebuilt. Not doing so might result in anatomical inaccuracy due to matrix deformation. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When the switch generator selection message is displayed (and before selecting I Approve or Cancel, acquisition of EA points, FAM and CPM is disabled. |

### Switching from RFA to PFA During a Study

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Switching\_RF\_to\_PFA\_During\_Study\_EN.xml

It is possible to switch from the RF generator to the TRUPULSE™ Generator during a study.

For generator connections, refer to the *Instructions for Use* provided with the generator.

1. In the Tools menu, switch the generator.

Tools > Generators > TRUPULSE™

A message appears, prompting you to disconnect the RF Generator.

![PFA_v8p2_Switch_RF_PFA_Generator.png](data:image/png;base64...)

1. Disconnect the RF Generator from the PIU.
2. Connect the TRUPULSE™ Generator to the 20 POLE A or 20 POLE B socket of the PIU.
3. After verifying that the RF Generator cable is disconnected from the PIU, click I Approve.

The CARTO™ 3 System now resets the visualization matrix and TPI data. During this time, the Reset Visualization progress indication appears on the status bar. If use of ACL catheters is needed, the visualization matrix needs to be rebuilt.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When the switch generator selection message is displayed (and before selecting I Approve or Cancel), acquisition of EA points, FAM and CPM is disabled. |

## Troubleshooting Generator Connections

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Troubleshooting\_Generator\_Connections\_EN.xml

A system message appears if the TRUPULSE™ Generator fails to communicate with the CARTO™ 3 System – either during ablation or when not ablating.

![PFA_v8p3_Communication_Failure_Trupulse.png](data:image/png;base64...)

Figure 5: Communication Failure Message During PF

A similar message appears if there is no communication between the CARTO™ 3 System and the RF Generator.

![PFA_v8_Communication_Failure_RF.png](data:image/png;base64...)

Figure 6: Communication Failure Message During RF

REP14517 D-78

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When both PFA and RFA VISITAG™ Sites are shown in the same study, rely on the following CARTO™ 3 System features to differentiate between PFA and RFA sessions:   * PFA and RFA VISITAG™ Sites are displayed in different colors (PFA VISITAG™ Sites are purple, RFA VISITAG™ Sites are red). * PFA and RFA sessions are detailed separately in the session list of the Graphs Viewer for each ablation. * The connected generator type is indicated in the status bar.   Follow the workflow of switching generators during a study (see ["Switching from PFA to RFA During a Study"](#target9000013) and ["Switching from RFA to PFA During a Study"](#target9000014)). |

# CARTO™ 3 System Interface with VARIPULSE™ Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Varipulse\_EN.xml

## Catheter Setup Screen

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Phase3\_Catheter\_Setup\_Screen\_EN.xml

When a VARIPULSE™ Catheter is connected, the system automatically identifies the VARIPULSE™ Catheter and displays the catheter information in the Catheter Setup screen. Specific visualization settings are selected by default.

REP14517 D-106 D-74 D-75

|  |  |
| --- | --- |
| ![DxNoteWarning.png](data:image/png;base64...) | **WARNING**  Before ablating, visually verify correctness of the position of the ablation catheter in relation to the required ablation site. Use your common clinical practice for real-time verification of catheter locations throughout the procedure (inspection of IC signals, direct imaging guidance such as fluoroscopy or ultrasound, etc.). Failure to do so might result in incorrect placement of the catheter. |

![PFA_v8p3_Catheter_Setup_Screen.png](data:image/png;base64...)

Figure 7: Catheter Setup Screen with VARIPULSE™ Catheter

![PFA_v8p3_Catheter_Visualization_Settings.png](data:image/png;base64...)

Figure 8: Default VARIPULSE™ Catheter Visualization Settings

| Option | Value |
| --- | --- |
| Catheter Image | Selected by default. This cannot be changed. |
| Label | Cleared by default. |
| Electrodes | Selected by default.  When selected, the electrode numbers are displayed. Default value: All |
| Shaft Color:  Use for signal color | Shaft Color default color: Turquoise.  Signal color selection default color: Light green. |
| Mapping Channels | Default setting: All. |
| Proximity Indicators Visualization | The Proximity Indicators Visualization settings provide the following TPI modes:   * Binary Selected by default. * Continuous. * None   See ["Proximity Indicators for the VARIPULSE™ Catheter"](#target9000015)  Stable checkbox for TPI. Selected by default.  When TPI Indication is presented in real-time, the updating of proximity status can lead to flickering. To reduce this, the status can be updated in stable mode.  The setting can be saved to the template.  StableTPI is only available for the VARIPULSE™ Catheter - and only when the Proximity Indicators Visualization method is set to either Binary or Continuous. If None is selected, the Stable checkbox is grayed out. Stable TPI filters out the heartbeat impact on the TPI calculation and provides stable representation of the information in comparison to the real-time TPI visualization.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Stable TPI only affects TPI visualization in map viewers and Catheter View. and does not affect any other TPI indication in the Point List and Point Viewer of the CARTO™ System. Stable TPI will also not affect the point acquisition preferences dialog. | |
| For bipolar mapping channel, use | Either Electrode, Distal Electrode or Both Electrodes. Either Electrode is the default option. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  You can change the Electrodes and Use for signal color settings for the VARIPULSE™ Catheter. |

## Catheter Visualization

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Catheter\_Visualization\_EN.xml

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| The catheter view dialog displays a fixed frontal view mode as default for the VARIPULSE™ Catheter. The position of the catheter can be rotated as needed. Once rotated, clicking on the fixed frontal view icon returns the display to the default fixed frontal view. To exit this mode, press the synchronization button to sync the orientation with the Main Map Viewer.  Table 4: Fixed Frontal View Dialog Icons   |  |  | | --- | --- | | ![PFA_v8p3_Fixed_View_Reset.png](data:image/png;base64...) | Fixed frontal view icon | | ![PFA_v8p3_Fixed_View_Sync.png](data:image/png;base64...) | Sync from map view to catheter view | | ![PFA_v8p3_Fixed_View_Minimize.png](data:image/png;base64...) | Minimize catheter window | | ![PFA_v8p3_Varipulse_Fixed_Frontal_View1.png](data:image/png;base64...) |
| The electrode numbers indicate the catheter orientation. Electrode 1 is distal. Electrode 10 is proximal to the shaft. The catheter tip is always colored blue. | ![PFA_v8p3_Varipulse_Fixed_Frontal_View_Electrode_Numbers.png](data:image/png;base64...) |
| The default electrode coloring is gray. This indicates that the electrode is out of sheath, with no electrodes selected for ablation in the TRUPULSE™ Generator routing and no error. | ![PFA_v8p2_Bidirectional_Default.png](data:image/png;base64...) |
| Electrodes that are in-sheath, burned or disconnected, are colored black. | ![PFA_v8p2_Bidirectional_Burned_Electrodes.jpg](data:image/jpeg;base64...) |
| Electrodes that are selected for ablation in the TRUPULSE™ Generator are colored yellow.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  After selecting ablation electrodes in the generator, confirm that the correct electrodes are displayed in the CARTO™ 3 System. | | ![PFA_v8p2_Bidirectional_Yellow_Electrodes.jpg](data:image/jpeg;base64...) |
| During ablation, the active electrodes are colored purple. TPI indications on the electrodes depend on TPI status (proximity, no proximity, or unknown). See ["Proximity Indicators for the VARIPULSE™ Catheter"](#target9000016). | ![PFA_v8p2_Bidirectional_Purple_Electrodes.jpg](data:image/jpeg;base64...) |
| Overlapping electrodes; when there is an overlap, the electrodes are colored brown, and an error message appears.  If overlapping electrodes are detected by the TRUPULSE™ Generator, the generator stops any ongoing ablation. | ![PFA_v8p2_Bidirectional_Overlapping_Electrodes.jpg](data:image/jpeg;base64...) |
| Depending on the Proximity Indicators Visualization, the highlighting is presented in Binary or Continuous mode.  In Binary mode, electrodes that are in close proximity with the tissue (positive TPI) are highlighted by a white band either side of the electrode. In Continuous mode, electrodes are highlighted by a sphere.  Electrodes that are not in close proximity are not highlighted. | ![PFA_v8p3_Varipulse_Fixed_Frontal_View_Electrode_Numbers.png](data:image/png;base64...)  Figure 9: Binary TPI  ![PFA_v8p3_Varipulse_Fixed_Frontal_View_Electrode_Bubbles.png](data:image/png;base64...)  Figure 10: Continuous TPI |
| Electrodes with unknown TPI status are highlighted in red-brown (maroon).  Insufficient TPI training at the specific location might lead to an unknown TPI status. | ![PFA_v8p2_Bidirectional_Unknown_TPI.png](data:image/png;base64...) |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The VARIPULSE™ Catheter consists of 3 Single Axis Sensors for determining its location. In the event of at least one Single Axis Sensor (SAS) failure, the VARIPULSE™ Catheter is not displayed. If this occurs, a catheter sensor error is displayed:   * Error 116 (if connected to 20 POLE A) * Error 139 (if connected to 20 POLE B) |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The visualization of the VARIPULSE™ Catheter is based on a magnetic model only. |

## TPI for the VARIPULSE™ Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_8p3\_TPI\_VP\_EN.xml

TPI is available for the VARIPULSE™ Catheter. With Tissue Proximity Technology, the CARTO™ 3 System uses impedance measurements to determine an electrode's proximity to cardiac tissue. If the electrode is in proximity to the tissue, the electrode is considered to be touching. Proximity is defined as a distance of less than 0.2 mm from the tissue.

The CARTO™ 3 System calculates TPI impedance based on unipolar values (per each electrode), while the TRUPULSE™ Generator uses a bipolar impedance calculation related to the ablation parameters which can be viewed through the Graphs Viewer. These are two separate impedance measurements and should not be confused

**TPI Reset**

TPI is reset automatically in the following cases:

* There is a Body Coordinate System (BCS) movement scenario.
* The TRUPULSE™ Generator is switched on for the first time.
* When switching between PF and RF generators.
* When a Visualization reset is performed from the Catheter menu.

If you think the TPI status is inaccurate, it can be manually reset:

* Click Catheter > Reset TPI from the CARTO™ 3 System menu. This resets **all** TPI-related data.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The VARIPULSE™ Catheter requires re-calibration whenever a manual reset is performed. See ["VARIPULSE™ Catheter TPI Calibration"](#target9000017). |

REP14517 D-99 D-100

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  In the event that communication with the TRUPULSE™ Generator is lost, TPI indications for the VARIPULSE™ Catheter are invalid and the status is displayed as 'unknown' if the System does not recognize reconnection of the Generator. Alert message #1223 is displayed. See ["Error Handling"](#target9000018).  If a TRUPULSE™ Generator is replaced with another TRUPULSE™ Generator, a manual TPI reset must be performed. |

REP14517 D-105

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  During the application of PF energy, the status of TPI indications are frozen during each application and also for 3 seconds post-application. Post-application recovery time of the **last** application is only 200 ms. If the catheter is moved during the post-application recovery time, incorrect TPI indications might be displayed. |

## VARIPULSE™ Catheter TPI Calibration

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Catheter\_Calibration\_EN.xml

Before using TPI, a calibration process can be performed. The calibration process helps the CARTO™ 3 System learn TPI in a more streamlined and efficient manner, via a visual guidance, to gain a full TPI data establishment resulting in less unknown statuses during the procedure. VARIPULSE™ TPI Calibration is not available in review mode.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  This calibration process is only available for the VARIPULSE™ Catheter. To calibrate other catheters with TPI functionality, make sure to move the catheter sufficiently within the entire chamber, without letting the electrodes touch the tissue or other devices, until there is no brown band around the electrode. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  TPI Calibration is advised as part of the procedure. The VARIPULSE™ Catheter TPI Calibration process can be skipped, however, this may lead to insufficient TPI training data and unknown TPI status. |

During the calibration process, which occurs in the cone volume (as shown in the Calibration Workflow shown below), each electrode of the VARIPULSE™ Catheter passes through the same area in the blood pool (not in proximity to the tissue), allowing a ratio between the electrodes to be calculated. As part of the VARIPULSE™ TPI calibration learning, standard visual TPI-related indications are temporarily disabled, and replaced with other calibration-specific indicators.

![PFA_v8p3_Catheter_Calibration_Menu.png](data:image/png;base64...)

Figure 11: VARIPULSE™ TPI Calibration Options

The VARIPULSE™ TPI Calibration menu includes two options: Auto- Initialize VARIPULSE™ Calibration (selected by default) and Initialize Calibration. When the Auto- Initialize VARIPULSE™ Calibration option is selected, the calibration dialog is displayed automatically upon connection of the VARIPULSE™ Catheter and the completion of the catheter visualization, or on manual reset of TPI. The calibration process can also be started manually by selecting Initialize Calibration from the VARIPULSE™ TPI Calibration menu option.

To ensure a rapid calibration process:

* Place the distal tip of the sheath about 1 cm from the septum. and direct the curve towards mid-chamber.
* When the VARIPULSE™ Catheter is exiting the sheath, make sure that the electrode being calibrated does not touch the tissue or other devices. Failure to do so could prolong the calibration process.
* Keep the sheath stable (by maintaining the sheath tip position).
* Advance two electrodes out of sheath and follow the visualization indications. Once the electrodes are colored green (complete), advance two additional electrodes out of sheath. Keep advancing the electrodes until the process is complete.

Table 5: Calibration Workflow

|  |  |
| --- | --- |
| REP14517 A-35  When the VARIPULSE™ TPI Calibration dialog first opens, the following default message is displayed: | |
| REP14517 A-35  Press Start and then advance 2 electrodes out of sheath. Note: During Calibration, TPI indications are disabled. When the calibration process is completed or ended, TPI indications are restored in the map viewers.  If the catheter electrodes are not in the sheath, the calibration process can't be initialized. A message is displayed informing you of this, with an instruction to ensure all electrodes are in the sheath before starting the calibration process. | ![PFA_v8p3_TPI_Calibration1a.png](data:image/png;base64...) |
| After pressing Start, and the first distal electrode is out of sheath, a cone-shaped training zone and a bullseye icon ![PFA_v8p3_TPI_Calibration5a_Bullseye.png](data:image/png;base64...) are displayed (based on the exit point of the first distal electrode from the sheath). A VARIPULSE™ TPI Calibration dialog appears, displaying a legend of the electrode visualization indicators.  This dialog also contains an instruction to keep the sheath stable and ensure that the currently calibrated electrodes are not in proximity to tissue (based on the orange indication as described in the legend).   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Electrodes pulled back into the sheath during calibration, are reset, and their data is not saved (even if they have already completed the calibration process). | | ![PFA_v8p3_TPI_Calibration2bbb_1.png](data:image/png;base64...) |
| When the first electrode exits the sheath, visual indicators appear. The legend in the VARIPULSE™ TPI Calibration dialog describes the TPI calibration status:   * In Progress - yellow indicators. * Completed - green indicators. * Electrodes out of cone - red indicators. * Electrodes are in proximity to tissue (within the training zone) - orange indicators.   During training, extend two electrodes at a time out of the sheath, and within the cone volume, wait for calibration completion (green indicators), then continue with the next two. If less than ten electrodes complete calibration training, a dialog is displayed: VARIPULSE™ calibration is partially completed. If all ten electrodes complete calibration training, a VARIPULSE™ calibration completed successfully. dialog is displayed.  If required, click the X or the Stop button to stop the calibration process.  If, during calibration, the catheter is disconnected, the process is reset, and the calibration dialog reopens when reconnecting the catheter. | |
| An additional warning is displayed in the dialog if sheath movement is detected during the calibration process: Sheath movement is identified. Position the distal end of the sheath at the marked location and advance the catheter. Position the sheath at the marked location (bullseye). Once the sheath is stabilized, and the next electrode exits the sheath, the message changes to: Keep the sheath stable and ensure that the currently calibrated electrodes are not in proximity to the tissue. | ![PFA_v8p3_TPI_Calibration3bbb.png](data:image/png;base64...) |

REP14517 A-37

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When calibrating the catheter without a FAM reconstruction, the training zone is displayed without a reconstruction context - and may be close to the tissue. Do not consider the training zone as a 'safe zone' to maneuver the catheter without touching the tissue. |

The VARIPULSE™ TPI Calibration options are not available and/or the calibration is terminated in the following situations:

* The VARIPULSE™ Catheter is not connected (or becomes disconnected during calibration).
* Pacing with the VARIPULSE™ Catheter is detected.
* Ablation is detected (RFA or PFA).
* If a TPI reset occurs while the VARIPULSE™ TPI Calibration dialog is open.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The calibration process is socket-specific and calibration results using 20 POLE A socket cannot be used when using 20 POLE B (and vice versa). A separate calibration process needs to be performed if switching sockets.  After completion (full or partial) of the calibration process, disconnecting and reconnecting the same VARIPULSE™ Catheter *to the same socket* does not trigger the calibration process, even if Auto- Initialize VARIPULSE™ Calibration is enabled (TPI data is saved). Connection of the catheter to a different socket or connection of a different VARIPULSE™ Catheter *does* trigger the process. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  After completion (full or partial) of the calibration process, in the event of an automatic TPI reset, there is no trigger for the calibration process, even if Auto- Initialize VARIPULSE™ Calibration is enabled. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When a manual TPI reset is performed from the Catheter menu, the VARIPULSE™ Catheter requires re-calibration. |

## Proximity Indicators for the VARIPULSE™ Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Phase3\_Proximity\_Indicators\_for\_the\_VARIPULSE\_Catheter\_EN.xml

In the Proximity Indicators Visualization section of the Catheter Setup, three modes are available:

* Binary indicator (default ): The term Binary refers to whether there is proximity (or not) between the electrode and tissue. The TPI visualization has three indications: **proximity** (indicated by a white band either side of the electrode), **no proximity** (no band), and **unknown** (maroon band).
* Continuous indicator: This TPI visualization also has three indications: **proximity**, **no proximity**, and **unknown**. When the electrode is in proximity, a white transparent sphere surrounds the electrode. The sphere size increases or decreases continuously according to the Tissue Proximity Ratio calculated for the corresponding electrode. A larger sphere indicates closer proximity (a higher TPI ratio) - and vice versa. If proximity is not achieved, a sphere is not displayed. For **unknown** indication, a maroon band is displayed either side of the electrode.
* None: No TPI visualization.

Table 6: Continuous Proximity Indications

| Viewer | Indication On... | Proximity Indication | No Proximity Indication | Unknown Indication |
| --- | --- | --- | --- | --- |
| Map Viewers | Catheter Electrode | ![PFA_v8p3_Continuous_Touch_Indication1.png](data:image/png;base64...) | ![PFA_v8p3_Continuous_No_Touch_Indication1.png](data:image/png;base64...) | ![PFA_v8p3_Continuous_Unknown_Indication1.png](data:image/png;base64...) |
| Point List | Point | ![tissueProximity_indication_point_touch_4-3.png](data:image/png;base64...) | ![tissueProximity_indication_point_no_touch_4-3.png](data:image/png;base64...) | ![tissueProximity_indication_point_unknown_4-3.png](data:image/png;base64...) |
| Selected Point Viewer/ Baseline Point Viewer | ECG Channel | ![tissueProximity_indication_point_touch_4-3.png](data:image/png;base64...) | ![tissueProximity_indication_point_no_touch_4-3.png](data:image/png;base64...) | ![tissueProximity_indication_point_unknown_4-3.png](data:image/png;base64...) |

The CARTO™ 3 System supports storing the TPI visualization modes as part of the Study template. The TPI visualization mode can be changed at any time during the Study.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  There is no display of TPI indications (in proximity or unknown) on black electrodes of the VARIPULSE™ Catheter. |

# PFA Sessions

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_PFA\_Ablation\_Sessions\_EN.xml

Each ablation session consists of 3 applications of PF energy. During ablation, the ablating electrode is colored purple in the catheter visualization. TPI indication displayed during the application represents the TPI status prior to the application.

Each application is part of a PF ablation session (consecutive applications set by the generator monitor). The Readings Dashboard shows a designated display of the ablation parameters and total applications in the session.

REP14517 D-57 D-96

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  To avoid ACL and magnetic noise during PF application, ACL and Magnetic Signals are paused for all catheters for the duration of application. The ACL visualization-based catheter locations may therefore be temporarily inaccurate during, and up to two seconds after PF application. |

## Readings Dashboard

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Readings\_Dashboard\_EN.xml

When connected to the TRUPULSE™ Generator, the background of the Readings Dashboard is colored purple during PFA ablation, red during RFA, and black when not ablating (inactive).

The PFA Readings Dashboard displays parameters in the form of a circular progress bar. The ablation session parameters are as follows:

* Progress Bar: Progress of applications.
* White lines indicate PF applications.
* Light gray segments indicate the time between applications.
* During ablation, the progress bar is colored orange, showing ablation progress in real time.

![PFA_v8p2_Readings_Dashboard_Ablating_2.png](data:image/png;base64...)

Figure 12: Readings Dashboard During Ablation

![PFA_v8p2_Readings_Dashboard_Non_Ablating.png](data:image/png;base64...)

Figure 13: Readings Dashboard When Inactive

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A PF ablation counter indication can now be added to the Readings Dashboard that displays the number of PF ablations performed. The ablation counter indication can be shown or hidden on the Readings Dashboard. The PF ablation counter’s status (displayed / not displayed) and position on the Readings Dashboard can be saved to a template |

REP14517 D-55

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A communication error between the TRUPULSE™ Generator and the CARTO™ 3 Workstation during PF application can result in partial or missing ablation data. If this happens, the electrode and the Readings Dashboard remain purple until the ablation countdown estimation is completed, and the Progress Bar continues reflecting the ablation countdown session until completion. A caution message is displayed. |

REP14517 D-47 D-48 D-49 D-50

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A communication error between the TRUPULSE™ Generator and the CARTO™ 3 Workstation during PF application might result in the following errors:   * CARTO™ 3 System displays generator errors when there are no errors in TRUPULSE™. * CARTO™ 3 System displays burnt/overlapping electrodes, and the TRUPULSE™ Generator doesn't. * CARTO™ 3 System doesn't display burnt/overlapping electrodes, and the TRUPULSE™ Generator does.   If this type of display mismatch occurs, rely on the generator's data. |

## Graphs Viewer

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Phase3\_Graphs\_Viewer\_EN.xml

The Graphs Viewer displays a bar graph with real-time bipolar impedance values from the TRUPULSE™ Generator for VARIPULSE™ Catheter electrodes. Bipolar impedance values can also be displayed in a table format view - contact your local Biosense Webster Clinical Account Specialist (CAS) to set this up. The Graphs Viewer real-time bipolar impedance values are not available in Review mode.

![PFA_v8p3_Graphs_Viewer.png](data:image/png;base64...)

Figure 14: The CARTO™ 3 System displaying the Graphs Viewer

VARIPULSE™ electrodes which are marked black (in-sheath, disconnected or high impedance) are not displayed in the Graphs Viewer or the Session List,

The generator notifies the CARTO™ 3 System if the session was completed. The result is displayed in the Duration/Complete column of the Session list, as Completed or Incomplete. The (catheter) Type is listed as VARIPULSE™.

An ablation session is considered Complete when 3 applications were performed with the VARIPULSE™ Catheter.

An ablation session is considered Incomplete when less than 3 applications were performed with the VARIPULSE™ Catheter (whether it was because of pacing during ablation, impedance values were too high, or user intentionally stopped ablation).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A status of Unknown appears in the Duration/Complete column of the Session list, when there is a loss of communication with the generator during ablation. |

The Session list is synchronized with the real-time Graphs Viewer, and its values are available in Review mode.

## Viewing Signals

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Viewing\_Signals\_EN.xml

Signals for the VARIPULSE™ Catheter are labeled 20A or 20B by default, depending on where the TRUPULSE™ Generator is connected. The label can be changed in the Catheter Setup screen. VARIPULSE™ Catheter signals are light green by default. The color can also be changed in the Catheter Setup screen.

![PFA_Support_v8p3_Viewing_Signals.png](data:image/png;base64...)

Figure 15: Display of VARIPULSE™ Catheter Signal with highlighted channel (blue) and highlighted reference channel (yellow)

Highlighting of ablation channels is enabled in both the Monitor panel and the Annotation Viewer by default, but it can be changed for each viewer in the ECG viewer tools menu.

Channels that are selected for ablation are highlighted. The highlighting remains for 3 seconds after the ablation session.

![PFA_Support_v8_Signals_Selection_Ablation.png](data:image/png;base64...)

Figure 16: Display of Channels Selected for Ablation

## VISITAG™ Sessions with PFA

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Visitag\_Sessions\_EN.xml

The CARTO™ 3 System automatically creates a single PFA VISITAG™ site per electrode. This site represents the entire ablation session.

**PFA Status Site Coloring**

PFA VISITAG™ Sites are colored according to their status:

* PFA VISITAG™ Site tags are colored dark purple if they pass the threshold for selected filters. See ["PFA Preferences"](#target9000019).
* PFA VISITAG™ Site tags are colored light purple if they do not pass the threshold for selected filters.
* If there is insufficient data due to communication loss with the generator, the PFA VISITAG™ Site tags are colored gray.
* PFA VISITAG™ Site tags are colored light purple until completion of an ablation **session**. They remain light purple if the ablation **session** is incomplete. Upon completion of an ablation **session** (and if the ablations pass the threshold for selected filters), PFA VISITAG™ Sites are colored dark purple.

![PFA_Status_Coloring_Method.png](data:image/png;base64...)

Figure 17: PFA Status Color Bar

![PFA_Support_v8_Tags1.png](data:image/png;base64...)

Figure 18: PFA VISITAG™ Sites: Insufficient Data (Left), Incomplete Ablation Session (Center) and Complete Ablation Session (Right)

### VISITAG™ Toolbar

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Visitag\_Toolbar\_EN.xml

The CARTO™ 3 System contains a new VISITAG™ toolbar for PFA features introduced in this version.

The toolbar has 3 modes allowing for convenient access to the relevant tools and options based on the selected mode of operation:

| PFA only - displayed for PFA | RFA only - displayed for RFA. | PFA + RFA – displayed when both ablation modes are used |
| --- | --- | --- |
| ![PFA_8-5_Visitag_Toolbar_PF2.png](data:image/png;base64...) | ![PFA_8-5_Visitag_Toolbar_RF2.png](data:image/png;base64...) | ![PFA_8-5_Visitag_Toolbar_Mixed2.png](data:image/png;base64...) |

Table 7: New VISITAG™ Toolbar buttons impacting the VARIPULSE™ Catheter' in the study

| Icon | Tool Tip | Description |
| --- | --- | --- |
| ![PFA_v8p3_Visitag_Toolbar_SIte_Tags.png](data:image/png;base64...) | Site Tags On/Off | On by default.  Click to turn Site Tag on or off.  Click the arrow to set the radius for the displayed PFA VISITAG™ Site Tag (in mm).  This setting affects display size only. It does not indicate lesion size.  This button affects the size of PFA VISITAG™ Site Tags. |
| ![PFA_v8p3_Visitag_Toolbar_Tag_Projection.png](data:image/png;base64...) | Site Tag Projection On/Off | Off by default.  Click to turn Site Tag Projection on or off.  This button applies to PFA VISITAG™ Site Tags. |
| ![PFA_v8p3_Visitag_Toolbar_Grids.png](data:image/png;base64...) | Grid On/Off | Off by default.  Click to turn Grid Cell display on or off.  Click the arrow to display additional options:   * Show Grid * Show Grid Projection |
| ![PFA_v8p3_Visitag_Toolbar_FAM_Coloring.png](data:image/png;base64...) | FAM Coloring On/Off | Off by default.  Click to turn FAM Coloring on or off.  This button applies to the FAM reconstruction around each projected grid. |
| ![PFA_v8p3_Visitag_Toolbar_Connecting_Line.png](data:image/png;base64...) | Connecting Line On/Off | Off by default.  Click to turn the VARIPULSE™ connecting Line feature on or off.  Click the arrow to display additional options:   * Selected * All   This button displays the connecting line for PFA VISITAG™ Sites associated with the Selected session (or All sessions). |
| ![PFA_v8p3_Visitag_Toolbar_Overlapping_Grid_Indication.png](data:image/png;base64...) | Grid Overlap Indication On/Off | Off by default.  Click to turn Grid Overlap Indication on or off. |

### PFA Preferences

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_V8\_visitag\_TPI\_EN.xml

![PFA_v8p3_Tag_Preferences2.png](data:image/png;base64...)

Figure 19: PFA Preferences

Table 8: Options for PFA VISITAG™ Preferences

| Option | Value |
| --- | --- |
| **Respiration Adjustment**  The Respiration Adjustment option allows the closest end experium (EE) point to the PF application to be associated with the location of that application.  The algorithm has been refined in this version for use with PFA VISITAG™ Sites.  When ablating with the VARIPULSE™ Catheter without Respiration Adjustment, unintentional catheter movement during ablation (or catheter movement due to respiration) might result in insufficient energy being applied in the intended location. Respiration Adjustment can be selected to receive average and gated position of the tag.  When using Respiration Gating and the Respiration Adjustment filter, the PFA VISITAG™ Site tag position is calculated as an average location of all PF applications - adjusted to the end expiration phase position.  REP14517 D-83  When not using Respiration Gating and the Respiration Adjustment filter, the PFA VISITAG™ site location is based on the initial position of the catheter electrodes in the first application in the ablation session (just before the application begins). | The Respiration Adjustment filter is checked by default.  Gated Respiration can be used for the VARIPULSE™ Catheter. If Gated is On, and respiration training has not been performed, N/A appears by this option.  If Gated is Off, then First application location is used instead.  If both Respiration Adjustment and Stability options are not selected, the PFA VISITAG™ Site is located at the last electrode position just before the first application.  If the Respiration Adjustment option is selected but Stability is not selected, the tag positions are calculated by the average of end experium points closest to each application in the session. In this case the distance between applications is not taken into consideration for Stability.  If both Respiration Adjustment and Stability options are selected, site locations are calculated using both the Max. distance and the respiration adjusted positions. |
| TPI Filter | The TPI Filter is cleared by default. The selection can be saved to a template. The tissue proximity status is saved in a log file before each application.  When the TPI Filter is selected, TPI status is included in the VISITAG™ definition. The TPI Filter evaluates the Stable TPI status before each application. If at least 1 out of the 3 applications of PF energy per ablation was in proximity to the tissue prior to each application, then it is considered as having passed the filter threshold and a dark purple PFA VISITAG™ is displayed. If TPI was not in proximity, the PFA VISITAG™ Sites are marked as not having passed the filter threshold (light purple PFA VISITAG™).  During applications, the TPI status is available and duplicated from the last stable TPI status before the application. The System will maintain the PFA TPI Filter state for new maps according to the current filter state in a study. |
| Stability  This is a user-defined threshold for the distance change between the locations of PF applications at which a catheter is considered to be stable. | The Stability Filter is cleared by default and the selection can be saved to a template.  Max. distance can be used for user-defined maximum distances between PF applications in millimeters. The default is 5 mm. If this condition is met, the PFA VISITAG™ Site location is based on the average of the PF application locations. If this condition is not met, the PFA VISITAG™ Site location is displayed with a light purple PFA VISITAG™, and the location that exceeded the threshold is not taken into account in the calculation. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Light purple PFA VISITAG™ Sites and grids disappear when no additional EE points are received. Due to a delay in the ACCURESP™ Module, the EEs are received with a delay of up to 1.5 respiratory cycles. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If electrodes exceed the set Max. distance threshold when rotating the catheter during an ablation session, the ablation is marked with a light purple PFA VISITAG™ – even if performed in the same location of a different catheter electrode. |

REP14517 D-83 D-84 D-85 A-93

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If respiration training was not performed, then N/A is displayed next to the Respiration Adjustment and the Stability check boxes in the PFA Preferences. In this case, the PFA VISITAG™ Site is located at the last electrode position just before the first application and the Gating/Stability algorithms are not applied to the PFA VISITAG™ Sites. Use common clinical judgment and standard workflow to identify ablation gaps. |

REP14517 A-38 A-39

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When ablating with the Stability Filter enabled, and respiration data is available: The status of the PFA VISITAG™ Site may be updated several seconds after ablation ends (the PFA VISITAG™ Sites may change from dark purple to light purple). To avoid repeated, unnecessary PF ablations, wait a few seconds until the ablation status updates. Since the TRUPULSE™ Generator forces a post-ablation period of several seconds between ablations (which is longer than one respiration cycle), the user must wait a few seconds before performing further ablations. |

REP14517 D-72

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A disconnected or damaged communications cable might result in a loss of communication with the TRUPULSE™ Generator. If this occurs, ablation information is not available to the CARTO™ 3 System, and a PFA VISITAG™ Site might not be created. A point must be acquired and a manual tag to represent the ablation must be used instead. |

### Connecting Line Indication

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Visitag\_Connecting\_Line\_EN.xml

Displayed PFA VISITAG™ Sites associated with the Selected session (or All sessions) can be shown with a blue line connecting them (in real-time or review mode). This feature is activated by the dedicated button on the VISITAG™ toolbar.

![PFA_Support_v8_Tags3.png](data:image/png;base64...)

Figure 20: PFA VISITAG™ Sites with Connecting Line

An orange line is displayed that indicates the physical gap between the most distal and proximal active electrodes for the Selected session only. Use **<CTRL>** + mouse click to show more than one **Connecting Line**. This feature is not available in All sessions display mode.

When Selected sessions display mode is enabled and several ablation sessions are selected, the orange connecting line will be displayed for any of the selected sessions.

When displayed, the orange connecting line is present for any permutation of distal and proximal electrodes of the ablation session.

![PFA_v8p3_Orange_Connecting_Line.png](data:image/png;base64...)

Figure 21: Proximal and Distal Electrode Indication

### Grids

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_PFA\_Tag\_Grids\_EN.xml

The completion status of all grid entities is derived from the PFA VISITAG™, resulting in a color of either dark or light purple (or gray for insufficient data).

There are three visualization methods available:

* Grids (visualized volumetrically in their original location) are small spheres that surround the PFA VISITAG™ Site. This feature enables a geometric continuous representation of the bipolar locations of these ablations.
* Projected Grids: Grid cells are projected if the distance to the reconstruction is less than 10 mm. Each grid cell is projected onto the FAM reconstruction. This gives users a visualization of the ablation on the FAM reconstruction - therefore an anatomical reconstruction is needed for the display of Projected Grids.
* FAM Coloring: A representation of the projected grids.

| Grids | Projected Grids Coloring | FAM Coloring |
| --- | --- | --- |
| ![PFA_v8p3_Grid.png](data:image/png;base64...) | ![PFA_v8p3_Projected_Grid.png](data:image/png;base64...) | ![PFA_v8p3_FAM_Grid.png](data:image/png;base64...) |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When FAM Coloring or Projected Grids are selected, display of PFA Grids are not displayed:   * If less than approximately 10% of the surrounding Grids of each site are within the threshold distance (less than 10 mm) to the FAM, the Grids representing that site appear in their original location and color. * If more than approximately 10% of the surrounding Grids of a site are within threshold distance to the FAM, Grids are not displayed, and then FAM Coloring and / or Projected Grids are displayed on the FAM. |

REP14517 D-65

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If the catheter moves during ablation, insufficient energy might be applied in the intended location. Grids are derived from the location of the PFA VISITAG™ position and indicate the locations of PF applications. |

REP14517 D-89 D-95

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When creating a FAM reconstruction, endeavor to be as accurate as possible. An inaccurate/incomplete FAM reconstruction might lead to inaccurate grid projections. |

### Grid Overlap Indication

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Grid\_Overlap\_Indication\_EN.xml

The Grid Overlap Indication feature is designed to show:

* The placement of current grid cells.
* Grid cells from previous ablations that have overlapping color indications.
* Indication of where future grids would fall based on the current electrode position.

The Grid Overlap Indication is updated in real-time. This feature is only available with the VARIPULSE™ Catheter.

The Grid Overlap Indication is displayed in the map viewers (when not ablating) around each VARIPULSE™ Catheter electrode selected for ablation. When working with projected grids, these indications are overlaid on the map surface or imported image. The indication includes highlighting areas that overlap with previously created grid cells and areas that do not overlap. The Grid Overlap Indication is available for PFA Grids or Projected Grids (but not both).

REP14517 D-90 D-91

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  The Grid Overlap Indication is not related to respiratory gating locations, but rather it is based on the real-time electrode location. The indication takes into account only the grids that are associated with the active map.  The Grid Overlap Indication does not take RFA grid cells into account, and future grids that overlap previous RFA grid cells are colored green. The indication is in real-time and represents a rough indication of the location. It does not reflect the final PFA VISITAG™ Site/ Grid location. |

REP14517 A-92 A-93

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When TPI filter is enabled, the Grid Overlap Indication is applied only for electrodes that are in proximity to the tissue. |

In the Grid display:

* **Purple:** indicates the location of previous ablation grids based on the location of the VARIPULSE™ electrodes.
* **Red:** indicates locations where future ablation grids would overlap with previously created grids.
* **Green:** indicates the location of future ablation grids and indicates locations where future ablation grids would be created without overlap with previously created grids.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Green grids also indicate previous light purple ablations indication to highlight areas which would result in a dark purple indication when all ablation parameters are met. |

![PFA_v8p3_Grid_Overlap_Indication2.png](data:image/png;base64...)

Figure 22: Grid Overlap Indication displaying current, overlapping and future Grids

## Cumulative Data Window

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Phase3\_Cumulative\_Data\_Window\_EN.xml

The following data is available to the Cumulative Data Window:

* Respiration Adjusted: Yes/No
* Number of applications: Colored green if 3 of 3 applications were completed, red if less than 3 applications were completed.
* Stability (Max. distance): When filter is checked.
* TPI Filter: When checked, if *at least* 1 of 3 applications were in proximity to the tissue prior to each application this information is displayed in green. If none of the applications were in proximity, and the TPI Filter is checked, this information is displayed in red.

![PFA_v8p3_DPW_2.png](data:image/png;base64...)

Figure 23: Data Window with TPI Filter Active, No Respiration Gating, and a Complete Ablation Session

![PFA_v8p3_DPW2_2.png](data:image/png;base64...)

Figure 24: Data Window with No Respiration Gating and an Incomplete Ablation Session

If a recalculation was performed (Max. distance value changed or a filter was activated or deactivated in the PFA Preferences), the data in the Data Window is updated.

In the event of a loss of communication, N/A appears next to the Number of applications. If PFA VISITAG™ Sites are created when there is no communication, this message is displayed: '**Lost Communication - data might be partial**.'

**Data Window for Multiple Selected PFA VISITAG™ Sites**

Multiple selected PF ablation sessions can be displayed in the Data Window by:

* Selecting one or more PF ablations in the 3D Map Viewer and choosing Show Data Picking Window from the right-click menu (or using the keyboard shortcut **D**.
* Selecting one or more PF ablation in the Ablation Session List and choosing Show Data Picking from the right-click menu (or using the keyboard shortcut **D**.

The Data Window for multiple PF ablations include the following parameters:

* The title includes the total number of selected ablations.
* The start time of the earliest ablation from the selection.
* The end time of the latest ablation from the selection.

![PFA_v8p3_DPW_Multi.png](data:image/png;base64...)

Figure 25: Multiple Selected PF Ablation Sessions

## Manual Point Acquisition

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Manual\_Point\_Acquisition\_EN.xml

If points are acquired during a PF ablation session, a PF ABL tag is applied. The points are acquired according to the nearest reference annotation before the PFA session (up to 3000 ms earlier). These tags indicate electrode location. For indication of ablation session completion, refer to the Duration/Complete column in the Session list of the ["Graphs Viewer"](#target9000020). If a session is marked as Incomplete, refer to the TRUPULSE™ Generator for the reason. Based on this, you can decide whether to keep the points or delete them.

![PFA_v8p3_Tag_Setup.png](data:image/png;base64...)

Figure 26: Tag Setup Dialog Box

In the Point List , a comment is added to PF ablation points, identifying the ablation session.

![PFA_v8p3_Point_List.png](data:image/png;base64...)

Figure 27: Point List

## Map Merge with PFA Support

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8p3LMR\_Map\_Merge\_PFA\_EN.xml

This version of the CARTO™ 3 System now supports importing maps with PFA VISITAG™ Sites.

![PFA_v8p3_Map_Merge_PFA.png](data:image/png;base64...)

Figure 28: Map Merge with PFA VISITAG™ Sites

* A VISITAG™ license is required to display VISITAG™ Sites from previous studies.
* First and Last name in previous and current studies must match.
* Imported maps load in the Additional Map Viewer with prefix "Prev".
* Imported maps can also be loaded in the Main Map Viewer as a shadow map (no colors).
* Cumulative Data Window for each tag can be opened from the imported map - prefixed with "Prev".
* The VISITAG™ "Prev" Toolbar is displayed in the Additional Map Viewer when a map is loaded from a previous study. Its icons are context-sensitive according to the type of tag (PF, RF, or both).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If there are no VISITAG™ Sites or manual tags in the previous study the Toolbar doesn't open automatically, the toolbar can be opened from the menu or by right-clicking for contextual menu, but the buttons will be inactive. |

# General Workflow for the VARIPULSE™ Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PFA\_Support\_v8\_Phase3\_Varipulse\_Workflow\_EN.xml

|  |  |
| --- | --- |
| 1. | Introduce the VARIPULSE™ Catheter into the Left Atrium via the sheath. |
| 2. | Perform TPI calibration for the VARIPULSE™ Catheter, using the calibration dialog and paying attention to any CARTO™ 3 System messages. See ["VARIPULSE™ Catheter TPI Calibration"](#target9000021). |
| 3. | Create and edit a detailed, accurate and high-resolution FAM map of the chamber. |
| 4. | Position catheter using TPI indications. |
| 5. | Ablate (using PFA VISITAG™/Grid options). See ["VISITAG™ Toolbar"](#target9000022). |
| 6. | Identify gaps between electrodes 1 and 10 (proximal/ distal) using the connecting line indicator. See ["Connecting Line Indication"](#target9000023). |
| 7. | Reposition catheter to close gaps. Confirm with available features. |
| 8. | Steps 4-7 represent the steps needed for one ablation in a PVI procedure. Continue the recommended workflow according to the VARIPULSE™ Catheter Optimal Device Performance Guide received during training. |

# PFA Data Files

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_PFA\_Intro\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  This section provides information about exported data from a study in CARTO™ 3 System, version 8 with PFA. For information about other exported data from CARTO™ 3 System, version 8, refer to the documentation CD that was provided with your system. |

The VisiTagExport folder is created if the CARTO VISITAG™ Module option was selected in the Export Study Data dialog box when exporting the data. The information in these files reflects the last settings defined in the VISITAG Preferences when the data was exported. Some of the exported files depend on the catheter that was used.

The data files described in this document are created if the VARIPULSE™ Catheter was used during the study and the CARTO VISITAG™ Module option was selected when the data was exported. They reflect PFA settings at the time of export.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Within a specific study, all files that include the same reference information, such as Session Number or Site index, can be cross-referenced for data analysis. |

The following files are for R&D use only. They are not described in this document.

* RawPositions\_PFA.txt
* VisiTagSettings\_PFA.txt

## AblationData\_PFA.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Ablation-Data\_PFA\_EN.xml

These files contain information imported to the CARTO™ 3 System from the generator during PFA sessions. Data for every ablation starting from the beginning of the first application to the end of the last application is included.

Table 9: AblationData\_PFA.txt File

| Row | Description |
| --- | --- |
| TimeStamp | PIU running time stamp (sampled every 100 ms) |
| Session | Ablation session number, which correlates to sessions in other files |
| ChannelID | Electrode ID |
| Polarity | Defines if ablation was unipolar (UNI) or bipolar (BI) |
| Impedance | Recorded impedance, in ohms |
| Power | 0 if not applicable |
| DistalTemperature | N/A if not applicable |
| ProximalTemperature | N/A if not applicable |

## Applications\_PFA.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Applications\_PFA\_EN.xml

These files contain information about the applications of the ablation session, the three applications associated with the position are individually identified.

Table 10: Applications\_PFA.txt File

| Column | Description |
| --- | --- |
| SessionId | ID for the ablation session |
| ChannelId | ID of ablating electrodes (0 for 9) |
| SiteId | Index number of the site: chronological numbering of each site in the study |
| App# | Application number (1, 2, 3...) |
| App. Start Time | The PIU time stamp of the start of the application |
| App. End Time | The PIU time stamp of the end of the application |
| X, Y, Z coord. | x, y, z coordinates for the end expiration (EE) position closest to the application.  N/A. Not applicable when respiration data is not present, |
| EE Timestamp | The PIU time stamp of the \*\*\*(EE) occurrence |

## Grids\_PFA.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Grids\_PFA\_EN.xml

These files contain information regarding the Grid Cells that were displayed based on the preferences that were active when the data was exported.

Table 11: Grids\_PFA.txt File

| Column | Description |
| --- | --- |
| UniqID | Unique ID given to each Grid Cell |
| X, Y, Z | x, y, z coordinates for each Grid Cell |
| SessionId | ID for the ablation session |
| ChannelId | ID of ablating electrodes (0 for 9) |
| Completion Rate | Application completion percentage.  33 = 1 application; 66 = 2 applications; 100 = 3 applications |
| ProjUniqueID\_[Map Name] | Unique ID of the Projected Grid  -10000 if the Projected Grid is not present (it is above the distance threshold) |
| ProjX\_[Map Name] | X coordinate of Projected Grid |
| ProjY\_[Map Name] | Y coordinate of Projected Grid |
| ProjZ\_[Map Name] | Z coordinate of Projected Grid |
| ProjDistToVol\_[Map\_Name] | Distance from Projected Grid to the reconstruction |

## Sites\_PFA.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Sites\_PFA\_EN.xml

These files contain information for all sites that were displayed based on the preferences that were active when the data was exported.

This matches the information displayed in the Cumulative Data Popup window for each selected VISITAG™ Site.

Table 12: Sites\_PFA.txt File

| Column | Description |
| --- | --- |
| Session | Ablation session number |
| ChannelID | ID of ablating electrodes (0 for 9) |
| SiteIndex | Index number of the site in chronological order |
| X, Y, Z | x, y, z coordinates for each site |
| Init X, Y, Z | The x, y, z coordinates for the initial position of the site. This is the last position before starting the first application. |
| Completion rate | Percentage completion of PFA session  33 = 1 application; 66 = 2 applications; 100 = 3 applications |
| PFA Mode type | PFA |
| TPI status | The TPI status of the tag during ablation:   * 3/3 = Three applications were in proximity to the tissue * 2/3 = Two applications were in proximity to the tissue * 1/3 = One application was in proximity to the tissue * 0/3 = No applications were in proximity to the tissue * N/A = The ablation did not pass the filter threshold |
| TPI state | The TPI filter state during the export process:   * True: TPI filter is active * False: TPI filter is not active |
| IsRespAdj | The Respiration Adjustment check box value   * True: Respiration Adjustment filter is active * False: Respiration Adjustment filter is not active |
| MaxDistance | The maximum distance change value of the session. The maximal distance between the positions of applications. |

## VisiTagSessions\_PFA.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_VisiTagSessions\_PFA\_EN.xml

These files contain information for all sites that were displayed based on the preferences that were active when the data was exported.

Table 13: VisiTagSessions\_PFA.txt File

| Column | Description |
| --- | --- |
| SessionID | ID for the ablation session |
| StartTs | Start of session timestamp |
| EndTs | End of session timestamp |
| PresetName | Name of the preset used in the ablation session. Always = Preset. |
| PresetId | Preset ID for PFA ablation session. Always = 1. |
| HW Session ID | Ablation session number in TRUPULSE™ |
| Completion rate | Percentage of completion of PF session |
| Ablating electrodes | Number of electrodes which delivered PFA.  In range form, for example, 2-7, 0-9. |
| PFA Mode type | For R&D use only |
| Comment | Comment, if added by user |

# Error Handling

https://bwiildita.sharepoint.com/sites/prod/Topics/Error\_handling\_PFA\_v8\_EN.xml

The following error messages might appear when using a VARIPULSE™ Catheter. For all other Error, Alert, and Info messages, refer to the *CARTO™ 3 System Instructions for Use*.

| Message | Action |
| --- | --- |
| Error 346  REF/DECA: Multi-channel ablation generator connection. | Connection of multi-channel ablation generator or ablation catheter to the REF/DECA socket is detected by the system. Connect the multi-channel ablation generator to 20 POLE A or 20 POLE B socket to continue. |
| Alert 1223  Unknown TPI status for VARIPULSE™ Catheter | TPI status for VARIPULSE™ Catheter is unavailable while there is no communication with the TRUPULSE™ Generator. This affects TPI indications and other TPI-related functionality. Choose one of the following:  •Re-establish connection to the TRUPULSE™ Generator. TPI indications will be restored automatically.  •Select "Reset TPI" from the catheter menu to reset TPI-related information and allow TPI training to be performed.  When replacing the TRUPULSE™ Generator with another TRUPULSE™ Generator, select "Reset TPI" from the catheter menu to reset TPI-related information, as current parameters may differ between generators. |
| Error 2610  The ablation data received by the CARTO™ 3 system is not from the currently selected generator. |  |
| Alert 2611  PFA end-expirium data missing. | The respiration-related data required for adjusting the PFA Tags is not available.  Perform the following until resolved:  1. Perform Respiration training using ACCURESP™ Module.  2. Disable the Respiration Adjustment and the Stability options in the PFA preferences |

# Troubleshooting

https://bwiildita.sharepoint.com/sites/prod/Topics/Troubleshooting\_PFA\_v8p3\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If there is indication of metal interference, you can click the magnet icon to see which catheter or patch is affected. However, for catheters with a Single Axis Sensor (SAS) such as VARIPULSE™ Catheter, the metal value is displayed as N/A. |

Table 14: Known Issues

| Issue | Workaround | # |
| --- | --- | --- |
| If an electrode is burned out and it is not selected for ablation, there is no indication that it is defective. The electrode is displayed as gray instead of black. | N/A | 200566 |
| If the VARIPULSE™ Module is installed when Dual Monitor is also installed, the mode is set to Clone. | Manually set Extended mode in the Monitor Setup dialog. | 243410 |
| When opening a new map during an ablation session with the TRUPULSE™ Generator and then selecting nGEN™ as the generator, on returning to the first map the Complete ablation session status changes to Incomplete in the Graphs Viewer’s Ablation Session table. | 1. Select the second map. 2. Go to Tools > Generator > Select TRUPULSE™. 3. Select the first map. 4. The PFA Ablation session status changes to completed. | 256188 |
| VARIPULSE™ Catheter TPI indication is distorted when VARIPULSE™ is re-connected to the same socket where a previously connected MEM/HD catheter was, and Reset Visualization is performed. | Reset TPI. | 258347 |
| VARIPULSE™ ablation point is acquired as an EA point (and not as a location-only point), when acquired on the penultimate reference annotation before the 3rd application. Coloring over the FAM reconstruction at this point should be disregarded. | Manually tag and type the point as a location-only point. | 258045 |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
|  |  |

![_TBCO11;B=20;W=176.25pt;H=39.75pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5440-0182HREV01A](data:None;base64...)

![](data:image/png;base64...)

1. The connected RF generator will appear in the menu. [↑](#footnote-ref-1)