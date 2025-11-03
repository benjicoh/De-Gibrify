|  |  |
| --- | --- |
| CARTO® Signal Processing Unit (SPU) | |
| Hardware Instructions for Use |  |
|  |  |

|  |
| --- |
| UG-5070-00H (01A) |
| March 2023 |
| Please read this document carefully before using this device with the CARTO® 3 System. |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![](data:image/png;base64...) © 2020 - 2023 by Biosense Webster, Inc. All rights reserved.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  *Federal (USA) law restricts this device to sale by or on the order of a physician.* |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Any serious incident that has occurred due to, or during, the use of the product described herein should be reported to Biosense Webster. In Europe a report should also be made to the competent authority of the Member State in which the user and/or patient is established. |

Third-party trademarks used herein are trademarks of their respective owners.

For Biosense Webster patent information, see:

<http://www.biosensewebster.com/virtualpatentmarking>

See the documentation CD accompanying the CARTO® 3 System for information on third party software notices applicable to this product.

P.N.: ()

16 March 2023

Table of Contents

[CARTO® Signal Processing Unit (SPU) 1](#_Toc129878860)

[Overview 1](#_Toc129878861)

[About this Document 1](#_Toc129878862)

[SPU Package Contents 2](#_Toc129878863)

[Safety Information 3](#_Toc129878864)

[Physical Setup 3](#_Toc129878865)

[EMC Information 3](#_Toc129878866)

[Labels and Symbols on the SPU Hardware 4](#_Toc129878867)

[Hardware 5](#_Toc129878868)

[SPU Dimensions 5](#_Toc129878869)

[Applied Current 5](#_Toc129878870)

[Environmental Conditions 5](#_Toc129878871)

[Servicing 5](#_Toc129878872)

[Cleaning the SPU 6](#_Toc129878873)

[Assembling the SPU Holder 6](#_Toc129878874)

[Connecting the SPU 9](#_Toc129878875)

[Connecting to the PIU Power Supply 9](#_Toc129878876)

[Connecting the SPU to the PIU 10](#_Toc129878877)

[Tests on SPU Start-Up 11](#_Toc129878878)

[Connecting a Catheter 12](#_Toc129878879)

[SPU LED Status 12](#_Toc129878880)

[Status Indication Panel 13](#_Toc129878881)

[Troubleshooting 14](#_Toc129878882)

# CARTO® Signal Processing Unit (SPU)

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Title\_EN.xml

## Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Overview\_EN.xml

The **CARTO® Signal Processing Unit (SPU)** is used for connecting diagnostic catheters with more than 20 mapping electrodes to the CARTO® 3 System. These catheters are referred to as *HD catheters*. [[1]](#footnote-1)

The SPU version 2 is compatible with CARTO® 3 System V7.2.40 and later.

![SPU_holder_veiw.png](data:image/png;base64...)

Figure 1: SPU in Holder

When the PIU has 58-channel TPI calibration[[2]](#footnote-2), TPI is available through the SPU on sockets 20 POLE A and 20 POLE B.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Consult your Biosense Webster representative regarding availability in your country. |

REP9626: V7 SPU 1.1.9

The SPU must be attached securely to the SPU holder. The SPU holder ensures that the SPU is secured in the proper position and protected from accidental bumps. The SPU holder can be attached to the rectangular rail of the CARTO® 3 System cart, patient table, or the Boom.

### About this Document

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_About\_this\_Release\_win10\_EN.xml

This document describes the SPU, SPU holder installation, connection to the CARTO® 3 System, and troubleshooting related to the SPU.

The SPU enables functionality of SPU-supported catheters with the CARTO® 3 System. The basic functionality is described in this document.

Each SPU-supported catheter has a separate *Instructions for Use and Release Notes* document describing catheter functionality in the CARTO® 3 System. Refer to this document before using the catheter with the CARTO® 3 System. Contact your Biosense Webster representative for details of compatible catheters that are available in your country.

Refer to the CARTO® 3 System *Instructions for Use* for further information about the system before using the SPU.

Refer to the catheter's *Instructions for Use* for further information about the connected catheters.

### SPU Package Contents

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Components\_EN.xml

The SPU comes with the following components.

Table 1: SPU Package Contents

| Component | Component |
| --- | --- |
| SPU  ![SPU_view.png](data:image/png;base64...) | Ethernet (fiber optic) cable (3 m)  ![SPU_SPU_to_PIU_Ethernet_Cable_EN.jpg](data:image/jpeg;base64...) |
| Branched (Y) power cable  ![CW-0303-30F_Ycable.jpg](data:image/jpeg;base64...) | 20 POLE A/B interface cables  ![SPU_to_PIU_Cable.jpg](data:image/jpeg;base64...) |
| SPU Holder Cradle Base  ![SPU_plastic_bracket.jpg](data:image/jpeg;base64...) | SPU Holder Cradle Assembly  ![SPU_bracket.jpg](data:image/jpeg;base64...) |
| SPU Holder Clamping Assembly  ![SPU_holder.jpg](data:image/jpeg;base64...) | 4 metal screws  ![SPU_screws.jpg](data:image/jpeg;base64...) |

## Safety Information

https://bwiildita.sharepoint.com/sites/prod/Topics/Safety\_SPU\_EN.xml

All safety considerations, cautions, and warnings that apply to the general use of the CARTO® 3 System also apply while using this module. In addition, the following considerations apply:

* Each catheter has indications, contraindications, and warnings or precautions that are specific to that catheter. Before using any catheter with the CARTO® 3 System, please refer to the catheter's Instructions for Use (IFU) to obtain information relevant to that specific catheter.
* Read this document and the accompanying CARTO® 3 System *Instructions for Use* before using this device.

### Physical Setup

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Physical\_Seyup\_EN.xml

REP9626: V7 SPU 8.1.2

Usability Testing for rectangular rails only.

The SPU must be attached securely to the SPU holder. The SPU holder can be attached to the rectangular rail of the CARTO® 3 System cart, the patient table, or the Boom.

![SPU_holder_cart_configuration.jpg](data:image/jpeg;base64...)

Figure 2: SPU Assembly on System Cart

When attaching the SPU holder to the cart, patient table, or Boom, ensure that:

REP9626: V7 SPU 1.3.1, 1.3.2

* The SPU is at least 0.60 m away from the Location Pad.
* The SPU is at least 0.20 m away from the PIU.
* Sockets are accessible for cable connections.

REP9626: V7 SPU 1.1.11

* The ventilation openings are not covered.

### EMC Information

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_EMC\_Info\_EN.xml

REP9626: V7 SPU 1.1.1, 1.1.2, 1.1.3, 1.1.4, 1.1.5, 1.1.10. 1.5.1, 1.5.2, 1.5.3, 1.5.4

The following table presents data regarding IEC 60601‑1‑2, 4th edition compliance of the CARTO® 3 System when used with the SPU.

Table 2: Summary of Test Results

| Test | Standard | Class/ Severity Level | Test Result |
| --- | --- | --- | --- |
| **Emission** (IEC 60601‑1‑2 sections 7.1 -7.2) | | | |
| Conducted emission  Freq. range: 150 kHz - 30 MHz | CISPR 11 | 230, 120, and 100 VAC mains: Group 1 Class A | Complies |
| Radiated emission  Freq. range: 30 MHz - 1000 MHz | CISPR 11 | Group 1 Class A | Complies |
| Harmonic current emission test | IEC 61000‑3‑2 | AC mains: Class A | Complies |
| Voltage changes, Voltage fluctuations and Flicker test | IEC 61000‑3‑3 | AC mains | Complies |
| **Immunity** (IEC 60601‑1‑2 sections 8.9 - 8.10) | | | |
| Immunity from Electrostatic Discharge (ESD) | IEC 61000‑4‑2 | 8 kV contact discharges and 15 kV air discharges | Complies |
| Immunity from radiated electromagnetic fields | IEC 61000‑4‑3 | 3.0 V/m; 80 MHz ÷ 2.7 GHz, 80% AM, 1 kHz | Complies |
| Immunity from proximity field from wireless communications equipment | IEC 61000‑4‑3 | List of frequencies, from 9 V/m up to 28 V/m, PM (18 Hz or 217 Hz), FM 1 Hz | Complies |
| Immunity from Electrical Fast Transient (EFT) | IEC 61000‑4‑4 | ±2.0 kV on AC mains; Tr/Th - 5/50 ns, 100kHz | Complies |
| Immunity from Surge | IEC 61000‑4‑5 | ±2.0 CM/ ±1.0 kV DM on AC mains; Tr/Th - 1.2/50 (8/20) µs | Complies |
| Immunity from conducted disturbances induced by radiofrequency fields | IEC 61000‑4‑6 | 3.0, 6.0 VRMS on AC mains and Interconnection cables; 0.15 ÷ 80 MHz, 80% AM @ 1 kHz | Complies |
| Immunity from power frequency magnetic field | IEC 61000‑4‑8 | 30 A/m @ 50 Hz and 60 Hz | Complies |
| Immunity from voltage dips, short interruptions and voltage variations | IEC 61000‑4‑11 | On 230 VAC and 100 VAC mains; 0% - 0.5 cycle and 1 cycle; 70% - 25 cycles; 0% - 250 cycles | Complies |

For additional information, refer to the CARTO® 3 System *Instructions for Use*.

### Labels and Symbols on the SPU Hardware

https://bwiildita.sharepoint.com/sites/prod/Topics/MEB\_external\_labels\_EN.xml

|  |  |
| --- | --- |
| **SPU Power Supply Label** | ![SPU_label_v7p3.png](data:image/png;base64...) |
| **Defibrillation-Proof CF** Symbol | ![dfib.gif](data:image/png;base64...)  The ECG inputs of the SPU are defibrillation-proof. |

## Hardware

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_HW\_title\_EN.xml

### SPU Dimensions

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_Dimensions\_EN.xml

Table 3: Component Dimensions

| Component | Width [mm (in)] | Height [mm (in)] | Depth [mm (in)] | Weight [kg (lbs)] |
| --- | --- | --- | --- | --- |
| SPU | 100 (3.94) | 93 (3.66) | 270 (10.63) | 1.35 (2.98) |
| Holder | 106.4 (4.19) with SPU | 242 (9.53) | NA | 1.4 (3.09) |

### Applied Current

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Applied\_Current\_EN.xml

Table 4: Rated Current/Power for the SPU

| Type | Rated Current/Power | Source |
| --- | --- | --- |
| DC | 1.3 Amp /31.2 Watt | PIU Power Supply (24 V DC) |

### Environmental Conditions

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Environ\_Conditions\_EN.xml

Table 5: Environmental Conditions for the SPU Operation and Storage

| Environment | Condition | Minimum | Maximum |
| --- | --- | --- | --- |
| Operating | Temperature | 10 ºC (50 ºF) | 30 ºC (86 ºF) |
| Relative Humidity | 25% | 75% |
| Atmospheric Pressure | 700 hPa | 1050 hPa |
|  |  |  |  |
| Storage | Temperature | –10 ºC (14 ºF) | 50 ºC (122 ºF) |
| Relative Humidity | 15% | 95% |

Table 6: Protection Against the Ingress of Water

| Rating | Value |
| --- | --- |
| IP Rating | IPX0 |

### Servicing

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_Servicing\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**  The SPU and its related components are not user serviceable. Only personnel certified by Biosense Webster can service the SPU. |

The SPU and its related components have no internal parts that require servicing or maintenance by users. If the SPU does not function properly, contact the Biosense Webster Call Center.

The expected service life of the SPU is 7 years, based on Mean Time Between Failures (MTBF) tests.

**Standard Periodic Maintenance Activities**

During the annual service visit, the Biosense Webster, Inc. service personnel will perform the following activities for the SPU:

* Visual inspection for signs of physical damage
* Ensure that the components are assembled correctly
* Inspect cables and connectors, replacing cables if required
* Verify that serial number of the SPU matches the records

### Cleaning the SPU

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Cleaning\_the\_SPU\_EN.xml

REP9626: V7 SPU 8.1.1-8.1.2

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Before cleaning the SPU, or the SPU cables, always disconnect the SPU from the power supply. |

The SPU does not require sterilization or disinfection. To clean the outside of the SPU, wipe with a slightly damp cloth. It is recommended to dampen the cloth with alcohol-free hand soap and water.

For all other cables, disconnect the cables from the SPU, and clean them with a slightly damp cloth.

The following materials are approved for cleaning the cables:

* Alcohol-free hand soap
* Diluted ammonia (2%)
* Sodium hypochlorite (bleach) solution 10% in water
* Hydrogen peroxide
* Methylated spirit
* Isopropyl alcohol
* Distilled water

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Do not immerse cables in liquid.  During cleaning, ensure that all cable connectors remain dry. |

Extension cables for SPU-supported catheters may require sterilization. Refer to the cable's *Instructions for Use* for details.

## Assembling the SPU Holder

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_holder\_assembly\_left-right\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The SPU holder can be configured for any side of the CARTO® 3 System cart, patient table, or Boom. Before assembling the holder, decide in which direction you want the SPU to face in its intended location. |

**Assemble the SPU holder, as follows:**

|  |  |
| --- | --- |
| 1. | Place the SPU upside-down on a flat surface.![SPU_upside-down.jpg](data:image/jpeg;base64...) |
| 2. | Fit the black SPU Holder Cradle Assembly over the space at the bottom of the SPU, coordinating the screw-holes.![SPU_black_holder.jpg](data:image/jpeg;base64...)  The silicon cable holders should face the top of the SPU. |
| 3. | Fit the white SPU Holder Cradle Base into the space, according to the direction in which you want the SPU to be hung.   |  |  | | --- | --- | | ![SPU+holder-right.jpg](data:image/jpeg;base64...) | ![SPU+holder-left.jpg](data:image/jpeg;base64...) | | The holder is shown with the brackets of the Cradle Base in the appropriate direction. | | |
| 4. | Place the 4 provided screws into the holes and fasten the Cradle Base to the bottom of the SPU by tightening the screws with the provided screwdriver.![SPU_holder_screws.jpg](data:image/jpeg;base64...) |
| 5. | Align the brackets of the white Cradle Base with the bottom of the SPU Holder Clamping Assembly and slide the SPU unit on to the Holder until it clicks into place.   |  |  | | --- | --- | | ![SPU_holder_slide_a.jpg](data:image/jpeg;base64...) | ![SPU_holder_slide_b.jpg](data:image/jpeg;base64...) | |
| 6. | Attach the SPU holder to a rectangular rail of the CARTO® 3 System cart, patient table, or the Boom.   |  |  | | --- | --- | | 6.1 | Place the SPU Holder Clamping Assembly next to the rail and press and hold the spring bolt. | | 6.2 | Fit the Clamp over the top of the rail. | | 6.3 | Push the SPU Holder Clamping Assembly down against the rail and release the spring bolt. Ensure that the SPU Holder Clamping assembly has a firm grip on the railing. | |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  REP9626: V7 SPU 1.3.1, 1.3.2  When attaching the SPU holder to the cart, bedrail, or Boom, ensure that the SPU:   * Is at least 0.60 m away from the Location Pad. * Is at least 0.20 m away from the PIU. |

## Connecting the SPU

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_Connect\_EN.xml

sBIT bug resolution

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The SPU performs a self-test for verifying its electrical functionality. Since this test includes verification of ECG channel functionality, do not connect the catheter or extension cable until the test is complete (up to 1 minute). |

### Connecting to the PIU Power Supply

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Connect\_to\_Power\_Supply\_EN.xml

REP9626: V7 SPU 1.1.16

The SPU connects to the PIU Power Supply with a branched cable. LED indicators on the front of the SPU light up when the power is ON.

![CW-0303-30F_Ycable.jpg](data:image/jpeg;base64...)

Figure 3: Branched (Y) Power Cable

| Connection Description | Image |
| --- | --- |
| Branch of the Y-cable marked **Power Supply** connects to the PIU Power Supply. | ![PIU_powerSupply_front_power.png](data:image/png;base64...) |
| Branch of the Y-cable marked **SPU** connects to the SPU. | ![SPU_back_power.png](data:image/png;base64...) |

### Connecting the SPU to the PIU

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Connect\_to\_PIU\_EN.xml

REP9626: V7 SPU 1.3.3

The SPU connects to the back of the PIU with a fiber optic cable, and to the front of the PIU with two 20 POLE interface cables for a diagnostic catheter with more than 20 mapping electrodes. Do not use any other interface cables with the SPU.

Connect the cables in the following recommended sequence:

|  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 1. | Connect the 20 POLE interface cables as follows:   |  |  |  |  |  | | --- | --- | --- | --- | --- | | 1.1 | |  |  |  | | --- | --- | --- | | Connect the white connectors of the 2 20 POLE interface cables to the to Pole A and to Pole B sockets on the SPU.   |  |  | | --- | --- | | ![SPU_to_PIU_Cable_white_connectors.jpg](data:image/jpeg;base64...) | ![SPU_back_poleA-B.png](data:image/png;base64...) | | | | 1.2 | |  |  |  | | --- | --- | --- | | Connect the light blue connectors of the 2 20 POLE interface cables to the 20 POLE A and 20 POLE B sockets of the PIU.   |  |  | | --- | --- | | ![SPU_to_PIU_Cable_blue_connectors.jpg](data:image/jpeg;base64...) | ![PIU_front_poleA+B.png](data:image/png;base64...) |   REP9626: V7 SPU 1.1.14, 1.1.15  The cable connected to the To Pole A socket on the SPU must be connected to the 20 POLE A socket on the PIU.  The cable connected to the To Pole B socket on the SPU must be connected to the 20 POLE B socket on the PIU. | | |
| 2. | Connect the Ethernet (fiber optic) cable as follows:   |  |  |  |  |  | | --- | --- | --- | --- | --- | | 2.1 | |  |  |  | | --- | --- | --- | | Connect one end of the fiber optic cable to the Ethernet port on the SPU.   |  |  | | --- | --- | | ![PIU_FO_orange_single_connector.png](data:image/png;base64...) | ![SPU_back_Ethernet.png](data:image/png;base64...) | | | | 2.2 | |  |  |  | | --- | --- | --- | | Connect the other end of the fiber optic cable to the Ethernet 2 port on the PIU.   |  |  | | --- | --- | | ![PIU_FO_orange_double_connector.png](data:image/png;base64...) | ![PIU_back_no_cables_ethernet2.png](data:image/png;base64...) | | | |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When disconnecting the SPU from the PIU, it is recommended to remove the 20 POLE interface cables from the PIU only. Do not disconnect the 20 POLE cable from the SPU. |

### Tests on SPU Start-Up

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_2\_update\_win10\_EN.xml

sBIT bug resolution

The SPU performs a self-test for verifying its electrical functionality. Since this test includes verification of ECG channel functionality, do not connect the catheter or extension cable until the test is complete (up to 1 minute).

During the test, the SPU LED indicators are blue or green. When the SPU LED and the SPU Status icon in the System Status Panel are both a steady green, you can connect the catheter.

For additional information, see ["SPU LED Status"](#target9000001).

In addition, each time the SPU is fully connected and powered on, the Workstation checks the version number. If there is a mismatch between the SPU and the CARTO® 3 System, the SPU software is updated. During the update, a progress bar appears in the System Status panel. When the update is complete, a pop-up appears, instructing you to reboot the SPU by disconnecting and reconnecting the power cable. This is a one-time update.

### Connecting a Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Connect\_to\_Catheter\_EN.xml

Before connecting the catheter to the SPU, ensure that the SPU is connected and ready for use. The LED is green and the green connection icon appears on the System status bar.

sBIT bug resolution

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  SPU startup can take up to 1 minute to complete. Confirm that the SPU startup is complete before connecting an SPU-supported catheter. |

REP9626: V7 SPU 1.3.6

|  |  |  |  |
| --- | --- | --- | --- |
| 1. | Connect the catheter to the SPU extension cable connector.![OCTARAY_SPU_Extension_Cable_EN.png](data:image/png;base64...)   |  |  | | --- | --- | | Example: The OCTARAY™ Mapping Catheter is shown here. | ![SPU_OCTARAY_Catheter_EN.png](data:image/png;base64...) | |
| 2. | Connect the SPU extension cable to the SPU. ![OCTARAY_SPU_and_Extension_Cable_EN.png](data:image/png;base64...) |

### SPU LED Status

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_SPU\_LED\_Indicators\_EN.xml

The following table describes the LED status indication for standard SPU operating conditions.

| SPU State | Indication | Description |
| --- | --- | --- |
| **Startup** | ![SPU_Front_No_Power_Blank_LEDs_EN.JPG](data:image/jpeg;base64...)![SPU Front Startup Blue.JPG](data:image/jpeg;base64...) | When the PIU power supply is switched on, the SPU goes through a startup process, consisting of power-up, initialization, and internal testing.  The SPU LED indicators are either blue or steady/blinking green. |
| **Operational** | ![SPU_Front_Operational_Green_LEDs_EN.JPG](data:image/jpeg;base64...) | If no errors were detected during startup, the SPU is operational, and the SPU LED indicators are green.  The SPU LED indicators remain green unless the state of the SPU changes. |
| **Error** | ![SPU_Front_Non-Operational_Red_LEDs_EN.jpg](data:image/jpeg;base64...) | If a voltage or a temperature problem is detected, the SPU is not operational, and the SPU LED indicators are red.  The SPU LED indicators remain red until the issue is resolved. |
| **Software Update** | During a software update, the SPU LED indicators are magenta. | |

### Status Indication Panel

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_P3\_Status\_Indication\_EN.xml

When you create a new study with the SPU connected to the PIU, the SPU Status icon appears on the System Status Panel.

![SPU_Status_Panel_with_Fully_Connected_SPU_Highlighted_EN.jpg](data:image/jpeg;base64...)

Figure 4: Sample System Status Panel with Fully Connected SPU

The SPU automatically performs several start-up and validation functions, including electrical and external device communication status, cable connectivity, noise filtering, and temperature monitoring. If issues are detected, the SPU Status icon and/or the System messages provide indication.

Table 7: SPU Status Indication

| Status | Icon | Description |
| --- | --- | --- |
| Connected | ![SPU_Icon_Indicator_Con_Con1_EN.png](data:image/png;base64...) | The SPU is fully connected and ready for use. This indicates the following:   * The branched cable is connected to the Power Supply. * The 20 POLE interface cables are connected to the SPU, and to the 20 POLE A and 20 POLE B sockets of the PIU. * A functioning Ethernet cable is connected to the SPU and the PIU. * The SPU and the PIU are synchronized. |
| Disconnected or Error | ![SPU_Icon_Indicator_Dis_Dis1_EN.png](data:image/png;base64...) | There is an error or a lack of communication between the SPU and the Workstation. |
| REP9626: V7 SPU 1.6.4, 1.8.2, 1.10.1  No Sync  or  Self test | ![SPU_Icon_Indicator_Dis_Con1_EN.png](data:image/png;base64...) | The SPU and the PIU are connected via the Ethernet cable, but they are not synchronized or when the SPU is first started, during the self-test. |

## Troubleshooting

https://bwiildita.sharepoint.com/sites/prod/Topics/SPU\_HW\_Troubleshooting\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If an error message recommends rebooting the SPU, ensure that you disconnect the catheter before disconnecting the SPU power cable. Reconnect the power cable, and then wait for the SPU self test to complete before reconnecting the catheter. |

The examples in the table below describe possible SPU error conditions and their resolutions.

| Issue | Indication | Corrective Actions |
| --- | --- | --- |
| **No Power**  REP9626: V7 SPU 1.1.16 | No SPU LED indication  ![SPU_Front_Connected_No Power_Blank_LEDs_EN.JPG](data:image/jpeg;base64...) | Perform the following until resolved:  1. Turn the Power Supply on.  2. Ensure that the Power Supply is connected to a properly functioning main power source.  3. Ensure that the power cable is securely connected to the PIU Power Supply and the SPU. See ["Connecting to the PIU Power Supply"](#target9000002).  4. Replace the power cable.  5. If the problem persists, replace the SPU. |
| REP9626: SPU 1.1.6  **Voltage or temperature problem** | SPU LED indicators are red  ![SPU_Front_Non-Operational_Red_LEDs_EN.jpg](data:image/jpeg;base64...) | Perform the following until resolved:  1. Ensure that the SPU is completely uncovered.  2. Ensure that the SPU has a minimum clearance of at least:   * 0.60 m from the Location Pad * 0.20 m from the PIU   3. Reset the power to the SPU by disconnecting and reconnecting the power cable to the SPU. See ["Connecting to the PIU Power Supply"](#target9000003).  4. Replace the power cable.  5. If the problem persists, replace the SPU. |
| REP9626: V7 SPU 1.1.12  **Ethernet connection issue** | SPU LED indicators flash green  ![SPU_Front_No_Ethernet_Blank_LEDs_EN.JPG](data:image/jpeg;base64...)  ![SPU_Front_No_Ethernet_Green_LEDs_EN.JPG](data:image/jpeg;base64...) | The LED might flash green during the self-test. If the indicator flashes green at any other time, perform the following until resolved:  1. Ensure that the correct Ethernet cable is in use. If not, replace the cable.  2. Ensure that the Ethernet cable is properly and securely connected to the PIU and the SPU. See ["Connecting the SPU to the PIU"](#target9000004).  3. Replace the Ethernet cable.  4. If the problem persists, replace the SPU. |
| REP9626: V7 SPU 1.1.13  **Incorrect 20 POLE cable connection** | * Error message * Indication in Catheter Setup screen   ![SPU_Catheter_Setup_A_in_REF-DECA_and_B_Correct_EN.jpg](data:image/jpeg;base64...)   * Status icon   ![SPU_Icon_Indicator_Dis_Con1_EN.png](data:image/png;base64...) | If the cables between the SPU and the front of the PIU are not correctly connected, use one of these methods to resolve the issue:   * Refer to the indication in the Catheter Setup screen. A red triangle appears next to the socket that is not connected correctly. * Follow the instructions in the error message to resolve the issue. Refer to the Error Messages chapter in the CARTO® 3 System *Instructions for Use* for details. |

|  |  |
| --- | --- |
| ![](data:image/jpeg;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) 0344 |  |

![_TBCO11;B=20;W=160.50pt;H=39.75pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5070-00HREV01A](data:None;base64...)

![](data:image/png;base64...)

1. 1 Consult your Biosense Webster representative regarding availability in your country. [↑](#footnote-ref-1)
2. 2 See Multi-Connector TPI Ready sticker on the back of the PIU. [↑](#footnote-ref-2)