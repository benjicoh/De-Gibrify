|  |
| --- |
|  |
| User Guide |
|  |

|  |
| --- |
| () |
| November 2024 |
|  |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © 2008 - 2024 by Biosense Webster, Inc. All rights reserved.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  *Federal (USA) law restricts this device to sale by or on the order of a physician.* |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Any serious incident that has occurred due to, or during, the use of the product described herein should be reported to Biosense Webster. In Europe a report should also be made to the competent authority of the Member State in which the user and/or patient is established. |

Third-party trademarks used herein are trademarks of their respective owners.

Some pictures in this document are provided courtesy of ©STOCKERT GmbH.

For Biosense Webster patent information, see:

<http://www.biosensewebster.com/virtualpatentmarking>

See the documentation CD accompanying the CARTO™ 3 System for information on third party software notices applicable to this product.

P.N.: UG-5400-8481 (P01)

5 November 2024

Table of Contents

[Connecting the CARTO™ 3 System to Other Equipment in the EP Lab 1](#_Toc181736032)

[Safety 1](#_Toc181736033)

[Workstation Connections 2](#_Toc181736034)

[Dell Precision™ T5860 Workstation 2](#_Toc181736035)

[Dell Precision™ T5820 Workstation 2](#_Toc181736036)

[HP Z4 G5 Workstation 4](#_Toc181736037)

[HP Z4 G4 Workstation 4](#_Toc181736038)

[Network Connectivity Security 5](#_Toc181736039)

[Secure Communications Certificate 5](#_Toc181736040)

[Security Maintenance 5](#_Toc181736041)

[Firewall Configuration for CARTO™ 3 System Digital Services 5](#_Toc181736042)

[Updating the Antivirus Definition File 7](#_Toc181736043)

[Updating Antivirus Definition Files Automatically 7](#_Toc181736044)

[Updating Antivirus Definition Files Manually 8](#_Toc181736045)

[DICOM Network Connectivity 9](#_Toc181736046)

[Reserved IP Addresses 9](#_Toc181736047)

[Required Site Information 10](#_Toc181736048)

[Setting Up Hardware for PACS Connectivity 11](#_Toc181736049)

[DICOM Network Configuration Schemes 11](#_Toc181736050)

[Configuring the DICOM Network 12](#_Toc181736051)

[RF Generator Connectivity 17](#_Toc181736052)

[Connect to the SMARTABLATE™ System 17](#_Toc181736053)

[Connect to the nGEN™ System 18](#_Toc181736054)

[Display System Connectivity 20](#_Toc181736055)

[Safety Considerations 20](#_Toc181736056)

[Generic Monitor Connectivity 20](#_Toc181736057)

[DVI Cable Kit 21](#_Toc181736058)

[Connect a Standard Optical DVI Cable 25](#_Toc181736059)

[Pacing Stimulator Connectivity 27](#_Toc181736060)

[Connect the CARTO™ 3 System to a Stimulation Device 29](#_Toc181736061)

[Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F 30](#_Toc181736062)

[EP Recording System Connectivity 32](#_Toc181736063)

[BS ECG Connectivity 33](#_Toc181736064)

[ICEG Connectivity 34](#_Toc181736065)

[Stimulation Connectivity 34](#_Toc181736066)

[Generic Connection 34](#_Toc181736067)

[Setting Up the Generic Connection 35](#_Toc181736068)

[Connecting to GE CardioLab® 36](#_Toc181736069)

[Connecting the BS ECG Cable 37](#_Toc181736070)

[Connecting the ICEG Cable 37](#_Toc181736071)

[Stimulation Connectivity 38](#_Toc181736072)

[Configure the CardioLab® System 38](#_Toc181736073)

[Connecting to Bard LabSystem™ PRO 39](#_Toc181736074)

[Connect the BS ECG Cable 41](#_Toc181736075)

[Connect the ICEG Cable 41](#_Toc181736076)

[Stim Splitter Adapter Cable 41](#_Toc181736077)

[Configuring the CLEARSIGN™ Amplifier 42](#_Toc181736078)

[Connecting to Siemens AXIOM Sensis XP 43](#_Toc181736079)

[Difference in Signal Display 43](#_Toc181736080)

[Define Recommended Filter Settings 44](#_Toc181736081)

[Recording System Connections for HD Catheters 45](#_Toc181736082)

[OCTARAY™ Catheter 45](#_Toc181736083)

[OPTRELL™ 36 Catheter 46](#_Toc181736084)

[OPTRELL™ 48 Catheter 47](#_Toc181736085)

[Fluoroscopy System Connectivity 50](#_Toc181736086)

[Installation 50](#_Toc181736087)

[Image Retrieval from Fluoroscopy System 51](#_Toc181736088)

[Philips X-Ray System 51](#_Toc181736089)

[Philips Allura 3D Coronary Angiography 51](#_Toc181736090)

[EP Navigator Interface 53](#_Toc181736091)

[Siemens X-Ray System 57](#_Toc181736092)

[Configuring syngo DynaCT for Connectivity 57](#_Toc181736093)

[GE X-Ray System 62](#_Toc181736094)

[Configure AW VolumeShare™ 4 for Connectivity 62](#_Toc181736095)

[Ultrasound System Connectivity 67](#_Toc181736096)

[Overview 67](#_Toc181736097)

[Supported Ultrasound Catheters 67](#_Toc181736098)

[Ultrasound Video Interface 67](#_Toc181736099)

[Connecting the Workstation to the Vivid™ iq System 68](#_Toc181736100)

[Connecting the Workstation to Vivid S70/S60/S70N/S60N 69](#_Toc181736101)

[Connecting the Workstation to the ACUSON P500™ System 71](#_Toc181736102)

[Connecting the Workstation to the ACUSON SC2000™ System 72](#_Toc181736103)

[Connecting the Workstation to the ACUSON Origin™ System 73](#_Toc181736104)

[Peripherals 74](#_Toc181736105)

[Keyboard Requirements 74](#_Toc181736106)

[Mouse Requirements 74](#_Toc181736107)

[KVM Switch Requirements 74](#_Toc181736108)

[Printer Requirements 74](#_Toc181736109)

[Generic Network Equipment 75](#_Toc181736110)

List of Tables

[Table 1: Reserved IP Addresses 9](#_Toc181736187)

[Table 2: Equipment for Generic Connection to the EP Recording System 34](#_Toc181736188)

[Table 3: CARTO™ 3 System to CardioLab® Interface Cables 36](#_Toc181736189)

[Table 4: CARTO™ 3 System to LabSystem™ PRO Interface Cables 39](#_Toc181736190)

[Table 5: CARTO™ 3 System to CLEARSIGN™ Input Connections 42](#_Toc181736191)

[Table 6: Filter Settings 43](#_Toc181736192)

[Table 7: Recording System Connections 45](#_Toc181736193)

[Table 8: Recording System Connections 46](#_Toc181736194)

[Table 9: Recording System Connections 48](#_Toc181736195)

[Table 10: Key to Connecting the Workstation and the Vivid™ iq System 69](#_Toc181736196)

[Table 11: Key to Connecting the Workstation and the Vivid™ S70 System 70](#_Toc181736197)

[Table 12: Key to Connecting the Workstation and the ACUSON P500™ System 71](#_Toc181736198)

[Table 13: Key to Connecting the Workstation and the ACUSON SC2000™ System 72](#_Toc181736199)

[Table 14: Key to Connecting the Workstation and the ACUSON Origin™ System 73](#_Toc181736200)

List of Figures

[Figure 1: Dell T5860 Connections 2](#_Toc181736201)

[Figure 2: Connections for Dell T5820 with A4000 or T1000 GPU 3](#_Toc181736202)

[Figure 3: Dell T5820 Connections 3](#_Toc181736203)

[Figure 4: HP Z4 G5 Connections 4](#_Toc181736204)

[Figure 5: Connections for HP Z4 G4 with A4000 or T1000 GPU 4](#_Toc181736205)

[Figure 6: Shared Server 12](#_Toc181736206)

[Figure 7: Separate Servers 12](#_Toc181736207)

[Figure 8: System Tools Menu 12](#_Toc181736208)

[Figure 9: DICOM Network Configuration 13](#_Toc181736209)

[Figure 10: SMARTABLATE™ System Connections 18](#_Toc181736210)

[Figure 11: nGEN™ System Connections 19](#_Toc181736211)

[Figure 12: Available Monitor Connections—HP Z4 with DVI Port for Primary Monitor 21](#_Toc181736212)

[Figure 13: Available Monitor Connections—all Workstations with DP for Primary Monitor 21](#_Toc181736213)

[Figure 14: Available Monitor Connections—Workstations with DP for Primary Monitor 21](#_Toc181736214)

[Figure 15: PIU Sockets for Stimulator Connectivity 27](#_Toc181736215)

[Figure 16: Generic (Locally Routed) Stimulation Socket Pair 27](#_Toc181736216)

[Figure 17: Emergency Stimulation Socket Pairs 28](#_Toc181736217)

[Figure 18: PIU Connections for a Stimulator: General Input (red) and Direct Inputs (blue) 29](#_Toc181736218)

[Figure 19: Recommended Stimulator Connection for ECG Cards EA‑5401‑162/162F 30](#_Toc181736219)

[Figure 20: Combined Connection: Recording System and Generic 30](#_Toc181736220)

[Figure 21: Combined Connection: Recording System and Direct 30](#_Toc181736221)

[Figure 22: System Panel Showing ECG Card Part Number 31](#_Toc181736222)

[Figure 23: PIU Connectors for EP Recording System Connectivity 33](#_Toc181736223)

[Figure 24: CardioLab® Front Panel 37](#_Toc181736224)

[Figure 25: CardioLab® Study Configuration (Example) 39](#_Toc181736225)

[Figure 26: LabSystem™ PRO Front Panel 41](#_Toc181736226)

[Figure 27: CLEARSIGN™ Amplifier Setup 43](#_Toc181736227)

[Figure 28: OPTRELL™ Mapping Catheter Unsupported Electrodes 48](#_Toc181736228)

[Figure 29: Allura–CARTO™ 3 System–PACS Connectivity 51](#_Toc181736229)

[Figure 30: Example DICOM Configuration for Connectivity to Allura System 53](#_Toc181736230)

[Figure 31: Server Icons 66](#_Toc181736231)

[Figure 32: CARTO™ 3 to Vivid™ iq Connections 69](#_Toc181736232)

[Figure 33: CARTO™ 3 to Vivid™ S70 Connections 70](#_Toc181736233)

[Figure 34: CARTO™ 3 Workstation to ACUSON P500™ Connections 71](#_Toc181736234)

[Figure 35: CARTO™ 3 Workstation to ACUSON SC2000™ Connections 72](#_Toc181736235)

# Connecting the CARTO™ 3 System to Other Equipment in the EP Lab

In This Chapter

[Safety 1](#_Toc181736111)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/ConnectUG\_intro\_v8p3\_EN.xml

The CARTO™ 3 System supports connectivity with a variety of third-party systems and equipment in the EP lab. In some cases, an add-on module is required to enable connectivity.

This document covers topics relating to connectivity with the CARTO™ 3 System for hospital staff to be aware of, but not to be responsible for remedying problems that may occur. Installation, testing, and maintenance of the equipment should be performed only by certified Biosense Webster-authorized Field Service Engineers (FSE).

Any unauthorized attempt to repair equipment that is still under warranty and service agreement voids that warranty.

Connectivity of the CARTO™ 3 System to third-party systems and equipment is dependent on local regulatory approval. Before connecting the CARTO™ 3 System to other systems or equipment, consult with your Biosense Webster representative to verify that connectivity is approved in your country.

## Safety

https://bwiildita.sharepoint.com/sites/prod/Topics/SafetyConnect\_EN.xml

In addition to specific safety information in the body of this manual, refer to the Safety chapter of the *CARTO™ 3 System Instructions for Use*.

# Workstation Connections

In This Chapter

[Dell Precision™ T5860 Workstation 2](#_Toc181736112)

[Dell Precision™ T5820 Workstation 2](#_Toc181736113)

[HP Z4 G5 Workstation 4](#_Toc181736114)

[HP Z4 G4 Workstation 4](#_Toc181736115)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/WS\_connect\_intro\_EN.xml

The exact locations of the ports vary depending on the model of Workstation installed. Refer to reference label attached to the Workstation.

## Dell Precision™ T5860 Workstation

https://bwiildita.sharepoint.com/sites/prod/Topics/WS\_connect\_Dell\_T5860\_v8p3\_EN.xml

The ports for the Dell T5860 Workstation are identified in the figure below.

![Dell_T5860_with_callouts.png](data:image/png;base64...)

Figure 1: Dell T5860 Connections

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A schematic label of the ports is affixed towards the back of the Workstation. |

## Dell Precision™ T5820 Workstation

https://bwiildita.sharepoint.com/sites/prod/Topics/T5820\_Connections\_intro.xml

There are two Dell T5820 Workstations options, as follows:

The ports for the Dell T5820 Workstation with A4000 or T1000 GPU are identified in the figure below.

![T5820_Prime_GPU_with_callouts.png](data:image/png;base64...)

Figure 2: Connections for Dell T5820 with A4000 or T1000 GPU

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A schematic label of the ports is affixed towards the back of the Workstation. |

The ports for the Dell T5820 Workstation for CARTO PRIME™ are identified in the figure below.

![Dell_T5820_Prime_with_callouts.png](data:image/png;base64...)

Figure 3: Dell T5820 Connections

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A schematic label of the ports is affixed towards the back of the Workstation. |

## HP Z4 G5 Workstation

https://bwiildita.sharepoint.com/sites/prod/Topics/WS\_connect\_HP\_Z4\_G5\_v8p3\_EN.xml

The ports for the HP Z4 G5 Workstation are identified in the figure below.

![HP_Z4G5_with_callouts.png](data:image/png;base64...)

Figure 4: HP Z4 G5 Connections

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A schematic label of the ports is affixed towards the back of the Workstation. |

## HP Z4 G4 Workstation

https://bwiildita.sharepoint.com/sites/prod/Topics/connectivity\_HP\_Z4\_G4\_WS\_v8p3\_EN.xml

The ports for the HP Z4 G4 Workstation with A4000 or T1000 GPU are identified in the figure below:

![HP_Z4G4_GPU_with_callouts.png](data:image/png;base64...)

Figure 5: Connections for HP Z4 G4 with A4000 or T1000 GPU

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A schematic label of the ports is affixed towards the back of the Workstation. |

# Network Connectivity Security

In This Chapter

[Secure Communications Certificate 5](#_Toc181736116)

[Security Maintenance 5](#_Toc181736117)

[Firewall Configuration for CARTO™ 3 System Digital Services 5](#_Toc181736118)

[Updating the Antivirus Definition File 7](#_Toc181736119)

[Updating Antivirus Definition Files Automatically 7](#_Toc181736120)

[Updating Antivirus Definition Files Manually 8](#_Toc181736121)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Network\_connectivity\_security\_EN.xml

To ensure the cybersecurity of the CARTO™ 3 System these security guidelines will help secure connections and communications needed to maintain a secure setup.

## Secure Communications Certificate

https://bwiildita.sharepoint.com/sites/prod/Topics/Secure\_comms\_certificate\_v8\_EN.xml

The provision of a secure communications certificate to be implemented in your CARTO™ 3System is the responsibility of a Biosense Webster representative. The certificate status is detailed on the About CARTO™ System Window.

## Security Maintenance

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Software\_Security\_Maintenance\_EN.xml

The security level of the CARTO™ 3 System software components is regularly maintained by the periodical deployment of **Security Service Packs** according to the Biosense Webster Security for Product policy. Security Service Packs may also be deployed to remedy emerging high-level risk security vulnerabilities.

When enabled, Security Service Packs can be pushed to the CARTO™ System. Indication appears in the opening screen when a new service pack is ready to install.

## Firewall Configuration for CARTO™ 3 System Digital Services

https://bwiildita.sharepoint.com/sites/prod/Topics/Cloud\_Security\_EN.xml

To enable the CARTO™ 3 System to communicate with Digital Services, the hospital IT must configure the hospital firewall as follows:

|  |  |
| --- | --- |
| 1. | **Outbound Connections for Cloud Communication**  Allow outbound traffic on the following ports **only to the specified domains**:  **Ports to allow outbound connections**:   * TCP/443 (HTTPS) * TCP/5671 (AMQPS) * TCP/8883 (SMQTT)   **Domains to allow for these ports**:   * global.azure-devices-provisioning.net * jnj-cloudpillar-jupiter-dps0.azure-devices-provisioning.net * jnj-cloudpillar-mars-dps0.azure-devices-provisioning.net * jnj-cloudpillar-venus-dps0.azure-devices-provisioning.net * jnj-cloudpillar-jupiter-iot0.azure-devices.net * jnj-cloudpillar-mars-iot0.azure-devices.net * jnj-cloudpillar-venus-iot0.azure-devices.net |
| 2. | **Certificate Verification**  To verify the validity of certificates using AIA, CRL, and OCSP protocols, allow outbound connections **only to the following domains** on the specified port:  **Port to allow outbound connections**:   * TCP/80 (HTTP)   **Domains to allow for these ports**:   * cacerts.digicert.com * cacerts.geotrust.com * www.microsoft.com * crl.microsoft.com * crl3.digicert.com * crl4.digicert.com * cdp.geotrust.com * mscrl.microsoft.com * ocsp.msocsp.com * ocsp.digicert.com * oneocsp.microsoft.com * status.geotrust.com |
| 3. | **DNS Communication**  If there is a firewall between the CARTO™ 3 System and your DNS servers, allow bidirectional traffic to your DNS servers on the following ports:   * TCP/53 (DNS) * UDP/53 (DNS) |
| 4. | **Antivirus Updates**  To facilitate automatic updates of antivirus definition files, allow outbound connections **only to the following domain** on the specified port:   * **Port to allow outbound connections**:   + TCP/80 (HTTP) * **Domain to allow for this port:**   + update.nai.com |
| 5. | **Restrict Inbound Connections**  No inbound connections from any domain should be allowed to the CARTO™ 3 System, except for the necessary bidirectional DNS traffic as specified in section 3. |

## Updating the Antivirus Definition File

https://bwiildita.sharepoint.com/sites/prod/Topics/AV\_connect\_intro\_v8p3\_EN.xml

The CARTO™ 3 System supports a seamless, background connection to the Trellix antivirus update website, allowing antivirus definition files to be updated automatically. These antivirus definition files can also be sourced manually.

### Updating Antivirus Definition Files Automatically

https://bwiildita.sharepoint.com/sites/prod/Topics/Antivirus\_automatic\_update\_EN.xml

The System's antivirus application runs automatically to download new antivirus definition files, performed upon either Shut Down or Scan & Shut Down when exiting the CARTO™ 3 System. Automatic antivirus updates use antivirus definition files sourced from Trellix.

For automatic antivirus updates, the hospital must configure:

* Outbound access from the CARTO™ 3 DICOM Ethernet Port to the domain name [update.nai.com](https://update.nai.com/products) on the HTTP port TCP/80.
* DNS server accessibility on TCP port 53.

In the DICOM Network Configuration dialog, configure local settings DNS Server 1 and DNS Server 2 according to hospital IT instructions. When the hospital network is configured correctly communication will not be blocked, and the antivirus updates should work. For additional information, see ["DICOM Network Connectivity"](#target9000002)

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  It is mandatory to connect the product to a network with a firewall, and to close all other ports. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Trellix requires you to add [update.nai.com](https://update.nai.com/products) as a named domain instead of using direct IP addresses[[1]](#footnote-1).  The hospital firewall must not allow inbound connections from any domain to the CARTO™ 3 System. |

You can test connectivity from the System to the Trellix antivirus definition update website using the Test button on the DICOM Network Configuration page, the result appears to the right of the button.

|  |  |
| --- | --- |
| ![DICOM_AVTest_success.png](data:image/png;base64...) | Indicates connectivity is present. |
| ![DICOM_AVTest_fail.png](data:image/png;base64...) | Indicates no connectivity. |
| ![DICOM_AVTest_notdone.png](data:image/png;base64...) | Indicates a test has not been performed. |

### Updating Antivirus Definition Files Manually

https://bwiildita.sharepoint.com/sites/prod/Topics/Antivirus\_manual\_update\_EN.xml

The antivirus definition files are saved to a USB mass storage device from a PC connected to the Internet, then transferred to the CARTO™ 3 System Workstation.

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| 1. | On a PC connected to the Internet, download the latest self-installing virus definition files from the Trellix site to a USB mass storage device:   |  |  | | --- | --- | | 1.1 | Format the USB mass storage device before each update. | | 1.2 | Insert a USB mass storage device. | | 1.3 | In a web browser, open <https://www.trellix.com/en-us/downloads/security-updates.html> (the URL at the time of publication) and download the latest V3 Virus Definition update (xDAT.exe file). | | 1.4 | Verify that the USB mass storage device has sufficient space for the file to be downloaded. | | 1.5 | Save the file to the root folder of the USB mass storage device. | | 1.6 | Correctly remove the USB mass storage device from the PC. | |
| 2. | On the CARTO™ 3 System Workstation:   |  |  | | --- | --- | | 2.1 | Insert or connect the USB mass storage device that was removed from the PC in the previous step. | | 2.2 | In the CARTO™ 3 System application, click System and then Security Updates, and wait for the process to complete. | | 2.3 | Correctly remove the USB mass storage device from the CARTO™ 3 System Workstation. | |

If for any reason you have trouble performing the update, contact a Biosense Webster representative.

# DICOM Network Connectivity

In This Chapter

[Reserved IP Addresses 9](#_Toc181736122)

[Required Site Information 10](#_Toc181736123)

[Setting Up Hardware for PACS Connectivity 11](#_Toc181736124)

[DICOM Network Configuration Schemes 11](#_Toc181736125)

[Configuring the DICOM Network 12](#_Toc181736126)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/PACS\_server\_config\_intro\_EN.xml

The CARTO™ 3 System supports connection to DICOM networks, enabling the following functionality:

* Backup and Restore procedures on a PACS server
* Retrieval of CT and MRI images from the radiology PACS server (for use with the CARTOMERGE™ Module)
* Retrieval of fluoroscope images (for fluoroscopy system connectivity)

For details about DICOM conformance of the CARTO™ 3 System, see the DICOM Conformance Statement on the Documentation CD. For details about CARTO™ 3 System security, see the Manufacturer Disclosure Statement for Medical Device Security and the CARTO™ 3 Security User Guide.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If your deployment requires secure communication, IPsec can be enabled. Configuring IPsec is performed only by a Biosense Webster representative. To enable IPsec, contact the Biosense Webster Call Center. |

## Reserved IP Addresses

https://bwiildita.sharepoint.com/sites/prod/Topics/reservedIP\_Addresses\_c3\_v8\_EN.xml

The CARTO™ 3 Workstation uses several IP addresses for communication with the PIU and other equipment in the lab. The addresses already in use are not available for configuring the CARTO™ 3 System – PACS connection.

The following IP addresses cannot be used for the CARTO™ 3 System – PACS connection.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Using any of the following IP addresses for the CARTO™ 3 System – PACS connection might cause address conflicts and impair functionality of the CARTO™ 3 System. |

The following IP addresses cannot be used for the CARTO™ 3 System – PACS connection.

Table 1: Reserved IP Addresses

| IP Address | Used By |
| --- | --- |
| **EP Recording System** | |
| 192.168.5.1 | CARTO™ 3 Workstation |
| 192.168.5.2 | EP Recording Computer |
| **PIU** | |
| 192.168.0.10 | CARTO™ 3 Workstation |
| 192.168.0.11 | CARTO™ 3 PIU |
| **Ultrasound System** | |
| 192.168.123.200 | Ultrasound System |
| 192.168.123.202 | CARTO™ 3 Workstation |
| **nGEN™ Generator** | |
| 192.168.168.21 | CARTO™ 3 Workstation (when NAVIGANT port is used for Generator) |
| 192.168.170.21 | CARTO™ 3 Workstation (when NAVIGANT port is used for Generator) - Encrypted |
| 192.168.168.22 | nGEN™ RF Generator |
| 192.168.170.22 | nGEN™ RF Generator - Encrypted |
| 192.168.168.23 | nGEN™ RF Remote Monitor |
| **EPU** | |
| 192.168.6.1 | CARTO™ 3 Workstation |
| 192.168.6.2 | CARTO™ 3VISITAG SURPOINT™ EPU |
| **Reserved for Future Use** | |
| 192.168.169.3 | CARTO™ 3 Workstation - Reserved for future use |
| 192.168.171.3 | CARTO™ 3 Workstation - Reserved for future use - Encrypted |
| 192.168.169.2 | Reserved for future use |
| 192.168.171.2 | Reserved for future use - Encrypted |

## Required Site Information

https://bwiildita.sharepoint.com/sites/prod/Topics/DICOM\_siteinfo\_v8p3\_EN.xml

Site information is used for configuring the DICOM network. Information required depends on the selected configuration scheme, including:

* IP address assigned to the CARTO™ 3 System on the hospital network
* Subnet Mask of the DICOM Network
* Default Gateway of the DICOM Network (if not on the same VLAN as the CARTO™ 3 System)
* Application Entities for the CARTO™ 3 System Store, Query, Restore, and Storage Commitment services
* Port numbers through which the CARTO™ 3 System and the PACS listen for each of the exported DICOM services
* IP Address of the PACS Server for exporting the Store, Query, Restore, and Storage Commitment services
* Application Entities of the PACS Server Store, Query, Restore, and Storage Commitment services exported for use by the CARTO™ 3 System
* Port numbers through which the PACS server listens for each of its exported DICOM services

The CARTO™ 3 Workstation uses several IP addresses for communication with the PIU and other equipment in the lab. The addresses already in use are not available for configuring the CARTO™ 3 System – PACS connection. For a list of IP addresses that are not available for use, see ["Reserved IP Addresses"](#target9000005).

Depending on the server users, the following services can be defined:

* Query—the CARTO™ 3 System searches data stored on the server.
* Restore—the CARTO™ 3 System retrieves data from the server.
* Store—the server stores data backed up from the CARTO™ 3 System.
* Storage Commitment—the server sends confirmation that the study has been successfully stored on the network.

The following table shows which services are used by each of the server users.

| User | Query | Restore | Store | Storage Commitment |
| --- | --- | --- | --- | --- |
| CARTO™ 3 System[[2]](#footnote-2) | Yes | Yes | No | No |
| Fluoroscopy Services | No | Yes | No | No |
| Image Integration | Yes | Yes | No | No |
| Study Archiver | Yes | Yes | Yes | Yes |

## Setting Up Hardware for PACS Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/configure\_pacs\_on\_carto\_v8p3\_EN.xml

To prepare the system hardware for PACS connectivity, connect the LAN cable between the Workstation (onboard network socket) and the DICOM network.

No connection of the PIU, LP, or Patch Unit is required.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The DICOM port on the back of the CARTO™ 3 workstation may appear in a different location on the back panel, depending on the model of workstation. |

## DICOM Network Configuration Schemes

https://bwiildita.sharepoint.com/sites/prod/Topics/DICOM\_network\_config\_schemes\_EN.xml

The procedure for configuring the DICOM network depends on site requirements. Two general configuration schemes are common:

* Connecting to a shared server for imaging (CT and MRI scans) and archiving (CARTO™ 3 Studies)
* Connecting to separate servers for imaging (CT and MRI scans), archiving (CARTO™ 3 Studies), and other functions

![PACS_shared_server_V8.jpg](data:image/jpeg;base64...)

Figure 6: Shared Server

![DICOM_Services_V8.jpg](data:image/jpeg;base64...)

Figure 7: Separate Servers

Various additional configurations are possible. The site setup might require using a different configuration.

## Configuring the DICOM Network

https://bwiildita.sharepoint.com/sites/prod/Topics/DICOM\_network\_config\_v8\_EN.xml

To configure the DICOM Network open the DICOM Network Configuration dialog from the Opening Screen, click System > DICOM Network.

![system_tools_v8p3.png](data:image/png;base64...)

Figure 8: System Tools Menu

The DICOM Network is configured using information depending on your configuration scheme, see ["DICOM Network Configuration Schemes"](#target9000006).

![DICOM_network_config_dialog-num.jpg](data:image/jpeg;base64...)

Figure 9: DICOM Network Configuration

|  | Section | Description |
| --- | --- | --- |
| 1 | Local Parameters | To edit the local settings, do one of the following:   * Under CARTO™ 3 System Local Parameters, select Edit. * Right-click CARTO™ 3 System Local Parameters and select Edit CARTO™ 3 Parameters.   The Edit CARTO™ 3 Parameters dialog appears.  ![Edit_params_gui_blank.png](data:image/png;base64...)  Enter the definitions for the CARTO™ 3 System as follows:   * In the CARTO™ 3 System Local IP box, enter the value for the IP address assigned to the CARTO™ 3 System on the network. * In the Subnet Mask box, enter the value defining the subnet boundary of the CARTO™ 3 System. * In the Default Gateway box, enter the Gateway IP Address. This defines the IP address of the gateway through which the CARTO™ 3 System passes to communicate with: the PACS server, the Trellix antivirus definition update website, and to retrieve Security Service Packs. * DNS Server 1 * DNS Server 2   Click OK for the parameters to display. |
| 2 | Configuring the Server | Adding a server to the network has two steps: adding the server, then adding services to the server.  If you are configuring a shared server, complete both steps adding all services.[[3]](#footnote-3) If you are configuring separate servers, repeat both steps for each server and add only the relevant services (see ["Required Site Information"](#target9000007)). |
| 3 | Managing a Server | Use Add, Edit, and Delete buttons to manage the server.  Select Add and enter required site information to the Add Server dialog.  ![DICOM_add_server_v8p3.png](data:image/png;base64...)   * Server Name * Server IP * Select Image Integration for importing CT and MRI scans from the hospital network * Select Study Archiver for storing and retrieving CARTO™ 3 Studies using the hospital network.   Click OK for the server and its configuration to display.  To modify the server configuration select the Server Name and click Edit or Delete. |
| 4 | Adding a Service | Use Add, Edit, and Delete buttons to manage the four available services Query, Restore, Store, and Storage Commitment (StoreCommit).  To add services right-click the server name and select Add Service (or double-click the server name). The Add Service dialog appears.  ![DICOM_add_servicev8p3.png](data:image/png;base64...)  When configuring each service the applicable input parameters are available for entering site information, complete as follows:  ![service_param_table.png](data:image/png;base64...)  Click OK for the service definitions to display.  To modify a service configuration highlight the service and select Edit or Delete. |
| 5 | PACS Server Connectivity | To test the PACS server configuration, select Test.  A message about the testing process appears.  ![DICOM_test_message.PNG](data:image/png;base64...)  Green check marks next to the server name and service types verify test success.  If the clock icon ![Archiver_StorageCommit_wait_icon.png](data:image/png;base64...) is displayed next to StoreCommit, the CARTO™ 3 System is still waiting for a response from the server.  To comprehensively test connectivity, reboot the workstation then back up and restore a CARTO™ 3 Study and an image study. Refer to the File Management chapter in the *CARTO™ 3 System Comprehensive User Guide*. |
| 6 | Antivirus Service | The Antivirus update service connectivityTest button verifies the connectivity status between the CARTO™ 3 System and the Trellix antivirus definition update website.  The System returns the test result indicating the success or failure of the connectivity test.  For additional information, see ["Updating the Antivirus Definition File "](#target9000008). |
| 7 | Software Service | The Software update service connectivityTest button verifies the connectivity status between the CARTO™ 3 System and the Digital Services backend.  The System returns the test result indicating the success or failure of the connectivity test.  For additional information, see ["Security Maintenance"](#target9000009). |
| 8 | Is Secure | Indicates a secure connection is required between the CARTO™ 3 System and the PACS server. |

If a DICOM connectivity issue is detected, an error message appears in the upper right corner of the dialog. The status updates every 10 seconds, the error may resolve before the message disappears.

|  |  |
| --- | --- |
| ![DICOM_cable_unplugged.jpg](data:image/jpeg;base64...) | Ensure that the cable is connected correctly. |
| ![DICOM_ping_failed.jpg](data:image/jpeg;base64...) | Ensure that the local parameters are configured correctly. |

# RF Generator Connectivity

In This Chapter

[Connect to the SMARTABLATE™ System 17](#_Toc181736127)

[Connect to the nGEN™ System 18](#_Toc181736128)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/RF\_Generator\_Connectivity\_v8\_EN.xml

REP 4611 D-V1-1.25.1

The CARTO™ 3 System can be connected to an RF generator. The RF generators listed below are fully supported. Use of any other RF generator with the system requires approval from a Biosense Webster representative.

| Generator | Connectivity through… | Connects to... |
| --- | --- | --- |
| SMARTABLATE™ System RF Generator | RF generator adapter cable | RF GENERATOR socket of the PIU |
| Serial data cable | CARTO™ 3 Workstation |
| nGEN™ Generator | Ethernet cable | CARTO™ 3 Workstation |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The system might create a 5–10 ohm impedance offset on the RF generator. * Before you initialize catheter visualization, the RF generator must be connected and switched on and the RF generator patch must be connected. Do not switch the RF generator off during initialization. |

## Connect to the SMARTABLATE™ System

https://bwiildita.sharepoint.com/sites/prod/Topics/Connect\_SMARTABLATE\_v8p3\_EN.xml

This section describes the connections between the SMARTABLATE™ and the CARTO™ 3 System. For additional generator connectivity information, refer to documentation provided with your generator.

![SMARTABLATE_C3_connections.PNG](data:image/png;base64...)

Figure 10: SMARTABLATE™ System Connections

|  | Connection | Description |
| --- | --- | --- |
| 1 | CATHETER 1 – connection to the CARTO™ 3 System PIU | Connect the 10-pin connector of the RF generator cable to the CATHETER 1 socket on the front of the generator and the 20-pin connector of the cable to the RF GENERATOR socket on the front of the PIU. |
| 2 | Serial data port 2 – connection to the CARTO™ 3 Workstation | Connect the Redel connector of the serial data communication cable to serial data port 2 on the back of the generator and the D-subminiature connector of the cable to the CARTO™ 3 Workstation. |

See the SMARTABLATE™ System RF Generator User Manual for instructions on testing communication between the systems.

## Connect to the nGEN™ System

https://bwiildita.sharepoint.com/sites/prod/Topics/Connecting\_nGEN\_EN.xml

This section describes the connections between the nGEN™ and the CARTO™ 3 System. For additional generator connectivity information, refer to documentation provided with your generator.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The connections in the setups below are the same whether the CARTO™ 3 Workstation is installed in the EP lab or installed in the observation room (control room). |

|  |  |
| --- | --- |
| ![nGEN_frnt_n_rear.JPG](data:image/jpeg;base64...)  Figure 11: nGEN™ System Connections | |
| 1 | Ethernet cable – connection from the CARTO™ 3 System Workstation's NAVIGANT port to an available nGEN™ system LAN port. |
| 2 | Cable – connection from the CARTO™ 3 PIU's RF GENERATOR socket or MAP socket (depending on which catheter is used) to the nGEN™ Console's ABLATION socket or SYSTEM socket. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The Ethernet cable must be connected to the same port used during the initial installation of the nGEN™ Generator. The NAVIGANT port is the default port; however, the EP port or U/S port may have been used instead if the NAVIGANT port was unavailable at the time of installation. **Use of any other port requires configuration by an authorized Biosense Webster Technician**. |

# Display System Connectivity

In This Chapter

[Safety Considerations 20](#_Toc181736129)

[Generic Monitor Connectivity 20](#_Toc181736130)

[DVI Cable Kit 21](#_Toc181736131)

[Assembling the Protective Sleeves on the Cable 22](#_Toc181736132)

[Connecting the DVI Cable 23](#_Toc181736133)

[Updating the Supported Resolution of the DVI Cable Kit 24](#_Toc181736134)

[Connect a Standard Optical DVI Cable 25](#_Toc181736135)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Display\_connectivity\_title\_EN.xml

## Safety Considerations

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_Safety\_Considerations\_EN.xml

To ensure elimination of touch-current hazard, the connectivity of the monitors located in the operating room should include safety solutions, such as:

* Galvanic isolation (fiber-optic DVI connection, or DVI/VGA isolation box)
* Grounding monitor(s) connected to the boom; no access to the metal part of the DVI/VGA connectors on the boom for clinical staff during EP procedures

## Generic Monitor Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_Monitor\_Requirements\_v8p3\_EN.xml

The CARTO™ 3 System supports the following monitor resolutions:

* 2560 × 1440
* 1920 × 1200
* 1920 × 1080
* 1600 × 1200

The CARTO™ 3 System can be connected to high resolution medical grade monitors. When connecting the system to medical grade monitors, ensure the following:

* The CARTO™ 3 System is presented in its native resolution, without any pixel manipulation.
* The same resolution is supplied in both monitors.

The available analog and digital connections for the monitors with the HP Z4 G4 and HP Z4 G5 Workstations with a DVI Port for the Primary Monitor are summarized in the following diagram.

![MonitorOutputsT5810.jpg](data:image/jpeg;base64...)

Figure 12: Available Monitor Connections—HP Z4 with DVI Port for Primary Monitor

The available analog and digital connections for the monitors with all workstation with a DP for the Primary Monitor are summarized in the following diagram.

![MonitorOutputsT5820with2080.jpg](data:image/jpeg;base64...)

Figure 13: Available Monitor Connections—all Workstations with DP for Primary Monitor

The available analog and digital connections for the monitors with workstation with a DP for the Primary Monitor are summarized in the following diagram.

![MonitorOutputsT5820with2080.jpg](data:image/jpeg;base64...)

Figure 14: Available Monitor Connections—Workstations with DP for Primary Monitor

### DVI Cable Kit

https://bwiildita.sharepoint.com/sites/prod/Topics/DVI\_Cable\_Kit\_v8p3\_EN.xml

The Optical DVI Detachable Transmitter Receiver Kit includes the following:

* Fiber optic cable 2×LC to 2×LC, hardened, 30 m
* Pair of programmed adapters DVI to/from LC optical cable: Tx and Rx
* USB power cable 30 cm with plug – P01A
* USB Cable Type A to B, 0.25 m
* Plastic sleeve (×2) for protecting the cable

In the kit, the cable is supplied pre-assembled. The adapters are connected according to the color code marked on the adapters and cable ends.

The kit is adapted to the resolution of a 24-inch monitor (1920 × 1200).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If the DVI cable kit is installed on a monitor with a resolution other than 1920 × 1200, adjustments are made at time of system setup by the Biosense Webster Field Service Engineer. |

#### Assembling the Protective Sleeves on the Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/DVI\_cable\_sleeves\_EN.xml

To protect the cable, two plastic sleeves are supplied with the kit.

|  |  |
| --- | --- |
| 1. | Disassemble the transmitter and receiver units.  ![DVI_adapter_disassembled.jpg](data:image/jpeg;base64...) |
| 2. | Assemble one sleeve on each end of the cable.  ![DVI_cable_with_sleeve.jpg](data:image/jpeg;base64...) |
| 3. | Reassemble the transmitter and receiver units on the cable ends according to the color code marked on the adapters and cable ends.  ![DVI_adapter_assembled.jpg](data:image/jpeg;base64...) |

#### Connecting the DVI Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/Connect\_DVI\_Cable\_v8p3\_EN.xml

The following three connections are required to connect the monitors with the Workstation:

* Connect the receiver end of the DVI cable to the repeater monitor.
* Connect one of the USB power cables from the DVI cable to the outer USB port on the monitor.
* Connect the transmitter end of the DVI cable to the CARTO™ 3 Workstation.

|  |  |  |
| --- | --- | --- |
| ![DVI_Monitor_connections.jpg](data:image/jpeg;base64...) | | ![DP-to-DVI-D.jpg](data:image/jpeg;base64...) |
| **Left:** Receiver end of DVI cable | **Right:** USB power cable | DP to DVI-D Adapter |

To locate the main monitor display port for your workstation, see ["Workstation Connections"](#target9000010).

If the monitor was not supplied by Biosense Webster and is not equipped with a USB port for 5 VDC power, use a 5 VDC adapter with the following specifications:

|  |  |  |
| --- | --- | --- |
| Connector: | DC 3.5 plug | |
| Polarity | ![Adapter_polarity.png](data:image/png;base64...) | |
| 1 | +5 V |
| 2 | GND |
| Power | IN | 100–240 V~ |
| OUT | 5 VDC max 1 A |

#### Updating the Supported Resolution of the DVI Cable Kit

https://bwiildita.sharepoint.com/sites/prod/Topics/Update\_Resolution\_for\_DVI\_EN.xml

If the DVI cable kit is installed on a monitor with a resolution other than 1920 × 1200, update the supported resolution of the kit using the following procedure.

|  |  |
| --- | --- |
| 1. | Connect the 5-V power adapter to the power socket of the DVI transmitter, and connect the adapter to the mains.  ![DVI_LED.png](data:image/png;base64...) |
| 2. | Using a thin screwdriver, push the Auto EDID button on the DVI transmitter.  ![EDID_button.png](data:image/png;base64...)  © Kramer Electronics, Ltd |
| 3. | Connect the DVI transmitter directly to the monitor.  ![LED_blinking.png](data:image/png;base64...)  The indication LED blinks several times while the transmitter reads the EDID. |
| 4. | When the indication LED stops blinking, disconnect the power. |
| 5. | Disconnect the DVI transmitter. |

### Connect a Standard Optical DVI Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/StandardDVI\_connectivity\_EN.xml

If a standard optical DVI cable (without adapters) is used to connect the monitor instead of the Optical DVI Detachable Transmitter Receiver Kit, connect the cable as follows:

KT-5400-203 added following ECO\_06013

|  |  |
| --- | --- |
| 1. | Connect the DVI DC USB power supply cable from the DVI cable to the outer USB downstream port on the monitor.  ![Repeater_Monitor_DC_PWR_Connections.jpg](data:image/jpeg;base64...) |
| 2. | Connect the short USB cable supplied with the Monitor accessories between the USB upstream port and the inner USB downstream port.  This cable ensures continuous power supply to the USB sockets and prevents disabling of the video socket on the Workstation video card when the Monitor is in Sleep Mode. |
| 3. | If the monitor is the older model, do the following:   |  |  | | --- | --- | | 3.1 | Access the monitor menu by pressing the Menu button. | | 3.2 | Use **+/-** navigation buttons to navigate to Other Settings. | | 3.3 | Navigate to the Audio option. | | 3.4 | Set ON during power save? to Yes. | |
| 4. | Connect the monitor AC power cable.  ![monitor_power_connected.jpg](data:image/jpeg;base64...) |
| 5. | Connect the DVI cable to the monitor and secure with its screws.  ![power_DVI_and_DVI_POWER_connected.jpg](data:image/jpeg;base64...) |

# Pacing Stimulator Connectivity

In This Chapter

[Connect the CARTO™ 3 System to a Stimulation Device 29](#_Toc181736136)

[Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F 30](#_Toc181736137)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Stimulator\_connectivity\_v2\_EN.xml

The pacing stimulator is connected to the PIU by pairs of 2 mm pins.

![piu_stimulatorConnections_v8p3.jpg](data:image/jpeg;base64...)

Figure 15: PIU Sockets for Stimulator Connectivity

The system supports generic (locally routed) stimulation to any two adjacent electrodes (such as 1\_2, 2\_3, 3\_4, etc.)

![piu_stimulatorConnections_generic_v8p3.jpg](data:image/jpeg;base64...)

Figure 16: Generic (Locally Routed) Stimulation Socket Pair

Stimulation cannot be routed to nonadjacent electrodes (such as 2\_5, 1\_10, etc.). The positive pole of the stimulator is always routed to the even-numbered electrode, and the negative pole of the stimulator is always routed to the odd-numbered electrode. When stimulation is routed through the CARTO™ 3 System, routing is indicated on the catheter visualization (Main Map Viewer), the Stimulation Routing Icon (System Toolbar), and the relevant channel (ECG viewers). The system automatically disconnects the RF generator from electrodes MAP 1 and MAP 2 when the stimulator is routed to one of these electrodes.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * Be aware that this protection is not available when the CARTO™ 3 Workstation is powered off. * Stimulation cannot be routed through the CARTO™ 3 System when the PIU is OFF, except through the emergency stimulation socket pairs. |

1.2.2.2 V2; REP4611 D-V1-4.4.1

The CARTO™ 3 System provides four direct stimulation socket pairs, which can be used in an emergency, even if the PIU is off.

![piu_stimulatorConnections_emergency_v8p3.jpg](data:image/jpeg;base64...)

Figure 17: Emergency Stimulation Socket Pairs

|  |  |  |  |
| --- | --- | --- | --- |
| ![piu_stimulatorConnections_emergency_MAP.png](data:image/png;base64...) | Direct connection pair that is connected directly to electrodes MAP 1 and MAP 2  1.20.1, 4.4.2. V1  1.9.4.1 V3   |  |  | | --- | --- | | ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**  The emergency connection to electrodes MAP 1 and MAP 2 overrides the RF generator-disconnect mechanism. Therefore, it is the responsibility of users to prevent pacing stimulation and ablation in parallel. Do not apply RF energy while the stimulator is connected via these sockets unless specifically indicated by the stimulator's instructions for use. Do not use this parallel connection when using a Bloom Stimulator. Doing so might induce ventricular fibrillation or formation of microbubbles. Microbubbles have been associated with increased risk of an embolic event. | |
| ![piu_stimulatorConnections_emergency_RD.png](data:image/png;base64...) | Direct connection pair that is connected directly to electrodes REF/DECA 1 and 2 |
| ![piu_stimulatorConnections_emergency_QA.png](data:image/png;base64...) | Direct connection pair that is connected directly to electrodes QUAD A 1 and QUAD A 2 |
| ![piu_stimulatorConnections_emergency_QB.png](data:image/png;base64...) | Direct connection pair that is connected directly to electrodes QUAD B 1 and QUAD B 2 |

Contact the Biosense Webster Service and Support Department for instructions on how to connect the pacing stimulator.

|  |  |
| --- | --- |
| ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**  Ensure that each stimulation channel is routed to a single destination. In particular, ensure that the channels used for stimulation by the CARTO™ 3 System are not connected in parallel to both the front input sockets and the ICEG Out Interface. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  It is recommended to use the stimulation splitter cable for separating between stimulator channels that will be routed by the recording system and stimulator channels that will be routed by the CARTO™ 3 System. |

## Connect the CARTO™ 3 System to a Stimulation Device

https://bwiildita.sharepoint.com/sites/prod/Topics/Connect\_to\_Pacing\_Device\_C3\_EN.xml

Stimulation devices should be connected to the PIU via the cable supplied with the CARTO™ 3 System, or another approved cable supplied with the stimulation instrument, as shown below.

![stimulator_connectors_v8p3.jpg](data:image/jpeg;base64...)

Figure 18: PIU Connections for a Stimulator: General Input (red) and Direct Inputs (blue)

|  |  |
| --- | --- |
| 1. | Connect the two banana plugs on one end of the cable to the stimulator. |
| 2. | Insert the two banana plugs on the other end of the cable (one red and one black) in the sockets marked Stimulator + (red) /– (black) on the PIU (see [Figure 18: "PIU Connections for a Stimulator: General Input (red) and Direct Inputs (blue)"](#target9000011), red marking). |
| 3. | Using CARTO™ 3 Software, select intracardiac electrodes for stimulation use (see the CARTO™ 3 System Comprehensive User Guide for details).  The ICEG electrode for stimulation is selected in the CARTO™ 3 Software. |

|  |  |
| --- | --- |
| ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**   * Do not connect the RF generator and stimulator to the same catheter electrode unless specifically permitted by the stimulator manufacturer. * In case of PIU failure, the user can override the software settings by connecting the pacing instrument banana plugs into each one of the direct input pairs on the front of the PIU. * Some stimulators require a filter between the CARTO™ 3 System and the stimulator. These stimulators are typically used in Japan. Therefore, in Japan contact Biosense Webster service personnel before connecting a stimulator.   Failure to use a filter when required can result in additional noise that might compromise performance of the CARTO™ 3 System. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The system supports unipolar stimulation (between a catheter electrode in the heart and an electrode in the IVC). See the ECG chapter in the CARTO™ 3 System Comprehensive User Guide. |

## Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F

https://bwiildita.sharepoint.com/sites/prod/Topics/Stim\_connect\_ECG\_cards162\_EN.xml

If the PIU is equipped with ECG cards Revision EA‑5401‑162/162F, stimulation can be routed directly from the EP recording system. The following diagram shows the recommended connection configuration for systems with ECG cards EA‑5401‑162/162F.

![Stimulator_for_ECG_Cards.jpg](data:image/jpeg;base64...)

Figure 19: Recommended Stimulator Connection for ECG Cards EA‑5401‑162/162F

In this configuration, stimulation is routed from the recording system only. The stimulation signals pass through the PIU to catheter electrodes. Stimulation can be performed from more than one site simultaneously.

Additional connection configurations for systems with ECG cards EA‑5401‑162/162F are shown in the following diagrams.

![Stimulator_for_RS_Generic.jpg](data:image/jpeg;base64...)

Figure 20: Combined Connection: Recording System and Generic

![Stimulator_for_RS_Direct.jpg](data:image/jpeg;base64...)

Figure 21: Combined Connection: Recording System and Direct

To verify that the PIU is equipped with ECG cards EA‑5401‑162/162F:

With the PIU connected and turned ON, in the Help menu, click About CARTO™ 3 System.

The part number of the ECG card set appears in the center of the System panel.

![SystemPanel_ECG_card_set.jpg](data:image/jpeg;base64...)

Figure 22: System Panel Showing ECG Card Part Number

# EP Recording System Connectivity

In This Chapter

[BS ECG Connectivity 33](#_Toc181736138)

[ICEG Connectivity 34](#_Toc181736139)

[Stimulation Connectivity 34](#_Toc181736140)

[Generic Connection 34](#_Toc181736141)

[Setting Up the Generic Connection 35](#_Toc181736142)

[Connecting to GE CardioLab® 36](#_Toc181736143)

[Connecting the BS ECG Cable 37](#_Toc181736144)

[Connecting the ICEG Cable 37](#_Toc181736145)

[Stimulation Connectivity 38](#_Toc181736146)

[Stimulation Splitter 38](#_Toc181736147)

[Configure the CardioLab® System 38](#_Toc181736148)

[Connecting to Bard LabSystem™ PRO 39](#_Toc181736149)

[Connect the BS ECG Cable 41](#_Toc181736150)

[Connect the ICEG Cable 41](#_Toc181736151)

[Stim Splitter Adapter Cable 41](#_Toc181736152)

[Connecting the Stim Splitter 42](#_Toc181736153)

[Configuring the CLEARSIGN™ Amplifier 42](#_Toc181736154)

[Connecting to Siemens AXIOM Sensis XP 43](#_Toc181736155)

[Difference in Signal Display 43](#_Toc181736156)

[Define Recommended Filter Settings 44](#_Toc181736157)

[Recording System Connections for HD Catheters 45](#_Toc181736158)

[OCTARAY™ Catheter 45](#_Toc181736159)

[OPTRELL™ 36 Catheter 46](#_Toc181736160)

[OPTRELL™ 48 Catheter 47](#_Toc181736161)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Interfacing with EP Recorders\_EN.xml

REP4611 A-V1-1.17.5

This section describes connectivity of the CARTO™ 3 System with an EP recording system. This connectivity includes the following:

* Body surface (BS) ECG
* Intracardiac electrogram (ICEG)
* Stimulation

Two types of cables sets can be used:

* Generic cables (which fit any recording system)
* Dedicated cables for the specific recording system

On the back of the PIU, the ECG Out connector is used for BS ECG connectivity and the IC Out connector for ICEG connectivity. On the front of the PIU, the Stimulator connectors are used for stimulation connectivity.

|  |  |
| --- | --- |
| ![PIU_Connectors_for_EP_v8.jpg](data:image/jpeg;base64...)  Figure 23: PIU Connectors for EP Recording System Connectivity | 1 IC Out  2 ECG Out  3 Stimulator |

In addition, an Ethernet connection between the CARTO™ 3 Workstation and the EP recording system is required for data connectivity.

## BS ECG Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/BS\_ECG\_Connectivity\_EN.xml

Body Surface (BS) ECG connectivity makes available the following features of the CARTO™ 3 System:

* Protection against defibrillation with special BS ECG cables (as with any recording system)
* Filtering of noise generated by the location functionality of the CARTO™ 3 System
* Reduction of common noise by supplying all signals relative to the WCT (subtracting WCT signals)

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The EP Recording system remains connected to all body surface leads when the CARTO™ 3 System is turned off. * If the ground is generated via the right leg as with some EP Systems, this connection might generate noise. |

The recording system can be connected to the PIU using either the generic ECG Out Unit or a dedicated cable that connects directly to the recording system inputs.

## ICEG Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/ICEG\_connectivity\_EN.xml

Intracardiac Electrogram (ICEG) connectivity makes available the following features of the CARTO™ 3 System:

* Simple catheter connectivity
* Special features for catheters connected to the CARTO™ 3 System, such as catheter visualization
* Filtering of noise generated by the CARTO™ 3 System location functionality
* Reduction of common noise by supplying all signals relative to the WCT or ICEG reference (parallel to WCT signal subtraction in BS ECG connectivity)

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * For CARTO™ 3 System ICEG signals to pass to the EP recording system, ensure that the PIU is on. * Define the reference for unipolar signals on the recording system relative to the WCT. * Selecting IC-Reference on the CARTO™ 3 System automatically generates the same IC-Reference on both systems for the unipolar signals of catheters connected to the CARTO™ 3 System. On the recording system, do not change the configuration manually in any way (leaving the unipolar signals relative to the WCT). |

## Stimulation Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/Stimulation\_connectivity\_EN.xml

See ["Pacing Stimulator Connectivity"](#target9000012) for details about the stimulation sockets.

For systems with the hardware-based Stimulation Enhancements feature,[[4]](#footnote-4) stimulation connectivity supports routing stimulation directly from the EP recording system.

## Generic Connection

https://bwiildita.sharepoint.com/sites/prod/Topics/GenericConnection\_EN.xml

Biosense Webster supplies equipment that enables a generic connection to an EP recording system.

Table 2: Equipment for Generic Connection to the EP Recording System

| Part Name | Part |
| --- | --- |
| **BS ECG Connectivity** | |
| ECG Out Unit | ![ECG_Out_small.jpg](data:image/jpeg;base64...) |
| **ICEG Connectivity** | |
| IC Out Cable | ![IC_Out_small.jpg](data:image/jpeg;base64...) |
| **Stimulation Connectivity** | |
| EP Recording System Pin Box  *(Example shown—CardioLab® Catheter Input Module)* | ![EPRS_pin_box.jpg](data:image/jpeg;base64...) |
| 2 Pin–2 Pin Pacing Cable  Not required for systems with ECG card set EA‑5401‑162/162F | ![cable_2pin_2pin.jpg](data:image/jpeg;base64...) |

### Setting Up the Generic Connection

https://bwiildita.sharepoint.com/sites/prod/Topics/Connect\_to\_EP\_Recorder\_EN.xml

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| 1. | Set up the BS ECG output connection as follows:   |  |  | | --- | --- | | 1.1 | Connect the ECG Out Unit (with 10 ECG connectors) to the ECG OUT socket on the back of the PIU. | | 1.2 | Connect the BS cable of the EP recording system to the 10 connectors. | |
| 2. | Set up the ICEG output connection as follows:   |  |  | | --- | --- | | 2.1 | Connect the IC Out Cable to the IC OUT socket on the back of the PIU. | | 2.2 | Connect the end with touch-protected (banana) plugs to the EP recording system. |   The IC Out Cable has a 78-pin plug on one end, which is connected directly to the PIU. The other end has 78 banana plugs that connect directly to the EP recording system. |
| 3. | Set up stimulation connectivity as follows:   * Connect the stimulator to the EP recording system and connect the EP recording system to the PIU:   1. Connect the stimulator to the EP recording system.   2. Route stimulation from the recording system to a specific pair of channels (usually 31–32) on the EP recording system pin box.   3. Connect the 2 Pin–2 Pin Cable to the EP recording system pin box and to the stimulation inlets on the PIU. * Alternatively, connect the stimulator directly to the CARTO™ 3 System. |

## Connecting to GE CardioLab®

https://bwiildita.sharepoint.com/sites/prod/Topics/epConnectivity\_cardioLab\_c3\_EN.xml

Biosense Webster supplies a set of cables that enable easy connectivity between the systems.

Table 3: CARTO™ 3 System to CardioLab® Interface Cables

| Name and Part Number | Cable |
| --- | --- |
| **BS ECG Connectivity** | |
| BW-GE BS-ECG Cable | ![cable_Cardiolab_ECG.jpg](data:image/jpeg;base64...) |
| **ICEG Connectivity** | |
| BW-GE ICEG Cable | ![cardioLab_ICEG_Cable_1.2in.png](data:image/png;base64...) |
| **Stimulation Connectivity** | |
| Two Pairs STIM Cable  Not required for systems with ECG card set EA‑5401‑162/162F (see ["Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F"](#target9000013) | ![carto_StimulationCable_small.png](data:image/png;base64...) |
| STIM Splitter CARTO™ CardioLab®  Not required for systems with ECG card set EA‑5401‑162/162F (see ["Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F"](#target9000014) | ![cardioLab_StimulationSplitter_small.png](data:image/png;base64...) |
| GE Stimulator Interface Cable | ![cardioLab_StimulationInterfaceCable_small.png](data:image/png;base64...) |

The cables connect to the front panel of the CardioLab® unit.

|  |  |  |
| --- | --- | --- |
| ![CardioLabFrontPanel_callout.jpg](data:image/jpeg;base64...)  Figure 24: CardioLab® Front Panel |  |  |
| 1 | ECG connector |
| 2 | ICEG connector |
| 3 | Stim connector |

### Connecting the BS ECG Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/CardioLab\_BS\_ECG\_connectivity\_EN.xml

For BS ECG connectivity between the CARTO™ 3 System and the GE CardioLab® EP recording system, use the dedicated BW-GE BS ECG cable.

|  |  |
| --- | --- |
| 1. | Connect the end labeled **GE CARDIOLAB BS** to the ECG connector on the front panel of the CardioLab® system. |
| 2. | Connect the end labeled **PIU ECG OUT** to the CARTO™ 3 System ECG Out connector located on the back panel of the PIU. |

### Connecting the ICEG Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/CardioLab\_ICEG\_connectivity\_EN.xml

For ICEG connectivity between the CARTO™ 3 System and GE CardioLab® EP recording system, use the dedicated BW-GE ICEG cable.

|  |  |
| --- | --- |
| 1. | Connect the end labeled **CARTO 3 PIU** to the CARTO™ 3 System IC Out connector located on the back panel of the PIU. |
| 2. | Connect the other end of the cable as follows:   * Connector labeled **CARDIO LAB A** to the ICEG-in socket **A** of the CardioLab® EP recording system * Connector labeled **CARDIO LAB B** to the ICEG-in socket **B** of the CardioLab® EP recording system |

### Stimulation Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/stimulation\_connectivity\_EPRS\_EN.xml

Set up stimulation connectivity for the CardioLab® EP recording system by using one of the following:

* Stimulation Splitter (dedicated splitter cable)
* Designated channels on the GE Catheter Input Module (pin box) (see ["Setting Up the Generic Connection"](#target9000015))
* For systems with ECG card set EA‑5401‑162/162F, see ["Connecting to a Stimulation Device for a System with ECG Cards EA‑5401‑162/162F"](#target9000016).

#### Stimulation Splitter

https://bwiildita.sharepoint.com/sites/prod/Topics/stimulation\_connectivity\_via\_splitter\_EN.xml

The Stimulation Splitter provides connectivity between the CARTO™ 3 System, CardioLab® EP recording system, and a stimulator. The splitter connects the four channels of the stimulator as follows:

* Channels 1 and 2 to the CardioLab® EP recording system
* Channels 3 and 4 to the CARTO™ 3 System (as channels A and B)

In addition, the splitter enables the CardioLab® EP recording system to identify stimulation events on channel 3 routed to the CARTO™ 3 System.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * When using a two-channel stimulator, use channels 1 and 3 of GE stimulator interface cable. In this case, channel 1 of the stimulator is used for routing stimulation to a catheter that is connected directly to the recording system, and channel 2 of the stimulator is used for routing stimulation to a catheter that is connected directly to the CARTO™ 3 System. * Stimulation signals on channel 4 cannot be detected by the CardioLab® EP recording system. |

### Configure the CardioLab® System

https://bwiildita.sharepoint.com/sites/prod/Topics/cardioLab\_configuring\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Channel definition on the CardioLab® system should be performed by a certified CardioLab® user. |

The correct channel definitions are presented in the following table:

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| **CARTO™ 3 System** | MAP 1-4 | QUAD A 1-4 | QUAD B 1-4 | 20 POLE A 1-20 | REF/DECA 1-10 | 20 POLE B 1-20 | Stimulation Port |
| **CardioLab®** | Box A 1-4 | Box A 5-8 | Box A 9-12 | Box A 13-32 | Box B 1-10 | Box B 11-30 | Box B 31-32 |

|  |  |  |  |
| --- | --- | --- | --- |
| 1. | Define the channels as detailed in the table above.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  DECA channels are not transmitted to the EP Recording System. | |
| 2. | **For systems not equipped with ECG card set EA‑5401‑162/162F:** Define Box B channels 31-32 as **Carto Stim** and route channel 3 (**A** on the CARTO™ 3 System stimulation cable) to **Carto Stim**.  This enables the CardioLab® system to record the stimulation events when stimulating via the CARTO™ 3 System.  **Recommended:** Save the CardioLab® Study Configuration template as **CARTO3** |

![cardioLab_configuration.png](data:image/png;base64...)

Figure 25: CardioLab® Study Configuration (Example)

## Connecting to Bard LabSystem™ PRO

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_Clearsign\_EN.xml

Biosense Webster supplies a set of cables for easy connectivity to the Boston Scientific (formerly Bard) LabSystem™ PRO system.

Table 4: CARTO™ 3 System to LabSystem™ PRO Interface Cables

| Name and Part Number | Cable |
| --- | --- |
| **BS ECG Connectivity** | |
| Boston Scientific ECG Cable (3 m or 6 m), to be provided by Bard upon request | ![Bard_ECG.jpg](data:image/jpeg;base64...) |
| **ICEG Connectivity** | |
| Boston Scientific ICEG Cable (3 m or 6 m), to be provided by Boston Scientific upon request | ![Bard_ICEG.jpg](data:image/jpeg;base64...) |
| **Stimulation Connectivity** | |
| Two Pairs STIM Cable  Not required for systems with ECG card set EA‑5401‑162/162F | ![carto_StimulationCable_small.png](data:image/png;base64...) |
| Boston Scientific Stim Splitter (Adapter)  Not required for systems with ECG card set EA‑5401‑162/162F | ![Bard_StimSplit.jpg](data:image/jpeg;base64...) |
| Boston Scientific 4 Pair Stim Cable | ![Bard_Stim.jpg](data:image/jpeg;base64...) |

The cables connect to the front panel of the LabSystem™ PRO unit.

|  |  |  |
| --- | --- | --- |
| ![Bard_EPRS_callout.jpg](data:image/jpeg;base64...)  Figure 26: LabSystem™ PRO Front Panel | 1 | ECG connector |
| 2 | ICEG connector |
| 3 | Stim connector |

### Connect the BS ECG Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_ECG\_Connectivity\_EN.xml

For BS ECG connectivity between the CARTO™ 3 System and Boston Scientific (formerly Bard) EP recording system, use the dedicated Boston Scientific ECG cable. The direct connection ECG cable passes a 12-lead ECG from the CARTO™ 3 System PIU to the CLEARSIGN™ amplifier. When the PIU is on, the outputs are buffered signals. When the PIU is off, the cable connects the CLEARSIGN™ amplifier directly to the patient ECG electrodes.

|  |  |
| --- | --- |
| 1. | Connect the end labeled **BARD** to the ECG connector on the front panel of the CLEARSIGN™ amplifier. |
| 2. | Connect the end labeled **BIOSENSE WEBSTER** to the CARTO™ 3 System ECG Out connector located on the back panel of the PIU. |

### Connect the ICEG Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_ICEG\_Connectivity\_EN.xml

For ICEG connectivity between the CARTO™ 3 System and Bard EP recording system, use the dedicated Boston Scientific (formerly Bard) ICEG cable.

|  |  |
| --- | --- |
| 1. | Connect the end labeled **BIOSENSE WEBSTER** to the CARTO™ 3 System IC Out connector located on the back panel of the PIU. |
| 2. | Connect the end labeled **BARD** to an IC connector on the CLEARSIGN™ amplifier (to determine which connector to use, see ["Configuring the CLEARSIGN™ Amplifier"](#target9000017)). |

### Stim Splitter Adapter Cable

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_Stim\_adapter\_EN.xml

The Stim splitter adapter cable receives four stimulator signal pairs. Stim 1 and Stim 2 are passed to the CLEARSIGN™ amplifier. Stim 3 and Stim 4 are passed to the CARTO™ 3 System PIU.

Stim 3 and Stim 4 are also connected through a high value resistor to the CLEARSIGN™ amplifier to enable stimulation detection on these channels. However, stimulation using Stim 3 and Stim 4 is prevented on the CLEARSIGN™ amplifier.

For 40 channel configurations, it is recommended to use the Stim splitter. The Stim splitter enables the CLEARSIGN™ amplifier to detect and log stimulation that is executed from the CARTO™ 3 System.

#### Connecting the Stim Splitter

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_Stimulation\_Connectivity\_EN.xml

|  |  |
| --- | --- |
| 1. | Connect the Stim splitter end labeled **Recording System Stim Output** to the Stimulator connector of the CLEARSIGN™ amplifier. |
| 2. | Connect the Boston Scientific (formerly Bard) 4-Pair Stim Cable to the Stimulator Input connector of the Stim splitter and to the stimulator. |
| 3. | Connect the Navigation System Stim Output connector of the Stim splitter to the Two Pairs STIM Cable. |
| 4. | Connect the plugs labeled A+ and A– of the Two Pairs STIM Cable to the generic stimulation sockets on the PIU.  Typically, plugs B+ and B– are unconnected. However, they can be used for connecting to direct stimulation sockets. |

### Configuring the CLEARSIGN™ Amplifier

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_ICEG\_EN.xml

The CARTO™ 3 System passes 78 intracardiac signals to the CLEARSIGN™ Amplifier.

The output signals are defined in the table below:

Table 5: CARTO™ 3 System to CLEARSIGN™ Input Connections

| CARTO™ 3 System Outputs | CLEARSIGN™ Intracardiac Inputs |
| --- | --- |
| MAP 1–10 | Inputs 1–10 |
| REF/DECA 1–10 | Inputs 11–20 |
| 20 POLE A 1–20 | Inputs 21–40 |
| 20 POLE B 1–20 | Inputs 41–60 |
| DECA 1–10 | Inputs 61–70 |
| HRA 1–4 | Inputs 71–74 |
| RVA 1–4 | Inputs 75–78 |

For convenient switching between a CARTO™ 3 Procedure and a non-CARTO™ 3 Procedure, it is recommended to use the last IC Module on the CLEARSIGN™ amplifier for configuring the CARTO™ 3 channel setup. On an 80-channel system, use IC2. On a 120-channel system, use IC3. This allows CLEARSIGN™ setups that were configured previously on the lower modules to remain intact without the need to disconnect the CARTO™ 3 System cables each time.

If your CLEARSIGN™ amplifier has only 40 channels, you must switch cables to use the amplifier without the CARTO™ 3 System. Alternatively, contact the local Boston Scientific (formerly Bard) representative for information about adding an IC module to the existing CLEARSIGN™ amplifier.

The following figure shows CLEARSIGN™ Amplifier Bi-polar setup using all available signals through the intracardiac direct connection cable. Sampling rate is typically set to 1 kHz but is user selectable.

![Bard_channel_setup.jpg](data:image/jpeg;base64...)

Figure 27: CLEARSIGN™ Amplifier Setup

## Connecting to Siemens AXIOM Sensis XP

https://bwiildita.sharepoint.com/sites/prod/Topics/Data\_Connections\_EP\_Recording\_System\_Siemens\_EN.xml

A dedicated cable set for connecting the AXIOM Sensis XP to the CARTO™ 3 System is available from Siemens. Contact the Siemens representative to set up connectivity.

## Difference in Signal Display

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_matching\_signals\_EN.xml

The CARTO™ 3 System and the EP recording system use different types of signal processing. This might cause a difference in the way signals are displayed on the two systems.

To make the signals closer in appearance, use the following filter settings.

Table 6: Filter Settings

| Filter | Signal | Typical EP Recording System | CARTO™ 3 System |
| --- | --- | --- | --- |
| High-Pass | ICEG Bipolar | 30 Hz | 8 / 16 Hz |
| ICEG Unipolar | 1 Hz | 1 / 2 / 4 Hz |
| Surface ECG | 0.1 / 0.5 / 1Hz | 0.5 / 1 Hz |
| Low-Pass | ICEG Bipolar | 250 / 500 Hz | 500 Hz |
| ICEG Unipolar | 100 / 250 Hz | 240 Hz |
| Surface ECG | 250 Hz | 120 / 240 Hz |

### Define Recommended Filter Settings

https://bwiildita.sharepoint.com/sites/prod/Topics/Bard\_recommended\_filter\_settings\_EN.xml

Filter settings of the CARTO™ 3 System can be adjusted from the Filter Configuration dialog box.

|  |  |
| --- | --- |
| 1. | In the CARTO™ 3 Software Application on the ECG menu, click Filters Configuration.  The Filter Configuration dialog box opens.  ![filterConfiguration_v8p3.png](data:image/png;base64...) |
| 2. | For the relevant channels, click ![arrow_drop_list.PNG](data:image/png;base64...) to open the list and select the desired setting (see ["Difference in Signal Display"](#target9000018)).   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Clear the All-channel power rejection filter check box except for troubleshooting purposes. | |
| 3. | Click Update. |

## Recording System Connections for HD Catheters

https://bwiildita.sharepoint.com/sites/prod/Topics/HD\_catheters\_recording\_system\_EN.xml

The CARTO™ 3 System can be connected to the Recording System with the direct cable or the indirect cable for 36 channels.

The tables in the *Connectivity User Guide* present the correspondence between the electrode number displayed in the CARTO™ 3 System and the Recording System.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  REP9626: V7 1.8.2   * When using the indirect cable, verify that the pins are connected correctly. Incorrect connection may result in stimulation routing to the wrong electrodes.   REP9626: V7 1.8.1   * Verify that the recording system configuration is correct. Incorrect configuration may result in noise on the signals or stimulation routing to the wrong electrode. |

### OCTARAY™ Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PIU-Plus\_recording\_sys\_OCTARAY\_EN.xml

REP9626: V7 1.8.12

For the OCTARAY™ Catheter, the following electrodes are not transferred to the Recording System:

* B5, B6, C5, C6, E5, E6, F5, F6, G5, G6, H5, and H6.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The System does not support inter-spline bipolar channels. |

The CARTO™ 3 System can be connected to the Recording System with the direct cable or the indirect cable for 36 channels.

REP9626: V7 1.8.2

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  When using the indirect cable, verify that the pins are connected correctly. Incorrect connection may result in stimulation routing to the wrong electrodes. |

The table below presents the correspondence between the electrode number displayed in the CARTO™ 3 System and the Recording System.

REP9626: V7 1.8.1

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Verify that the recording system configuration is correct. Incorrect configuration may result in noise on the signals or stimulation routing to the wrong electrode. |

Table 7: Recording System Connections

| Electrode# | PIU Socket | Electrode# | PIU Socket |
| --- | --- | --- | --- |
| A1 | 20 POLE A1 | E3 | 20 POLE B3 |
| A2 | 20 POLE A2 | E4 | 20 POLE B4 |
| A3 | 20 POLE A3 | F1 | 20 POLE B5 |
| A4 | 20 POLE A4 | F2 | 20 POLE B6 |
| B1 | 20 POLE A5 | F3 | 20 POLE B7 |
| B2 | 20 POLE A6 | F4 | 20 POLE B8 |
| B3 | 20 POLE A7 | G1 | 20 POLE B9 |
| B4 | 20 POLE A8 | G2 | 20 POLE B10 |
| C1 | 20 POLE A9 | G3 | 20 POLE B11 |
| C2 | 20 POLE A10 | G4 | 20 POLE B12 |
| C3 | 20 POLE A11 | H1 | 20 POLE B13 |
| C4 | 20 POLE A12 | H2 | 20 POLE B14 |
| D1 | 20 POLE A13 | H3 | 20 POLE B15 |
| D2 | 20 POLE A14 | H4 | 20 POLE B16 |
| D3 | 20 POLE A15 | A5 | 20 POLE B17 |
| D4 | 20 POLE A16 | A6 | 20 POLE B18 |
| E1 | 20 POLE B1 | D5 | 20 POLE B19 |
| E2 | 20 POLE B2 | D6 | 20 POLE B20 |

### OPTRELL™ 36 Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PIU-Plus\_recording\_sys\_OPTRELL36\_EN.xml

REP9626: V7 1.8.2 (From OCTARAY)

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  The CARTO™ 3 System can be connected to the Recording System with the direct cable or the indirect cable for 36 channels. When using the indirect cable, verify that the pins are connected correctly. Incorrect connection may result in stimulation routing to the wrong electrodes. |

REP13141: A1 (IFU indicates OPTRELL's connectivity and pacing limitation )

REP11406: A-96 (IFU indicates OPTRELL's connectivity and pacing limitation)

The table below presents the correspondence between the electrode number displayed in the CARTO™ 3 System and the Recording System.

REP9626: V7 1.8.1 (From OCTARAY)

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*   * Verify that the recording system configuration is correct. Incorrect configuration may result in noise on the signals or stimulation routing to the wrong electrode. * Do not pace through or connect 20 POLE A channels 17-20 to the Recording System. |

Table 8: Recording System Connections

| Electrode# | PIU Socket | Electrode# | PIU Socket |
| --- | --- | --- | --- |
| A1 | 20 POLE A MAG\_1 | D1 | 20 POLE A MAG\_4 |
| A2 | 20 POLE A MAG\_8 | D2 | 20 POLE A MAG\_9 |
| A3 | 20 POLE B MAG\_20 | D3 | 20 POLE A MAG\_14 |
| A4 | 20 POLE B MAG\_15 | D4 | 20 POLE A MAG\_15 |
| A5 | 20 POLE A MAG\_11 | D5 | 20 POLE B MAG\_10 |
| A6 | 20 POLE B MAG\_6 | D6 | 20 POLE B MAG\_3 |
| B1 | 20 POLE A MAG\_2 | E1 | 20 POLE A MAG\_5 |
| B2 | 20 POLE A MAG\_7 | E2 | 20 POLE A MAG\_12 |
| B3 | 20 POLE B MAG\_19 | E3 | 20 POLE B MAG\_18 |
| B4 | 20 POLE B MAG\_16 | E4 | 20 POLE B MAG\_13 |
| B5 | 20 POLE B MAG\_12 | E5 | 20 POLE B MAG\_7 |
| B6 | 20 POLE B MAG\_5 | E6 | 20 POLE B MAG\_2 |
| C1 | 20 POLE A MAG\_3 | F1 | 20 POLE A MAG\_6 |
| C2 | 20 POLE B MAG\_10 | F2 | 20 POLE A MAG\_11 |
| C3 | 20 POLE A MAG\_13 | F3 | 20 POLE B MAG\_17 |
| C4 | 20 POLE A MAG\_16 | F4 | 20 POLE B MAG\_14 |
| C5 | 20 POLE B MAG\_9 | F5 | 20 POLE B MAG\_8 |
| C6 | 20 POLE B MAG\_4 | F6 | 20 POLE B MAG\_1 |

### OPTRELL™ 48 Catheter

https://bwiildita.sharepoint.com/sites/prod/Topics/PIU-Plus\_recording\_sys\_OPTRELL48\_EN.xml

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

Figure 28: OPTRELL™ Mapping Catheter Unsupported Electrodes

The table below presents the correspondence between the electrode number displayed in the CARTO™ 3 System and the Recording System.

REP9626: V7 1.8.1 (From OCTARAY)

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*   * Verify that the recording system configuration is correct. Incorrect configuration may result in noise on the signals or stimulation routing to the wrong electrode. * Do not pace through or connect 20 POLE A channels 17-20 to the Recording System. |

Table 9: Recording System Connections

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

# Fluoroscopy System Connectivity

In This Chapter

[Installation 50](#_Toc181736162)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/connectivity\_fluoro\_fer\_c3\_EN.xml

The connectivity between the systems is established using standard TCP/IP connectivity. A Hospital IP address is required.

This connectivity includes two aspects:

* The X-ray system uses the Digital Imaging and Communications in Medicine (DICOM) protocol to send images to the CARTO™ 3 System, as specified in the X-ray system configuration. To enable this connectivity, the CARTO™ 3 System is connected to the hospital network. For optimal performance, it is recommended to connect the CARTO™ 3 System to the hospital network through the X-ray system Ethernet switch. If that is not possible, the communication can be made using a 1 GBps Ethernet network.
* The X-ray system sends geometry information to the CARTO™ 3 System through the CARTO™ 3 System connection to the existing X-ray system control network. The CARTO™ 3 System only receives information and does not send any information that might change the X-ray system behavior.

This connectivity is achieved by one or two physical Ethernet cables (depending on the X-ray configuration), and requires configuration of both systems. For detailed information about security aspects of this connectivity, refer to the CARTO™ 3 System *Security User Guide*.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The connectivity required for the CARTOUNIVU™ Module is not related to PACS systems on the hospital network. It does not require additional DICOM services, such as Modality Worklist. |

## Installation

https://bwiildita.sharepoint.com/sites/prod/Topics/fluoroBG\_hwAndInstallation\_EN.xml

Biosense Webster service personnel are responsible for activating the CARTOUNIVU™ Module on the Workstation, connecting the fluoroscopy system with the CARTO™ 3 System, and calibrating the CARTOUNIVU™ Module. The installation includes attaching a Registration Plate to the Location Pad.

After installation, the fluoroscopy system will be listed in the Study Setup screen.

Addendum to V6, SRA002588

**Considerations for labs equipped with MediGuide™ Systems:**

MediGuide™ Systems must be turned off during CARTO™ 3 procedures. Turning the MediGuide™ System on may affect the conditions under which the CARTO™ 3 System was installed and calibrated.

# Image Retrieval from Fluoroscopy System

In This Chapter

[Philips X-Ray System 51](#_Toc181736163)

[Philips Allura 3D Coronary Angiography 51](#_Toc181736164)

[Configuring Connectivity with the Allura System on the CARTO™ 3 System 52](#_Toc181736165)

[EP Navigator Interface 53](#_Toc181736166)

[Configuring the EP Navigator Server on the CARTO™ 3 System 53](#_Toc181736167)

[Configuring the DICOM Settings on the EP Navigator 55](#_Toc181736168)

[Configuring DICOM Nodes on EP Navigator for the CARTO™ 3 System 55](#_Toc181736169)

[Siemens X-Ray System 57](#_Toc181736170)

[Configuring syngo DynaCT for Connectivity 57](#_Toc181736171)

[GE X-Ray System 62](#_Toc181736172)

[Configure AW VolumeShare™ 4 for Connectivity 62](#_Toc181736173)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Connectivity\_other\_systems\_EN.xml

## Philips X-Ray System

https://bwiildita.sharepoint.com/sites/prod/Topics/XRay\_Philips\_title\_EN.xml

### Philips Allura 3D Coronary Angiography

https://bwiildita.sharepoint.com/sites/prod/Topics/Allura\_switch\_EN.xml

Segmented images from the Allura 3D coronary angiography system can be imported to the CARTOMERGE™ Module. Whenever possible, it is recommended to connect the CARTO™ 3 System directly to the hospital DICOM network. If it is not possible to connect the CARTO™ 3 System directly to the DICOM network, you can establish connectivity with the Philips Allura system via an Ethernet switch supplied by Philips. This switch is already installed at the site for connecting the Allura system to the hospital network. The switch connects the CARTO™ 3 System, Allura system, and the PACS server as illustrated below:

![Allura_Connection_v8p3.jpg](data:image/jpeg;base64...)

Figure 29: Allura–CARTO™ 3 System–PACS Connectivity

Data transfer between the systems takes place in a three-step process:

1. On the Allura system, raw and segmented data is created and stored in DICOM format on the Philips EP Navigator.
2. The CARTO™ 3 System receives the segmented data over the DICOM network from the EP Navigator via the Ethernet switch. The data is processed in the CARTOMERGE™ Module.
3. The completed CARTO™ 3 System studies with integrated segmented data are stored on the PACS server via the Ethernet switch.

#### Configuring Connectivity with the Allura System on the CARTO™ 3 System

https://bwiildita.sharepoint.com/sites/prod/Topics/Allura\_config\_EN.xml

Connect a LAN cable from the network socket of the CARTO™ 3 Workstation to the Ethernet switch.

The procedure below details the configuration of the CARTO™ 3 System for the Allura system server. For DICOM configuration instructions, see ["Configuring the DICOM Network"](#target9000019).

|  |  |
| --- | --- |
| 1. | In the CARTO™ 3 System opening screen, click System. |
| 2. | Click DICOM Network.  The DICOM Network Configuration window appears. |
| 3. | Click Add Server.  The Add Server dialog box opens. |
| 4. | Enter the Server Name and the Server IP and select the Image Integration check box.  The Server IP is supplied by Philips service personnel.  ![Add_Server_Image_Integration_PACS.jpg](data:image/jpeg;base64...)   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  To enable data import directly from the CARTO™ 3 System without using the Image Integration Module, select the CARTO™ System check box also. |   The Server IP is supplied by Philips service personnel.  In the Servers group of the DICOM Network Configuration window, the new server is listed. |
| 5. | Right-click the server and select Add Service.  The Add Service dialog box appears.  ![DICOM_Add_Service_3-2.png](data:image/png;base64...) |
| 6. | From the Service Type list, select Query and enter the appropriate information in the following fields:   * SCU (CARTO™ 3 System) AE * SCP (Allura) Port * SCP (Allura) AE |
| 7. | Click OK. |
| 8. | In the DICOM Network Configuration window, right-click the server and select Add Service.  The Add Service dialog box opens. |
| 9. | From the Service Type list, select Restore and enter the appropriate information in the following fields:   * SCU (CARTO™ 3 System) Port * SCU (CARTO™ 3 System) AE * SCP (Allura) AE |

![DICOM_Config_Allura_v8.jpg](data:image/jpeg;base64...)

Figure 30: Example DICOM Configuration for Connectivity to Allura System

### EP Navigator Interface

https://bwiildita.sharepoint.com/sites/prod/Topics/Interfacing\_EP\_Navigator\_EN.xml

#### Configuring the EP Navigator Server on the CARTO™ 3 System

https://bwiildita.sharepoint.com/sites/prod/Topics/Configure\_EP\_Nav\_Server\_EN.xml

The CARTO™ 3 System and the Philips Healthcare EP Navigator imaging application can be connected over the DICOM network as follows:

|  |  |
| --- | --- |
| 1. | In the DICOM Network Configuration window, click Add Server (see ["Configuring the DICOM Network"](#target9000020)).  The Add Server dialog box appears.  ![DICOM_Add_Server.PNG](data:image/png;base64...) |
| 2. | Enter the Server Name and the Server IP and select the Image Integration check box.  The Server IP is provided by Philips service personnel.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  To enable data import directly from the CARTO™ 3 System without using the Image Integration Module, select the CARTO™ System check box also. |   In the Servers group of the DICOM Network Configuration window, the new server is listed. |
| 3. | Right-click the server and select Add Service.  The Add Service dialog box appears.  ![DICOM_Add_Service_3-2.png](data:image/png;base64...) |
| 4. | From the Service Type list, select Query and enter the required information.  Typical definitions for EP Navigator are:   * EP Navigator Port: 3028 * EP Navigator AE: ACP3EPW   Fields that are not editable do not require any information. |
| 5. | Click OK. |
| 6. | In the Servers group in the DICOM Network Configuration window, right-click the server and select Add Service. |
| 7. | On the Service Type list, select Restore and enter the required information.  The typical AE title for EP Navigator is **ACP3EPW**. Fields that are not editable do not require any information. |
| 8. | Close the DICOM Network Configuration window. |
| 9. | Click OK in the System Tools dialog box. |

#### Configuring the DICOM Settings on the EP Navigator

https://bwiildita.sharepoint.com/sites/prod/Topics/Configure\_C3\_on\_EP\_Nav\_EN.xml

Configuring the EP Navigator system requires the assistance of a Philips engineer. The following instructions are supplied by Philips Healthcare and are subject to change without notice. They are included here for reference only.

|  |  |
| --- | --- |
| 1. | On the EP Navigator, log in as Administrator and start Field Service Framework. |
| 2. | On the Configuration tab, select DICOM > Local System.  ![EP_Nav_DICOM_local.jpg](data:image/jpeg;base64...) |
| 3. | Enter the AE Title and Port Number.  Typical definitions are:   |  |  | | --- | --- | | AE Title | ACP3EPW | | Port Number | 3028 | |
| 4. | For Allow Incoming Queries, select YES. |
| 5. | Click OK. |
| 6. | Reboot the system. |

#### Configuring DICOM Nodes on EP Navigator for the CARTO™ 3 System

https://bwiildita.sharepoint.com/sites/prod/Topics/Configure\_C3\_Nodes\_EP\_Nav\_EN.xml

|  |  |
| --- | --- |
| 1. | On the Configuration tab, select DICOM > Easy Network Wizard. |
| 2. | Click New and select CARTO.  ![EP_Nav_Wizard1.jpg](data:image/jpeg;base64...) |
| 3. | For both nodes of the CARTO™ 3 System (Query/Restore and Storage), enter definitions for the following:   * AE-Title * IP Address * Port Number   Default values for the Port Number and AE Title are displayed automatically.  ![EP_Nav_Wizard2.jpg](data:image/jpeg;base64...) |
| 4. | In the CARTO™ 3 System opening screen, click Image Integration. |
| 5. | In the EP Navigator Easy Network Wizard, for each node click Test. |
| 6. | Click OK to close the Easy Network Wizard. |
| 7. | On the System tab, click Activation > Activate Configuration Changes. |
| 8. | When the application restarts, on the System tab, click Activation > Accept New Settings. |

## Siemens X-Ray System

https://bwiildita.sharepoint.com/sites/prod/Topics/XRay\_Siemens\_title\_EN.xml

### Configuring syngo DynaCT for Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/DynaCT\_configure\_EN.xml

Configuration of the *syngo* DynaCT system requires the assistance of a Siemens engineer. The following instructions are supplied by Siemens Healthcare and are subject to change without notice. They are included here for reference only.

|  |  |
| --- | --- |
| 1. | On the Leonardo workstation of the *syngo* DynaCT system, click Options > Service > Local Service to open the service application.  Use of the Siemens password is required to enter the service application. The Siemens engineer is responsible for opening the application.  The service application opening screen displays the available functions. |
| 2. | Click Configuration.  ![Siemens_service_op_scr.PNG](data:image/png;base64...)  The Configuration window opens. The left pane displays the System Options (1 in figure below).  ![Siemens_service_config.PNG](data:image/png;base64...) |
| 3. | In the DICOM options (2 in figure in Step 2), click General (3 in figure in Step 2).  The main pane displays configuration information. In the Study Transfer field (4 in figure in Step 2), the AE title of the Leonardo workstation is displayed. |
| 4. | In the Local Host options (5 in figure in Step 2), click TCP/IP LAN.  The IP LAN information is displayed in the main pane.  ![Siemens_service_IP_LAN.PNG](data:image/png;base64...) |
| 5. | In the Adapter field (1 in figure in Step 4), select the network adapter for the Leonardo DICOM network.  In the IP address field (2 in figure in Step 4), the IP address of the Leonardo workstation is displayed. |
| 6. | In the DICOM options, click Network Nodes (1 in figure below).  ![Siemens_services_Nodes.PNG](data:image/png;base64...) |
| 7. | In the Select Host menu (2 in figure in Step 6), verify that there is a CARTO option.  If there is no CARTO option in the menu, define it as a new host. |
| 8. | In the TCP/IP address field (4 in figure in Step 6), ensure that the IP address assigned to the CARTO™ 3 System is correct. |
| 9. | Click Test to test the connection. |
| 10. | Click > (3 in figure in Step 6).  The final configuration stage is displayed.  ![Siemens_service_Node_props.PNG](data:image/png;base64...) |
| 11. | In the Logical Name field (1 in figure in Step 10), define the logical name for the CARTO™ 3 System (if not already defined) and link it to a Host.  For convenience, use for the Logical Name the same name as in Host (CARTO). |
| 12. | In the Application Entity Properties group, define the AE title for the Logical Name (3 in figure in Step 10) and the port through which it listens for SCP services (4 in figure in Step 10).  Use the same AE title as defined on the CARTO™ 3 System for all SCU services (limited to Query only because the CARTO™ 3 System does not store on the Leonardo workstation). |
| 13. | In the Supported DICOM services group (4 in figure in Step 10), ensure that Store is selected.  Because the only SCP that the CARTO™ 3 System exports is Store, other services are not selected. |
| 14. | Click Save to save the configuration (5 in figure in Step 10). |
| 15. | In the Security options, click Settings.  ![Siemens_service_security.PNG](data:image/png;base64...)  If the Enable trusted host functionality check box (1 in figure above) is selected, only medical devices that have been defined on the Leonardo workstation will be authorized to perform queries. It is recommended to select the check box. |

## GE X-Ray System

https://bwiildita.sharepoint.com/sites/prod/Topics/XRay\_GE\_title\_EN.xml

### Configure AW VolumeShare™ 4 for Connectivity

https://bwiildita.sharepoint.com/sites/prod/Topics/Interface\_with\_ShareVolume\_v8p3\_EN.xml

Configuration of the VolumeShare™ 4 system requires the assistance of a GE engineer. The following instructions are supplied by GE Healthcare and are subject to change without notice. They are included here for reference only.

|  |  |
| --- | --- |
| 1. | On the Advantage Workstation on the Patient menu, click Admin. > Display Configuration.  ![GE_fluoro_DisplayConfiguration.png](data:image/png;base64...)  The Configuration window appears.  ![GE_fluoro_StationConfiguration.png](data:image/png;base64...) |
| 2. | From the Station Configuration group, collect the information required for configuring the AW VolumeShare™ system on the CARTO™ 3 System (see ["Configuring the DICOM Network"](#target9000021)) as follows:   * Application Entity in the hostname field * IP in the internet address field   The Port number is 4006. |
| 3. | On the Patient menu, click Tools > Network Manager.  ![GE_fluoro_Tools_NetworkManager.png](data:image/png;base64...)  The Network Manager dialog box appears.  ![GE_fluoro_NetworkManager.png](data:image/png;base64...) |
| 4. | Click Create.  A dialog box for configuring remote host parameters appears.  ![GE_fluoro_RemoteHostParameters.png](data:image/png;base64...) |
| 5. | Define the Query Retrieve server, as follows:   |  |  | | --- | --- | | 5.1 | According to the information in the DICOM Network Configuration window in the CARTO™ 3 Software Application (see ["Configuring the DICOM Network"](#target9000022)), define the parameters in the following fields.   * + Application Entity Title (BW\_QRS in the example)   + Network address   + Port number | | 5.2 | Define Host label and Host name as desired.  For convenience, you can define them like the Application Entity Title. | | 5.3 | In the Query retrieve field, select Supported. | | 5.4 | Click Save. |   ![GE_fluoro_RemoteHostParameters_104.png](data:image/png;base64...) |
| 6. | Repeat Steps 3–4 and then define the Store server (similar to defining the Query Retrieve server in Step 5). |

When the servers are configured, an icon for each server appears at the bottom of the VolumeShare™ main screen.

![GE_fluoro_server_icons.png](data:image/png;base64...)

Figure 31: Server Icons

# Ultrasound System Connectivity

In This Chapter

[Overview 67](#_Toc181736174)

[Supported Ultrasound Catheters 67](#_Toc181736175)

[Ultrasound Video Interface 67](#_Toc181736176)

[Connecting the Workstation to the Vivid™ iq System 68](#_Toc181736177)

[Connecting the Workstation to Vivid S70/S60/S70N/S60N 69](#_Toc181736178)

[Connecting the Workstation to the ACUSON P500™ System 71](#_Toc181736179)

[Connecting the Workstation to the ACUSON SC2000™ System 72](#_Toc181736180)

[Connecting the Workstation to the ACUSON Origin™ System 73](#_Toc181736181)

|  |
| --- |
|  |

## Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/Ultrasound\_connectivity\_EN.xml

Ultrasound connectivity includes:

* Connecting the ultrasound catheter (SOUNDSTAR™ Catheter) to the PIU and to the ultrasound system
* Connecting the CARTO™ 3 System Workstation to the ultrasound machine

The CARTO™ 3 System Workstation is connected to the ultrasound machine via cables:

* An Ethernet data cable
* A video cable, connecting the ultrasound video output to the workstation frame grabber card (analog interface option only).

### Supported Ultrasound Catheters

https://bwiildita.sharepoint.com/sites/prod/Topics/Ultrasound\_connectivity\_v8\_EN.xml

When working with the CARTO™ 3 System, you must use a supported catheter from the SOUNDSTAR™ Ultrasound Catheter family (referred to as the SOUNDSTAR™ Catheter). There are several versions of the SOUNDSTAR™ Catheter[[5]](#footnote-5), compatible with GE and Siemens ultrasound systems:

* SOUNDSTAR™ 3D 10 F Diagnostic Ultrasound Catheter
* SOUNDSTAR™ eco 10 F Diagnostic Ultrasound Catheter
* SOUNDSTAR™ eco 8 F Diagnostic Ultrasound Catheter
* SOUNDSTAR CRYSTAL™ 9 F Ultrasound Catheter

### Ultrasound Video Interface

https://bwiildita.sharepoint.com/sites/prod/Topics/Connectivity\_US\_video\_over\_LAN\_intro\_EN.xml

Digital and Analog video interface solutions between the CARTO™ 3 System Workstation and ultrasound systems coexist.

**Digital Interface**

The CARTO™ 3 System Workstation is connected to the ultrasound system via an Ethernet cable for Video over LAN and data communication. The CARTO™ 3 System Workstation and the ultrasound system exchange data using socket communication in TCP/IP data streaming mode.

The ultrasound system acts as a server and the CARTO™ 3 System connects to the ultrasound system as a client through a dedicated peer-to-peer network connection. The IP address and port number of the ultrasound server are pre-configured on the CARTO™ 3 System.

**Analog Interface**

This solution sends data in an analog format, such as VGA, and then grabs the images via the Matrox Solios frame grabber in the CARTO™ 3 Workstation.

Frame Data Stream communicates as raw pixel data and is connected by another distinguishing port.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Refer to the Declaration of Compatibility for ultrasound systems, compatible with a specific version of the CARTO™ 3 System. There is not backwards compatibility with earlier versions of the CARTO™ 3 Navigation System. |

## Connecting the Workstation to the Vivid™ iq System

https://bwiildita.sharepoint.com/sites/prod/Topics/connection\_workstation\_vividiq\_v8\_EN.xml

The interface between the Vivid™ iq system running software version 208 or later, and the CARTO™ 3 System can be digital or analog.

A digital interface is a direct connection. For video over LAN the Vivid™ iq software version 208.z is limited to Protocol Version 2.0.

An analog interface connects using an Isolated HDMI Splitter.

|  |  |
| --- | --- |
| ![DxNoteWarning.png](data:image/png;base64...) | **WARNING**  Do not connect the Vivid™ iq system and the CARTO™ 3 System directly with video cables. Use the Isolated HDMI Splitter. A direct cable connection might damage and void safety isolation. |

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  For analog interface, use kit supplied by GE to connect the video signal between the Vivid™ iq System and the CARTO™ 3 System. Using any other video converter module might degrade the quality of the ultrasound images displayed by the CARTO™ 3 System. |

![Ultrasound_connectivity_VVividIQ_AnalogDigital.jpg](data:image/jpeg;base64...)

Figure 32: CARTO™ 3 to Vivid™ iq Connections

Table 10: Key to Connecting the Workstation and the Vivid™ iq System

| # | Part | Connections |
| --- | --- | --- |
| 1 | CARTO™ 3 Workstation | CARTO™ 3 Workstation |
| 2 | Ethernet cable 35 m | Connect the Workstation to the ultrasound system.  Ethernet cable for Video over LAN and data communication. |
| 3 | VGA-DVI cable | Connect the Workstation to the isolated splitter |
| 4 | Isolated HDMI Splitter |  |
| 5 | HDMI-HDMI cable | Connect the isolated splitter to the ultrasound system |
| 6 | GE Vivid™ iq Ultrasound System | GE Healthcare's Vivid™ iq ultrasound system |
| 7 | SwiftLink Crystal GE Viq&S70 | Connects to the ultrasound system |
| 8 | SOUNDSTAR CRYSTAL GE | Connects to the GE Vivid iq ultrasound system |
| 9 | SOUNDSTAR™ Eco cable | 33-pin cable connects the catheter to the CARTO™ 3 PIU |
| 10 | CARTO™ 3 PIU | CARTO™ 3 PIU (Patient Interface Unit) |

## Connecting the Workstation to Vivid S70/S60/S70N/S60N

https://bwiildita.sharepoint.com/sites/prod/Topics/connection\_workstation\_vividS70\_v8\_EN.xml

Reference to the Vivid S70 ultrasound system in this document includes the Vivid S60/S70/S60N/S70N models.

The configuration illustrated is for a Vivid™ S70 System running software version 206 or later.

|  |  |
| --- | --- |
| ![DxNoteDanger.png](data:image/png;base64...) | **WARNING**  Do not connect the Vivid™ S70 System and the CARTO™ 3 System directly with video cables. Use the Isolated HDMI Splitter. A direct cable connection might damage and void safety isolation. |

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  For analog interface, use kit supplied by GE to connect the video signal between the Vivid™ S70 System and the CARTO™ 3 System. Using any other video converter module might degrade the quality of the ultrasound images displayed by the CARTO™ 3 System. |

![Ultrasound_connectivity_Vivid_S70_AnalogDigital.jpg](data:image/jpeg;base64...)

Figure 33: CARTO™ 3 to Vivid™ S70 Connections

Table 11: Key to Connecting the Workstation and the Vivid™ S70 System

| # | Part | Connections |
| --- | --- | --- |
| 1 | CARTO™ 3 Workstation | CARTO™ 3 Workstation |
| 2 | Ethernet cable 35 m | Connect the Workstation to the ultrasound system.  Ethernet cable for Video over LAN and data communication. |
| 3 | VGA-DVI cable | Connect the Workstation to the isolated splitter |
| 4 | Isolated HDMI Splitter |  |
| 5 | DVI-HDMI cable | Connect the isolated splitter to the ultrasound system |
| 6 | GE Vivid™ S70 Ultrasound System | GE Healthcare's Vivid™ S70 Ultrasound System |
| 7 | SwiftLink Crystal GE Viq&S70 | Connects to the ultrasound system |
| 8 | SOUNDSTAR CRYSTAL GE | Connects to the GE Vivid iq ultrasound system |
| 9 | SOUNDSTAR™ Eco cable | 33-pin cable connects the catheter to the CARTO™ 3 PIU |
| 10 | CARTO™ 3 PIU | CARTO™ 3 PIU (Patient Interface Unit) |

## Connecting the Workstation to the ACUSON P500™ System

https://bwiildita.sharepoint.com/sites/prod/Topics/connection\_workstation\_P500\_v8\_EN.xml

For the Analog Interface solution, connect the CARTO™ 3 System and the ACUSON P500™ ultrasound system via the Siemens isolation box. The isolation box converts the digital signal from the ultrasound system to an analog signal for the CARTO™ 3 System. Connect the CARTO™ 3 System to the OUT connector of the isolation box. Connect the ACUSON P500™ ultrasound system to the IN connector. Do not connect the two systems directly.

For the Digital Interface solution, the Siemens video over LAN streaming is for use with the Siemens ACUSON P500™ software version VC11A.

![Ultrasound_connectivity_ACUSON_P500_AnalogDigital.jpg](data:image/jpeg;base64...)

Figure 34: CARTO™ 3 Workstation to ACUSON P500™ Connections

Table 12: Key to Connecting the Workstation and the ACUSON P500™ System

| # | Part | Connections |
| --- | --- | --- |
| 1 | CARTO™ 3 Workstation | CARTO™ 3 Workstation |
| 2 | Ethernet cable 35 m | Connect the Workstation to the ultrasound system.  Ethernet cable for Video over LAN and data communication. |
| 3 | VGA-DVI cable | Connect the Workstation to the isolated splitter |
| 4 | Isolated HDMI Splitter |  |
| 5 | DVI-HDMI cable | Connect the isolated splitter to the ultrasound system |
| 6 | ACUSON P500™ Ultrasound System | ACUSON P500™ Ultrasound System |
| 7 | SwiftLink ACUSON P500™ | Connects to the ultrasound system |
| 8 | SOUNDSTAR CRYSTAL | Connects to the ultrasound system |
| 9 | SOUNDSTAR™ Eco cable | 33-pin cable connects the catheter to the CARTO™ 3 PIU |
| 10 | CARTO™ 3 PIU | CARTO™ 3 PIU (Patient Interface Unit) |

## Connecting the Workstation to the ACUSON SC2000™ System

https://bwiildita.sharepoint.com/sites/prod/Topics/connection\_workstation\_SC20000\_v8\_EN.xml

For the Analog Interface solution, connect the CARTO™ 3 System and the ACUSON SC2000™ ultrasound system via the Siemens isolation box. The isolation box converts the digital signal from the ultrasound system to an analog signal for the CARTO™ 3 System. Connect the CARTO™ 3 System to the OUT connector of the isolation box. Connect the ACUSON SC2000™ ultrasound system to the IN connector. Do not connect the two systems directly.

For the Digital Interface solution, the Siemens video over LAN streaming is for use with the Siemens ACUSON SC2000™ software version VC15A.

![Ultrasound_connectivity_ACUSON_SC2000_AD.jpg](data:image/jpeg;base64...)

Figure 35: CARTO™ 3 Workstation to ACUSON SC2000™ Connections

Table 13: Key to Connecting the Workstation and the ACUSON SC2000™ System

| # | Part | Connections |
| --- | --- | --- |
| 1 | CARTO™ 3 Workstation | CARTO™ 3 Workstation |
| 2 | Ethernet cable 35 m | Connect the Workstation to the ultrasound system.  Ethernet cable for Video over LAN and data communication. |
| 3 | VGA-DVI cable | Connect the Workstation to the isolated splitter |
| 4 | Isolated HDMI Splitter |  |
| 5 | DVI-HDMI cable | Connect the isolated splitter to the ultrasound system |
| 6 | Siemens ACUSON SC2000™ Ultrasound System | Siemens ACUSON SC2000™ Ultrasound System |
| 7 | SwiftLink Crystal GE | Connects to the ultrasound system |
| 8 | SOUNDSTAR CRYSTAL | Connects to the ultrasound system |
| 9 | SOUNDSTAR™ Eco cable | 33-pin cable connects the catheter to the CARTO™ 3 PIU |
| 10 | CARTO™ 3 PIU | CARTO™ 3 PIU (Patient Interface Unit) |

## Connecting the Workstation to the ACUSON Origin™ System

https://bwiildita.sharepoint.com/sites/prod/Topics/Connnection\_workstation\_origin\_EN.xml

Siemens ACUSON Origin™ SW Version VB20A (2031.028) is limited to SOUNDSTAR CRYSTAL™ ULS Catheter with a digital interface only

![Ultrasound_connectivity_ACUSON_Origin_Digital.jpg](data:image/jpeg;base64...)

Table 14: Key to Connecting the Workstation and the ACUSON Origin™ System

| # | Part | Connections |
| --- | --- | --- |
| 1 | CARTO™ 3 Workstation | CARTO™ 3 Workstation |
| 2 | Ethernet cable 35 m | Connect the Workstation to the ultrasound system.  Ethernet cable for Video over LAN and data communication. |
| 3 | Siemens ACUSON Origin™ Ultrasound System | Siemens ACUSON Origin™ Ultrasound System |
| 4 | CARTO™ 3 PIU | CARTO™ 3 PIU (Patient Interface Unit) |
| 5 | SOUNDSTAR™ Eco cable | 33-pin cable connects the catheter to the CARTO™ 3 PIU |
| 6 | SOUNDSTAR CRYSTAL | Connects to the ultrasound system |
| 7 | SwiftLink Crystal GE | Connects to the ultrasound system |

# Peripherals

In This Chapter

[Keyboard Requirements 74](#_Toc181736182)

[Mouse Requirements 74](#_Toc181736183)

[KVM Switch Requirements 74](#_Toc181736184)

[Printer Requirements 74](#_Toc181736185)

[Generic Network Equipment 75](#_Toc181736186)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/Non-BW\_Supplied\_Peripherals\_EN.xml

The CARTO™ 3 System supports monitors, mouse devices, and keyboard-video monitor-mouse (KVM) switches that are not supplied by Biosense Webster with the CARTO™ 3 System. When installing such devices with the CARTO™ 3 System, it is the service representative's responsibility to ensure that the peripherals connected to the CARTO™ 3 System comply with IEC 60950 and the criteria detailed below.

## Keyboard Requirements

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_Keyboard\_Requirements\_EN.xml

The CARTO™ 3 System supports 104-key QWERTY keyboards with generic USB or PS/2 connectors that support Microsoft Windows® 10.

## Mouse Requirements

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_Mouse Requirements\_EN.xml

The CARTO™ 3 System supports optical/laser mouse devices with generic USB or PS/2 connectors and 2-button+scrolling wheel (with button functionality) configuration, that support Microsoft Windows® 10.

## KVM Switch Requirements

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_KVM\_Switch\_Requirements\_EN.xml

The KVM switches used with the CARTO™ 3 System should provide direct connectivity for the above monitors keyboards and mouse devices and support Microsoft Windows® 10. They should also be EDID compatible.

## Printer Requirements

https://bwiildita.sharepoint.com/sites/prod/Topics/peripherals\_Printer\_Requirements\_EN.xml

The HP Universal Print Driver (UPD) is installed on the CARTO™ 3 System to support connection to a printer with generic USB connectors or connection to a network printer.

The CARTO™ 3 System supports printers that use the HP Universal Print Driver (UPD), PCL6, first UPD version 7.2.0 and lower.

For a list of supported printers, see:

https://support.hp.com/us-en/document/ish\_4952109-2831856-16

## Generic Network Equipment

https://bwiildita.sharepoint.com/sites/prod/Topics/Generic\_network\_equipment\_EN.xml

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Biosense Webster does not supply network switches and routers for installation with the CARTO™ 3 System. Site personnel are responsible for installation and further support for such equipment. If the assistance of a Biosense Webster Field Service Engineer is required for network configuration, the site staff should contact the local Biosense Webster Technical Support Center. |

Generic network equipment including switches and routers can be connected to the CARTO™ 3 System. Ensure that the equipment meets the requirements outlined here.

* All network equipment is located outside the patient environment.
* For equipment used for real-time data presentation:
  + Direct communication is via a Category 5 cable or above or via a fiber-optic cable.
  + Connector adapters can be added.
  + Media transceivers (such as optic to electric) can be added.
  + One Ethernet switch can be added.
* For equipment used for non-real-time communication:
  + Direct communication is via a Category 5 cable or above or via a fiber-optic cable.
  + Connector adapters can be added.
  + Media transceivers (such as optic to electric) can be added.
  + Both Ethernet switches and routers can be added.
* All switch and router ports are 100 Mbps or above.
* Copper cables are Category 5 or above.
* The length of copper cables is according to Ethernet standard (0–100 m).
* The length of fiber-optic cables is according to specification of the specific device (typically 0–1,000 m).
* Routers are configured to enable access from the CARTO™ 3 Workstation to the counterpart of the connected system. Isolation from other networks (virtual LANs), if required, is enabled using the configuration of the specific router.
* The address of a router is configured as a gateway on the Workstation.

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![](data:image/png;base64...)

1. Trellix uses multiple IP addresses for load balancing and high availability. The IP addresses are not static, therefore their direct use is not supported. For more information refer to technical articles in the Trellix Knowledge Center. [↑](#footnote-ref-1)
2. For use with CARTOMERGE™ Module Enhancements—where available [↑](#footnote-ref-2)
3. Storage Commitment is an optional service. [↑](#footnote-ref-3)
4. Where available [↑](#footnote-ref-4)
5. Where available [↑](#footnote-ref-5)