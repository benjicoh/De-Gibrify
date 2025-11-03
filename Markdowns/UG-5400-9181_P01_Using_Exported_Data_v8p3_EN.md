|  |
| --- |
| Using Exported Data |
| User Guide |
|  |

|  |
| --- |
| () |
| September 2024 |
|  |

![A picture containing text, clipart  Description automatically generated](data:image/png;base64...)![A picture containing diagram  Description automatically generated](data:image/png;base64...) © 2021 - 2024 by Biosense Webster, Inc. All rights reserved.

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

P.N.: UG-5400-9181 (P01)

8 September 2024

Table of Contents

[Introduction 1](#_Toc176706045)

[Exporting Study Data 1](#_Toc176706046)

[Folder Structure 2](#_Toc176706047)

[File Naming Conventions 3](#_Toc176706048)

[Exported Data From Previous Versions 4](#_Toc176706049)

[Top-Level Folder 5](#_Toc176706050)

[[Study #] [Timestamp].xml 6](#_Toc176706051)

[[Map Name].mesh 6](#_Toc176706052)

[[Map Name]\_car.txt 7](#_Toc176706053)

[[Map Name]\_Points\_Export.xml 10](#_Toc176706054)

[[Map Name]\_P[#]\_Point\_Export.xml 10](#_Toc176706055)

[[Map Name]\_ECG\_Export\_[#].txt 11](#_Toc176706056)

[[Map Name]\_P[#]\_[Connector]\_Electrode\_Positions.txt 11](#_Toc176706057)

[[Map Name]\_P[#]\_[Connector]\_Electrode\_Positions\_OnAnnotation.txt 12](#_Toc176706058)

[[Map Name]\_P[#]\_[Connector]\_Sensor\_Positions.txt 12](#_Toc176706059)

[[Map Name]\_P[#]\_[Connector]\_Sensor\_Positions\_OnAnnotation.txt 12](#_Toc176706060)

[[Map Name]\_P[#]\_ContactForce.txt 12](#_Toc176706061)

[[Map Name]\_CartoFinderSite\_[Site #]\_IdxInMap.txt 13](#_Toc176706062)

[RF\_[Map Name]\_[RF#].txt 14](#_Toc176706063)

[ContactForceInRF\_[Map Name]\_[RF #].txt 14](#_Toc176706064)

[RF\_CARTO\_TO\_ABLATOR\_SESSIONS\_MAPPING.txt 15](#_Toc176706065)

[TemperaturesInRF\_[Map Name]-[RF #].txt 15](#_Toc176706066)

[Version.txt 15](#_Toc176706067)

[PASO™ Module Exported Data 16](#_Toc176706068)

[ConfigurationData.txt 16](#_Toc176706069)

[IS[#].txt 16](#_Toc176706070)

[ISISCorrelations.txt 17](#_Toc176706071)

[PM[#].txt 17](#_Toc176706072)

[PMISCorrelations.txt 18](#_Toc176706073)

[CARTO VISITAG™ Module Exported Data 19](#_Toc176706074)

[General CARTO VISITAG™ Module Exported Data 20](#_Toc176706075)

[AblationData.txt 20](#_Toc176706076)

[AblationSites.txt 20](#_Toc176706077)

[AblationSites\_WhiteTags.txt 21](#_Toc176706078)

[ContactForceData.txt 21](#_Toc176706079)

[fpti-formulas.xml 22](#_Toc176706080)

[Grids.txt 22](#_Toc176706081)

[Sites.txt 22](#_Toc176706082)

[Sites\_Validity.txt 23](#_Toc176706083)

[Sites\_WhiteTags.txt 23](#_Toc176706084)

[VisiTagDisplay.txt 23](#_Toc176706085)

[VisiTagPresets.txt 23](#_Toc176706086)

[VisiTagSessions.txt 23](#_Toc176706087)

[VisiTagSettings.txt 24](#_Toc176706088)

[QMODE+™ Ablation Sessions 25](#_Toc176706089)

[AblationData\_QMODE+.txt 25](#_Toc176706090)

[AblationSites\_QMODE+.txt 25](#_Toc176706091)

[AblationSites\_WhiteTags\_QMODE+.txt 26](#_Toc176706092)

[ContactForceData\_QMODE+.txt 26](#_Toc176706093)

[Sites\_QMODE+.txt 26](#_Toc176706094)

[Sites\_WhiteTags\_QMODE+.txt 27](#_Toc176706095)

[Sites\_Validity\_QMODE+.txt 27](#_Toc176706096)

[VisiTagSessions\_QMODE+.txt 27](#_Toc176706097)

[VisiTagSettings\_QMODE+.txt 27](#_Toc176706098)

# Introduction

In This Chapter

[Exporting Study Data 1](#_Toc176706099)

[Folder Structure 2](#_Toc176706100)

[File Naming Conventions 3](#_Toc176706101)

[Exported Data From Previous Versions 4](#_Toc176706102)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport-Introduction\_EN.xml

You can export study data from the CARTO™ 3 System as text files that can be used for external analysis.

This document provides information on study data that was exported from CARTO™ 3 System, version 8.

For information on data exported from a different version (including evaluation versions), contact your Biosense Webster representative.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Data files presented in this document are for illustration purposes only and cannot be used to infer or deduce patterns, trends, or results. |

## Exporting Study Data

https://bwiildita.sharepoint.com/sites/prod/Topics/Data\_Export\_Exported\_Data\_EN.xml

Exporting study data is only available in Review mode (Study > Export Study Data). The data reflects the status at the time of export, including any changes made in Review mode.

![ExportStudyData_DialogBox_v7.png](data:image/png;base64...)

Figure 1: Export Study Data Dialog Box

When Base is selected, the exported data includes the location of all electrodes, map data, and ablation session data. It also includes data related to the CONFIDENSE™ Module, such as pattern matching data, and the CARTO PRIME™ Module, such as LAT Hybrid data.

To export data for the CARTO VISITAG™ Module, PASO™ Module, or CARTOFINDER™ Module, select the module in the Export Study Data dialog box.

The data is added to a \*.zip file, which is exported using the Export Data tool.

![exportData_rawDataExport.png](data:image/png;base64...)

Figure 2: Export Data Tool

After the password-protected file is unzipped, go to the [Patient Timestamp] > [Study Name] subfolder. Unzip the Export\_Study file.

![DataExport_zip_location.png](data:image/png;base64...)

Figure 3: Path to Study Data Zip file

For details, refer to the *CARTO™ 3 Comprehensive User Guide* (CUG).

## Folder Structure

https://bwiildita.sharepoint.com/sites/prod/Topics/Data\_Export\_Folder\_Structure\_EN.xml

Data files are exported to a file called ExportData + timestamp, e.g., ExportData30\_12\_20 11\_59\_25.zip. The timestamp reflects the date and time of export, not the study.

After unzipping the files, there is a top-level folder with the base content and, if relevant, CARTOFINDER™ Module data.

Subfolders are created for the PASO™ Module (PasoExport) and CARTO VISITAG™ Module (VisiTagExport). The VisiTagExport folder also contains files related to the QDOT MICRO™ Catheter, if used during the study.

![Data_sampleFolderStructure.png](data:image/png;base64...)

Figure 4: Sample Folder Structure

## File Naming Conventions

https://bwiildita.sharepoint.com/sites/prod/Topics/dataExport\_FileNames\_EN.xml

File names for exported study data include details such as the study date and time, as well as point numbers, PIU socket, and ablation session. In this document, sample file names are used to represent the names of exported files. For example, the file *2-BS V SR 1\_P1\_MAGNETIC\_20\_POLE\_A\_CONNECTOR\_Electrode\_Positions.txt* would be described as *[Map Name]\_P[#]\_[Connector]\_Electrode\_Positions.txt*.

Table 1: File Naming Conventions: Placeholders

| Term | Stands for... | Example |
| --- | --- | --- |
| [Map Name] | Map number and name | 2-BS V SR 1 |
| P[#] | Point number | P2 |
| [Connector] | PIU socket | 20\_POLE\_A\_CONNECTOR |
| [RF #] | Ablation session number | RF\_1-Map\_2 |
| [Study #] | Study name | **Study 3** 12\_28\_2020 14-30-44.xml |
| [Timestamp] | Export timestamp | Study 3 **12\_28\_2020 14-30-44**.xml |
| [Site #] | CARTOFINDER™ Site number | CartoFinderSite\_1 |

Connected catheters are identified in the exported data by the socket to which the catheter was connected; however, the names used in the exported study data do not match the socket names on the PIU.

Table 2: Converting PIU Socket Names to Exported Connector Names

| PIU Socket | Connector in File |
| --- | --- |
| MAP | NAVISTAR\_CONNECTOR |
| 20 POLE A | MAGNETIC\_20\_POLE\_A\_CONNECTOR |
| 20 POLE B | MAGNETIC\_20\_POLE\_B \_CONNECTOR |
| REF/DECA | CS\_CONNECTOR |
| Ultrasound | ULS\_CONNECTOR\_SENSOR |
| QUAD A | QUAD\_A\_CONNECTOR |
| QUAD B | QUAD\_B\_CONNECTOR |
| DECA | DEC\_CONNECTOR |

## Exported Data From Previous Versions

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExportFromPreviousVersions\_EN.xml

Studies from previous versions of the CARTO™ 3 System can be restored in this version of the CARTO™ 3 System and then the study data can be exported. However, due to difference between the versions, some data files are not generated or may not contain valid data after export from the current version.

For example, the System may encounter difficulty exporting the gain reference value which is required to calculate the voltage of the ECG signal. To verify whether the ECG files are correct, open [Map Name]\_P[#]\_ECG\_Export.txt in Excel. If the Gain value is -10000, the file is invalid.

![Data Export - Incorrect Exported ECG.png](data:image/png;base64...)

Figure 5: Sample Invalid ECG File

If this occurs, or there are other issues when exporting study data from an older version, contact your Biosense Webster representative.

# Top-Level Folder

In This Chapter

[[Study #] [Timestamp].xml 6](#_Toc176706103)

[[Map Name].mesh 6](#_Toc176706104)

[[Map Name]\_car.txt 7](#_Toc176706105)

[[Map Name]\_Points\_Export.xml 10](#_Toc176706106)

[[Map Name]\_P[#]\_Point\_Export.xml 10](#_Toc176706107)

[[Map Name]\_ECG\_Export\_[#].txt 11](#_Toc176706108)

[[Map Name]\_P[#]\_[Connector]\_Electrode\_Positions.txt 11](#_Toc176706109)

[[Map Name]\_P[#]\_[Connector]\_Electrode\_Positions\_OnAnnotation.txt 12](#_Toc176706110)

[[Map Name]\_P[#]\_[Connector]\_Sensor\_Positions.txt 12](#_Toc176706111)

[[Map Name]\_P[#]\_[Connector]\_Sensor\_Positions\_OnAnnotation.txt 12](#_Toc176706112)

[[Map Name]\_P[#]\_ContactForce.txt 12](#_Toc176706113)

[[Map Name]\_CartoFinderSite\_[Site #]\_IdxInMap.txt 13](#_Toc176706114)

[RF\_[Map Name]\_[RF#].txt 14](#_Toc176706115)

[ContactForceInRF\_[Map Name]\_[RF #].txt 14](#_Toc176706116)

[RF\_CARTO\_TO\_ABLATOR\_SESSIONS\_MAPPING.txt 15](#_Toc176706117)

[TemperaturesInRF\_[Map Name]-[RF #].txt 15](#_Toc176706118)

[Version.txt 15](#_Toc176706119)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_BaseData\_EN.xml

The top-level folder contains the data files for base CARTO™ 3 System functionality, as well as files for CONFIDENSE™ Module and CARTO PRIME™ Module. If CARTOFINDER™ Module data was exported, it is also in the top-level folder.

In the case of a remap, Re is added to the map name. A copy of every file is created.

![dataExport_Remap_SampleNames.png](data:image/png;base64...)

Figure 6: Sample Files Before and After Remap

These files are described below, according to Study, Map, Point, Ablation Session, Version.

## [Study #] [Timestamp].xml

https://bwiildita.sharepoint.com/sites/prod/Topics/Study-Name-Date\_EN.xml

These files contain details of parameters used during the study.

Table 3: [Study #] [Timestamp].xml File

| Section Name | Description |
| --- | --- |
| Study | Name of the study, including timestamp |
| Units | Defines units for distance and angle used within the file |
| Environment | Orientation of Main Map Viewer (camera position). |
| ExternalObjs | Lists objects such as the heart icon or the color bar that might have been used during the study |
| Maps | ColoringTable lists the available map coloring types |
| SurfaceErrorTable |
| PasoTable gives the IS name |
| CFAEColoringTable provides the CFAE thresholds |
| TagsTable lists the available point tags and types |
| Map: Lists map coloring data, and point data including x, y, z coordinates, orientation, tags, projection location, catheter ID, and CFAE data (if enabled), for each map in the study |

## [Map Name].mesh

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_mesh\_EN.xml

These files are created for each exported map. The data in these files represent the geometry and coloring of the map.

Table 4: Sections in [Map Name].mesh Files

| Section Name | Description |
| --- | --- |
| Header | Contains version and copyright information  ![dataExport_mesh_header.png](data:image/png;base64...) |
| GeneralAttributes | Lists general attributes such as Mesh ID, number of vertices, coloring information, and map coloring types.  ![dataExport_mesh_general.png](data:image/png;base64...) |
| VerticesSection | Provides data for each vertex  ![dataExport_mesh_vertices.png](data:image/png;base64...) |
| TrianglesSection | Provides data for each triangle  ![dataExport_mesh_triangles.png](data:image/png;base64...) |
| VerticesColorSection | For each vertex, provides values for different map coloring types.  -10000 represents missing or invalid data.  ![dataExport_mesh_verticesColorSection.png](data:image/png;base64...) |
| VerticesAttributesSection | Indicates whether a vertex is associated with an Early Meets Late value (EML for upper threshold; ExtEML for lower threshold) or a scar value (SCAR).  For each option, 1 indicates that it has the attribute; 0 indicates that it is does not (regular vertex).  ![dataExport_mesh_verticeAttributesSection.png](data:image/png;base64...) |

## [Map Name]\_car.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_car-txt\_8p1\_EN.xml

These files present a list of the acquired points in the map, along with the point index, location information, electrical data, point tag and type details, and the catheter ID. When applicable, details for Wavefront annotation, pattern matching, and LAT Hybrid points are also included.

Table 5: [Map Name]\_car.txt File

| Column | Information |
| --- | --- |
| A | P (for Point) |
| B | Column not in use (for backward compatibility) |
| C | Point Index |
| D | Column not in use (for backward compatibility) |
| E | X (position coordinate) |
| F | Y (position coordinate) |
| G | Z (position coordinate) |
| H | Alpha (angular coordinate of point) |
| I | Beta (angular coordinate of point) |
| J | Gamma (angular coordinate of point) |
| K | Unipolar voltage, in mV |
| L | Bipolar voltage, in mV (Multipolar value, if applicable) |
| M | LAT value, in ms |
| N | Impedance value, in Ohms |
| O | Point Type: Normal = 0, Location Only= 1, Scar = 2, Floating = 3, TE= 4 |
| P | Label ID: without Tag= -1, none = 4, His = 5, Pacing Site = 6, Double Potential = 7, Fragmented Signal = 8, Ablation = 9, Scar = 10, Location Only = 11, End of Sheath = 13, User Defined = 25 |
| Q | Point Label Size = always 1 |
| R | Point Label = always A |
| S | Label Color = always 0 |
| T | Catheter ID (internal identification) |
| U | Column not in use (for backward compatibility) |
| V | When Wavefront Annotation is used, the maximum downslope value of the unipolar signal where mapping annotation was calculated  -10000 if Wavefront was not used, or if the annotation was manually edited |
| W | Pattern Matching Correlation Data: Overall Correlation  -1 if not applicable |
| X | Pattern Matching Correlation Data: Window of Interest From  0 if not applicable |
| Y | Pattern Matching Correlation Data: Window of Interest To  0 if not applicable |
| Z | Maximum microelectrode bipolar value (QDOT MICRO™ Catheter only)  -10000 if not applicable |
| AA | Comma-delimited string of all map Wavefront annotation candidates  -10000 if not applicable |
| AB | Point timestamp (PIU time) |
| AC | X of PVC beat (LAT Hybrid points)  N\A if not applicable |
| AD | Y of PVC beat (LAT Hybrid points)  N\A if not applicable |
| AE | Z of PVC beat (LAT Hybrid points)  N\A if not applicable |
| AF | Hybrid distance (LAT Hybrid points)  N\A if not applicable |
| AG | WOI from (Start of Window of Interest) |
| AH | WOI to (End of Window of Interest) |
| AI | Voltage WOI from |
| AJ | Voltage WOI to |
| AK | Late Annotation amplitude threshold |
| AL | Late Annotation left boundary |
| AM | Is Late Annotation |
| AN | Late Annotation Mapping Sensitivity level |
| AO | Complex Fractionation Score of potential fractionation segment candidate  -10000 if not applicable |
| AP | Complex Duration percent  -10000 if not applicable |
| AQ | Complex Duration in ms  -10000 if not applicable |
| AR | Complex Onset Time (relative to reference annotation)  -10000 if not applicable |
| AS | Touch indication (0=In touch, 1=Not in touch, 2=Unknown, 3=Not supported) |
| AT | Reference annotation time |
| AU | Electrode used for annotation (0=Proximal, 1=Distal, 2=no-LAT) |
| AV | Original LAT for cases where the LAT has changed |
| AW | Smart Index |
| AX | LAT stability value |
| AY | Position stability value |
| AZ | RER indication (0=Not supported, 1=Not in respiration gate, 2=In respiration gate) |
| BA | Bipolar signal dv/dt value of mapping annotation, when Wavefront or Late Annotation annotation is used.  Multipolar signal dv/dt value of mapping annotation, when Multipolar annotation is used.  In other mapping annotation criteria or no LAT points, a value of -10000. |
| BB | PCA coefficients for Multipolar calculation, in a matrix configuration, comma separated.  Neighboring electrodes that were not selected for PCA calculation appear as 0.  [MPA1 MPA2 MPA3  MPA2 MPB2 MPC2  MPC1 MPC2 MPC3] |
| BC | Smart Index map outscoring point index  -10000 if not applicable |
| BD | Channel Number |
| BE | Channel Name |

## [Map Name]\_Points\_Export.xml

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Points-Export\_EN.xml

For each map, these files list each Point Export file in the folder.

![Base-Points-Export-XML-File.png](data:image/png;base64...)

Figure 7: Sample from [Map Name]\_Points\_Export.xml File

## [Map Name]\_P[#]\_Point\_Export.xml

https://bwiildita.sharepoint.com/sites/prod/Topics/Point-Export\_EN.xml

These files contain information about the point, such as time stamp, annotations, voltage, and impedance. It also contains the file names for all other exported files related to the point.

Table 6: [Map Name]\_P[#]\_Point\_Export.xml File

| Element | Description |
| --- | --- |
| Point | Contains the point index and time stamp. |
| Annotations | Contains the start time, reference annotation, and mapping annotation for the point. |
| WOI | Contains the Window of Interest (WOI) for the point (to and from values). |
| Voltages | Lists the voltage information for the point.  If a QDOT MICRO™ Catheter was used, this includes the maximum microelectrode bipolar value (MaxMicroBipolar) and the electrode it came from (MaxMicroBipolarSourceChannelID). If not, MaxMicroBipolar is set to -10000 and MaxMicroBipolarSourceChannelID is 0. |
| Positions | Contains the Connector elements. |
| Connector | Lists the exported files for each catheter that was connected when the point was acquired. |
| Impedances | Contains details about the impedance for the point. |
| ECG | Contains the name of the data file that contains the ECG information. |

## [Map Name]\_ECG\_Export\_[#].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/ECG-Export\_7p5\_EN.xml

These files contain 2.5 seconds of intracardiac and body surface ECG signals for timestamps that contain at least one acquired point. Each column represents approximately 2.5 seconds of one channel that was recorded at the selected point.

When imported to Excel with the *From Text/CSV* option, the following row numbers apply:

* **Row 1**: the version of the export: ECG\_Export\_4.0
* **Row 2**: the value used to convert the raw data to millivolts.

To convert to mV, select the relevant columns and rows and multiply by the gain listed in Row 3. (0.003).

* **Row 3**: column names for the relevant channels (unipolar mapping, bipolar mapping, multipolar mapping, reference) for each electrode with ECG data.

Subsequent rows contain the ECG data.

## [Map Name]\_P[#]\_[Connector]\_Electrode\_Positions.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Electrode-Positions\_EN.xml

These files are generated for each point, for each connected catheter. They present the coordinates of each electrode of the catheter over a 2.5 seconds recording.

Table 7: [Map Name]\_P[#]\_[Connector]\_Electrode\_Positions.txt File

| Column | Information |
| --- | --- |
| Electrode# | Electrode number starting from distal (1) through proximal (for example, 20 in a 20-pole catheter) |
| Time | Time stamp of the data collected. Every number represents time in ms from first sample close to 0 through approximately 2,500 ms |
| X | X (location reference of the electrode in space) |
| Y | Y (location reference of the electrode in space) |
| Z | Z (location reference of the electrode in space) |

## [Map Name]\_P[#]\_[Connector]\_Electrode\_Positions\_OnAnnotation.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/Electrode-Positions\_OnAnnotation\_EN.xml

These files are generated for each point, for each connected catheter. They present the coordinates of each electrode at the reference annotation time.

## [Map Name]\_P[#]\_[Connector]\_Sensor\_Positions.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Sensor-Positions\_EN.xml

These files are generated for each point, for each connected sensor-based catheter. They present the coordinates of the sensor, every 17 ms, over a 2.5 second recording time.

## [Map Name]\_P[#]\_[Connector]\_Sensor\_Positions\_OnAnnotation.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Sensor-Positions-OnAnnotation\_EN.xml

These files are generated for each point, for each connected catheter. They present the coordinates of the sensor at the reference annotation time.

## [Map Name]\_P[#]\_ContactForce.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_ContactForce\_EN.xml

These files contain force information for each point acquired when a force catheter (such as THERMOCOOL SMARTTOUCH™ Catheter) was used in a study. If a force catheter was not used, the file is not created.

Some of the data relates to the reflects the last settings defined in the CARTO SMARTTOUCH™ Preferences prior to exporting the data.

![CFPreferences_CF_7_partial.png](data:image/png;base64...)

Figure 8: Section of Force Preferences

Table 8: [Map Name]\_P[#]\_ContactForce.txt File

| Column | Information |
| --- | --- |
| Rate | Sampling rate for force reading (every 50 ms) |
| Mode | Mode for calculation (Number/Vector Calculation Type)  0: Average; 1: Maximum |
| IntervalGraph | The sampling interval for Graphs Viewer  50 ms to 1000 ms |
| IntervalNonGraph | The sampling interval for Number/Vector display  200 ms to 1000 ms |
| Index | Index Number, from 1 to 200, for force samples  For each point,10 seconds of data is exported (9.5 seconds before the annotation 0.5 seconds after the annotation). Each raw data segment is 50 ms, and each row presents 50 ms of data. |
| Time | Time from reference annotation (2,000 ms), ranging from -7,500 ms to +2,500 ms. |
| Timestamp | PIU Running time. |
| ForceValue | Force, measured in grams.  If the force is less than 5 g, Axial value (Column E) and Lateral value (Column F) are set to 0, and it can be viewed only through the Base Data (Raw Data).  Negative values in this column represent force direction. In the CARTO™ 3 System they are set to absolute values. |
| AxialAngle | Axial Angle, in degrees, representing the vector degree ranging from 0 through 360 degrees.  If the value is negative, add 360 to the value to obtain the true value in degrees. |
| LateralAngle | Lateral Angle Vector, in degrees, ranging from 0 through 180 degrees. If the value is negative, add 180 to obtain the true value in degrees. |
| MetalSeverity | For R & D use only. |
| InAccuracySeverity | For R & D use only. |
| NeedZeroing | Contact Force zeroing status:  0: No need for zeroing; 1: Additional zeroing needed; 2: Needs initial zeroing. |

## [Map Name]\_CartoFinderSite\_[Site #]\_IdxInMap.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/CFSite-IdxInMap-txt\_EN.xml

These files are only created if the CARTOFINDER™ Module option was selected in the Export Study Data dialog box when exporting the data. Each file contains details for a single CARTOFINDER™ site.

Table 9: [Map Name]\_CartoFinderSite\_[Site #]\_IdxInMap.txt File

| Section | Details |
| --- | --- |
| CartoFinder Site information | Presents details for the site |
| Catheter Position | Presents details for each electrode in the site, including channel ID and name, branch, and coordinates |
| Algorithm result | Presents the dominant cycle length and total number of Focal and Rotational events |
| Annotations | Presents the annotation details for each electrode in the site |
| Events | Presents the start and end times for each electrode in the site |
| ECG | Presents the unipolar electrogram data for each electrode in the site |

## RF\_[Map Name]\_[RF#].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_RF-Session\_EN.xml

These files contain information recorded during RF ablation sessions.

If a force catheter was used, the force applied during the ablation session is in a separate file, see ["ContactForceInRF\_[Map Name]\_[RF #].txt"](#target9000001).

Table 10: RF\_[Map Name]\_[RF#].txt File

| Parameter | Meaning |
| --- | --- |
| PiuTimeStamp | PIU running ablation time. |
| Irrigation | Irrigation flow rate.  -1 if there is no flow or the value is not available. |
| Power Mode | RF generator mode:  0=normal; 1=PRA; 2=QMODE+™; 3=Power; 4=Temperature; 5=QMODE™ |
| AblTime[#] | Measured every 100 ms. |
| Power[#] | Power value of the energy delivered, in Watts. |
| Impedance[#] | Impedance value registered |
| DistalTemperature[#] | Distal temperature sensor reading, in °C. |
| ProximalTemperature[#] | Proximal temperature sensor (in NAVISTAR™ DS Catheter for example), in °C. When no proximal sensor is present, the value shown is 0. |

## ContactForceInRF\_[Map Name]\_[RF #].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_ContactForceInRF\_EN.xml

These files contain force information for each RF session when a force catheter (such as THERMOCOOL SMARTTOUCH™ Catheter) was used.

The information is in the same format as ["[Map Name]\_P[#]\_ContactForce.txt"](#target9000002), with the following differences:

* The information is recorded during RF application only, and not related to points
* The time frame of each file represents the length of each RF session
* Column A refers to the time frame represented by the PIU running time (**NOT** indexing, as in ContactForce data files)

## RF\_CARTO\_TO\_ABLATOR\_SESSIONS\_MAPPING.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/RF\_CARTO\_TO\_ABLATOR\_SESSIONS\_MAPPING\_TXT\_EN.xml

The ablation session number in the CARTO™ 3 System generally does not match the session number in the RF generator. This file provides a link between the session numbers.

## TemperaturesInRF\_[Map Name]-[RF #].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/TempsInRF-ReMap\_EN.xml

These files are created if a QDOT MICRO™ Catheter was used during the ablation session.

Table 11: TemperaturesInRF\_[Map Name]-[RF #].txt File

| Column | Information |
| --- | --- |
| TimeStamp | Workstation Timestamp |
| Raw Temperatures | Measured Temperatures |
| Comp Temperatures | Compensation Temperatures (same as Raw Temperatures) |
| IsAblating | Ablating in the TimeStamp (TRUE or FALSE) |
| Alfa | Reverse Calculated Temperature (used for temperature verification) |
| Ablation voltage | Voltage (actual voltage during an ablation) |
| PIU TS | PIU Timestamp (same as TimeStamp) |

## Version.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_Version\_EN.xml

These files contain the specific build and version information about the CARTO™ 3 System installed at the time the Study was exported. Information includes the date and time of the build and the version.

# PASO™ Module Exported Data

In This Chapter

[ConfigurationData.txt 16](#_Toc176706120)

[IS[#].txt 16](#_Toc176706121)

[ISISCorrelations.txt 17](#_Toc176706122)

[PM[#].txt 17](#_Toc176706123)

[PMISCorrelations.txt 18](#_Toc176706124)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-Module\_Export-Data\_EN.xml

The PaSoExport folder and its contents are created if the PASO™ Module option was selected in the Export Study Data dialog box when the data was exported. The information in the PaSoExport folder reflects the last settings defined in the PASO™ Preferences prior to exporting the data.

## ConfigurationData.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-ConfigData\_EN.xml

The Configuration Data file contains the last PASO™ Module preferences set by the user when the study was exported. Information includes pace mapped signal (PM) and induced signal (IS) correlation thresholds and minimum number of leads required for correlation. These files also include the name prefixes defined by the user for both IS and PM.

## IS[#].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-IS\_EN.xml

These files contain information for each IS captured during a PASO™ Module study. The IS number represents the chronological number assigned during the study.

Each file includes header data with general information about the IS, followed by ECG recording values.

Table 12: IS[#].txt File

| Row | Description |
| --- | --- |
| ID | IS number |
| Name | IS name, including prefix and number (e.g., IS1) |
| Timestamp | Year, month, day, and time of capture |
| Current matched IS | The IS number of the IS selected for correlation (either best matched IS or user-selected IS) |
| Best matched IS | The IS number of the best matched IS as correlated by the PASO™ Module |
| Cycle Length | The cycle length at the time of capture |
| Interval Start | PIU timestamp, in ms, marking the start of a 2.5 s interval around the user-defined morphology of interest (MOI) |
| Timestamp Start; Timestamp End | PIU running time, in ms, marking the beginning and end of the IS capture (2.5 s) |
| Interval Start | PIU timestamp, in ms, marking the start of the last 2.5 s of the IS |
| Current WOI | The start and end timestamp for the current MOI, whether defined by the System or the user, and the 2.5 s around it |
| Original WOI | The start and end timestamp for the original MOI selected by the System |
| Reference IS/Non-reference IS | Specifies whether this is a reference IS |
| ECG | ECG recording values for all leads of the IS for 2.5 seconds, one value per 1ms, in mV. |

## ISISCorrelations.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-ISISCorrelations\_EN.xml

These files contain information about the calculated correlation between the IS signals captured during a PASO™ Module study. The PASO™ Module designates a signal as a Reference IS (unique IS) based on the IS-IS correlation value.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  User-defined parameters listed; however, the values are identical to the System parameters, because IS to IS correlation cannot be user defined. |

Table 13: ISISCorrelations.txt File

| Row | Description |
| --- | --- |
| IS# correlated to IS# | Section header showing the primary and secondary IS that are being compared |
| User Defined Average | See System Average |
| User Defined Channel | See System Channel |
| User Defined WOI | See System WOI |
| System Average | 12- lead ECG average correlation |
| System Channel | Correlation of each lead of the two ISs, in this order: I, II, III, aVL, aVR, aVF, V1, V2, V3, V4, V5, V6 |
| System WOI | MOI used when calculating the correlation (start and end based on PIU running time, in ms). The MOI is derived from the primary IS. |

## PM[#].txt

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-PM\_EN.xml

These files contain information for each PM recorded during a PASO™ Module study. The PM number represents the chronological number given by the PASO™ Module.

Each file includes header data with general information about the PM, followed by ECG recording values.

Table 14: PM[#].txt File

| Row | Description |
| --- | --- |
| ID | PM number |
| Name | PM name, including prefix and number (e.g., PM1) |
| Timestamp | Year, month, day, and time of capture |
| Current Matched IS | The IS number of the IS selected for correlation (either best matched IS or user-selected IS) |
| Best Matched IS | The IS number of IS with highest correlation value, as defined by the PASO™ Module |
| Cycle Length | The cycle length at the time of capture |
| Timestamp Start; Timestamp End | PIU running time, in ms, marking the beginning and end of the PM recording (2.5 s) |
| Interval Start | PIU timestamp, in ms, marking the start of the last 2.5 s of the PM |
| Point ID | N/A (not related to map point) |
| ECG | ECG recording values for all leads of the PM for 2.5 seconds, one value per 1ms, in mV. |

## PMISCorrelations.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/PASO-PMISCorrelations\_EN.xml

These files contain information about the calculated correlation between each PM to each reference IS captured during a PASO™ Module study.

Table 15: PMISCorrelations.txt File

| Row | Description |
| --- | --- |
| PM# correlated to IS# | Section header showing the PM and IS that are being compared |
| User Defined Average | 12- lead ECG average correlation  By default, this matches System Average. If PM was edited, it is recalculated based on the PM change over the IS. |
| User Defined Channel | Correlation of each lead of the PM and IS 12-lead ECG, in this order: I, II, III, aVL, aVR, aVF, V1, V2, V3, V4, V5, V6.  By default, this matches System Channels. If PM was edited, it is recalculated based on the PM change over the IS. |
| User Defined WOI | MOI used when calculating the correlation (start and end based on PIU running time, in ms). *This is derived from the IS*. |
| System Average | 12- lead ECG average correlation |
| System Channel | Correlation of each lead of the PM and IS 12-lead ECG, in this order: I, II, III, aVL, aVR, aVF, V1, V2, V3, V4, V5, V6. |
| System WOI | MOI used when calculating the correlation (start and end based on PIU running time, in ms). |

# CARTO VISITAG™ Module Exported Data

In This Chapter

[General CARTO VISITAG™ Module Exported Data 20](#_Toc176706125)

[AblationData.txt 20](#_Toc176706126)

[AblationSites.txt 20](#_Toc176706127)

[AblationSites\_WhiteTags.txt 21](#_Toc176706128)

[ContactForceData.txt 21](#_Toc176706129)

[fpti-formulas.xml 22](#_Toc176706130)

[Grids.txt 22](#_Toc176706131)

[Sites.txt 22](#_Toc176706132)

[Sites\_Validity.txt 23](#_Toc176706133)

[Sites\_WhiteTags.txt 23](#_Toc176706134)

[VisiTagDisplay.txt 23](#_Toc176706135)

[VisiTagPresets.txt 23](#_Toc176706136)

[VisiTagSessions.txt 23](#_Toc176706137)

[VisiTagSettings.txt 24](#_Toc176706138)

[QMODE+™ Ablation Sessions 25](#_Toc176706139)

[AblationData\_QMODE+.txt 25](#_Toc176706140)

[AblationSites\_QMODE+.txt 25](#_Toc176706141)

[AblationSites\_WhiteTags\_QMODE+.txt 26](#_Toc176706142)

[ContactForceData\_QMODE+.txt 26](#_Toc176706143)

[Sites\_QMODE+.txt 26](#_Toc176706144)

[Sites\_WhiteTags\_QMODE+.txt 27](#_Toc176706145)

[Sites\_Validity\_QMODE+.txt 27](#_Toc176706146)

[VisiTagSessions\_QMODE+.txt 27](#_Toc176706147)

[VisiTagSettings\_QMODE+.txt 27](#_Toc176706148)

|  |
| --- |
|  |

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAGModuleData\_EN.xml

The VisiTagExport folder is created if the CARTO VISITAG™ Module option was selected in the Export Study Data dialog box when exporting the data. The information in these files reflects the last settings defined in the VISITAG Preferences when the data was exported. Some of the exported files depend on the catheter that was used.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Within a specific study, all files that include the same reference information, such as Session Number or Site index, can be cross-referenced for data analysis. |

The following files are for R&D use only. They are not described in this document.

* AdjustedPositions.txt
* AdjustedPositions\_QMODE+.txt
* AllPositionInGrids.txt
* EndExperiums.txt
* EndExperiums\_QMODE+.txt
* PositionsData.txt
* PositionsData\_QMODE+.txt
* RawPositions.txt
* RawPositions\_QMODE+.txt
* RespirationIndications.txt
* RespirationIndications\_QMODE+.txt
* SiteLocation.txt

## General CARTO VISITAG™ Module Exported Data

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Specific-Exported-Data-Files\_EN.xml

The information in these files is based on the Stability Algorithm selected, and the last settings defined in the CARTO VISITAG™ Module Preferences dialog box at time of export.

### AblationData.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Ablation-Data\_EN.xml

These files contain information imported to the CARTO™ 3 System from the RF generator during RF applications.

Table 16: AblationData.txt File

| Row | Description |
| --- | --- |
| TimeStamp | PIU running time stamp (sampled every 100 ms) |
| Session | Ablation session number, which correlates to sessions in other files |
| ChannelID | The electrode which delivered RF energy  0 for focal |
| Polarity | Defines if ablation was unipolar (UNI) |
| Impedance | Recorded impedance, in ohms |
| Power | RF power delivered, in Watts |
| DistalTemperature | Distal temperature sensor reading, in °C |
| ProximalTemperature | Proximal temperature sensor, in °C (in NAVISTAR™ DS Catheter for example)  When no proximal temperature sensor is present, the value is 0. |

### AblationSites.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-AblationSites\_EN.xml

These files contain information on the VISITAG™ Sites (called Ablation Sites in the exported data) that were calculated and displayed based on the preferences selected when the data was exported.

Each ablation session may contain more than one VISITAG™ Site. For each site, the file presents the timing of the site initiation, site detection, and site termination. All times are based on PIU run time (in ms).

Table 17: AblationSites.txt File

| Column | Description |
| --- | --- |
| Session | Ablation session number |
| ChannelID | The electrode which delivered RF energy (0 for focal) |
| SiteIndex | Index number of the site. Presents the chronological numbering of each site in a Study. |
| FirstPosTimeStamp | VISITAG™ Site initiation: the time the catheter reached the position |
| FirstPosPassedFilterTimeStamp | VISITAG™ Site detection: the first time that the catheter position was identified as a Site, based on the user-defined preferences |
| LastPosTimeStamp | VISITAG™ Site termination: the last time the catheter was in that position |

### AblationSites\_WhiteTags.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-AblationSites\_WhiteTags\_EN.xml

These files contain data about the formation of sites with white VisiTags that are under the threshold. These tags are formed when using the Stability+ algorithm.

For a description of the display options, see ["AblationSites.txt"](#target9000003).

### ContactForceData.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-ContactForceData\_EN.xml

These files present the force data for each ablation session in the study.

Table 18: ContactForceData.txt File

| Column | Description |
| --- | --- |
| Time | PIU running time, in ms |
| Session | RF session number |
| ChannelID | Identifies the electrode number for which RF was delivered (such as 0 for focal) |
| Force | If the force is less than 5 g, Axial value (Column E) and Lateral value (Column F) are set to 0, and it can be viewed only through the Base Data (Raw Data).  Negative values in this column represent force direction. In the CARTO™ 3 System they are set to absolute values. |
| AxialAngle | Axial Angle, in degrees, representing the vector degree ranging from 0 through 360 degrees. If the value is negative, add 360 to the value to obtain the true value in degrees. |
| LateralAngle | Lateral Angle Vector, in degrees, ranging from 0 through 180 degrees. If the value is negative, add 180 to obtain the true value in degrees. |
| InAccuracySeverity | For R&D use only |
| MetalSeverity | For R&D use only |
| NeedZeroing | Contact Force zeroing status 0: No need for zeroing; 1: Additional zeroing needed; 2: Needs initial zeroing |

### fpti-formulas.xml

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-fpti-formula\_EN.xml

These files contain the values of the Tag Index (FPTI) formula used at the time of data export.

### Grids.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Grids\_EN.xml

These files contain information regarding the Grid Cells that were displayed based on the preferences that were active when the data was exported.

Table 19: Grids.txt File

| Column | Description |
| --- | --- |
| Unique ID | Unique ID given to each Grid Cell |
| X, Y, Z | x, y, z coordinates for each site |
| MaxTime | For R&D use only |
| TotalTime | Accumulated time of all the positions associated with the Grid Cell |
| MaxImpedance | For R&D use only |
| MaxTemperature | For R&D use only |
| MaxPower | For R&D use only |
| MaxAverageForce | For R&D use only |

### Sites.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites\_EN.xml

These files contain information for all sites that were displayed based on the preferences that were active when the data was exported.

This matches the information displayed in the cumulative data window for each selected VISITAG™ Site.

Table 20: Sites.txt File

| Column | Description |
| --- | --- |
| Session | Ablation session number |
| ChannelID | The electrode which delivered RF energy (0 for focal) |
| SiteIndex | Index number of the site: chronological numbering of each site in the study |
| X, Y, Z | x, y, z coordinates for each site |
| DurationTime | Duration of each site, in s |
| AverageForce | Average force in each site, in g |
| MaxTemperature | Maximum temperature in each site, in °C |
| MaxPower | Maximum power in each site, in W |
| BaseImpedance | Initial impedance measured at beginning of each site, in ohms |
| ImpedanceDrop | Maximum impedance drop from base in each site, in ohms |
| FTI | Force Time Integral value |
| RFIndex | Tag Index value, based on the VISITAG™ Preferences that were active when the data was exported |
| TagIndexStatus | Tag Index activation status |

### Sites\_Validity.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites\_Validity\_EN.xml

These files contain validity information for each site created when using the Stability+ algorithm.

The exported data file is empty when the Stability+ algorithm is not selected.

Table 21: Sites\_Validity.txt File

| Column | Description |
| --- | --- |
| Session ID | Ablation session number |
| Channel ID | The electrode which delivered RF energy (0 for focal) |
| Site Index | Index number of the site: chronological numbering of each site in the study |
| IsValid | 0 = Grey tags; 1 = White tags; 2 = Red scale tags |

### Sites\_WhiteTags.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites\_WhiteTags\_EN.xml

These files contain data about the formation of sites with white VisiTags that are under the Minimum Time threshold. These tags are formed when using the Stability+ algorithm.

The exported data file is empty when the Stability+ algorithm is not selected.

For a description of the display options, see ["Sites.txt"](#target9000004).

### VisiTagDisplay.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagDisplay\_EN.xml

These files list the display options that were active on the VISITAG™ Toolbar when the data was exported. The value is 0 if the display option was not active. The value is 1 if the display option was active.

### VisiTagPresets.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagPresets\_EN.xml

These files list all the presets that were defined in the study and includes the configuration of each preset. For a description of the parameters listed for each preset, see ["VisiTagSettings.txt"](#target9000005).

### VisiTagSessions.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagSessions\_EN.xml

These files contain information for all sites that were displayed based on the preferences that were active when the data was exported.

Table 22: VisiTagSessions.txt File

| Column | Description |
| --- | --- |
| SessionID | ID for the ablation session |
| StartTs | Start ablation time |
| EndTs | End ablation time |
| PresetName | Name of the preset used in the ablation session |
| PresetId | Preset ID |
| Comment | Comment, if added by user |
| Region | For R&D use only |

### VisiTagSettings.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagSettings\_EN.xml

These files contain the VISITAG™ Preferences that were active when the data was exported. Tag Index options are only available with VISITAG SURPOINT™ Module functionality.

For QMODE+™ Module settings, see ["VisiTagSettings\_QMODE+.txt"](#target9000006).

Table 23: VisiTagSettings.txt File

| Term | Description |
| --- | --- |
| Algorithm Type | Name of the algorithm type selected.  Compensated when the Stability+ Algorithm is selected.  Gated when the Gated (ACCURESP™) Algorithm is selected. |
| PresetID | ID number of the Preset that was active when the data was exported |
| PresetName | Name of the Preset that was active when the data was exported |
| useRespirationCompensation | Respiration Adjustment check box value  0 if not selected, 1 if selected |
| isLocationStabilityFilterEnabled | Location Stability check box value  0 if not selected, 1 if selected |
| isAvailable | Minimum Time check box value  0 if not selected, 1 if selected |
| locationStabilityThreshold | Maximum Distance Change, in mm.  When Stability+ is selected, Maximum Distance Change is 3 mm. |
| minimalAblationTimeThreshold | Minimum Time, in s |
| isImpedanceDropFilterEnabled | Always 0  Not available in this version. |
| impedanceDropThreshold | Always -1  Not available in this version. |
| IsContactForceFilterEnabled | Force Over Time check box  0 if not selected, 1 if selected |
| contactForcePercentageThreshold | Force Over Time, Time threshold, in % |
| contactForceValueForPercentThreshold | Force Over Time, Minimum Force threshold, in g |
| isFPTIThresholdIndicationEnabled | Tag Index activation  0 if not selected, 1 if selected |
| FPTIMinThreshold | Tag Index: Threshold Low value |
| FPTIMaxThreshold | Tag Index: Threshold High Value |
| TagIndexFormulaGUID | Tag Index: Global Unique Identification |
| isTemperatureFilterEnabled | Always 0  Not available in this version. |
| temperatureThreshold | Always -1  Not available in this version. |
| minimalAblationTimeThreshold\_QMODE+ | Minimum Time, in s is present when Stability+ is selected and a QDOT MICRO™ License is enabled |
| source of RF index | Internal Calculation |

## QMODE+™ Ablation Sessions

https://bwiildita.sharepoint.com/sites/prod/Topics/Data\_Export\_QDOT\_MICRO\_EN.xml

The QMODE+™ data files are created if a QDOT MICRO™ Catheter[[1]](#footnote-1) was connected, a QMODE+™ ablation session was performed during the study, and the CARTO VISITAG™ Module option was selected in the Export Study Data dialog box when the data was exported.

### AblationData\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-AblationData-QMODE\_EN.xml

These files are created for every study that included QMODE+™ ablation sessions. They contain the same information contained in the AblationData.txt files, but for QDOT MICRO™ Catheters when using QMODE+™ ablation mode.

See ["AblationData.txt"](#target9000007).

### AblationSites\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-AblationSites\_QMODE\_EN.xml

These files contain information for all QMODE+™ sites that were created during the study.

Table 24: AblationSites\_QMODE+.txt File

| Column | Description |
| --- | --- |
| Session | QMODE+™ ablation session number |
| ChannelID | The electrode that delivered RF energy (0 for focal) |
| SiteIndex | Index number of the site, in order of site creation |
| FirstPosTimeStamp | Time stamp for start of ablation session |
| FirstPosPassedFilterTimeStamp | Always -1  (No filters are used for QMODE+™ sites) |
| LastPosTimeStamp | Timestamp for end of ablation session |

### AblationSites\_WhiteTags\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-AblationSites\_WhiteTags\_QMODE+v8p2\_EN.xml

These files contain data about the formation of QMODE+™ sites with white VisiTags that are under the QMODE+™ minimum duration threshold. These tags are formed when using the Stability+ algorithm.

For a description of the display options, see ["AblationSites\_WhiteTags.txt"](#target9000008).

### ContactForceData\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/DataExport\_contactForce\_QDOT\_EN.xml

These files contain the same information contained in the ContactForceData.txt files, but for QDOT MICRO™ Catheters when using QMODE+™ ablation mode.

See ["ContactForceData.txt"](#target9000009).

### Sites\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites-QMODE\_EN.xml

These files contain information for all QMODE+™ sites based on the preferences that were active when the data was exported.

Table 25: Sites\_QMODE+.txt File

| Column | Description |
| --- | --- |
| Session | Ablation session number |
| ChannelID | The electrode that delivered RF energy  Electrode numbers start from 0. |
| SiteIndex | Index number of the site, in chronological order |
| X, Y, Z | x, y, z coordinates for each site |
| DurationTime | Total time, in s |
| AverageForce | Average force in each site |
| MaxTemperature | Maximum temperature in each site, in ºC |
| MaxPower | Maximum power in each site, in W |
| BaseImpedance | Initial impedance measured at the beginning of each site, in ohms |
| ImpedanceDrop | Maximum impedance drop in each site, in ohms |
| FTI | Force Time Integral value |
| Resp.Gated | Respiration Gating status  0 if not active, 1 if active |
| AvgForce | Average force in each site |
| Temp.Rise | 95th percentile below the maximum temperature during the ablation session, minus the initial temperature before ablation, in °C |
| Total.E | Total energy, power integral over time |
| Tot.E\_State | Total energy status  0 if it didn't pass user threshold, 1 if it passed |
| IsValid | Power data validity  0 if missing power data for a time window of 350 msec or more, 1 if valid |

### Sites\_WhiteTags\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites\_QMODE+\_WhiteTags\_EN.xml

These files contain information for all QMODE+™ sites based on the preferences that were active when using the Stability+ algorithm.

The exported data file is empty when the Stability+ algorithm is not selected.

These files contain information about the formation of sites with white tags that are under the QMODE+™Minimum Time threshold.

For a description of the display options, see ["Sites\_QMODE+.txt"](#target9000010).

### Sites\_Validity\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-Sites\_Validity\_QMODE+\_v8p2\_EN.xml

These files contain validity information for all QMODE+™ sites that were created during the study when using the Stability+ algorithm.

The exported data file is empty when the Stability+ algorithm is not selected.

For a description of the display options, see ["Sites\_Validity.txt"](#target9000011).

### VisiTagSessions\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagSessions-QMODE\_EN.xml

These files contain the same information contained in the VisiTagSessions.txt data files, but for the QMODE+ Module when using QMODE+™ ablation mode.

See ["VisiTagSessions.txt"](#target9000012) for data file information, definitions and file format.

### VisiTagSettings\_QMODE+.txt

https://bwiildita.sharepoint.com/sites/prod/Topics/VISITAG-VisiTagSettings-QMODE\_EN.xml

These files contain the QMODE+™ Preferences settings that were active when the study was exported. These files are only available when using the Gated Algorithm. When the Stability+ Algorithm is selected, see ["VisiTagSettings.txt"](#target9000013) for applicable information.

![qmode_preferences_v7p3.png](data:image/png;base64...)

Figure 9: QMODE+™ Preferences

Table 26: VisiTagSettings\_QMODE+.txt File

| Term | Description |
| --- | --- |
| PresetID | Preset ID for QMODE+™ ablation sessions (always 1) |
| PresetName | Name of the QMODE+™ Preset (always Preset) |
| useRespirationAdjustmentInGatedStability | Respiration adjustment status, as set in the VISITAG™ Preferences  0=No, 1=Yes |
| QMODE+ ablation parameters indicators enabled | QMODE+™ Session Review Indicator status: 0 if the Color According to check box is not selected; 1 if it is. |
| Total energy indicator threshold | The current value of the Total energy applied threshold.  When the Color According to check box is selected, QMODE+™ site tags are colored red if they meet the threshold, and pink if they do not. |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![](data:image/png;base64...)

1. Where the module is available and installed [↑](#footnote-ref-1)