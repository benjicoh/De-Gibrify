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

[CARTO ELEVATE™ Module Overview 1](#_Toc209354826)

[Enhanced CONFIDENSE™ 2](#_Toc209354827)

[Activating a Smart Index Map 2](#_Toc209354828)

[Smart Index Calculation 4](#_Toc209354829)

[Smart Index Visualization Filter 6](#_Toc209354830)

[Acquiring Points for a Smart Index Map 7](#_Toc209354831)

[Optimizing a Smart Index Map 8](#_Toc209354832)

[Interactions with Other Modules and Features 9](#_Toc209354833)

[Complex Signal Identification 10](#_Toc209354834)

[Algorithm Development 10](#_Toc209354835)

[Acquiring Complex Points 11](#_Toc209354836)

[Determining LAT Values 12](#_Toc209354837)

[Density Filter Behavior 12](#_Toc209354838)

[Viewing Complex Points in the Map 12](#_Toc209354839)

[Complex Points Display Filters 15](#_Toc209354840)

[Minimum Fractionation Score 16](#_Toc209354841)

[Time Frame Within WOI 16](#_Toc209354842)

[Bipolar Amplitude of Complex Signal (mV) 19](#_Toc209354843)

[Minimum Duration 19](#_Toc209354844)

[Recalculating the Fractionation Score 20](#_Toc209354845)

[Selected Point Viewer 20](#_Toc209354846)

[Point List 21](#_Toc209354847)

[Point Tags 22](#_Toc209354848)

[Viewing Ripple Bars on Complex Points 22](#_Toc209354849)

[Copying and Moving Points 23](#_Toc209354850)

[Interactions with Other Modules and Features 24](#_Toc209354851)

[Automatic Pattern Acquisition 25](#_Toc209354852)

[Displaying Automatic Patterns 25](#_Toc209354853)

[Activating Automatic Pattern Acquisition 26](#_Toc209354854)

[Auto Pattern Bank Window 27](#_Toc209354855)

[Pattern Viewer 28](#_Toc209354856)

[APA Menu 30](#_Toc209354857)

[Display Filters 31](#_Toc209354858)

[Settings 32](#_Toc209354859)

[Automatic Patterns Summary 33](#_Toc209354860)

[Histogram 33](#_Toc209354861)

[Cycle Length 34](#_Toc209354862)

[Creating a Map using an Automatic Pattern 35](#_Toc209354863)

[Verification Mode 36](#_Toc209354864)

[Automatic Pattern Acquisition Deactivated 36](#_Toc209354865)

[Interactions with other CARTO™ 3 Modules 36](#_Toc209354866)

[Multipolar Mapping 37](#_Toc209354867)

[Activating Multipolar Mapping 38](#_Toc209354868)

[Viewing Multipolar Maps 39](#_Toc209354869)

[Multipolar Frame Point Filter 39](#_Toc209354870)

[ECG Viewers 40](#_Toc209354871)

[Point List 43](#_Toc209354872)

[Editing Points 43](#_Toc209354873)

[Copying and Moving Points 43](#_Toc209354874)

[Interaction with Other Modules 43](#_Toc209354875)

[Troubleshooting 45](#_Toc209354876)

# CARTO ELEVATE™ Module Overview

https://bwiildita.sharepoint.com/sites/prod/Topics/Advanced\_Mapping\_Module\_Introduction\_v8\_EN.xml

The CARTO ELEVATE™ Module contains the following advanced mapping features:

|  |  |
| --- | --- |
| Enhanced CONFIDENSE™ | Enhanced CONFIDENSE™ Mapping provides a simple way to create optimized maps, ensuring maps are automatically and continuously improved. A Smart Index value is assigned to each potential point during continuous acquisition. If the Smart Index value is above 0.4 and all filter criteria are met, the point is acquired and can be viewed in the Point List whether they contribute to the map or not. As mapping continues points are swapped such that the point with the higher Smart Index value remains. You can project points that are only higher than a specified Smart Index value onto the map coloring by adjusting the Smart Index Visualization filter threshold. |
| Complex Signal Identification | The Complex Signal Identification feature allows for automatic acquisition and tagging of complex signals. Additional filtering tools are provided for viewing the identified complex signals in specific regions of interest. |
| Automatic Pattern Acquisition (APA) | The Automatic Pattern Acquisition (APA) feature provides a burden analysis of activations found on the reference signals, either the body surface (BS) ECG or intracardiac electrograms (IC EGMs), and automatically acquires patterns for either ventricular or atrial mappings. Automatic acquisition is achieved through a clustering mechanism using incoming beats, grouped based on similar morphology, to create patterns of interest. With APA you can quickly create new maps based on selected patterns of interest, as well as verifying ablation success while monitoring for reoccurrence. |
| Multipolar Mapping | The Multipolar Mapping feature provides localized unipolar signals and is designed to reduce far field components that cause inconsistent voltage and LAT measurements from unipolar signals, accentuating the local activation. The Multipolar Mapping algorithm analyzes signals from multiple neighboring electrodes, identifying common far field components and removing them. The annotation is placed on the greatest negative deflection of the multipolar signal within the WOI.  This feature is designed to work only with an OPTRELL™ mapping catheter. |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Images in this document are for illustrative purposes only. |

# Enhanced CONFIDENSE™

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_intro\_v8\_EN.xml

Enhanced CONFIDENSE™ provides a simple way to create optimized maps, ensuring maps are automatically and continuously improved. A Smart Index value is assigned to each potential point during continuous acquisition. If the Smart Index value is above 0.4 and all filter criteria are met, the point is acquired and can be viewed in the Point List whether they contribute to the map or not. As mapping continues points are swapped such that the point with the higher Smart Index value remains. You can project points that are only higher than a specified Smart Index value onto the map coloring by adjusting the Smart Index Visualization filter threshold.

## Activating a Smart Index Map

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_Activating\_v8\_EN.xml

Mapping with Smart Index is initiated using either Map Setup or using a system quick map feature to create a new map.

In the Map Setup screen the following display parameters require specific settings for Smart Index setup.

|  |  |
| --- | --- |
| ![map_setup_rhythm_with_numbers.png](data:image/png;base64...)  Figure 1: Map Setup Window | 1. Map type: FAM 2. LAT Hybrid is not selected 3. Smart Index is selected 4. Select a Rhythm Type is selected |

Table 1: Smart Index Map Setup Requirements

| Display | Description |
| --- | --- |
| Map Type | Select FAM.  The Smart Index option is not available when Point-by-Point is selected. |
| LAT Hybrid | LAT Hybrid maps are not supported. |
| Smart Index | Select to activate a map using Smart Index configuration.  You cannot select this option after acquiring points or contours.  Smart Index is selected by default in the first map in a study when using a default template. The exception to this is when the Atrial Fibrillation default template is used, and Smart Index is not selected by default. |
| Select a Rhythm Type | Smart Index evaluates potential points based on a specific rhythm type.  REP14517 A-12  Select from these rhythm type options:   * Stable Rhythm * Premature Beats * Pacing Rhythm   The rhythm type option selected influences the parameters used in the Smart Index. For rhythm type options Stable Rhythm and Premature Beats, points are not acquired while pacing. For the option Pacing Rhythm points are acquired when pacing is active.  For more information about Pacing Rhythm, refer to the "Continuous Mapping Feature" section of the *CONFIDENSE™ Module User Guide*. |

A Smart Index map can be created using a pattern in the Auto Pattern Bank window and the Pattern Bank window.

To create a new Smart Index map from the Pattern Bank window, click the New Map button. The Smart Index option displays, click the Smart Index button.

![Pattern_bank_new_map.png](data:image/png;base64...)

Figure 2: Creating a Smart Index Map from the Pattern Bank Window

For creating a Smart Index map based on a pattern in the Pattern Bank, refer to the "Creating New Map from Pattern Capture" section of the *CONFIDENSE™ Module User Guide*.

For creating a Smart Index map based on a pattern in the Auto Pattern Bank, see ["Creating a Map using an Automatic Pattern"](#target9000001).

## Smart Index Calculation

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_SmartIndex\_v8\_EN.xml

The Smart Index value is calculated from several parameters, including both user-defined and System-defined acquisition filters. Potential points are evaluated and filtered based on their Smart Index score. The parameters each have a fixed weighting factor between 0 and 5 based on the rhythm option selected. The resulting Smart Index is a number between 0.2 and 1. Potential points with a Smart Index value of less than 0.4 are not acquired.

The Smart Index algorithm automatically applies a weighting factor to each available parameter used to calculate the Smart Index. When a parameter is not active or not available its weighting factor for the Smart Index calculation is 0. When a parameter has a weighting factor of 0 the Smart Index algorithm does not include the parameter in the Smart Index calculation.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Parameters used in the Smart Index calculation are System-defined and are not user-configurable. |

The following parameters contribute to the Smart Index calculation.

Table 2: Smart Index Algorithm Parameter Descriptions

| Parameter | Description |
| --- | --- |
| LAT Stability | When rhythm type Stable Rhythm or Pacing Rhythm is selected, LAT Stability is checking for consistent annotation with the previous beat.  The LAT Stability filter threshold is 6 ms. Points with LAT Stability greater than 6 ms are filtered out and not acquired to the map. Points with LAT Stability of 6 ms or lower are given a score as part of Smart Index, respective to stability value.  When rhythm type Premature Beats is selected in the Map Setup, the weighting factor is 0 and does not affect the Smart Index score.  When no late points are captured, the weighting factor is 0 and does not affect the Smart Index score. |
| Pattern Matching | When the Pattern Matching filter is selected by the user, it is used as a parameter in the Smart Index.  Points with a correlation score lower than the user defined threshold are filtered out. Points with a correlation score above threshold are given a score as part of Smart Index, respective to correlation value and pattern type (BS or IC).  This option is only available when a pattern has been captured and you have activated it. |
| Position Stability | When rhythm type Stable Rhythm or Pacing Rhythm is selected, the position stability is checking for consistent position with the previous beat.  The Position Stability filter threshold is 6 mm. Points with Position Stability greater than 6 mm are filtered out and not acquired to the map. Points with Position Stability of 6 mm or lower are given a score as part of Smart Index, respective to stability value.  When rhythm type Premature Beats is selected in the Map Setup, no Position Stability filter is applied, the weighting factor is 0 and does not affect the Smart Index score. |
| Respiration Gating | When Respiration Gating training is performed, it is used as a parameter in the Smart Index.  As part of Smart Index points are given a score respective to their respiration value, points outside of the End Experium are given a lower score.  When the Respiration Gated filter is selected, points are filtered and are not acquired to the map when outside of the End Experium. |
| Signal Sharpness | When Wavefront or Multipolar are selected as the mapping criterion, the signal's ‑dV/dt at the mapping annotation's position is used as a parameter in the Smart Index.  When Late Annotation is selected as the mapping criterion, points with no Late Annotation found receive a score based on their Wavefront annotation. For points where Late Annotation is found, the weighting factor for the Signal Sharpness parameter is 0.  When the mapping criterion is not set to Wavefront, Late Annotation or Multipolar, the weighting factor is 0 and does not affect the Smart Index score. |
| Tissue Proximity | When the Tissue Proximity filter is not selected (default), the Smart Index algorithm bases the calculation on the tissue proximity indication value. Points with negative proximity indication are given a lower score.  When the Tissue Proximity filter is selected, points with negative tissue proximity indication are filtered and not acquired to the map.  When TPI is either not known or not supported by the catheter, the weighting factor is 0 and does not affect the Smart Index score. |
| Late Annotation | When mapping criterion Late Annotation is selected, late points contribute to the point's Smart Index score.  Late points have a higher score because a weighting factor is applied to the point's Smart Index score.  When no late points are captured, the weighting factor is 0 and does not affect the Smart Index score. |

A Smart Index value is calculated and applied to the potential point.

## Smart Index Visualization Filter

https://bwiildita.sharepoint.com/sites/prod/Topics/Smart\_Index\_Visualization\_Filter\_v8\_EN.xml

When Smart Index is selected in Map Setup the Smart Index Visualization option is available. You can control the points projected onto the map by adjusting the Smart Index visualization threshold slider. The default value is 0.7. When a potential point has a Smart Index value above the user-defined threshold for visualization, the point is projected onto the map's coloring.

A point that does not meet the Smart Index threshold for visualization is set as a floating point in the Point List. As the Smart Index visualization filter threshold is adjusted points are either displayed on the map or are floating, depending on their Smart Index value.

To set the Smart Index filter threshold for visualization, right-click the map and select Smart Index Visualization. The Smart Index Visualization window appears with the filter for the map in the Main Map Viewer. Use the slider to adjust the threshold of the map named in the window. The adjustment is made to all displays of that map.

![SI_viz_setup_box.png](data:image/png;base64...)

Figure 3: Setting a Smart Index Visualization Filter Threshold

The Smart Index Visualization filter threshold from an active Smart Index map will be inherited when creating a map using: New Map, Remap, Map Replay, or Save Map As.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Only one Smart Index Visualization window can be opened at a time. |

## Acquiring Points for a Smart Index Map

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_Acquisition\_Filters\_v8\_EN.xml

System parameters are used automatically to calculate the Smart Index of a point in a Smart Index map. Additional user configurations can be set in the Acquisition Filters tab of the Preferences dialog box.

![Preferences_filters_menu_v8p3.png](data:image/png;base64...)

Figure 4: Acquisition Filters with a Smart Index Map

For details about Acquisition Filters refer to the *CARTO™ 3 System Instructions For Use*.

During Continuous Mapping the Filters Status toolbar gives a visual indication of the current acquisition. When Continuous Mapping is active but points were not acquired recently, click the filter icon to view the current acquisition filters in the Filters Status toolbar. The button turns orange, indicating you are now in edit mode. You can adjust the filters available as needed.

![filter_status_ext_v8p3.png](data:image/png;base64...)

Figure 5: Continuous Mapping Filters for a Smart Index Map

Channels are green when the Smart Index parameters are applied and the minimum system-defined acquisition threshold value of 0.4 for Smart Index is met. Channels are red when the Smart Index acquisition threshold is not met.

## Optimizing a Smart Index Map

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_EnhancingAMap\_v8\_EN.xml

Claim matrix

During mapping with Smart Index, the map is continuously optimized by swapping points, resulting in the point with the higher Smart Index value per volume replacing a point with a lower Smart Index value.

Instead of using the standard Density filter, which blocks acquisition of new points within a defined distance of an existing point, the Smart Index algorithm compares the Smart Index of the potential point to the existing point.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The swapping mechanism applies to points of the same type. For example, a point tagged by the System as a complex point can only be swapped with another Complex point., and a non-Complex point can only be swapped with another non-Complex point. |

When the Smart Index of the potential point is greater than the Smart Index of a current point in the sphere, the potential point is acquired and swapped with the previous point. The previous point becomes a floating point. It does not contribute to the color of the map, but can still be viewed in the Point List. When the continuous acquisition session is stopped, swapped points are permanently deleted from the study.

Point swapping prioritizes points and results in the higher quality point for the new volume being present on the map. This is achieved without manual intervention.

When the Smart Index of the potential point is less than the Smart Index of the current point in the sphere, the potential point is rejected.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * Continuous Mapping must be active for Smart Index enhancement to take place. * You can use the Parallel Mapping feature in a study with a combination of different map types, including Smart Index maps, and maps with CONFIDENSE™Acquisition Filters active. |

You can review points and signals in the Selected Point Viewer and in the Point List. You can change a map by making manual adjustments to add, change, and delete points.

Some points on a Smart Index map are not available for swapping. When points have been manually acquired, tagged, or edited they will remain as points on the map and are considered blocked for swapping.

## Interactions with Other Modules and Features

https://bwiildita.sharepoint.com/sites/prod/Topics/SmartMap\_Interactions\_v8p3\_EN.xml

Interactions with other advanced mapping features.

* When the Acquire Complex Signals filter is selected the Smart Index value is recalculated for previously acquired points in the Point List.

# Complex Signal Identification

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_ComplexSignalIdentification\_v8\_EN.xml

Claim matrix

The Complex Signal Identification feature allows for the automatic acquisition and tagging of complex signals. Additional filtering tools are provided for viewing the identified complex signals in specific regions of interest according to user-configurable criteria.

The feature can be used during a study or applied retrospectively.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The Complex Signal Identification algorithm is designed to support atrial flutter cases. Use of the algorithm was validated only in these conditions. |

## Algorithm Development

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_AlgorithmDevelopment\_v8\_EN.xml

Machine Learning methods were applied for the algorithm development.

For developing and validating the algorithm, a control database was created using input from multiple stable atrial typical and atypical flutter cases. This data was sourced from Medical Centers in Europe and the United States of America. It included data from different catheters, with complex signals, single activations, noisy signals, and so on.

The control database comprised variables representative of patient conditions relevant to accurately identify a complex signal. These variables include, but are not limited to, the following:

* Normal signals comprising of single activations falling within a diversified range of Window of Interest (WOI) and with a diversified range of voltage.
* Multiple activation signals diversified with their duration and their temporal presences within the WOI consistent with their activations beat after beat.
* Noisy signals within multiple activation that are not consistent beat after beat.

The algorithm training and validation data includes typical (8% of points) and atypical (92% of points) flutter arrhythmias.

Each sample was evaluated by three different clinical specialists who tagged the samples as normal, double potential, or fractionated. Samples that were unanimously tagged by all three specialists were included in the control database. In addition, the specialist identified and marked the onset and the offset of each signal.

After the control database was established, part of the data was provided to the machine learning tool, including the atrial ECG signals, cycle length, WOI boundaries, and selected characteristics of the signals. In addition, the results of the specialists' evaluation were provided. By using a logistic regression process, the various characteristics of the signals were evaluated, resulting in the machine output.

That output consisted of a series of weights for these features - the higher the weight, the more the characteristic is correlated to fractionation. After the algorithm's training phase, the weights were locked so no further dynamic learning occurs. The fractionation score is determined by the algorithm with the locked weights.

The remaining control database not used for the machine learning training was used for validation. Part of the validation process output was the determination of the algorithm performance. Analysis and validation data showed that the performance results for the default fractionation score threshold of 7.5 are above 80% for both specificity and sensitivity. Accuracy for duration detections is above 85%.

**Considerations when using the feature:**

REP14517 D-9 and D-10. Both refer to bullet 2 below.

* The algorithm is not sensitive enough to distinguish between double potential signals and fractionated signals.
* The noise level on signals can affect the algorithm performance. Performance is best when the signals are clean.
* Signal artifacts such as ventricular far field deflection may be falsely perceived by the algorithm as components of the local activity and therefore may affect duration calculation accuracy.

## Acquiring Complex Points

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_Acquiring\_Complex\_Points\_v8p3\_EN.xml

When the Acquire Complex Signals filter is active, the algorithm assigns a fractionation score and a duration (onset and offset) for each point candidate. The higher the fractionation score, the more confident the algorithm is that the signal is fractionated. A point candidate will be acquired if its calculated fractionation score is equal to or above 7.5.[[1]](#footnote-1)

As the score drops, the specificity drops but the sensitivity rises. With a higher score, specificity increases but some fractionated points will be missed. This fractionation score represents a trade-off between sensitivity and specificity.

To acquire Complex signals select the Acquire Complex Signals check box in the Complex Points tab of the Preferences dialog box.

![Preferences_complex_acquire_signals_8p3.png](data:image/png;base64...)

Figure 6: Activating Acquire Complex Signals Check Box

The Acquire Complex Signals check box is activated automatically when the following conditions selected in Map Setup are met:

* Smart Index is selected
* Chamber of interest selected is either Left Atrium or Right Atrium
* Rhythm type selected is Stable Rhythm.

If the Map Setup is changed and the three conditions are met, Acquire Complex Signals is automatically activated by default.

If one of the three conditions (above) is not met Acquire Complex Signals is automatically deactivated by default.

You can stop acquiring complex signals by deactivating the Acquire Complex Signals check box.

501

During continuous acquisition, a green dot appears in map's tab in the Filters Status toolbar if a complex signal was identified for any of the bipolar signals.

![Complex_Filters_Status_Toolbar.png](data:image/png;base64...)

Figure 7: Filters Status Toolbar with Complex Point

When Acquire Complex Signals is activated and after a point candidate passes the acquisition fractionation filter, it must also pass all other active acquisition filters set in the Acquisition Filters tab of the Preferences dialog box with the exception of the LAT Stability filter which is ignored at this stage of point acquisition.

For additional information about displaying Complex points on a map, see ["Complex Points Display Filters"](#target9000002).

### Determining LAT Values

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_DeterminingLATValues\_v8\_EN.xml

437

When a point candidate has passed all the filters, the LAT is evaluated.

* If there is no LAT value, the point candidate is acquired as a no-LAT point.
* If a LAT value is found and the LAT Stability filter is not active, this value is used for the point.
* If a LAT value is found and the LAT Stability filter is active, the point must pass the filter for the LAT value to be applied. Otherwise, the point candidate is acquired as a no-LAT point.

### Density Filter Behavior

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_ApplyingDensity\_Filter\_v8\_EN.xml

When a point candidate is evaluated by the Density filter, it is compared to the other points in the defined region. A Complex point candidate will be acquired only when no other Complex point is in the area, defined by the Density filter setting. In addition, a Complex point candidate with a LAT value will be acquired even if there is an existing Complex point with no LAT value in the area.

## Viewing Complex Points in the Map

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_ViewingComplexPointsMap\_v8\_EN.xml

Claim matrix

In the Visualization Setup dialog box, you can select options for viewing points tagged as Complex points (C.Frac). When a map is defined with the Acquire Complex Signals option selected, the default for Complex tag visualization is selected for both On Points and for Projected. In addition to hiding or showing these tags, you can highlight areas with Complex points with a green border.

![CSI_vizualization_setup_H.png](data:image/png;base64...)

Figure 8: Visualization Setup Options for Complex Points

|  |  |
| --- | --- |
| 1. | To open the dialog box, right-click the map and select Visualization Setup. |
| 2. | In the Complex Point Tags group, select whether you want the point tags displayed. Options: On Points, Projected, both, or neither. |
| 3. | To highlight areas with Complex points, in the Highlight Points group select the Complex check box. When Static is selected Complex points that meet the visualization criteria are presented on the map with a highlight around them. Points tagged automatically as C.Frac, and those tagged manually with the Fragmented Signal tag, are highlighted. |

The following images show some combinations of these options.

Table 3: Complex Point Visualization Examples

|  |  |
| --- | --- |
| Projected selected  Static selected | ![Complex_Visualization_1.png](data:image/png;base64...) |
| Projected selected  Static not selected | ![Complex_Visualization_2.png](data:image/png;base64...) |
| Projected not selected  Static selected | ![Complex_Visualization_3.png](data:image/png;base64...) |

## Complex Points Display Filters

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_ComplexPointsDisplayFilters\_v8p3\_EN.xml

232, 270, 391, 393

Claim matrix

The display filters provide a way to distinguish points that were acquired as fractionated which meet additional criteria. You can focus on areas of interest by adjusting these signal characteristic display filter settings.

Display filters for complex points are set in the Complex Points tab of the Preferences dialog box. These preferences are applied per map.

Points that meet all the selected criteria are tagged with a System-defined tag (C.Frac).

![preferences_complex_v8p3.jpg](data:image/jpeg;base64...)

Figure 9: Preferences for Complex Points Settings for Map

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  If you change these values after points were acquired, the changes appear immediately in the map viewers. However, they are applied in the Point List and the Selected Point Viewer only after you click Apply or OK. When you click Apply, the new settings are applied and the Preferences dialog box remains open. When you click OK, the new settings are applied and the Preferences dialog box closes. |

Complex-related parameters and settings are saved to the study template, with the exception of the Time Frame Within WOI parameter.

### Minimum Fractionation Score

https://bwiildita.sharepoint.com/sites/prod/Topics/Complex\_MinFracScore\_v8p3\_EN.xml

The Minimum Fractionation Score filter is always active.

The default value for this filter is 7.5. This means points can be acquired with greater sensitivity, then filtered for specificity.

You can enhance specificity by moving the slider to a higher value. Adjusting the slider to a lower value reduces specificity.

The point's fractionation score must be equal to or higher than the value on the slider to be tagged as complex and to appear in the map viewer.

![complex_preferences_point_minFrac_display_filter_8p3.png](data:image/png;base64...)

Figure 10: Minimum Fractionation Score Display Filter

### Time Frame Within WOI

https://bwiildita.sharepoint.com/sites/prod/Topics/Complex\_TimeFrameWithinWOI\_v8p3\_EN.xml

The Time Frame Within WOI filter is inactive by default. When activated, this filter is used to select a range within the WOI where you expect an overlap of the fractionation duration with this range. The overlap of range could be either in an internal range within the WOI, or as a dual separated range of the WOI providing an overlap in the mid-diastolic parts of the WOI. You can adjust the range using the sliders.

**Time Frame Within WOI: In**

To show all the Complex points that are at least partially within the range (overlapping the orange section), click In.

![Complex_Preferences_TimeFrame_WOI-IN_8p3.png](data:image/png;base64...)

Figure 11: Time Frame Within WOI when In Range

The criteria for inclusion is when one of the following is met:

* At least 75% or 80 ms of the signal's duration overlaps with the time range within the filters
* The onset time is before the left filter and the offset time is after the right filter.

Table 4: Examples of Time Frame Within WOI when In Range

| Signal Details | Signal |
| --- | --- |
| Signal Complex onset is 87 ms.  Signal Complex duration is 75 ms.  More than 75% of this Complex signal's duration is included in the time range between the filters.  The signal meets the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_in_more_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is 87 ms.  Signal Complex duration is 75 ms.  Less than 75% of this Complex signal's duration is included in the time range between the filters.  The signal does not meet the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_in_less_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is -115 ms.  Signal Complex duration is 129 ms.  More than 80 ms of this Complex signal's duration is included in the time range between the filters.  The signal meets the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_in_more_than_80ms.png](data:image/png;base64...) |
| Signal Complex onset is -115 ms.  Signal Complex duration is 129 ms.  Less than 80 ms of this Complex signal's duration is included in the time range between the filters.  The signal does not meet the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_in_less_than_80ms.png](data:image/png;base64...) |

**Time Frame Within WOI: Out**

To show points that are overlapping at least in one side of the dual boundaries of the WOI (orange sections), click Out.

![Complex_Preferences_TimeFrame_WOI-OUT_8p3.png](data:image/png;base64...)

Figure 12: Time Frame Within WOI when the Fractionation Overlaps one of the Dual Boundaries

The criteria for inclusion is when one of the following is met:

* At least 75% of the signal's duration overlaps with the time range between the right filter and the right WOI border
* At least 75% of the signal's duration overlaps with the time range between the left filter and the left WOI border.
* The onset time is up to 5 ms before the right filter. The offset time is after the right WOI border.

Table 5: Examples of Time Frame Within WOI when the Fractionation Overlaps one of the Dual Boundaries

| Signal Details | Signal |
| --- | --- |
| Signal Complex onset is -150 ms.  Signal Complex duration is 50 ms.  More than 75% of this Complex signal's duration overlaps with the time range of one of the filter boundaries.  The signal meets the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_out-left_more_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is -150 ms.  Signal Complex duration is 50 ms.  Less than 75% of this Complex signal's duration overlaps with the time range of one of the filter boundaries.  The signal does not meet the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_out-left_less_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is 88 ms.  Signal Complex duration is 64 ms.  More than 75% of this Complex signal's duration overlaps with the time range of one of the filter boundaries.  The signal meets the Time Frame Within WOI filter criteria for visualization of a complex signal on the map. | ![complex_woi_out-right_more_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is 88 ms.  Signal Complex duration is 64 ms.  Less than 75% of this Complex signal's duration overlaps with the time range of one of the filter boundaries.  The signal does not meet the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_out-right_less_than_75pc.png](data:image/png;base64...) |
| Signal Complex onset is 108 ms.  Signal Complex duration is 63 ms.  Complex onset time is up to 5 ms before the right filter and Complex offset is after the right WOI border.  The signal meets the Time Frame Within WOI filter criteria for visualization of a complex signal on the map. | ![complex_woi_out-upto_5ms.png](data:image/png;base64...) |
| Signal Complex onset is 108 ms.  Signal Complex duration is 63 ms.  Complex onset time is more than 5 ms before the right filter and Complex offset is after the right WOI border.  The signal does not meet the Time Frame Within WOI filter criteria for visualization of a Complex signal on the map. | ![complex_woi_out-more_than_5ms.png](data:image/png;base64...) |

### Bipolar Amplitude of Complex Signal (mV)

https://bwiildita.sharepoint.com/sites/prod/Topics/Complex\_Bipolar\_Amplitude\_of\_Signal\_v8p3\_EN.xml

The Bipolar Amplitude of Complex Signal (mV) filter is active by default. When activated, this filter tags any fractionated points with bipolar amplitude within the specified range (in the slider, displayed orange). The default range is set between 0.05 mV and 0.5 mV. These values are commonly accepted as the most frequently referenced lower and higher values. You can set different filtering thresholds for the bipolar amplitude range used as the focus of acquired fractionated potential points by adjusting the Bipolar Amplitude of Complex Signal (mV) sliders.

![Complex_Preferences_BipolarAmp.png](data:image/png;base64...)

Figure 13: Point with Bipolar Amplitude in Range Filter

### Minimum Duration

https://bwiildita.sharepoint.com/sites/prod/Topics/Complex\_Minimum\_Duration\_v8p3\_EN.xml

The Minimum Duration (ms) filter is active by default with duration (in milliseconds) of the complex signal set to 80 ms.

This filter tags fractionated potential points whose fractionation duration is equal to or higher than the value set in the slider. You can change the focus of fractionated potential points acquired by adjusting the threshold slider.

![Complex_Preferences_MinDuration_8p3.png](data:image/png;base64...)

Figure 14: Minimum Duration Filter

The value can be set in ms or %CL. Click %CL to filter according to the percentage of the duration over the cycle length. The recommended default is 30%.

## Recalculating the Fractionation Score

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_RecalculatingFractionalScore\_v8\_EN.xml

In some cases, the Complex Signal Analysis algorithm recalculates the fractionation score for acquired points.

* If the WOI is changed for all acquired points and the Acquire Complex Signals filter is selected, all points are recalculated.
* If the WOI or reference annotation of a single point is changed and the Acquire Complex Signals filter is selected, that point is recalculated.
* If the WOI or reference annotation of a single point is changed and the Acquire Complex Signals filter is not selected, the point is only recalculated if it already had a fractionation score.

If the WOI is changed in the Study Setup screen or the Annotation Viewer, no recalculation is necessary. The change applies to future points.

## Selected Point Viewer

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_SelectedPointViewer\_v8\_EN.xml

In the Selected Point Viewer, the duration is displayed as length of time (ms) and percentage of the cycle length.

![Complex_Selected_Point_Viewer.png](data:image/png;base64...)

Figure 15: Selected Point Viewer with Duration Displayed

188

The duration of the complex point is highlighted in the background of the Selected Point Viewer.

![Complex_Selected_Point.png](data:image/png;base64...)

Figure 16: Complex Point with Highlighted Background

This highlighting is active by default. To turn it off, click![CSI_hammer_icon.png](data:image/png;base64...) and select Show Complex Duration.

![Complex_Show_Duration_Highlight.png](data:image/png;base64...)

Figure 17: Turn Highlighting Off Using Show Complex Duration

## Point List

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_PointList\_v8\_EN.xml

189

When the Acquire Complex Signals check box is selected, 4 columns are added to the Point List.

* Fractionation Score displays the calculated fractionation score for each point.
* Complex Duration displays the total duration (in ms) of the complex signal.
* Complex %CL displays the duration of the complex signal as a percentage of the cycle length.
* Complex Onset displays the activation time of the complex signal onset relative to the reference annotation.

These columns remain in the Point List if the Acquire Complex Signals check box is cleared. They can be hidden manually by right-clicking on the Point List header and deselecting them from the Item Type list.

![CSI_point_list_complex_H.png](data:image/png;base64...)

Figure 18: Point List with Active Acquire Complex Signals Filter

The Fractionation Score is displayed for every point that was acquired while the Acquire Complex Signals filter was active. The other values are only shown for points tagged as C.Frac (points that pass all the display filters). If the display filters are updated, these columns are refreshed according to the new status.

## Point Tags

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_PointTags\_v8\_EN.xml

345

Claim matrix

If an acquired Complex point meets all the display filters, the C.Frac tag is automatically applied. This point tag can only be applied by the system; you cannot manually apply the tag to a point.

You can change the C.Frac tag applied to a point with another tag type, including removing the tag (set to None). When a System-tagged point is manually re-tagged, all its complex signal values are removed from the Point List except the fractionation score.

If the fractionation score is recalculated, points that were manually re-tagged are not included in the calculation, except for points tagged as None or Scar.

If automatic scar tagging is applied (either during acquisition or retroactively) and a point meets both Scar and Complex criteria, it is tagged as C.Frac, with a type of Scar. In the map, the point looks like a Complex point. For more information refer to the "Tag and Type" section of the *CARTO™ 3 Comprehensive User Guide*.

Points acquired manually during ablation are automatically tagged as Ablation points. Complex signal values are not applied during ablation.

## Viewing Ripple Bars on Complex Points

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_PropagationMap\_v8\_EN.xml

The Propagation map displays Ripple Bars for Complex points, including manually tagged points when the display option Show Ripple Bars on Complex Points in LAT Propagation Map is selected in the Complex Points tab of the Preferences dialog box. The check box is selected as default for all maps in the study. It is a system setting, relating to the study. When you deselect the setting and save the study, the display option saves as deselected for the study.

![Preferences_complex_ripple.jpg](data:image/jpeg;base64...)

Figure 19: Preferences Option to Display Ripple Bars on Complex Points

In the active map select Map > Propagation > LAT and press the Play button to start the propagation playback. The flow can be seen in the Main Map Viewer.

The length of the bar at any given time corresponds to the point's voltage for that time and the user's applied display settings for a Ripple Map, defined in the Ripple Map tab of the Preferences dialog box.

![Complex_Propogation_Map.png](data:image/png;base64...)

Figure 20: Propagation Map with Ripple Bars on Complex Points

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  This feature relies on the Ripple Map license being activated. |

## Copying and Moving Points

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_CopyMove\_Points\_v8\_EN.xml

When copying or moving a point that is not a Complex point (no fractionation score) to a map with Acquire Complex Signals active, the System calculates its fractionation score and evaluates the point to see if it meets the display criteria in the target map. If it does, the C.Frac tag is applied.

When copying or moving a Complex point to a map that does not have Acquire Complex Signals active, the fractionation score is removed, and the point is not tagged as Complex.

When copying or moving a Complex point that is tagged as Scar to a map with Acquire Complex Signals active, the System calculates its fractionation score and evaluates the point to see if it meets the display criteria in the target map. When the display criteria are met, the point is tagged as C.Frac with a type of Scar.

## Interactions with Other Modules and Features

https://bwiildita.sharepoint.com/sites/prod/Topics/AM\_CSI\_Interactions\_v8\_EN.xml

CARTO PRIME™ Module

* When recalculating a map with the Map Replay feature, Complex points can be acquired in a time interval where the feature was not originally active, and vice versa.
* The Acquire Complex Signals state will be inherited when creating a map using Remap or Map Replay. If conditions for automatic activation of the Acquire Complex Signals check box are no longer met, the check box will be deactivated.
* Parallel Mapping: a group can contain parallel maps with and without Complex Signal Acquisition.
* Complex Signal Acquisition is not available for LAT Hybrid maps or for Multipolar maps.

CARTOREPLAY™ Module

* Complex points can be acquired in a time interval where the feature was not active, and vice versa.

Interactions with other advanced mapping features

* When the Acquire Complex Signals filter is selected the Smart Index value is recalculated for previously acquired points in the Point List.

# Automatic Pattern Acquisition

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_intro\_v8\_EN.xml

The Automatic Pattern Acquisition (APA) feature provides a burden analysis of activations found on the reference signals, either the body surface (BS) ECG or intracardiac electrograms (IC EGMs), and automatically acquires patterns for either ventricular or atrial mappings. Automatic acquisition is achieved through a clustering mechanism using incoming beats, grouped based on similar morphology, to create patterns of interest. With APA you can quickly create new maps based on selected patterns of interest, as well as verify ablation success while monitoring for reoccurrence. Activation patterns from the BS ECG signals or from IC EGMs are automatically captured and presented for analysis.

The Auto Pattern Bank window dynamically displays automatic pattern information, based on either user-defined or default options. Automatic patterns are augmented with burden analysis data for visual presentation of the activity of the acquired patterns.

Automatically captured patterns are evaluated and clustered based on the same Pattern Matching correlation algorithm used in Continuous Mapping. They are referred to as Automatic patterns. For details about using the Pattern Matching filter, refer to the "CONFIDENSE™ Module" section of the *CARTO™ 3 System Instructions for Use*.

You can activate APA to collect patterns of interest as soon as the patient is connected to the BS ECG patches, prior to study initialization and prior to catheter insertion. Post-ablation, you can use the Verification mode to compare patterns found both before and after ablation.

## Displaying Automatic Patterns

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Displaying\_Automatic\_Patterns\_v8\_EN.xml

The Auto Pattern Bank window is used for displaying the automatically acquired patterns and selecting the patterns of interest for mapping.

The Auto Pattern Bank window is available after the reference criterion and channels have been selected.

To open the Auto Pattern Bank window, select Map > Auto Pattern Bank or right mouse click on the ![APA_open_button.png](data:image/png;base64...) icon in the main toolbar.

The Auto Pattern Bank window is displayed:

![APA_APBWindow_Menu.png](data:image/png;base64...)

Figure 21: Auto Pattern Bank Window

## Activating Automatic Pattern Acquisition

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Activating\_Automatic\_Pattern\_Acquisition\_v8\_EN.xml

To activate the APA clustering mechanism, click ![APA_off_button.png](data:image/png;base64...) on the main toolbar, or on the dedicated button in the Auto Pattern Bank window ![APA_APB_off_button.png](data:image/png;base64...).

The APA button turns orange, indicating that APA is active. While APA is active, the system automatically clusters all activations found on the selected reference signal (BS or IC) into groups of similar morphology.

While the APA feature is active the button within the Auto Pattern Bank window ![APA_timer_active.png](data:image/png;base64...) is orange. The total time APA has been active and collecting patterns during the study is displayed next to it.

To deactivate APA, click ![APA_on_button.png](data:image/png;base64...).

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  When exiting the study before initialization, data collected will not be backed up and restored. |

To setup a map for use with automatic patterns set reference criterion to Automatic and select Reference Channels in Map Setup.

![APA_Reference_Criteria_CROP.png](data:image/png;base64...)

Figure 22: Map Setup Reference Section

Electrical signals are obtained from a body surface or intracardiac signal. For details refer to the "Map Setup" section of the *CARTO™ 3 Instructions for Use*.

## Auto Pattern Bank Window

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Auto\_Pattern\_Bank\_Window\_v8\_EN.xml

The Auto Pattern Bank window consists of the following:

|  |  |
| --- | --- |
| ![Auto Pattern Bank Window with Numbers.png](data:image/png;base64...)  Figure 23: Auto Pattern Bank Window | 1. APA Menu 2. APA Summary 3. Activate/Deactivate 4. Verification Mode 5. Patterns Display 6. Histogram 7. Cycle Length |

In cases when no automated patterns are present, a screen message displays confirming this.

### Pattern Viewer

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_APB\_Window\_Pattern\_Viewer\_v8\_EN.xml

The Pattern Viewer area of the Auto Pattern Bank window is used to display the automated collected patterns and their burden analysis. The window can display up to 30 automatically captured patterns that meet the current Display Filters and Settings options. Patterns with a beat count of 1 will not be displayed in the window. The Pattern Viewer dynamically updates every second.

The following information is provided per each collected pattern:

|  |  |
| --- | --- |
| ![APA_pattern_template_numbers.png](data:image/png;base64...)  Figure 24: Automatic Pattern Template | 1. Pattern Status 2. Pattern Name 3. Number of pattern occurrences 4. Time lapse from last pattern occurrence 5. Sustained or Single-Beat Patterns 6. POI Duration (mSec) 7. Cycle Length 8. Signals/channels and Highlighted POI |

Table 6: Automatic Pattern Template Description

| Reference | Description |
| --- | --- |
| 1 | The status of a pattern is illustrated using the heart button. There are three status options available:  ![APA_heart_gray.png](data:image/png;base64...) Patterns are created with this default status or may be returned to it when deselected as favorite. These patterns are sorted and displayed in an order using defined filters.  ![APA_heart_reg.png](data:image/png;base64...) Patterns with this status are a favorite. To change a pattern to favorite, click the default heart button. The heart in the button turns orange. A favorite automatic pattern is a priority item in the Display Viewer, such that it shall always appear regardless of the defined Display Filters. A favorite automatic pattern is automatically added to the Pattern Bank.  ![APA_heart_signal.png](data:image/png;base64...) Patterns with this status indicate the automatic pattern is assigned to a map as part of the map's acquisition filtering. Automatic patterns assigned to a map cannot be deselected as a favorite pattern. An active pattern which is shown in the Pattern Viewer is automatically classified as assigned to the map. |
| 2 | This is the name of the automatic pattern. Patterns are numbered sequentially.  To edit an automatic pattern name, double click the pattern name or right-click the pattern and select Rename.  To add a Type to the automatic pattern, right-click the pattern and select Classification.  Classification of a pattern will result in the name of the pattern being updated with the selected arrhythmia unless the pattern's name was edited manually.  A pattern selected as a favorite will be automatically added to the Pattern Bank. The pattern's name will be shown with the following system-generated components:   * A prefix of A- to indicate the pattern was acquired by the automatic algorithm * The selected reference channel type, either BS or IC * The name and sequence of the pattern, for example Pattern 1. The automatic patterns index numbering is not reset when automatic patterns are deleted.   A sample name is A-BS Pattern 1.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  A pattern name is limited to 30 characters. | |
| 3 | The pattern count is the number of times a beat has matched this pattern. |
| 4 | The time displays how long since the pattern was last identified. |
| 5 | This is an indication of the pattern's sustainability. Patterns which appear in a sequence of beats with similar morphology will be indicated as Sustained Patterns. Patterns with a sequence of one activation at a time will be indicated as Single-Beat Patterns. |
| 6 | The POI indicates the width of the activation, which is also highlighted on the signal. |
| 7 | The Cycle Length duration from the shown beat reference annotation to its preceding beat reference annotation, measured in ms. |
| 8 | The signals' plot includes the pattern's ECG/EGM channels, showing 250 mSec before and after the reference annotation.  Left-click and hold on a pattern to scroll the pattern's signals up to 1 second before the reference annotation.  To adjust the gain, double-click on any of the patterns and use mouse wheel scrolling. Double-click will turn the pattern's signals blue.  IC patterns will appear with up to 10 distal channels.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Induced signals are not acquired. | |

For additional options for an active automated pattern, right-click the automatic pattern in the Pattern Viewer:

![APA_pattern_template_menu.png](data:image/png;base64...)

Figure 25: Automatic Pattern Additional Options

* Classification: Right-click to select a rhythm classification, The automatic pattern's name will update to reflect the classification selected. Default filter settings are applied, for additional information refer to the "CONFIDENSE™ Module" section of the *CARTO™ 3 System Instructions For Use*.

Classified patterns become favorites, appearing as a priority in the Pattern Viewer.

* New Map: Creates a new map based on the pattern selected and its classification.
* Rename: Change the name of the pattern.
* Optimize Pattern: For manual optimization of an automatic pattern the pattern's count must be 20 beats or greater. The system generates a new representative pattern for the clustered group of beats, using the last 20 beats acquired to the group. The optimization process automatically selects the beat which is most similar to all others within the group.

### APA Menu

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Menu\_v8\_EN.xml

Select ![APA_menureg_button.png](data:image/png;base64...) to show the APA Menu options. To close the APA Menu select ![APA_APB_menu_button.png](data:image/png;base64...).

Using the APA Menu you can control the display of the collected automatic patterns by selecting Display Filters and Settings, then saving to the study template. User preferences are applied when APA is activated, with the current filters and settings applied reflecting in the Auto Pattern Bank display.

### Display Filters

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Display\_Filters\_v8\_EN.xml

Filters are set in the Display Filters area of the Auto Pattern Bank window and control the Patterns Viewer. The filters control the patterns currently displayed in the Patterns Viewer based on different criteria. The filters affect only the patterns selected for display and not the patterns collected by the algorithm.

![APA_Display_Filters.png](data:image/png;base64...)

Figure 26: APA Menu Display Filters

Table 7: APA Menu Display Filters Descriptions

| Display Filter | Description |
| --- | --- |
| Burden | When selected, the percentage of each pattern occurrence must be equal or above the selected value for inclusion in the display. The minimum value is 0% and the maximum value is 100%. |
| Beat Count | When selected, the number of beats per cluster must be equal to or above the selected value. The minimum value is 2 and the maximum value is 10,000. |
| Last Active | When selected, the last active time in minutes per cluster must be equal to or below the selected value. The minimum number of minutes is 1 and the maximum number of minutes is 500. |
| Single-Beat Patterns | When selected, patterns repeating with a maximum of one consecutive beat with similar morphology, are displayed. |
| Sustained Patterns | When selected, patterns that repeat with a minimum number of consecutive beats with similar morphology as defined by the Sequence minimum are displayed (minimum 2, maximum 30). |

### Settings

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Settings\_v8\_EN.xml

The Settings options manage the order of patterns displayed in the Pattern Viewer with patterns automatically sorted based on the option selected. Additional information can be selected for display in the Pattern Viewer.

![APA_Settings.png](data:image/png;base64...)

Figure 27: APA Menu Settings

Table 8: APA Menu Settings Descriptions

| Settings | Description |
| --- | --- |
| Sort by | To sort the display of patterns in the Pattern Viewer, select from:   * Burden: based on the highest proportion of occurrences of the pattern, displayed in descending order. * First Active: based on the earliest appearance of the pattern. * Last Active: based on the latest appearance of the pattern.   Patterns with status favorite take precedence when patterns are sorted, regardless of option selected. |
| Highlight POI | Select to highlight the POI area to display for patterns in the Pattern Viewer.  ![APA_Pattern_Highlight_POI.png](data:image/png;base64...)  The POI of an automatic pattern can be edited in the Pattern Bank and not in the Auto Pattern Bank window.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  To edit the POI you must first duplicate the automatic pattern in the Pattern Bank. | |
| Delete | Use the ![APA_trash_button.png](data:image/png;base64...) button to delete all automatic patterns from the Auto Pattern Bank. When the delete button is pressed, all patterns are permanently deleted from the Auto Pattern Bank. Patterns that were previously marked as favorite or assigned to a map will be kept in the Pattern Bank (Pattern Matching feature only).  When changing the reference channels (from BS to IC or vice versa), and after patterns have been collected, use the delete button to reset the Auto Pattern Bank and start collecting patterns with the newly selected reference. |

### Automatic Patterns Summary

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Patterns\_Summary\_v8\_EN.xml

The summary line at the top of the Pattern Viewer area displays the number of filtered patterns and the percentage count they represent from the total number of beats. The display changes dynamically as automatic patterns occur, and as Display Filters change. The summary indicates the coverage of the currently defined filters from all collected data, suggesting the number of patterns displayed in relation to the total amount of beats analyzed.

![APA_Patterns_Summary.png](data:image/png;base64...)

Figure 28: Auto Pattern Bank Window Summary of Patterns

### Histogram

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Histogram\_v8\_EN.xml

The histogram bar displays information about each pattern displayed in the Pattern Viewer, updating dynamically every second while APA is active. The bins in the plot represent data captured: the number in the bin represents the percentage of beats accounted for, and the number above the bin represents the count of instances for the pattern. The histogram scale is logarithmic.

During Verification mode, a second bin appears in red, capturing the patterns activity during the Verification mode time only.

![APA_Histogram.png](data:image/png;base64...)

Figure 29: Auto Pattern Bank Histogram Bar

The order of plots matches the sequence of the patterns in the Pattern Viewer, adjusting dynamically as the pattern order refreshes every second.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * When Verification mode is turned on, the data in the first bin of a pattern in the histogram bar is preserved without change. * When Verification mode is turned off, each pattern's count collected during verification in the second bin is added to the associated first bin. |

To select a plot in the histogram to view in the Pattern Viewer section, click a bin in the histogram plot.

### Cycle Length

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Cycle\_Length\_v8\_EN.xml

The Cycle Length graph includes a real time plot of the cycle length values calculated by the reference annotations through time, and is updated every second. The plots on the graph are greyed out for the time periods when the APA algorithm was inactive. When selecting a pattern in the Pattern Viewer or the histogram bar, orange dots appear on the cycle length plot where all the beats associated with the selected pattern are present.

![APA_Cycle_Length.png](data:image/png;base64...)

Figure 30: Auto Pattern Bank Cycle Length Graph and Timeline

| Reference | Description |
| --- | --- |
| 1 | The Timeline button is blue when the Timeline mode is not activated.  ![APA_CL_Timeline.png](data:image/png;base64...)  When the Timeline is enabled, the cycle plot changes to a retrospective view. The button turns orange and an orange vertical guide appears for time selection. Select a point on the plot area, left-click to display the corresponding pattern in the Pattern Viewer and histogram. The orange vertical line is fixed. Points on the cycle length plot with similar cluster classification as the pattern on the selected point turn orange, indicating when the selected morphology appeared over time.  Select a pattern in the Pattern Viewer or histogram, associated beats on the cycle length plot display with an orange dot. The automatic algorithm must be active at the time point selected. The selected pattern must be in the Pattern Viewer.  To synchronize the APA Cycle Length graph's timeline with the Monitor's timeline, click the down arrow to the right of the Timeline button and select Sync with CARTOREPLAY™.  ![APA_CL_Timeline_orange.png](data:image/png;base64...)  The Timeline button turns orange and an orange link displays. Both APA and Monitor timelines are synchronized. Selecting a point on either timeline adjusts the other point simultaneously. |
| 2 | The duration scale of the plot time is configurable by the user via a dedicated drop-down menu, showing values for the last 1, 3, 5, 10 or 30 minutes.  The default plot duration is 5 minutes. |
| 3 | The graph's X axis details time.  The graph's Y axis details the range of beats' cycle length, from 150 to 1500 mSec.  Patterns with a recorded cycle length greater than 2 seconds display with N/A. |

## Creating a Map using an Automatic Pattern

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_CreatingMapAutoPattern\_v8\_EN.xml

An Automatic pattern can be used to create a new map using the AutoMap setup.

To create a new map using an Automatic pattern:

|  |  |
| --- | --- |
| 1. | Open the Auto Pattern Bank window. |
| 2. | Right-click on the pattern template, select New Map.  The Create New Map window displays.  ![Create_new_map_from_APA.png](data:image/png;base64...)  If a classification is not assigned to the pattern, select a classification from the options available.  In cases when the selected pattern is classified as PVC and an NSR pattern is also classified, the system enables the LAT Hybrid selection option. When creating a new LAT Hybrid map the NSR pattern:   * With the highest index is used * Becomes a favorite * Appears as assigned to the map. |
| 3. | Select the map to be a New Map or a Remap, with optional selection of Smart Index, LAT Hybrid and Parallel Mapping features. With LAT Hybrid the NSR pattern with the highest index is used.   |  |  | | --- | --- | | ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Smart Index and LAT Hybrid cannot be selected together. | |
| 4. | Click Create. A new map is created and is the active map. The Automatic Pattern becomes a favorite and is assigned to the new map.  The name of the pattern follows the system naming convention, for more information see ["Pattern Viewer"](#target9000003). |

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE   * A new map may only be created when Continuous Acquisition, FAM, and ablation are not active. * When selecting Parallel Mapping, the newly created map joins the current active parallel group. If an active group does not exist, the new map will be grouped with the current active map and form a new parallel mapping group. |

## Verification Mode

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Verification\_Mode\_v8\_EN.xml

The Verification mode is designed to be used post-ablation to provide comparison information of automatic patterns prior to ablation.

In the Auto Pattern Bank window, select ![apa_verification_button.png](data:image/png;base64...) to activate the Verification mode. If APA is in a deactivated state when the verification button is pressed, APA Is activated automatically.

When the Verification mode is active the button turns orange and a timer displays the total verification time ![apa_verification_timer.png](data:image/png;base64...). The mode remains active when the Auto Pattern Bank window is closed. The pattern count in the header is relative to verification time. Patterns with a count above zero have the pattern name and count turn red.

Automatic patterns active during verification, and with a count greater than 2, always appear in the Pattern Viewer. Inactive patterns are filtered by Display Filters and Settings options.

## Automatic Pattern Acquisition Deactivated

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Automatic\_Pattern\_Acquisition\_Deactivated\_v8\_EN.xml

APA uses the reference channels set in the current active map to acquire automatic patterns and only works when the reference criterion is ARA.

Certain conditions may cause APA to deactivate automatically. When APA is automatically deactivated the APA button displays with a warning symbol ![APA_warning_icon.png](data:image/png;base64...). APA is deactivated automatically if any of the following conditions occur:

* The reference criterion is not Automatic
* The reference channels are changed (after patterns have been collected)
* The reference channels are disconnected (N/C)
* The defined reference criterion is changed (after patterns have been collected)
* During ablation
* The PIU is disconnected.

## Interactions with other CARTO™ 3 Modules

https://bwiildita.sharepoint.com/sites/prod/Topics/APA\_Other\_Modules\_v8\_EN.xml

CARTO PRIME™ Module

* When creating a map from a pattern in the Auto Pattern Bank window, optional selection of Parallel Mapping and LAT Hybrid features may be available.
* When setting up a Smart Index map do not select LAT Hybrid.

PASO™ Module

* Induced signals are not included in the Auto Pattern Bank window.

# Multipolar Mapping

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_Mapping\_v8\_EN.xml

The Multipolar Mapping feature is designed to reduce far field components that cause inconsistent voltage and LAT measurements from unipolar signals, accentuating the local activation.

The Multipolar Mapping algorithm analyzes signals from multiple neighboring electrodes of the OPTRELL™ catheter, identifying common far field components and removing them from the unipolar signal. You can display the Multipolar channels and select them for mapping.

The OPTRELL™ frame electrodes, defined as electrodes from the first and last rows of the catheter, inherently have less immediate neighbors so the capability of far field reduction from these electrodes may be limited. To exclude these points from your map's coloring, see ["Multipolar Frame Point Filter"](#target9000004).

The Multipolar mapping annotation appears on the greatest negative deflection derivative (slope) of the Multipolar signal within the WOI, as long as the absolute deflection is above the system defined threshold of 0.015 mV/ms.

Multipolar Mapping is designed to work only with an OPTRELL™ mapping catheter.

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  You can create a template defining a layout to include an OPTRELL™ catheter and Multipolar mapping criterion. This template can be used prior to the connection of an OPTRELL™ catheter. For details, see the "Creating a Template" section of the *CARTO™ 3 Comprehensive User Guide*. |

## Activating Multipolar Mapping

https://bwiildita.sharepoint.com/sites/prod/Topics/Activating\_Multipolar\_Mapping\_v8\_EN.xml

When an OPTRELL™ mapping catheter is connected and set as the mapping catheter, the Multipolar option is added to the Mapping Criterion menu in the Map Setup screen. Select this option to activate Multipolar Mapping.

![Multipolar_map_setup.png](data:image/png;base64...)

Figure 31: Map Setup for Multipolar Mapping

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  The algorithm's far field estimation is based on signals within the WOI only. Changing the WOI limits may result in a morphology change of the multipolar signal. |

If the mapping catheter is changed before a point is acquired, the mapping criterion automatically changes to Wavefront.

## Viewing Multipolar Maps

https://bwiildita.sharepoint.com/sites/prod/Topics/Viewing\_Multipolar\_Maps\_v8\_EN.xml

REP14517 D-12

The voltage in a Multipolar map has the same voltage scale range as a Bipolar map. When a Multipolar map is displayed the multipolar voltage has the label Bi (MP), indicating the voltage measurement of the multipolar signal.

To display the multipolar voltage map coloring, right-click the map and select Bipolar (Multipolar).

![Multipolar Viewing 2.png](data:image/png;base64...)

Figure 32: Multipolar Voltage Map Coloring

The Color Scale Bar is updated, displaying the label Bi (MP).

![Multipolar_map_color_scale.png](data:image/png;base64...)

Figure 33: Multipolar Map Color Scale Bar

### Multipolar Frame Point Filter

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_frame\_point\_filter\_v8\_EN.xml

Multipolar frame points can be either included or excluded from the map's coloring using a filter in the Point Filter dialog box, opened using the Filtering menu option. The Exclude Multipolar Frame Point filter is available only for Multipolar FAM maps. By default, the filter is not selected.

When Exclude Multipolar frame points is selected, points acquired by the first and last rows of the OPTRELL™ catheter are set as type **Floating** and do not contribute to the map coloring.

When Exclude Multipolar Frame Point is not selected, points acquired by the first and last rows of the OPTRELL™ catheter are set as type **Normal** and contribute to the map coloring.

![Multipolar_frame_point_filter.png](data:image/png;base64...)

Figure 34: Point Filtering for Multipolar Frame Points

|  |  |
| --- | --- |
| ![DxNoteGeneric.png](data:image/png;base64...) | NOTE  Manually edited points are not affected by the Exclude Multipolar frame points filter. |

## ECG Viewers

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_ECG\_Viewers\_v8\_EN.xml

Multipolar signals are not available in the Monitor Pane. The calculated multipolar signals are only available in the Annotation Viewer and Selected Point Viewer. Multipolar signals have a prefix of MP.

![Multipolar_ECG_Viewer_MP_signals.png](data:image/png;base64...)

Figure 35: ECG Viewer with Multipolar Signals

REP14517 D-12

If you double-click a multipolar signal of a mapping channel in the Selected Point Viewer, its corresponding unipolar signals and bipolar signals are displayed (Multipolar view). The bipolar signal displayed has the current unipolar signal as the distal signal. For example, MP F1 shows unipolar F1, and bipolar F1-F2 . When you double-click again, Multipolar view is closed and the Selected Point Viewer returns to the previous signal display.

![Multipolar_view_display.png](data:image/png;base64...)

Figure 36: Multipolar View with Corresponding Signals

The multipolar peak-to-peak voltage value is displayed in the point value header, as Bi MP (mV).

![Multipolar_peak-to-peak.png](data:image/png;base64...)

Figure 37: Multipolar Peak-to-peak Voltage Value

The system does not automatically add reference signals to the display in ECG viewers (to prevent overcrowding of the signal display). You can manually add channels to the display. Multipolar mapping channels are marked with an M icon. Non-mapping multipolar channels can be added to viewers, they are not marked with an M icon.

![Multipolar_SPV_adding_channels.png](data:image/png;base64...)

Figure 38: Adding Channel(s) to a Display

The Point Tool Tip behavior is similar to the Selected Point Viewer, except the multipolar voltage header is Bi (MP).

![Multipolar_point_tool_tip.png](data:image/png;base64...)

Figure 39: Point Tool Tip

The noise level for multipolar signals is controlled by the Bipolar / Multipolar Noise Level setting in the Preferences dialog box. Multipolar signals with an amplitude lower than the threshold are considered no LAT.

![Preferences_wavefront.png](data:image/png;base64...)

Figure 40: Multipolar Noise Level Preference Control

The ECG Filters configuration settings control the multipolar signals display by changing the filters of the unipolar signals. Changes to the default filter settings may affect the morphology and the annotation of the multipolar signal. For details, refer to the "Configure ECG Filters" section of the *CARTO™ 3 Comprehensive User Guide*.

![ECG_filter_with_multipolar.png](data:image/png;base64...)

Figure 41: Filter Configuration for Multipolar Signals

## Point List

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_Point\_List\_v8\_EN.xml

REP14517 D-12

In the Point List, points are listed per electrode prefixed with the Label defined in Catheter Setup and followed by MP-A1, MP-A2, etc. For example, OPT MP-A1. Peak to peak voltage values are displayed in the Bi (MP) column.

![Multipolar Point List.png](data:image/png;base64...)

Figure 42: Multipolar Map Point List per Electrode

## Editing Points

https://bwiildita.sharepoint.com/sites/prod/Topics/Mulitpolar\_Editing\_Points\_v8\_EN.xml

When selecting multiple points with different WOIs, the ECG Viewer displays the WOI of the super-selected point for all Multipolar signals that currently appear in the window. The Multipolar signals of the non-super-selected point are calculated based on the WOI of the super-selected point. Point data remains unaffected and annotations will only change if Apply Voltage WOI of selected point to is selected.

If the WOI is changed for a selected point (in the Selected Point Viewer or Point Tool Tip), the multipolar signal and it's annotation will be recalculated.

If the WOI is changed for all points the multipolar signals and annotations of all the points are recalculated. To change the WOI for all points, select Map > Apply Voltage WOI of selected point to.

To change the voltage WOI of points, select Voltage WOI of all points.

To change the voltage and LAT WOI of points, select Voltage and LAT WOI of all points.

![Multipolar Editing Points.png](data:image/png;base64...)

Figure 43: Editing points in a Multipolar Map

## Copying and Moving Points

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_Copying\_and\_Moving\_Points\_v8\_EN.xml

147329

When points are copied or moved from one Multipolar map to another Multipolar map, the LAT and voltage values are recalculated according to the selected WOI of the destination map.

When points are copied or moved from a non-Multipolar map to a Multipolar map, the LAT and Voltage values of the points are recalculated according to Wavefront criterion.

147239 When points from a map with a different mapping criterion are copied or moved to a Multipolar map, the LAT and Voltage values of the points are recalculated according to Wavefront criterion.

Points cannot be copied or moved from a Multipolar map to another map type.

## Interaction with Other Modules

https://bwiildita.sharepoint.com/sites/prod/Topics/Multipolar\_Interaction\_with\_Other\_Modules\_v8\_EN.xml

Multipolar mapping feature works with standard CARTO™ 3 functionality. Additional key features include:

* Multipolar mapping is supported using Enhanced CONFIDENSE™.
* Retrospective acquisition with Map Replay is supported. If a different mapping catheter was used at some point, Wavefront annotation is applied.
* Multipolar mapping supports the use of LAT Velocity Vectors.
* A Multipolar map can be added to a group for Parallel Mapping, other maps may have a different mapping criterion. If a non-supported mapping catheter is used, Wavefront annotation is applied.
* Multipolar signals calculated in the CARTO™ 3 System are not presented in the Recording System.
* Local Conduction Vectors (LCVs) are supported with the Multipolar mapping feature.
* The CONFIDENSE™LAT Stability filter applies to Multipolar mapping.

The following modules and features are not supported with Multipolar mapping:

* Late Annotation Mapping
* Complex Signal Identification
* CARTO™ CFAE Module
* Multipolar channel data is not sent to the EP recording system.

# Troubleshooting

https://bwiildita.sharepoint.com/sites/prod/Topics/Release\_Notes\_for\_Advanced\_Mapping\_v8\_EN.xml

Table 9: Known Issues

| Issue | Workaround | # |
| --- | --- | --- |
| When adjusting Time Frame Within WOI, Bipolar Amplitude of Complex Signal (mV), and Minimum Duration (ms) sliders when capturing Complex points, a delay may occur. The more Complex points acquired to a map, the longer the delay - up to approximately 10 seconds. No further impact occurs. | Wait until the calculations for a Complex point are complete, the Apply and OK buttons return to gray and you can continue using the CARTO™ 3 System. | 244411 |

|  |  |
| --- | --- |
| ![A picture containing text, clipart  Description automatically generated](data:image/png;base64...) |  |
| **![ec-rep.gif](data:image/png;base64...)** | Biosense Webster  A Division of Johnson & Johnson Medical NV/SA  Leonardo da Vincilaan 15  1831 Diegem  BELGIUM  Tel: +32 (0) 2 746 3401  Fax: +32 (0) 2 746 3403  Call Center: +32 (0) 2 746 3463  Email: techsupport@its.jnj.com |
| ![phone.jpg](data:image/jpeg;base64...)**USA** | Biosense Webster, Inc.  31 Technology Drive, Suite 200  Irvine, CA 92618  USA  Tel: +1 (866) 4SERVCE (toll free in USA)  Tel: +1 (866) 473 7823  Fax: +1 (909) 468 2786  <http://www.biosensewebster.com> |
| ![manufactured_by_tr.png](data:image/png;base64...) |  |
| ![C:\Users\lsageev\AppData\Local\Temp\SNAGHTMLa30e47a.PNG](data:image/png;base64...) |  |

![_TBCO11;B=20;W=176.25pt;H=39.75pt;M=254;S=-1;BS=1;CD=1;CP=1;CPC=0;EM=0;E=0;CPR=0;FM=;WS=3;DPI=-1;DRM=0;MR=0;BBT=0;BBW=-1;SP=0;BWR=0;BWU=0;BG=1;F=Arial,9.00,,,0,0,0,0,,,;CS=0;O=0;QZB=0;QZL=0;QZR=0;QZT=0;QZU=0;R=0;PR=;T=1;TA=0;A=0;TD=0;HRT=;FC=0;BC=16777215;TC=0;OS=;SE=0;LC=;DP=[@dx_partnumber]REV[@dx_revision_major][@dx_revision_minor];D=UG-5407-0182HREV01A](data:None;base64...)

![](data:image/png;base64...)

1. For rationalization about the fractionation score, see "Algorithm Development". [↑](#footnote-ref-1)