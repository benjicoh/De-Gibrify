|  |
| --- |
| Security User Guide |
|  |
|  |

|  |
| --- |
| () |
| October 2024 |
|  |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © 2011 - 2024 by Biosense Webster, Inc. All rights reserved.

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

P.N.: UG-5400-0981 (P02)

29 October 2024

Table of Contents

[CARTO™ 3 System Security 1](#_Toc181109948)

[About the CARTO™ 3 System 1](#_Toc181109949)

[Glossary 1](#_Toc181109950)

[System Data 2](#_Toc181109951)

[Viewing System Information 2](#_Toc181109952)

[Hardware Components 4](#_Toc181109953)

[Software Components 5](#_Toc181109954)

[BIOS 5](#_Toc181109955)

[Operating System 5](#_Toc181109956)

[User Access to OS Administration 5](#_Toc181109957)

[Operating System (OS) Hardening Process 5](#_Toc181109958)

[OS Security Patches 5](#_Toc181109959)

[Proprietary Software 5](#_Toc181109960)

[Third-Party Software 6](#_Toc181109961)

[Screen Saver 6](#_Toc181109962)

[Connections and Communication 7](#_Toc181109963)

[Securing Connections Using IPSec 7](#_Toc181109964)

[CARTO™ 3 Online Security Updates 8](#_Toc181109965)

[System Antivirus Protection 9](#_Toc181109966)

[Introduction 9](#_Toc181109967)

[Antivirus Scan Timing 9](#_Toc181109968)

[Actions When a Virus is Detected 9](#_Toc181109969)

[Updating Antivirus Definitions 9](#_Toc181109970)

[Antivirus Log and Log Export 10](#_Toc181109971)

[Firewall 11](#_Toc181109972)

[Purpose and Implementation 11](#_Toc181109973)

[Activation, Control, and Configuration 11](#_Toc181109974)

[Notifications and Logging 11](#_Toc181109975)

[Default Settings 11](#_Toc181109976)

[Windows® Firewall Profile Settings 12](#_Toc181109977)

[Windows® Firewall Detailed Settings 12](#_Toc181109978)

[Updated Security Information 12](#_Toc181109979)

[Allow List 13](#_Toc181109980)

[System Users 14](#_Toc181109981)

[Secure Login 14](#_Toc181109982)

[Security Maintenance 15](#_Toc181109983)

[How to Contact Us 16](#_Toc181109984)

# CARTO™ 3 System Security

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Intro\_EN.xml

This document provides background information, security precautions, and recommendations for the proper use and maintenance of the CARTO™ 3 System.

The information in this document is relevant to version 8.1 of the CARTO™ 3 System.

This document is for hospital IT Administrators and CARTO™ 3 System users.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Images in this document are for illustrative purposes only. |

## About the CARTO™ 3 System

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_system\_EN.xml

The CARTO™ 3 System is a medical system used in electrophysiology laboratories for the diagnosis of heart arrhythmias.

The CARTO™ 3 System acquires data from intra-cardiac catheters and provides electro-physiologists with three-dimensional synthetic visualizations of the heart chamber walls and the catheters in use. Electrocardiogram (ECG) signal display is also available.

## Glossary

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_glossary\_EN.xml

|  |  |
| --- | --- |
| **BIOS** | the Basic Input / Output System in IBM PC®-compatible computers |
| **BW** | Biosense Webster |
| **CAS** | Clinical Account Specialist |
| **DICOM** | Digital Imaging and Communication in Medicine is the standard for handling, storing, printing, and transmitting information in medical imaging |
| **EP** | Electrophysiology |
| **ePHI** | Electronic Protected Health Information |
| **FSE** | Field Service Engineer |
| **GUI** | Graphic User Interface |
| **ICMP** | Internet Control Message Protocol |
| **IPSec** | Internet Protocol Security - an Internet RFP Standard |
| **HIPAA** | Health Insurance Portability and Accountability Act of 1996 |
| **MRI** | Magnetic Resonance Imaging |
| **NIST** | National Institute of Standards and Technology (http://www.nist.gov/index.html) |
| **OR Admin** | Operating Room Administrator |
| **OR User** | Operating Room User |
| **OS** | Operating System |
| **PACS** | Picture Archiving and Communication System |
| **PIU** | Patient Interface Unit |
| **R&D** | Research and Development |
| **SOP** | Standard Operating Procedure |
| **SPU** | Signal Processing Unit |
| **SW** | Software |
| **TCP/IP** | Transmission Control Protocol (TCP) and Internet Protocol (IP), set of communication protocols used for the Internet and similar networks |

## System Data

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_system\_data\_v8\_EN.xml

The CARTO™ 3 System generates proprietary data acquired during the CARTO™ 3 System EP procedure and contains intracardiac electrograms, body surface ECG signals, an anatomical model of the patient's heart, etc.

The data generated by the CARTO™ 3 System is stored locally on the hard drive and can be backed up to external systems, mainly PACS systems, through DICOM connectivity or to removable media such as CDs, DVDs, or USB mass storage devices.

The CARTO™ 3 System holds Electronic Protected Health Information (ePHI) data, including patient demographic data, which can be entered by the operator or received from the Hospital Information System through a connection to an EP recording system.

ePHI data is visible in the CARTO™ 3 System screen only during time-limited phases of the product use (mainly at the short EP study setup step, when the EP doctor inputs the patient data). Moreover, hospital internal security measures protect physical access to the EP lab, limiting the risk of visual access to on-screen ePHI data.

The CARTO™ 3 System uses data from other modalities such as CT, MRI, and fluoroscopy.

Data is imported to the CARTO™ 3 System either from the hospital network through DICOM connectivity or from a DICOM-compatible removable media, such as a CD, DVD, or USB mass storage device.

Data for debugging and research investigations (logs, recordings, etc.) can also be de-identified and exported to a USB mass storage device.

Data exported to USB mass storage devices is encrypted to prevent unauthorized access in the event of removable device loss.

## Viewing System Information

https://bwiildita.sharepoint.com/sites/prod/Topics/Viewing\_System\_Information\_v7p5\_EN.xml

To view general information about the installed application and hardware serial numbers, click Help > About CARTO™ System. This view includes a list of installed modules, ACL Tx card calibration, and Signal Processing Unit (SPU) version.

A counter appears for the number of uses of each chest and back patch sensor cable.

![C3_HelpAbout_v8.png](data:image/png;base64...)

Figure 1: Sample About CARTO™ System Window

For detailed information, click System Information.

The System Information window provides details for the following categories:

* Display Adapter
* Bios
* Anti Malware
* System
* Operating System
* Windows Updates

![System_information_AV.png](data:image/png;base64...)

Figure 2: Sample System Information Window

These details can be exported to a USB mass storage device. On the Export tab of the System Information Window, select the categories you want to export and click External Drive.

![System_info_config.png](data:image/png;base64...)

Figure 3: System Information Window, Export Tab

## Hardware Components

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_hardware\_EN.xml

The main components of the CARTO™ 3 System hardware are:

* **The Patient Interface Unit (PIU)** and related equipment, including the Location Pad (LP). The PIU is stationed near the patient, and the LP is positioned under the patient's table.
* **The Workstation** and related equipment are typically stationed in the observation room.
* **The Signal Processing Unit (SPU)**[[1]](#footnote-1) and the dedicated SPU holder. The SPU holder can be configured for any side of the CARTO™ 3 System cart, patient table, or Boom.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  It is strongly recommended that the workstation be physically locked using the built-in lock handle on the back panel. Moreover, the CARTO™ 3 System Workstation contains a Chassis Intrusion Switch that automatically logs any event involving opening the chassis to the BIOS memory. |

## Software Components

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_software\_EN.xml

The following sections detail the security aspects at each software layer and components of the CARTO™ 3 System Workstation.

### BIOS

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_bios\_EN.xml

The CARTO™ 3 System Workstation BIOS configuration is password protected. The BIOS Setup can be accessed by pressing the Workstation BIOS access key during startup. However, password protection prevents users from modifying BIOS parameter values.

### Operating System

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_OS\_EN.xml

The CARTO™ 3 System Workstation is based on the Microsoft® Windows® 10 x64 Enterprise LTSC.

### User Access to OS Administration

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_OS\_access\_EN.xml

To prevent user modifications to the CARTO™ 3 System Workstation that are adverse or security-breaking, the Windows® desktop is protected from unauthorized users. The CARTO™ 3 System main application and all its required services are executed automatically when the Workstation is started.

### Operating System (OS) Hardening Process

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_OS\_hardening\_EN.xml

The CARTO™ 3 System has been hardened to prevent users from changing Windows® settings that might affect system operation. The OS hardening is based on Center for Internet Security, Inc. (CIS®) recommendations, and NIST as described in The Unified Compliance Framework® for specific Windows 10-based systems and according to their relevance to the CARTO™ 3 System's specific needs.

### OS Security Patches

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_security\_patches\_EN.xml

Microsoft Windows® security patches are installed on the CARTO™ 3 System during manufacturing and included in periodic security updates.

### Proprietary Software

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_proprietary\_sw\_EN.xml

The CARTO™ 3 System Workstation Software includes proprietary software designed, implemented, and validated in-house using standard tools and according to Biosense Webster SOPs. The development environment is contained within a secured network.

Software Development Tools and Methods are implemented according to the Quality requirements of Biosense Webster Software Development Procedures and Guidelines.

### Third-Party Software

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_3rd\_party\_v8\_EN.xml

CARTO™ 3 System Workstation also contains third-party software validated for use after a documented review. This includes:

* Software developed by Biosense Webster sub-contractors, according to Biosense Webster SOPs
* Off-the-shelf software validated by Biosense Webster (Windows drivers, utilities, etc.).

### Screen Saver

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_screensaver\_EN.xml

The Windows® screen saver on the CARTO™ 3 System is disabled to prevent the display from locking during a procedure. Users cannot change this configuration.

# Connections and Communication

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Connections\_EN.xml

An optical cable between the CARTO™ 3 System Workstation and the CARTO™ 3 System PIU enables digital communication between both units, according to a private TCP/IP connection protocol.

An optical cable between the PIU and the SPU enables digital communication between the Workstation and the SPU, based on an extension of the Workstation-PIU private protocol.

The workstation connects to third-party medical systems using point-to-point network connections, via each of its five RJ-45 Ethernet ports, exchanging digital data with them according to commonly agreed-upon private protocols over TCP/IP and using Windows network file sharing.

This includes:

* Fluoroscopy system
* DICOM (PACS server)
* Electrophysiological therapeutic ablation generator
* Ultrasound system
* ECG EP Recording system

The CARTO™ 3 System Workstation USB port connections are used for Software & Security Updates and exporting data.

Biosense Webster Software and Security Updates, which are periodically deployed from USB mass storage devices, are protected by permission setting and a digital file signature verification.

![CARTO_System_Connections_v8p3.jpg](data:image/jpeg;base64...)

Figure 4: CARTO™ System Connections

For connectivity details, refer to the CARTO™ 3 System *Connectivity User Guide*.

## Securing Connections Using IPSec

https://bwiildita.sharepoint.com/sites/prod/Topics/secure\_connections\_ipsec\_EN.xml

The CARTO™ 3 System can be configured to use IPSec, for compliance with PACS (Picture Archiving and Communication System) servers.

With IPsec enabled, all communication between the CARTO™ 3 System and PACS servers is secured and encrypted.

Fluoroscopy systems can be configured to communicate securely using IPsec.

Enabling IPSec for secure communication is performed only by a Biosense Webster representative. To configure secure connections, contact the Biosense Webster Service and Support Department.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When connecting the CARTO™ 3 System to the Hospital network, it is recommended (and in some cases required) to use the DICOM port for the secure transmission of medical images. |

## CARTO™ 3 Online Security Updates

https://bwiildita.sharepoint.com/sites/prod/Topics/Online\_security\_updates\_EN.xml

The CARTO™ 3 System supports receiving security updates from the network.

For connectivity details, refer to the CARTO™ 3 System *Connectivity User Guide*.

# System Antivirus Protection

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Antivirus\_EN.xml

## Introduction

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Antivirus\_\_Intro\_EN.xml

Each new version of the CARTO™ 3 System software includes an updated version of Trellix Antivirus and its virus database. CARTO™ 3 System version 8.x comes with Trellix Endpoint Security Version 10.7. The antivirus software helps protect against viruses, spyware, and other malicious software found on infected external storage devices connected to the Workstation. The antivirus is active by default.

The antivirus definition files can be upgraded automatically.

For connectivity information and instructions how to perform antivirus definition file updates, refer to the CARTO™ 3 System *Connectivity User Guide*.

## Antivirus Scan Timing

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_antivirus\_scan\_timing\_EN.xml

The CARTO™ 3 Workstation performs an automated scan to check the computer for viruses and other threats on a regular basis. Scheduled scans are essential to ensuring the continuous health of the Workstation. By default, Trellix performs a scheduled scan once a week, but you can modify the schedule to fit your needs.

To prevent a negative impact on performance; the system does not start scheduled scans while a clinical study is in progress. If a clinical study is started while a scan is in progress, the scan is automatically stopped.

## Actions When a Virus is Detected

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_detect\_virus\_EN.xml

If the antivirus application detects a virus during a scan, it automatically attempts to remove the virus and repair the infected file without prompting the user for action.

If a file with a virus that cannot be removed is detected, a message appears, notifying the user that the file cannot be accessed. The antivirus application blocks access to the infected file to protect the operating system.

If you suspect that the Workstation has been exposed or compromised by a computer virus of any kind, immediately disconnect the computer from all networks and contact a Biosense Webster representative to remove the virus and if necessary, to reinstall the system.

## Updating Antivirus Definitions

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_updateAV\_v8p2\_EN.xml

Antivirus definitions (the catalog of known viruses or virus signatures) are updated in the CARTO™ 3 System either automatically or manually.

To find details about the last antivirus update installed, click Help > About CARTO™ System > System Information, and view the Anti Malware section.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  HIPAA rules require covered entities and business associates to keep antivirus software enabled and updated. We recommend that you update antivirus definitions as often as possible, and at least once every week.  **It is the customer’s responsibility to update antivirus definitions.** |

For instructions how to perform antivirus definition file updates, refer to the CARTO™ 3 System *Connectivity User Guide*.

## Antivirus Log and Log Export

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_MSessentials\_log\_EN.xml

By default, the Trellix Antivirus in the CARTO™ 3 System is configured to log its activity.

Biosense Webster authorized personnel with an Administrator password can access the Trellix Antivirus log file and export it (using the Export Data Tool). Antivirus log files are part of Windows Event Logs and limited to a maximum size of 100 MB. When the event log file reaches the maximum size, new entries overwrite older entries.

# Firewall

## Purpose and Implementation

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_FW\_purpose\_EN.xml

The CARTO™ 3 System Workstation uses the Windows® 10 firewall to block unauthorized inbound and outbound network traffic.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * The firewall is configured to allow ICMP traffic generated by the ping command. The ping command is used to check connectivity with other systems. * The CARTO™ 3 System SPU has no firewall protection because it is physically connected only to the PIU, via a dedicated point-to-point Ethernet TCP/IP connection. * The CARTO™ 3 System PIU is a real-time processing unit, based on a dedicated Digital Signal Processor platform. |

## Activation, Control, and Configuration

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_FW\_activation\_EN.xml

The system firewall is active by default.

Only certified Biosense Webster Field Service Engineers can perform the following tasks:

* Deactivate and reactivate the Firewall for a specific task.
* Configure the Firewall to access the GUI (Graphic User Interface) console.

|  |  |
| --- | --- |
| ![DxNoteCaution.png](data:image/png;base64...) | *CAUTION*  Biosense Webster recommends not changing the default firewall configuration. |

## Notifications and Logging

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Notifications-Logging\_EN.xml

To maintain an uninterrupted Clinical Study workflow, the Firewall is configured not to interfere with the use of the CARTO™ 3 System. Alerts related to firewall activity are recorded in the Firewall Log file.

You can export the Firewall Log file via the CARTO™ 3 System Export Data Tool.

## Default Settings

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_FW\_defalut\_EN.xml

To restore the original firewall settings, use the Windows Firewall Export feature. Windows Firewall Export restores the settings saved in a WFW file, which was saved on the Workstation Hard Disk upon installation.

By clicking Restore Firewall Settings, the saved WFW file is automatically imported, which ensures that the default state after the installation is duly restored.

## Windows® Firewall Profile Settings

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Win\_Firewall\_Prof\_Settings\_EN.xml

For all the three Windows® Firewall Profiles (Domain, Private, and Public):

* Windows® Firewall State is set to "On"
* Inbound Connections setting is set to "Block (default)"
* Outbound Connections setting is set to "Block (default)"
* All the physical network connections are protected by the Profile

## Windows® Firewall Detailed Settings

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Win\_Firewall\_Det\_Settings\_EN.xml

Information or customization requests about detailed Windows Firewall settings must be addressed to Biosense Webster personnel authorized for the restricted access to the Firewall Configuration application.

## Updated Security Information

https://bwiildita.sharepoint.com/sites/prod/Topics/SUG\_update\_security\_EN.xml

Johnson & Johnson maintains a public internet site for Security Vulnerability Disclosure and Security Advisories for J&J Medical Devices, including the CARTO™ 3 System: [www.productsecurity.jnj.com](http://www.productsecurity.jnj.com)

The site offers updated information about the current assessment performed by Johnson & Johnson and Biosense Webster of the risks posed by disclosed vulnerabilities.

The site also allows CARTO™ 3 System customers to post any additional security information requests and reports.

# Allow List

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Allow\_List\_EN.xml

The CARTO™ 3 Allow List mechanism ensures only approved applications can execute on the CARTO™ 3 Workstation. By default, all other applications are denied execution.

# System Users

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_system\_users\_EN.xml

## Secure Login

https://bwiildita.sharepoint.com/sites/prod/Topics/HIPAA\_intro\_V8p3\_EN.xml

The CARTO™ 3 System complies with all health regulations regarding privacy and integrity by providing a secure login to the system. When enabled, users are required to sign into the CARTO™ 3 System with a username and password. Secure Login records an audit trail file containing the username, time and date of logins, and system event descriptions. When using Secure Login, the system will logoff automatically and return the user to the Login dialogue box after a user-defined idle time is reached.

The audit trail file of system events is available for export by the hospital CARTO™ 3 System Administrator (OR Admin). The audit trail lists system events, identifying them with the following information:

* Time and date
* Username
* Event description.

The CARTO™ 3 System has four levels of application access, which allows selective access to Dialogs and Menus, as shown in the following table.

Table 1: User Types and Access Levels

| User Type | Role Associated with User Type | Access Level |
| --- | --- | --- |
| OR Admin | The Operating Room Admin (OR Admin) is a hospital administrator for the CARTO™ 3 System | User Management for the local Workstation with access to the CARTO™ 3 System and no access to Technician Tools |
| OR User | The Operating Room User (OR User) is an EP Doctor, or other EP staff | Access to the CARTO™ 3 System only, with no access to Technician Tools or User Management |
| CAS | BW Clinical Account Specialist (CAS) | Access to the CARTO™ 3 System, User Management, and partial access to Technician Tools (Upgrade and CAS Tools tabs only) |
| FSE | BW Field System Engineer (FSE) | Access to the CARTO™ 3 System, User Management, and Technician Tools for system configuration and software upgrades |

The CARTO™ 3 System has a User Management feature to manage individual user accounts. Once activated, user account management activities, including creating and disabling login accounts, will be performed by the customer.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The passwords for user types FSE and CAS are confidential and should not be disclosed to users of the CARTO™ 3 System. They are to be used by Biosense Webster representatives only. |

# Security Maintenance

https://bwiildita.sharepoint.com/sites/prod/Topics/CARTO\_SUG\_Software\_Security\_Maintenance\_EN.xml

The security level of the CARTO™ 3 System software components is regularly maintained by the periodical deployment of **Security Service Packs** according to the Biosense Webster Security for Product policy. Security Service Packs may also be deployed to remedy emerging high-level risk security vulnerabilities.

When enabled, Security Service Packs can be pushed to the CARTO™ System. Indication appears in the opening screen when a new service pack is ready to install.

Responsibilities for maintaining security related features are detailed in the following table:

| Responsibility | Role |
| --- | --- |
| Installation of Antivirus and Signature Updates | Shared Biosense Webster and Hospital IT / Lab Administrator |
| Installation of Security Service Packs (Cybersecurity Patches) | Shared Biosense Webster and Hospital IT / Lab Administrator |
| EP Procedures Backup and Restore | Hospital IT / Lab Administrator |
| User Management | Hospital IT / Lab Administrator |
| Password Renewal | Hospital IT / Lab Administrator |
| Sanitization of Electronic Protected Health Information (ePHI) before decommissioning the medical device | Hospital IT / Lab Administrator |
| Adjusting Application-Level Security, when necessary | Biosense Webster |
| Adjusting Firewall Settings | Biosense Webster |
| Develop and distribute Operating System Security Patches | Biosense Webster |
| Develop and distribute Third-Party Security Patches | Biosense Webster |

# How to Contact Us

https://bwiildita.sharepoint.com/sites/prod/Topics/contact\_us\_v7.5-8\_EN.xml

If you have identified a potential security vulnerability or privacy issue with products from the Johnson & Johnson Family of Companies, please contact us by sending an email (in English) to productsecurity@its.jnj.com. Please use our PGP Public Key to encrypt your email submission! The Public Key can be found on PGP public key servers (keyserver.pgp.com) by the key id 0x1F9A03EC.

Once we receive your message, our personnel will contact you.

The productsecurity@its.jnj.com email address is intended only for the purposes of reporting security vulnerabilities or privacy issues in medical device products from the Johnson & Johnson Family of Companies.

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![](data:image/png;base64...)

1. Where available and installed [↑](#footnote-ref-1)