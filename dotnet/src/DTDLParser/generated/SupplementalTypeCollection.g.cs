/* This is an auto-generated file.  Do not modify. */

namespace DTDLParser
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Text.Json;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Threading.Tasks;
    using DTDLParser.Models;

    /// <summary>
    /// A collection of DTDL types that are not materialized as C# classes.
    /// </summary>
    internal partial class SupplementalTypeCollection
    {
        static SupplementalTypeCollection()
        {
            EndogenousSupplementalTypes = new Dictionary<Dtmi, DTSupplementalTypeInfo>();

            Dtmi dtdlContextIdV2 = new Dtmi("dtmi:dtdl:context;2");
            Dtmi dtdlContextIdV3 = new Dtmi("dtmi:dtdl:context;3");
            Dtmi dtdlContextIdV4 = new Dtmi("dtmi:dtdl:context;4");
            Dtmi dtdlExtensionAnnotationContextIdV1 = new Dtmi("dtmi:dtdl:extension:annotation;1");
            Dtmi dtdlExtensionAnnotationContextIdV2 = new Dtmi("dtmi:dtdl:extension:annotation;2");
            Dtmi dtdlExtensionHistorizationContextIdV1 = new Dtmi("dtmi:dtdl:extension:historization;1");
            Dtmi dtdlExtensionMqttContextIdV1 = new Dtmi("dtmi:dtdl:extension:mqtt;1");
            Dtmi dtdlExtensionMqttContextIdV2 = new Dtmi("dtmi:dtdl:extension:mqtt;2");
            Dtmi dtdlExtensionMqttContextIdV3 = new Dtmi("dtmi:dtdl:extension:mqtt;3");
            Dtmi dtdlExtensionOverridingContextIdV1 = new Dtmi("dtmi:dtdl:extension:overriding;1");
            Dtmi dtdlExtensionOverridingContextIdV2 = new Dtmi("dtmi:dtdl:extension:overriding;2");
            Dtmi dtdlExtensionQuantitativeTypesContextIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes;1");
            Dtmi dtdlExtensionQuantitativeTypesContextIdV2 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes;2");
            Dtmi dtdlExtensionRequirementContextIdV1 = new Dtmi("dtmi:dtdl:extension:requirement;1");
            Dtmi dtdlLimitsOnvifContextIdV1 = new Dtmi("dtmi:dtdl:limits:onvif;1");
            Dtmi iotcentralContextIdV2 = new Dtmi("dtmi:iotcentral:context;2");

            Dtmi adjunctTypeTypeIdV3 = new Dtmi("dtmi:dtdl:class:AdjunctType;3");
            Dtmi aliasTypeIdV3 = new Dtmi("dtmi:dtdl:class:Alias;3");
            Dtmi latentTypeTypeIdV3 = new Dtmi("dtmi:dtdl:class:LatentType;3");
            Dtmi namedLatentTypeTypeIdV3 = new Dtmi("dtmi:dtdl:class:NamedLatentType;3");
            Dtmi semanticTypeTypeIdV2 = new Dtmi("dtmi:dtdl:class:SemanticType;2");
            Dtmi semanticTypeTypeIdV3 = new Dtmi("dtmi:dtdl:class:SemanticType;3");
            Dtmi semanticUnitTypeIdV2 = new Dtmi("dtmi:dtdl:class:SemanticUnit;2");
            Dtmi semanticUnitTypeIdV3 = new Dtmi("dtmi:dtdl:class:SemanticUnit;3");
            Dtmi unitTypeIdV2 = new Dtmi("dtmi:dtdl:class:Unit;2");
            Dtmi unitTypeIdV3 = new Dtmi("dtmi:dtdl:class:Unit;3");
            Dtmi unitAttributeTypeIdV2 = new Dtmi("dtmi:dtdl:class:UnitAttribute;2");
            Dtmi unitAttributeTypeIdV3 = new Dtmi("dtmi:dtdl:class:UnitAttribute;3");
            Dtmi valueAnnotationTypeIdV1 = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation");
            Dtmi historizedTypeIdV1 = new Dtmi("dtmi:dtdl:extension:historization:v1:Historized");
            Dtmi cacheableTypeIdV1 = new Dtmi("dtmi:dtdl:extension:mqtt:v1:Cacheable");
            Dtmi idempotentTypeIdV1 = new Dtmi("dtmi:dtdl:extension:mqtt:v1:Idempotent");
            Dtmi indexedTypeIdV1 = new Dtmi("dtmi:dtdl:extension:mqtt:v1:Indexed");
            Dtmi mqttTypeIdV1 = new Dtmi("dtmi:dtdl:extension:mqtt:v1:Mqtt");
            Dtmi overrideTypeIdV1 = new Dtmi("dtmi:dtdl:extension:overriding:v1:Override");
            Dtmi accelerationTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Acceleration");
            Dtmi angleTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Angle");
            Dtmi angularAccelerationTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:AngularAcceleration");
            Dtmi angularVelocityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:AngularVelocity");
            Dtmi apparentEnergyTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:ApparentEnergy");
            Dtmi apparentPowerTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:ApparentPower");
            Dtmi areaTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Area");
            Dtmi binaryUnitTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:BinaryUnit");
            Dtmi capacitanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Capacitance");
            Dtmi concentrationTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Concentration");
            Dtmi currentTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Current");
            Dtmi dataRateTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:DataRate");
            Dtmi dataSizeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:DataSize");
            Dtmi decimalUnitTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:DecimalUnit");
            Dtmi densityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Density");
            Dtmi distanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Distance");
            Dtmi electricChargeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:ElectricCharge");
            Dtmi energyTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Energy");
            Dtmi energyRateTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:EnergyRate");
            Dtmi forceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Force");
            Dtmi frequencyTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Frequency");
            Dtmi humidityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Humidity");
            Dtmi illuminanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Illuminance");
            Dtmi inductanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Inductance");
            Dtmi ionizingRadiationDoseTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:IonizingRadiationDose");
            Dtmi irradianceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Irradiance");
            Dtmi latitudeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Latitude");
            Dtmi lengthTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Length");
            Dtmi longitudeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Longitude");
            Dtmi luminanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Luminance");
            Dtmi luminosityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Luminosity");
            Dtmi luminousFluxTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:LuminousFlux");
            Dtmi luminousIntensityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:LuminousIntensity");
            Dtmi magneticFluxTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:MagneticFlux");
            Dtmi magneticInductionTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:MagneticInduction");
            Dtmi massTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Mass");
            Dtmi massFlowRateTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:MassFlowRate");
            Dtmi powerTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Power");
            Dtmi pressureTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Pressure");
            Dtmi quantitativeTypeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:QuantitativeType");
            Dtmi radioactivityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Radioactivity");
            Dtmi ratioUnitTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:RatioUnit");
            Dtmi reactiveEnergyTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:ReactiveEnergy");
            Dtmi reactivePowerTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:ReactivePower");
            Dtmi relativeDensityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:RelativeDensity");
            Dtmi relativeHumidityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:RelativeHumidity");
            Dtmi resistanceTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Resistance");
            Dtmi soundPressureTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:SoundPressure");
            Dtmi symbolicUnitTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:SymbolicUnit");
            Dtmi temperatureTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Temperature");
            Dtmi thrustTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Thrust");
            Dtmi timeSpanTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:TimeSpan");
            Dtmi torqueTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Torque");
            Dtmi unitPrefixTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:UnitPrefix");
            Dtmi velocityTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Velocity");
            Dtmi voltageTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Voltage");
            Dtmi volumeTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:Volume");
            Dtmi volumeFlowRateTypeIdV1 = new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:class:VolumeFlowRate");
            Dtmi accelerationVectorTypeIdV2 = new Dtmi("dtmi:iotcentral:class:AccelerationVector;2");
            Dtmi eventTypeIdV2 = new Dtmi("dtmi:iotcentral:class:Event;2");
            Dtmi locationTypeIdV2 = new Dtmi("dtmi:iotcentral:class:Location;2");
            Dtmi stateTypeIdV2 = new Dtmi("dtmi:iotcentral:class:State;2");
            Dtmi velocityVectorTypeIdV2 = new Dtmi("dtmi:iotcentral:class:VelocityVector;2");
            Dtmi accelerationTypeIdV2 = new Dtmi("dtmi:standard:class:Acceleration;2");
            Dtmi accelerationUnitTypeIdV2 = new Dtmi("dtmi:standard:class:AccelerationUnit;2");
            Dtmi angleTypeIdV2 = new Dtmi("dtmi:standard:class:Angle;2");
            Dtmi angleUnitTypeIdV2 = new Dtmi("dtmi:standard:class:AngleUnit;2");
            Dtmi angularAccelerationTypeIdV2 = new Dtmi("dtmi:standard:class:AngularAcceleration;2");
            Dtmi angularAccelerationUnitTypeIdV2 = new Dtmi("dtmi:standard:class:AngularAccelerationUnit;2");
            Dtmi angularVelocityTypeIdV2 = new Dtmi("dtmi:standard:class:AngularVelocity;2");
            Dtmi angularVelocityUnitTypeIdV2 = new Dtmi("dtmi:standard:class:AngularVelocityUnit;2");
            Dtmi areaTypeIdV2 = new Dtmi("dtmi:standard:class:Area;2");
            Dtmi areaUnitTypeIdV2 = new Dtmi("dtmi:standard:class:AreaUnit;2");
            Dtmi binaryPrefixTypeIdV2 = new Dtmi("dtmi:standard:class:BinaryPrefix;2");
            Dtmi binaryUnitTypeIdV2 = new Dtmi("dtmi:standard:class:BinaryUnit;2");
            Dtmi capacitanceTypeIdV2 = new Dtmi("dtmi:standard:class:Capacitance;2");
            Dtmi capacitanceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:CapacitanceUnit;2");
            Dtmi chargeUnitTypeIdV2 = new Dtmi("dtmi:standard:class:ChargeUnit;2");
            Dtmi currentTypeIdV2 = new Dtmi("dtmi:standard:class:Current;2");
            Dtmi currentUnitTypeIdV2 = new Dtmi("dtmi:standard:class:CurrentUnit;2");
            Dtmi dataRateTypeIdV2 = new Dtmi("dtmi:standard:class:DataRate;2");
            Dtmi dataRateUnitTypeIdV2 = new Dtmi("dtmi:standard:class:DataRateUnit;2");
            Dtmi dataSizeTypeIdV2 = new Dtmi("dtmi:standard:class:DataSize;2");
            Dtmi dataSizeUnitTypeIdV2 = new Dtmi("dtmi:standard:class:DataSizeUnit;2");
            Dtmi decimalPrefixTypeIdV2 = new Dtmi("dtmi:standard:class:DecimalPrefix;2");
            Dtmi decimalUnitTypeIdV2 = new Dtmi("dtmi:standard:class:DecimalUnit;2");
            Dtmi densityTypeIdV2 = new Dtmi("dtmi:standard:class:Density;2");
            Dtmi densityUnitTypeIdV2 = new Dtmi("dtmi:standard:class:DensityUnit;2");
            Dtmi distanceTypeIdV2 = new Dtmi("dtmi:standard:class:Distance;2");
            Dtmi electricChargeTypeIdV2 = new Dtmi("dtmi:standard:class:ElectricCharge;2");
            Dtmi energyTypeIdV2 = new Dtmi("dtmi:standard:class:Energy;2");
            Dtmi energyUnitTypeIdV2 = new Dtmi("dtmi:standard:class:EnergyUnit;2");
            Dtmi forceTypeIdV2 = new Dtmi("dtmi:standard:class:Force;2");
            Dtmi forceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:ForceUnit;2");
            Dtmi frequencyTypeIdV2 = new Dtmi("dtmi:standard:class:Frequency;2");
            Dtmi frequencyUnitTypeIdV2 = new Dtmi("dtmi:standard:class:FrequencyUnit;2");
            Dtmi humidityTypeIdV2 = new Dtmi("dtmi:standard:class:Humidity;2");
            Dtmi illuminanceTypeIdV2 = new Dtmi("dtmi:standard:class:Illuminance;2");
            Dtmi illuminanceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:IlluminanceUnit;2");
            Dtmi inductanceTypeIdV2 = new Dtmi("dtmi:standard:class:Inductance;2");
            Dtmi inductanceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:InductanceUnit;2");
            Dtmi latitudeTypeIdV2 = new Dtmi("dtmi:standard:class:Latitude;2");
            Dtmi lengthTypeIdV2 = new Dtmi("dtmi:standard:class:Length;2");
            Dtmi lengthUnitTypeIdV2 = new Dtmi("dtmi:standard:class:LengthUnit;2");
            Dtmi longitudeTypeIdV2 = new Dtmi("dtmi:standard:class:Longitude;2");
            Dtmi luminanceTypeIdV2 = new Dtmi("dtmi:standard:class:Luminance;2");
            Dtmi luminanceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:LuminanceUnit;2");
            Dtmi luminosityTypeIdV2 = new Dtmi("dtmi:standard:class:Luminosity;2");
            Dtmi luminousFluxTypeIdV2 = new Dtmi("dtmi:standard:class:LuminousFlux;2");
            Dtmi luminousFluxUnitTypeIdV2 = new Dtmi("dtmi:standard:class:LuminousFluxUnit;2");
            Dtmi luminousIntensityTypeIdV2 = new Dtmi("dtmi:standard:class:LuminousIntensity;2");
            Dtmi luminousIntensityUnitTypeIdV2 = new Dtmi("dtmi:standard:class:LuminousIntensityUnit;2");
            Dtmi magneticFluxTypeIdV2 = new Dtmi("dtmi:standard:class:MagneticFlux;2");
            Dtmi magneticFluxUnitTypeIdV2 = new Dtmi("dtmi:standard:class:MagneticFluxUnit;2");
            Dtmi magneticInductionTypeIdV2 = new Dtmi("dtmi:standard:class:MagneticInduction;2");
            Dtmi magneticInductionUnitTypeIdV2 = new Dtmi("dtmi:standard:class:MagneticInductionUnit;2");
            Dtmi massTypeIdV2 = new Dtmi("dtmi:standard:class:Mass;2");
            Dtmi massFlowRateTypeIdV2 = new Dtmi("dtmi:standard:class:MassFlowRate;2");
            Dtmi massFlowRateUnitTypeIdV2 = new Dtmi("dtmi:standard:class:MassFlowRateUnit;2");
            Dtmi massUnitTypeIdV2 = new Dtmi("dtmi:standard:class:MassUnit;2");
            Dtmi powerTypeIdV2 = new Dtmi("dtmi:standard:class:Power;2");
            Dtmi powerUnitTypeIdV2 = new Dtmi("dtmi:standard:class:PowerUnit;2");
            Dtmi pressureTypeIdV2 = new Dtmi("dtmi:standard:class:Pressure;2");
            Dtmi pressureUnitTypeIdV2 = new Dtmi("dtmi:standard:class:PressureUnit;2");
            Dtmi quantitativeTypeTypeIdV2 = new Dtmi("dtmi:standard:class:QuantitativeType;2");
            Dtmi ratioUnitTypeIdV2 = new Dtmi("dtmi:standard:class:RatioUnit;2");
            Dtmi relativeHumidityTypeIdV2 = new Dtmi("dtmi:standard:class:RelativeHumidity;2");
            Dtmi resistanceTypeIdV2 = new Dtmi("dtmi:standard:class:Resistance;2");
            Dtmi resistanceUnitTypeIdV2 = new Dtmi("dtmi:standard:class:ResistanceUnit;2");
            Dtmi soundPressureTypeIdV2 = new Dtmi("dtmi:standard:class:SoundPressure;2");
            Dtmi soundPressureUnitTypeIdV2 = new Dtmi("dtmi:standard:class:SoundPressureUnit;2");
            Dtmi temperatureTypeIdV2 = new Dtmi("dtmi:standard:class:Temperature;2");
            Dtmi temperatureUnitTypeIdV2 = new Dtmi("dtmi:standard:class:TemperatureUnit;2");
            Dtmi thrustTypeIdV2 = new Dtmi("dtmi:standard:class:Thrust;2");
            Dtmi timeSpanTypeIdV2 = new Dtmi("dtmi:standard:class:TimeSpan;2");
            Dtmi timeUnitTypeIdV2 = new Dtmi("dtmi:standard:class:TimeUnit;2");
            Dtmi torqueTypeIdV2 = new Dtmi("dtmi:standard:class:Torque;2");
            Dtmi torqueUnitTypeIdV2 = new Dtmi("dtmi:standard:class:TorqueUnit;2");
            Dtmi unitlessTypeIdV2 = new Dtmi("dtmi:standard:class:Unitless;2");
            Dtmi velocityTypeIdV2 = new Dtmi("dtmi:standard:class:Velocity;2");
            Dtmi velocityUnitTypeIdV2 = new Dtmi("dtmi:standard:class:VelocityUnit;2");
            Dtmi voltageTypeIdV2 = new Dtmi("dtmi:standard:class:Voltage;2");
            Dtmi voltageUnitTypeIdV2 = new Dtmi("dtmi:standard:class:VoltageUnit;2");
            Dtmi volumeTypeIdV2 = new Dtmi("dtmi:standard:class:Volume;2");
            Dtmi volumeFlowRateTypeIdV2 = new Dtmi("dtmi:standard:class:VolumeFlowRate;2");
            Dtmi volumeFlowRateUnitTypeIdV2 = new Dtmi("dtmi:standard:class:VolumeFlowRateUnit;2");
            Dtmi volumeUnitTypeIdV2 = new Dtmi("dtmi:standard:class:VolumeUnit;2");

            DTSupplementalTypeInfo adjunctTypeInfoEV3 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV3, adjunctTypeTypeIdEV3, isAbstract: true, isMergeable: false, null);
            adjunctTypeInfoEV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Command, DTEntityKind.CommandPayload, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute };
            adjunctTypeInfoEV3.AllowedCotypeVersions = new HashSet<int>() { 2, 3 };

            DTSupplementalTypeInfo adjunctTypeInfoEV4 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV4, adjunctTypeTypeIdEV4, isAbstract: true, isMergeable: false, null);
            adjunctTypeInfoEV4.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Byte, DTEntityKind.Bytes, DTEntityKind.Command, DTEntityKind.CommandPayload, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Decimal, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Short, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute, DTEntityKind.UnsignedByte, DTEntityKind.UnsignedInteger, DTEntityKind.UnsignedLong, DTEntityKind.UnsignedShort, DTEntityKind.Uuid };
            adjunctTypeInfoEV4.AllowedCotypeVersions = new HashSet<int>() { 2, 3, 4 };

            DTSupplementalTypeInfo aliasInfoEV3 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV3, aliasTypeIdEV3, isAbstract: false, isMergeable: false, null);
            aliasInfoEV3.AddProperty("dtmi:dtdl:property:aliasFor;3", new Dtmi("dtmi:dtdl:class:Entity;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            aliasInfoEV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Command, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute };
            aliasInfoEV3.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo aliasInfoEV4 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV4, aliasTypeIdEV4, isAbstract: false, isMergeable: false, null);
            aliasInfoEV4.AddProperty("dtmi:dtdl:property:aliasFor;4", new Dtmi("dtmi:dtdl:class:Entity;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            aliasInfoEV4.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Byte, DTEntityKind.Bytes, DTEntityKind.Command, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Decimal, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Short, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute, DTEntityKind.UnsignedByte, DTEntityKind.UnsignedInteger, DTEntityKind.UnsignedLong, DTEntityKind.UnsignedShort, DTEntityKind.Uuid };
            aliasInfoEV4.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo semanticTypeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV2, semanticTypeTypeIdEV2, isAbstract: true, isMergeable: false, null);
            semanticTypeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Telemetry };
            semanticTypeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo semanticTypeInfoEV3 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV3, semanticTypeTypeIdEV3, isAbstract: true, isMergeable: false, null);
            semanticTypeInfoEV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Telemetry };
            semanticTypeInfoEV3.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo semanticTypeInfoEV4 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV4, semanticTypeTypeIdEV4, isAbstract: true, isMergeable: false, null);
            semanticTypeInfoEV4.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandPayload, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Telemetry };
            semanticTypeInfoEV4.AllowedCotypeVersions = new HashSet<int>() { 2, 3, 4 };

            DTSupplementalTypeInfo semanticUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV2, semanticUnitTypeIdEV2, isAbstract: true, isMergeable: false, null);
            semanticUnitInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            semanticUnitInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo semanticUnitInfoEV3 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV3, semanticUnitTypeIdEV3, isAbstract: true, isMergeable: false, null);
            semanticUnitInfoEV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            semanticUnitInfoEV3.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo semanticUnitInfoEV4 = new DTSupplementalTypeInfo(DTExtensionKind.None, dtdlContextIdV4, semanticUnitTypeIdEV4, isAbstract: true, isMergeable: false, null);
            semanticUnitInfoEV4.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            semanticUnitInfoEV4.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo valueAnnotationInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionAnnotationContextIdV1, valueAnnotationTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            valueAnnotationInfoCV1.AddProperty("dtmi:dtdl:extension:annotation:v1:ValueAnnotation:annotates", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            valueAnnotationInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            valueAnnotationInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };
            valueAnnotationInfoCV1.AddSiblingConstraint(new SiblingConstraint() { KeyPropertyName = "name", KeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation:annotates"), RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Property;3"), new Dtmi("dtmi:dtdl:class:Telemetry;3") }, RequiredTypesString = "Property or Telemetry", DisallowedType = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation"), DisallowedTypeName = "ValueAnnotation" });

            DTSupplementalTypeInfo historizedInfoV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionHistorizationContextIdV1, historizedTypeIdV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdV3);
            historizedInfoV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            historizedInfoV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo historizedInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionHistorizationContextIdV2, historizedTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            historizedInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            historizedInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo cacheableInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV1, cacheableTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            cacheableInfoCV1.AddProperty("dtmi:dtdl:extension:mqtt:v1:Cacheable:ttl", new Uri("http://www.w3.org/2001/XMLSchema#duration"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            cacheableInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            cacheableInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };
            cacheableInfoCV1.RequiredCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:mqtt:v1:Idempotent") };

            DTSupplementalTypeInfo idempotentInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV1, idempotentTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            idempotentInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            idempotentInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo indexedInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV1, indexedTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            indexedInfoCV1.AddProperty("dtmi:dtdl:extension:mqtt:v1:Indexed:index", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, 1, null, regex: null, hasUniqueValue: true, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            indexedInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Telemetry };
            indexedInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo mqttInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV1, mqttTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            mqttInfoCV1.AddProperty("dtmi:dtdl:extension:mqtt:v1:Mqtt:commandTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV1.AddProperty("dtmi:dtdl:extension:mqtt:v1:Mqtt:payloadFormat", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV1.AddProperty("dtmi:dtdl:extension:mqtt:v1:Mqtt:telemetryTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Interface };
            mqttInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo cacheableInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV2, cacheableTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            cacheableInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Cacheable:ttl", new Uri("http://www.w3.org/2001/XMLSchema#duration"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            cacheableInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            cacheableInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };
            cacheableInfoCV2.RequiredCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:mqtt:v2:Idempotent") };

            DTSupplementalTypeInfo idempotentInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV2, idempotentTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            idempotentInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            idempotentInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo indexedInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV2, indexedTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            indexedInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Indexed:index", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, 1, null, regex: null, hasUniqueValue: true, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            indexedInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Telemetry };
            indexedInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo mqttInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV2, mqttTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            mqttInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Mqtt:cmdServiceGroupId", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^[!$-*,-.0-z|~]+$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Mqtt:commandTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Mqtt:payloadFormat", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Mqtt:telemetryTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV2.AddProperty("dtmi:dtdl:extension:mqtt:v2:Mqtt:telemServiceGroupId", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^[!$-*,-.0-z|~]+$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Interface };
            mqttInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo transparentInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV2, transparentTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            transparentInfoCV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Object;3"), new Dtmi("dtmi:dtdl:class:Object;4") }, RequiredTypesString = "Object" });
            transparentInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse };
            transparentInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo cacheableInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, cacheableTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            cacheableInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Cacheable:ttl", new Uri("http://www.w3.org/2001/XMLSchema#duration"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            cacheableInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            cacheableInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };
            cacheableInfoCV3.RequiredCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:mqtt:v3:Idempotent") };

            DTSupplementalTypeInfo errorInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, errorTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            errorInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Object };
            errorInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo errorMessageInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, errorMessageTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            errorMessageInfoCV3.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:String;2"), new Dtmi("dtmi:dtdl:class:String;3"), new Dtmi("dtmi:dtdl:class:String;4") }, RequiredTypesString = "String" });
            errorMessageInfoCV3.AddParentConstraint("fields", new Dtmi("dtmi:dtdl:extension:mqtt:v3:Error"), "Error", adjunctTypeIsUnique: true);
            errorMessageInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Field };
            errorMessageInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo errorResultInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, errorResultTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            errorResultInfoCV3.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:extension:mqtt:v3:Error") }, RequiredTypesString = "Error" });
            errorResultInfoCV3.AddParentConstraint("fields", new Dtmi("dtmi:dtdl:extension:mqtt:v3:Result"), "Result", adjunctTypeIsUnique: true);
            errorResultInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Field };
            errorResultInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };
            errorResultInfoCV3.DisallowedCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:requirement:v1:Required") };

            DTSupplementalTypeInfo idempotentInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, idempotentTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            idempotentInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Command };
            idempotentInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo indexedInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, indexedTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            indexedInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Indexed:index", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, 1, null, regex: null, hasUniqueValue: true, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            indexedInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Telemetry };
            indexedInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo mqttInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, mqttTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            mqttInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Mqtt:cmdServiceGroupId", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^[!$-*,-.0-z|~]+$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Mqtt:commandTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Mqtt:payloadFormat", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Mqtt:telemetryTopic", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^(?:(?:[!%-*,-.0-z|~][!$-*,-.0-z|~]*)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+}))(?:\/(?:(?:[!$-*,-.0-z|~]+)|(?:{(?:[A-Za-z]+:)?[A-Za-z]+})))*$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV3.AddProperty("dtmi:dtdl:extension:mqtt:v3:Mqtt:telemServiceGroupId", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, null, null, null, null, regex: new Regex(@"^[!$-*,-.0-z|~]+$"), hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            mqttInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Interface };
            mqttInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo normalResultInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, normalResultTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            normalResultInfoCV3.AddParentConstraint("fields", new Dtmi("dtmi:dtdl:extension:mqtt:v3:Result"), "Result", adjunctTypeIsUnique: true);
            normalResultInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Field };
            normalResultInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };
            normalResultInfoCV3.DisallowedCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:requirement:v1:Required") };

            DTSupplementalTypeInfo resultInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, resultTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            resultInfoCV3.AddPropertyValueConstraint("fields", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:extension:mqtt:v3:NormalResult"), new Dtmi("dtmi:dtdl:extension:mqtt:v3:ErrorResult") }, RequiredTypesString = "NormalResult or ErrorResult" });
            resultInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Object };
            resultInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo transparentInfoCV3 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionMqttContextIdV3, transparentTypeIdCV3, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            transparentInfoCV3.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Object;3"), new Dtmi("dtmi:dtdl:class:Object;4") }, RequiredTypesString = "Object" });
            transparentInfoCV3.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse };
            transparentInfoCV3.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo overrideInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionOverridingContextIdV1, overrideTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            overrideInfoCV1.AddProperty("dtmi:dtdl:extension:overriding:v1:Override:overrides", null, 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            overrideInfoCV1.AddPropertyValueConstraint("schema", new ValueConstraint() { SiblingKeyPropertyName = "name", SiblingKeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation:annotates"), SiblingParentOfPropertyId = new Dtmi("dtmi:dtdl:extension:overriding:v1:Override:overrides") });
            overrideInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property };
            overrideInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };
            overrideInfoCV1.RequiredCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation") };
            overrideInfoCV1.DisallowedCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:initialization:v1:Initialized") };
            overrideInfoCV1.AddSiblingConstraint(new SiblingConstraint() { KeyPropertyName = "name", KeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation:annotates"), UniqueReference = new Dtmi("dtmi:dtdl:extension:overriding:v1:Override:overrides"), SupplementalPropertyPath = new Dtmi("dtmi:dtdl:extension:overriding:v1:Override:overrides") });
            overrideInfoCV1.AddSiblingConstraint(new SiblingConstraint() { KeyPropertyName = "name", KeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v1:ValueAnnotation:annotates"), RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Property;3"), new Dtmi("dtmi:dtdl:class:Telemetry;3") }, RequiredTypesString = "Property or Telemetry" });

            DTSupplementalTypeInfo overrideInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionOverridingContextIdV2, overrideTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            overrideInfoCV2.AddProperty("dtmi:dtdl:extension:overriding:v2:Override:overrides", null, 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            overrideInfoCV2.AddPropertyValueConstraint("schema", new ValueConstraint() { SiblingKeyPropertyName = "name", SiblingKeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v2:ValueAnnotation:annotates"), SiblingParentOfPropertyId = new Dtmi("dtmi:dtdl:extension:overriding:v2:Override:overrides") });
            overrideInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property };
            overrideInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };
            overrideInfoCV2.RequiredCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:annotation:v2:ValueAnnotation") };
            overrideInfoCV2.DisallowedCocotypes = new HashSet<Dtmi>() { new Dtmi("dtmi:dtdl:extension:initialization:v2:Initialized") };
            overrideInfoCV2.AddSiblingConstraint(new SiblingConstraint() { KeyPropertyName = "name", KeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v2:ValueAnnotation:annotates"), UniqueReference = new Dtmi("dtmi:dtdl:extension:overriding:v2:Override:overrides"), SupplementalPropertyPath = new Dtmi("dtmi:dtdl:extension:overriding:v2:Override:overrides") });
            overrideInfoCV2.AddSiblingConstraint(new SiblingConstraint() { KeyPropertyName = "name", KeyrefPropertyId = new Dtmi("dtmi:dtdl:extension:annotation:v2:ValueAnnotation:annotates"), RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Property;3"), new Dtmi("dtmi:dtdl:class:Property;4"), new Dtmi("dtmi:dtdl:class:Telemetry;3"), new Dtmi("dtmi:dtdl:class:Telemetry;4") }, RequiredTypesString = "Property or Telemetry" });

            DTSupplementalTypeInfo accelerationInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, accelerationTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            accelerationInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AccelerationUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            accelerationInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            accelerationInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo angleInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, angleTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            angleInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angleInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angleInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo angularAccelerationInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, angularAccelerationTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            angularAccelerationInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AngularAccelerationUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularAccelerationInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angularAccelerationInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo angularVelocityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, angularVelocityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            angularVelocityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AngularVelocityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularVelocityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angularVelocityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo apparentEnergyInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, apparentEnergyTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            apparentEnergyInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ApparentEnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            apparentEnergyInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            apparentEnergyInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo apparentPowerInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, apparentPowerTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            apparentPowerInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ApparentPowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            apparentPowerInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            apparentPowerInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo areaInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, areaTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            areaInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AreaUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            areaInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            areaInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo binaryUnitInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV1, binaryUnitTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            binaryUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:baseUnit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:prefix", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Command, DTEntityKind.CommandPayload, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute };
            binaryUnitInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 2, 3 };

            DTSupplementalTypeInfo capacitanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, capacitanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            capacitanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:CapacitanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            capacitanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            capacitanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo concentrationInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, concentrationTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            concentrationInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            concentrationInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            concentrationInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo currentInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, currentTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            currentInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:CurrentUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            currentInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            currentInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo dataRateInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, dataRateTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            dataRateInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:DataRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataRateInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            dataRateInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo dataSizeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, dataSizeTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            dataSizeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:DataSizeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataSizeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            dataSizeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo decimalUnitInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV1, decimalUnitTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            decimalUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:baseUnit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:prefix", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            decimalUnitInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo densityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, densityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            densityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:DensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            densityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            densityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo distanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, distanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            distanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:LengthUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            distanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            distanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo electricChargeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, electricChargeTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            electricChargeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ChargeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            electricChargeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            electricChargeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo energyInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, energyTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            energyInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:EnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            energyInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            energyInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo energyRateInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, energyRateTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            energyRateInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            energyRateInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            energyRateInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo forceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, forceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            forceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ForceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            forceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            forceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo frequencyInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, frequencyTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            frequencyInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:FrequencyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            frequencyInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            frequencyInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo humidityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, humidityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            humidityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:DensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            humidityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            humidityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo illuminanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, illuminanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            illuminanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:IlluminanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            illuminanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            illuminanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo inductanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, inductanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            inductanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:InductanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            inductanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            inductanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo ionizingRadiationDoseInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, ionizingRadiationDoseTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            ionizingRadiationDoseInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:IonizingRadiationDoseUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ionizingRadiationDoseInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            ionizingRadiationDoseInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo irradianceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, irradianceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            irradianceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:IrradianceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            irradianceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            irradianceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo latitudeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, latitudeTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            latitudeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            latitudeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            latitudeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo lengthInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, lengthTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            lengthInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:LengthUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            lengthInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            lengthInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo longitudeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, longitudeTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            longitudeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            longitudeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            longitudeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo luminanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, luminanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            luminanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:LuminanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo luminosityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, luminosityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            luminosityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminosityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminosityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo luminousFluxInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, luminousFluxTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            luminousFluxInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:LuminousFluxUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousFluxInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousFluxInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo luminousIntensityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, luminousIntensityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            luminousIntensityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:LuminousIntensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousIntensityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousIntensityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo magneticFluxInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, magneticFluxTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            magneticFluxInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:MagneticFluxUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticFluxInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticFluxInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo magneticInductionInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, magneticInductionTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            magneticInductionInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:MagneticInductionUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticInductionInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticInductionInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo massInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, massTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            massInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:MassUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            massInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo massFlowRateInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, massFlowRateTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            massFlowRateInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:MassFlowRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massFlowRateInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            massFlowRateInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo powerInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, powerTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            powerInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            powerInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            powerInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo pressureInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, pressureTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            pressureInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:PressureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            pressureInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            pressureInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo quantitativeTypeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, quantitativeTypeTypeIdCV1, isAbstract: true, isMergeable: false, semanticTypeTypeIdEV3);
            quantitativeTypeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            quantitativeTypeInfoCV1.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:NumericSchema;3") }, RequiredTypesString = "NumericSchema" });
            quantitativeTypeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            quantitativeTypeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo radioactivityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, radioactivityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            radioactivityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:RadioactivityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            radioactivityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            radioactivityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo ratioUnitInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV1, ratioUnitTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            ratioUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:bottomUnit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:topUnit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            ratioUnitInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo reactiveEnergyInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, reactiveEnergyTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            reactiveEnergyInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ReactiveEnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            reactiveEnergyInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            reactiveEnergyInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo reactivePowerInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, reactivePowerTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            reactivePowerInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ReactivePowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            reactivePowerInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            reactivePowerInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo relativeDensityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, relativeDensityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            relativeDensityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            relativeDensityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            relativeDensityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo relativeHumidityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, relativeHumidityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            relativeHumidityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            relativeHumidityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            relativeHumidityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo resistanceInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, resistanceTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            resistanceInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ResistanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            resistanceInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            resistanceInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo soundPressureInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, soundPressureTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            soundPressureInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:SoundPressureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            soundPressureInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            soundPressureInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo symbolicUnitInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV1, symbolicUnitTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            symbolicUnitInfoCV1.AddProperty("dtmi:dtdl:property:symbol;3", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            symbolicUnitInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            symbolicUnitInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo temperatureInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, temperatureTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            temperatureInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:TemperatureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            temperatureInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            temperatureInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo thrustInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, thrustTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            thrustInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:ForceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            thrustInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            thrustInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo timeSpanInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, timeSpanTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            timeSpanInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:TimeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            timeSpanInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            timeSpanInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo torqueInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, torqueTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            torqueInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:TorqueUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            torqueInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            torqueInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo unitPrefixInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV1, unitPrefixTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV3);
            unitPrefixInfoCV1.AddProperty("dtmi:dtdl:property:exponent;3", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            unitPrefixInfoCV1.AddProperty("dtmi:dtdl:property:symbol;3", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            unitPrefixInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            unitPrefixInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo velocityInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, velocityTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            velocityInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:VelocityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            velocityInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            velocityInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo voltageInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, voltageTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            voltageInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:VoltageUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            voltageInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            voltageInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo volumeInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, volumeTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            volumeInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:VolumeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo volumeFlowRateInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV1, volumeFlowRateTypeIdCV1, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV1);
            volumeFlowRateInfoCV1.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v1:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;3"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v1:enum:VolumeFlowRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeFlowRateInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeFlowRateInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3 };

            DTSupplementalTypeInfo accelerationInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, accelerationTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            accelerationInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AccelerationUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            accelerationInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            accelerationInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo angleInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, angleTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            angleInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angleInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angleInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo angularAccelerationInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, angularAccelerationTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            angularAccelerationInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AngularAccelerationUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularAccelerationInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angularAccelerationInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo angularVelocityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, angularVelocityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            angularVelocityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AngularVelocityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularVelocityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            angularVelocityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo apparentEnergyInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, apparentEnergyTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            apparentEnergyInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ApparentEnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            apparentEnergyInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            apparentEnergyInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo apparentPowerInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, apparentPowerTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            apparentPowerInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ApparentPowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            apparentPowerInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            apparentPowerInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo areaInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, areaTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            areaInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AreaUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            areaInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            areaInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo binaryUnitInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV2, binaryUnitTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            binaryUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:baseUnit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:prefix", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Array, DTEntityKind.Boolean, DTEntityKind.Byte, DTEntityKind.Bytes, DTEntityKind.Command, DTEntityKind.CommandPayload, DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.CommandType, DTEntityKind.Component, DTEntityKind.Date, DTEntityKind.DateTime, DTEntityKind.Decimal, DTEntityKind.Double, DTEntityKind.Duration, DTEntityKind.Enum, DTEntityKind.EnumValue, DTEntityKind.Field, DTEntityKind.Float, DTEntityKind.Integer, DTEntityKind.Interface, DTEntityKind.LatentType, DTEntityKind.Long, DTEntityKind.Map, DTEntityKind.MapKey, DTEntityKind.MapValue, DTEntityKind.NamedLatentType, DTEntityKind.Object, DTEntityKind.Property, DTEntityKind.Relationship, DTEntityKind.Short, DTEntityKind.String, DTEntityKind.Telemetry, DTEntityKind.Time, DTEntityKind.Unit, DTEntityKind.UnitAttribute, DTEntityKind.UnsignedByte, DTEntityKind.UnsignedInteger, DTEntityKind.UnsignedLong, DTEntityKind.UnsignedShort, DTEntityKind.Uuid };
            binaryUnitInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 2, 3, 4 };

            DTSupplementalTypeInfo capacitanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, capacitanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            capacitanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:CapacitanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            capacitanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            capacitanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo concentrationInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, concentrationTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            concentrationInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            concentrationInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            concentrationInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo currentInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, currentTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            currentInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:CurrentUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            currentInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            currentInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo dataRateInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, dataRateTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            dataRateInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:DataRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataRateInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            dataRateInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo dataSizeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, dataSizeTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            dataSizeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:DataSizeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataSizeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            dataSizeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo decimalUnitInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV2, decimalUnitTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            decimalUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:baseUnit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:prefix", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            decimalUnitInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo densityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, densityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            densityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:DensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            densityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            densityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo distanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, distanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            distanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:LengthUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            distanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            distanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo electricChargeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, electricChargeTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            electricChargeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ChargeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            electricChargeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            electricChargeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo energyInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, energyTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            energyInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:EnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            energyInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            energyInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo energyRateInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, energyRateTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            energyRateInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            energyRateInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            energyRateInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo forceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, forceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            forceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ForceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            forceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            forceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo frequencyInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, frequencyTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            frequencyInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:FrequencyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            frequencyInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            frequencyInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo humidityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, humidityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            humidityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:DensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            humidityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            humidityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo illuminanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, illuminanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            illuminanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:IlluminanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            illuminanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            illuminanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo inductanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, inductanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            inductanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:InductanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            inductanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            inductanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo ionizingRadiationDoseInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, ionizingRadiationDoseTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            ionizingRadiationDoseInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:IonizingRadiationDoseUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ionizingRadiationDoseInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            ionizingRadiationDoseInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo irradianceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, irradianceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            irradianceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:IrradianceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            irradianceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            irradianceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo latitudeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, latitudeTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            latitudeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            latitudeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            latitudeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo lengthInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, lengthTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            lengthInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:LengthUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            lengthInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            lengthInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo longitudeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, longitudeTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            longitudeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:AngleUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            longitudeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            longitudeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo luminanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, luminanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            luminanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:LuminanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo luminosityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, luminosityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            luminosityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminosityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminosityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo luminousFluxInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, luminousFluxTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            luminousFluxInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:LuminousFluxUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousFluxInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousFluxInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo luminousIntensityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, luminousIntensityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            luminousIntensityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:LuminousIntensityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousIntensityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousIntensityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo magneticFluxInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, magneticFluxTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            magneticFluxInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:MagneticFluxUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticFluxInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticFluxInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo magneticInductionInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, magneticInductionTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            magneticInductionInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:MagneticInductionUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticInductionInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticInductionInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo massInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, massTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            massInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:MassUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            massInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo massFlowRateInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, massFlowRateTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            massFlowRateInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:MassFlowRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massFlowRateInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            massFlowRateInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo powerInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, powerTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            powerInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:PowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            powerInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            powerInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo pressureInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, pressureTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            pressureInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:PressureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            pressureInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            pressureInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo quantitativeTypeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, quantitativeTypeTypeIdCV2, isAbstract: true, isMergeable: false, semanticTypeTypeIdEV4);
            quantitativeTypeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            quantitativeTypeInfoCV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:NumericSchema;4") }, RequiredTypesString = "NumericSchema" });
            quantitativeTypeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            quantitativeTypeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo radioactivityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, radioactivityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            radioactivityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:RadioactivityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            radioactivityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            radioactivityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo ratioUnitInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV2, ratioUnitTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            ratioUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:bottomUnit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:topUnit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            ratioUnitInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo reactiveEnergyInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, reactiveEnergyTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            reactiveEnergyInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ReactiveEnergyUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            reactiveEnergyInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            reactiveEnergyInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo reactivePowerInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, reactivePowerTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            reactivePowerInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ReactivePowerUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            reactivePowerInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            reactivePowerInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo relativeDensityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, relativeDensityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            relativeDensityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            relativeDensityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            relativeDensityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo relativeHumidityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, relativeHumidityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            relativeHumidityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:Unitless"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            relativeHumidityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            relativeHumidityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo resistanceInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, resistanceTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            resistanceInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ResistanceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            resistanceInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            resistanceInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo soundPressureInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, soundPressureTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            soundPressureInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:SoundPressureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            soundPressureInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            soundPressureInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo symbolicUnitInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV2, symbolicUnitTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            symbolicUnitInfoCV2.AddProperty("dtmi:dtdl:property:symbol;4", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            symbolicUnitInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            symbolicUnitInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo temperatureInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, temperatureTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            temperatureInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:TemperatureUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            temperatureInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            temperatureInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo thrustInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, thrustTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            thrustInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:ForceUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            thrustInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            thrustInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo timeSpanInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, timeSpanTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            timeSpanInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:TimeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            timeSpanInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            timeSpanInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo torqueInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, torqueTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            torqueInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:TorqueUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            torqueInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            torqueInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo unitPrefixInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionQuantitativeTypesContextIdV2, unitPrefixTypeIdCV2, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            unitPrefixInfoCV2.AddProperty("dtmi:dtdl:property:exponent;4", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            unitPrefixInfoCV2.AddProperty("dtmi:dtdl:property:symbol;4", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            unitPrefixInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.EnumValue };
            unitPrefixInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo velocityInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, velocityTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            velocityInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:VelocityUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            velocityInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            velocityInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo voltageInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, voltageTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            voltageInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:VoltageUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            voltageInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            voltageInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo volumeInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, volumeTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            volumeInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:VolumeUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo volumeFlowRateInfoCV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlExtensionQuantitativeTypesContextIdV2, volumeFlowRateTypeIdCV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdCV2);
            volumeFlowRateInfoCV2.AddProperty("dtmi:dtdl:extension:quantitativeTypes:v2:property:unit", new Dtmi("dtmi:dtdl:class:EnumValue;4"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: new Dtmi("dtmi:dtdl:extension:quantitativeTypes:v2:enum:VolumeFlowRateUnit"), instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeFlowRateInfoCV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.CommandRequest, DTEntityKind.CommandResponse, DTEntityKind.Field, DTEntityKind.MapValue, DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeFlowRateInfoCV2.AllowedCotypeVersions = new HashSet<int>() { 4 };

            DTSupplementalTypeInfo requiredInfoCV1 = new DTSupplementalTypeInfo(DTExtensionKind.AdjunctType, dtdlExtensionRequirementContextIdV1, requiredTypeIdCV1, isAbstract: false, isMergeable: false, adjunctTypeTypeIdEV4);
            requiredInfoCV1.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Field };
            requiredInfoCV1.AllowedCotypeVersions = new HashSet<int>() { 3, 4 };

            DTSupplementalTypeInfo accelerationVectorInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, iotcentralContextIdV2, accelerationVectorTypeIdEV2, isAbstract: false, isMergeable: false, semanticTypeTypeIdEV2);
            accelerationVectorInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AccelerationUnit;2"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            accelerationVectorInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredValues = new List<Dtmi>() { new Dtmi("dtmi:iotcentral:schema:vector;2") }, RequiredValuesString = "vector" });
            accelerationVectorInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            accelerationVectorInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo eventInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, iotcentralContextIdV2, eventTypeIdEV2, isAbstract: false, isMergeable: false, semanticTypeTypeIdEV2);
            eventInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:NumericSchema;2"), new Dtmi("dtmi:dtdl:class:String;2") }, RequiredTypesString = "NumericSchema or String" });
            eventInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            eventInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo locationInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, iotcentralContextIdV2, locationTypeIdEV2, isAbstract: false, isMergeable: false, semanticTypeTypeIdEV2);
            locationInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredValues = new List<Dtmi>() { new Dtmi("dtmi:standard:schema:geospatial:point;2"), new Dtmi("dtmi:standard:schema:geospatial:multiPoint;2"), new Dtmi("dtmi:standard:schema:geospatial:lineString;2"), new Dtmi("dtmi:standard:schema:geospatial:multiLineString;2"), new Dtmi("dtmi:standard:schema:geospatial:polygon;2"), new Dtmi("dtmi:standard:schema:geospatial:multiPolygon;2"), new Dtmi("dtmi:iotcentral:schema:geopoint;2") }, RequiredValuesString = "point or multiPoint or lineString or multiLineString or polygon or multiPolygon or geopoint" });
            locationInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            locationInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo stateInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, iotcentralContextIdV2, stateTypeIdEV2, isAbstract: false, isMergeable: false, semanticTypeTypeIdEV2);
            stateInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:Enum;2") }, RequiredTypesString = "Enum" });
            stateInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            stateInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo velocityVectorInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, iotcentralContextIdV2, velocityVectorTypeIdEV2, isAbstract: false, isMergeable: false, semanticTypeTypeIdEV2);
            velocityVectorInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:VelocityUnit;2"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            velocityVectorInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredValues = new List<Dtmi>() { new Dtmi("dtmi:iotcentral:schema:vector;2") }, RequiredValuesString = "vector" });
            velocityVectorInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            velocityVectorInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo accelerationInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, accelerationTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            accelerationInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AccelerationUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            accelerationInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            accelerationInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo accelerationUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, accelerationUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo angleInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, angleTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            angleInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AngleUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angleInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            angleInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo angleUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, angleUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo angularAccelerationInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, angularAccelerationTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            angularAccelerationInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AngularAccelerationUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularAccelerationInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            angularAccelerationInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo angularAccelerationUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, angularAccelerationUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo angularVelocityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, angularVelocityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            angularVelocityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AngularVelocityUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            angularVelocityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            angularVelocityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo angularVelocityUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, angularVelocityUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo areaInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, areaTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            areaInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AreaUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            areaInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            areaInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo areaUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, areaUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo binaryPrefixInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.UnitAttribute, dtdlContextIdV2, binaryPrefixTypeIdEV2, isAbstract: false, isMergeable: false, unitAttributeTypeIdEV2);
            binaryPrefixInfoEV2.AddProperty("dtmi:dtdl:property:exponent;2", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryPrefixInfoEV2.AddProperty("dtmi:dtdl:property:symbol;2", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);

            DTSupplementalTypeInfo binaryUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticUnit, dtdlContextIdV2, binaryUnitTypeIdEV2, isAbstract: false, isMergeable: false, semanticUnitTypeIdEV2);
            binaryUnitInfoEV2.AddProperty("dtmi:dtdl:property:baseUnit;2", new Dtmi("dtmi:dtdl:class:Unit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoEV2.AddProperty("dtmi:dtdl:property:prefix;2", new Dtmi("dtmi:standard:class:BinaryPrefix;2"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            binaryUnitInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            binaryUnitInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo capacitanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, capacitanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            capacitanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:CapacitanceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            capacitanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            capacitanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo capacitanceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, capacitanceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo chargeUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, chargeUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo currentInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, currentTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            currentInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:CurrentUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            currentInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            currentInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo currentUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, currentUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo dataRateInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, dataRateTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            dataRateInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:DataRateUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataRateInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            dataRateInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo dataRateUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, dataRateUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo dataSizeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, dataSizeTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            dataSizeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:DataSizeUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            dataSizeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            dataSizeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo dataSizeUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, dataSizeUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo decimalPrefixInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.UnitAttribute, dtdlContextIdV2, decimalPrefixTypeIdEV2, isAbstract: false, isMergeable: false, unitAttributeTypeIdEV2);
            decimalPrefixInfoEV2.AddProperty("dtmi:dtdl:property:exponent;2", new Uri("http://www.w3.org/2001/XMLSchema#integer"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalPrefixInfoEV2.AddProperty("dtmi:dtdl:property:symbol;2", new Uri("http://www.w3.org/2001/XMLSchema#string"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);

            DTSupplementalTypeInfo decimalUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticUnit, dtdlContextIdV2, decimalUnitTypeIdEV2, isAbstract: false, isMergeable: false, semanticUnitTypeIdEV2);
            decimalUnitInfoEV2.AddProperty("dtmi:dtdl:property:baseUnit;2", new Dtmi("dtmi:dtdl:class:Unit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoEV2.AddProperty("dtmi:dtdl:property:prefix;2", new Dtmi("dtmi:standard:class:DecimalPrefix;2"), 1, null, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: true, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            decimalUnitInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            decimalUnitInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo densityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, densityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            densityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:DensityUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            densityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            densityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo densityUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, densityUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo distanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, distanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            distanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:LengthUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            distanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            distanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo electricChargeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, electricChargeTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            electricChargeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:ChargeUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            electricChargeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            electricChargeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo energyInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, energyTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            energyInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:EnergyUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            energyInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            energyInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo energyUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, energyUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo forceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, forceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            forceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:ForceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            forceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            forceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo forceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, forceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo frequencyInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, frequencyTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            frequencyInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:FrequencyUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            frequencyInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            frequencyInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo frequencyUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, frequencyUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo humidityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, humidityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            humidityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:DensityUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            humidityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            humidityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo illuminanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, illuminanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            illuminanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:IlluminanceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            illuminanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            illuminanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo illuminanceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, illuminanceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo inductanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, inductanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            inductanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:InductanceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            inductanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            inductanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo inductanceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, inductanceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo latitudeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, latitudeTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            latitudeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AngleUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            latitudeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            latitudeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo lengthInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, lengthTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            lengthInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:LengthUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            lengthInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            lengthInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo lengthUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, lengthUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo longitudeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, longitudeTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            longitudeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:AngleUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            longitudeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            longitudeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo luminanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, luminanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            luminanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:LuminanceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            luminanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo luminanceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, luminanceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo luminosityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, luminosityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            luminosityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:PowerUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminosityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            luminosityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo luminousFluxInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, luminousFluxTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            luminousFluxInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:LuminousFluxUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousFluxInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousFluxInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo luminousFluxUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, luminousFluxUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo luminousIntensityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, luminousIntensityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            luminousIntensityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:LuminousIntensityUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            luminousIntensityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            luminousIntensityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo luminousIntensityUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, luminousIntensityUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo magneticFluxInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, magneticFluxTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            magneticFluxInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:MagneticFluxUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticFluxInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticFluxInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo magneticFluxUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, magneticFluxUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo magneticInductionInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, magneticInductionTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            magneticInductionInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:MagneticInductionUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            magneticInductionInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            magneticInductionInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo magneticInductionUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, magneticInductionUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo massInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, massTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            massInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:MassUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            massInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo massFlowRateInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, massFlowRateTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            massFlowRateInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:MassFlowRateUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            massFlowRateInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            massFlowRateInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo massFlowRateUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, massFlowRateUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo massUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, massUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo powerInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, powerTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            powerInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:PowerUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            powerInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            powerInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo powerUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, powerUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo pressureInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, pressureTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            pressureInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:PressureUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            pressureInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            pressureInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo pressureUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, pressureUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo quantitativeTypeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, quantitativeTypeTypeIdEV2, isAbstract: true, isMergeable: false, semanticTypeTypeIdEV2);
            quantitativeTypeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:dtdl:class:Unit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            quantitativeTypeInfoEV2.AddPropertyValueConstraint("schema", new ValueConstraint() { RequiredTypes = new List<Dtmi>() { new Dtmi("dtmi:dtdl:class:NumericSchema;2") }, RequiredTypesString = "NumericSchema" });
            quantitativeTypeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            quantitativeTypeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo ratioUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticUnit, dtdlContextIdV2, ratioUnitTypeIdEV2, isAbstract: false, isMergeable: false, semanticUnitTypeIdEV2);
            ratioUnitInfoEV2.AddProperty("dtmi:dtdl:property:bottomUnit;2", new Dtmi("dtmi:dtdl:class:Unit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoEV2.AddProperty("dtmi:dtdl:property:topUnit;2", new Dtmi("dtmi:dtdl:class:Unit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            ratioUnitInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Unit };
            ratioUnitInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo relativeHumidityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, relativeHumidityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            relativeHumidityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:Unitless;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            relativeHumidityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            relativeHumidityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo resistanceInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, resistanceTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            resistanceInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:ResistanceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            resistanceInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            resistanceInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo resistanceUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, resistanceUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo soundPressureInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, soundPressureTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            soundPressureInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:SoundPressureUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            soundPressureInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            soundPressureInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo soundPressureUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, soundPressureUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo temperatureInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, temperatureTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            temperatureInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:TemperatureUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            temperatureInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            temperatureInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo temperatureUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, temperatureUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo thrustInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, thrustTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            thrustInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:ForceUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            thrustInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            thrustInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo timeSpanInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, timeSpanTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            timeSpanInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:TimeUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            timeSpanInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            timeSpanInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo timeUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, timeUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo torqueInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, torqueTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            torqueInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:TorqueUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            torqueInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            torqueInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo torqueUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, torqueUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo unitlessInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, unitlessTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo velocityInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, velocityTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            velocityInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:VelocityUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            velocityInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            velocityInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo velocityUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, velocityUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo voltageInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, voltageTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            voltageInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:VoltageUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            voltageInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            voltageInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo voltageUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, voltageUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo volumeInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, volumeTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            volumeInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:VolumeUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo volumeFlowRateInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.SemanticType, dtdlContextIdV2, volumeFlowRateTypeIdEV2, isAbstract: false, isMergeable: false, quantitativeTypeTypeIdEV2);
            volumeFlowRateInfoEV2.AddProperty("dtmi:dtdl:property:unit;2", new Dtmi("dtmi:standard:class:VolumeFlowRateUnit;2"), 1, 1, null, null, null, regex: null, hasUniqueValue: false, isPlural: false, isOptional: false, defaultLanguage: null, dtmiSeg: null, dictionaryKey: null, idRequired: false, typeRequired: true, childOf: null, instanceProperty: null, requiredValues: null, requiredValuesString: null, requiredLiteral: null);
            volumeFlowRateInfoEV2.AllowedCotypeKinds = new HashSet<DTEntityKind>() { DTEntityKind.Property, DTEntityKind.Telemetry };
            volumeFlowRateInfoEV2.AllowedCotypeVersions = new HashSet<int>() { 2 };

            DTSupplementalTypeInfo volumeFlowRateUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, volumeFlowRateUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            DTSupplementalTypeInfo volumeUnitInfoEV2 = new DTSupplementalTypeInfo(DTExtensionKind.Unit, dtdlContextIdV2, volumeUnitTypeIdEV2, isAbstract: false, isMergeable: false, unitTypeIdEV2);

            EndogenousSupplementalTypes[adjunctTypeTypeIdV3] = adjunctTypeInfoV3;
            EndogenousSupplementalTypes[aliasTypeIdV3] = aliasInfoV3;
            EndogenousSupplementalTypes[semanticTypeTypeIdV2] = semanticTypeInfoV2;
            EndogenousSupplementalTypes[semanticTypeTypeIdV3] = semanticTypeInfoV3;
            EndogenousSupplementalTypes[semanticUnitTypeIdV2] = semanticUnitInfoV2;
            EndogenousSupplementalTypes[semanticUnitTypeIdV3] = semanticUnitInfoV3;
            EndogenousSupplementalTypes[valueAnnotationTypeIdV1] = valueAnnotationInfoV1;
            EndogenousSupplementalTypes[historizedTypeIdV1] = historizedInfoV1;
            EndogenousSupplementalTypes[cacheableTypeIdV1] = cacheableInfoV1;
            EndogenousSupplementalTypes[idempotentTypeIdV1] = idempotentInfoV1;
            EndogenousSupplementalTypes[indexedTypeIdV1] = indexedInfoV1;
            EndogenousSupplementalTypes[mqttTypeIdV1] = mqttInfoV1;
            EndogenousSupplementalTypes[overrideTypeIdV1] = overrideInfoV1;
            EndogenousSupplementalTypes[accelerationTypeIdV1] = accelerationInfoV1;
            EndogenousSupplementalTypes[angleTypeIdV1] = angleInfoV1;
            EndogenousSupplementalTypes[angularAccelerationTypeIdV1] = angularAccelerationInfoV1;
            EndogenousSupplementalTypes[angularVelocityTypeIdV1] = angularVelocityInfoV1;
            EndogenousSupplementalTypes[apparentEnergyTypeIdV1] = apparentEnergyInfoV1;
            EndogenousSupplementalTypes[apparentPowerTypeIdV1] = apparentPowerInfoV1;
            EndogenousSupplementalTypes[areaTypeIdV1] = areaInfoV1;
            EndogenousSupplementalTypes[binaryUnitTypeIdV1] = binaryUnitInfoV1;
            EndogenousSupplementalTypes[capacitanceTypeIdV1] = capacitanceInfoV1;
            EndogenousSupplementalTypes[concentrationTypeIdV1] = concentrationInfoV1;
            EndogenousSupplementalTypes[currentTypeIdV1] = currentInfoV1;
            EndogenousSupplementalTypes[dataRateTypeIdV1] = dataRateInfoV1;
            EndogenousSupplementalTypes[dataSizeTypeIdV1] = dataSizeInfoV1;
            EndogenousSupplementalTypes[decimalUnitTypeIdV1] = decimalUnitInfoV1;
            EndogenousSupplementalTypes[densityTypeIdV1] = densityInfoV1;
            EndogenousSupplementalTypes[distanceTypeIdV1] = distanceInfoV1;
            EndogenousSupplementalTypes[electricChargeTypeIdV1] = electricChargeInfoV1;
            EndogenousSupplementalTypes[energyTypeIdV1] = energyInfoV1;
            EndogenousSupplementalTypes[energyRateTypeIdV1] = energyRateInfoV1;
            EndogenousSupplementalTypes[forceTypeIdV1] = forceInfoV1;
            EndogenousSupplementalTypes[frequencyTypeIdV1] = frequencyInfoV1;
            EndogenousSupplementalTypes[humidityTypeIdV1] = humidityInfoV1;
            EndogenousSupplementalTypes[illuminanceTypeIdV1] = illuminanceInfoV1;
            EndogenousSupplementalTypes[inductanceTypeIdV1] = inductanceInfoV1;
            EndogenousSupplementalTypes[ionizingRadiationDoseTypeIdV1] = ionizingRadiationDoseInfoV1;
            EndogenousSupplementalTypes[irradianceTypeIdV1] = irradianceInfoV1;
            EndogenousSupplementalTypes[latitudeTypeIdV1] = latitudeInfoV1;
            EndogenousSupplementalTypes[lengthTypeIdV1] = lengthInfoV1;
            EndogenousSupplementalTypes[longitudeTypeIdV1] = longitudeInfoV1;
            EndogenousSupplementalTypes[luminanceTypeIdV1] = luminanceInfoV1;
            EndogenousSupplementalTypes[luminosityTypeIdV1] = luminosityInfoV1;
            EndogenousSupplementalTypes[luminousFluxTypeIdV1] = luminousFluxInfoV1;
            EndogenousSupplementalTypes[luminousIntensityTypeIdV1] = luminousIntensityInfoV1;
            EndogenousSupplementalTypes[magneticFluxTypeIdV1] = magneticFluxInfoV1;
            EndogenousSupplementalTypes[magneticInductionTypeIdV1] = magneticInductionInfoV1;
            EndogenousSupplementalTypes[massTypeIdV1] = massInfoV1;
            EndogenousSupplementalTypes[massFlowRateTypeIdV1] = massFlowRateInfoV1;
            EndogenousSupplementalTypes[powerTypeIdV1] = powerInfoV1;
            EndogenousSupplementalTypes[pressureTypeIdV1] = pressureInfoV1;
            EndogenousSupplementalTypes[quantitativeTypeTypeIdV1] = quantitativeTypeInfoV1;
            EndogenousSupplementalTypes[radioactivityTypeIdV1] = radioactivityInfoV1;
            EndogenousSupplementalTypes[ratioUnitTypeIdV1] = ratioUnitInfoV1;
            EndogenousSupplementalTypes[reactiveEnergyTypeIdV1] = reactiveEnergyInfoV1;
            EndogenousSupplementalTypes[reactivePowerTypeIdV1] = reactivePowerInfoV1;
            EndogenousSupplementalTypes[relativeDensityTypeIdV1] = relativeDensityInfoV1;
            EndogenousSupplementalTypes[relativeHumidityTypeIdV1] = relativeHumidityInfoV1;
            EndogenousSupplementalTypes[resistanceTypeIdV1] = resistanceInfoV1;
            EndogenousSupplementalTypes[soundPressureTypeIdV1] = soundPressureInfoV1;
            EndogenousSupplementalTypes[symbolicUnitTypeIdV1] = symbolicUnitInfoV1;
            EndogenousSupplementalTypes[temperatureTypeIdV1] = temperatureInfoV1;
            EndogenousSupplementalTypes[thrustTypeIdV1] = thrustInfoV1;
            EndogenousSupplementalTypes[timeSpanTypeIdV1] = timeSpanInfoV1;
            EndogenousSupplementalTypes[torqueTypeIdV1] = torqueInfoV1;
            EndogenousSupplementalTypes[unitPrefixTypeIdV1] = unitPrefixInfoV1;
            EndogenousSupplementalTypes[velocityTypeIdV1] = velocityInfoV1;
            EndogenousSupplementalTypes[voltageTypeIdV1] = voltageInfoV1;
            EndogenousSupplementalTypes[volumeTypeIdV1] = volumeInfoV1;
            EndogenousSupplementalTypes[volumeFlowRateTypeIdV1] = volumeFlowRateInfoV1;
            EndogenousSupplementalTypes[accelerationVectorTypeIdV2] = accelerationVectorInfoV2;
            EndogenousSupplementalTypes[eventTypeIdV2] = eventInfoV2;
            EndogenousSupplementalTypes[locationTypeIdV2] = locationInfoV2;
            EndogenousSupplementalTypes[stateTypeIdV2] = stateInfoV2;
            EndogenousSupplementalTypes[velocityVectorTypeIdV2] = velocityVectorInfoV2;
            EndogenousSupplementalTypes[accelerationTypeIdV2] = accelerationInfoV2;
            EndogenousSupplementalTypes[accelerationUnitTypeIdV2] = accelerationUnitInfoV2;
            EndogenousSupplementalTypes[angleTypeIdV2] = angleInfoV2;
            EndogenousSupplementalTypes[angleUnitTypeIdV2] = angleUnitInfoV2;
            EndogenousSupplementalTypes[angularAccelerationTypeIdV2] = angularAccelerationInfoV2;
            EndogenousSupplementalTypes[angularAccelerationUnitTypeIdV2] = angularAccelerationUnitInfoV2;
            EndogenousSupplementalTypes[angularVelocityTypeIdV2] = angularVelocityInfoV2;
            EndogenousSupplementalTypes[angularVelocityUnitTypeIdV2] = angularVelocityUnitInfoV2;
            EndogenousSupplementalTypes[areaTypeIdV2] = areaInfoV2;
            EndogenousSupplementalTypes[areaUnitTypeIdV2] = areaUnitInfoV2;
            EndogenousSupplementalTypes[binaryPrefixTypeIdV2] = binaryPrefixInfoV2;
            EndogenousSupplementalTypes[binaryUnitTypeIdV2] = binaryUnitInfoV2;
            EndogenousSupplementalTypes[capacitanceTypeIdV2] = capacitanceInfoV2;
            EndogenousSupplementalTypes[capacitanceUnitTypeIdV2] = capacitanceUnitInfoV2;
            EndogenousSupplementalTypes[chargeUnitTypeIdV2] = chargeUnitInfoV2;
            EndogenousSupplementalTypes[currentTypeIdV2] = currentInfoV2;
            EndogenousSupplementalTypes[currentUnitTypeIdV2] = currentUnitInfoV2;
            EndogenousSupplementalTypes[dataRateTypeIdV2] = dataRateInfoV2;
            EndogenousSupplementalTypes[dataRateUnitTypeIdV2] = dataRateUnitInfoV2;
            EndogenousSupplementalTypes[dataSizeTypeIdV2] = dataSizeInfoV2;
            EndogenousSupplementalTypes[dataSizeUnitTypeIdV2] = dataSizeUnitInfoV2;
            EndogenousSupplementalTypes[decimalPrefixTypeIdV2] = decimalPrefixInfoV2;
            EndogenousSupplementalTypes[decimalUnitTypeIdV2] = decimalUnitInfoV2;
            EndogenousSupplementalTypes[densityTypeIdV2] = densityInfoV2;
            EndogenousSupplementalTypes[densityUnitTypeIdV2] = densityUnitInfoV2;
            EndogenousSupplementalTypes[distanceTypeIdV2] = distanceInfoV2;
            EndogenousSupplementalTypes[electricChargeTypeIdV2] = electricChargeInfoV2;
            EndogenousSupplementalTypes[energyTypeIdV2] = energyInfoV2;
            EndogenousSupplementalTypes[energyUnitTypeIdV2] = energyUnitInfoV2;
            EndogenousSupplementalTypes[forceTypeIdV2] = forceInfoV2;
            EndogenousSupplementalTypes[forceUnitTypeIdV2] = forceUnitInfoV2;
            EndogenousSupplementalTypes[frequencyTypeIdV2] = frequencyInfoV2;
            EndogenousSupplementalTypes[frequencyUnitTypeIdV2] = frequencyUnitInfoV2;
            EndogenousSupplementalTypes[humidityTypeIdV2] = humidityInfoV2;
            EndogenousSupplementalTypes[illuminanceTypeIdV2] = illuminanceInfoV2;
            EndogenousSupplementalTypes[illuminanceUnitTypeIdV2] = illuminanceUnitInfoV2;
            EndogenousSupplementalTypes[inductanceTypeIdV2] = inductanceInfoV2;
            EndogenousSupplementalTypes[inductanceUnitTypeIdV2] = inductanceUnitInfoV2;
            EndogenousSupplementalTypes[latitudeTypeIdV2] = latitudeInfoV2;
            EndogenousSupplementalTypes[lengthTypeIdV2] = lengthInfoV2;
            EndogenousSupplementalTypes[lengthUnitTypeIdV2] = lengthUnitInfoV2;
            EndogenousSupplementalTypes[longitudeTypeIdV2] = longitudeInfoV2;
            EndogenousSupplementalTypes[luminanceTypeIdV2] = luminanceInfoV2;
            EndogenousSupplementalTypes[luminanceUnitTypeIdV2] = luminanceUnitInfoV2;
            EndogenousSupplementalTypes[luminosityTypeIdV2] = luminosityInfoV2;
            EndogenousSupplementalTypes[luminousFluxTypeIdV2] = luminousFluxInfoV2;
            EndogenousSupplementalTypes[luminousFluxUnitTypeIdV2] = luminousFluxUnitInfoV2;
            EndogenousSupplementalTypes[luminousIntensityTypeIdV2] = luminousIntensityInfoV2;
            EndogenousSupplementalTypes[luminousIntensityUnitTypeIdV2] = luminousIntensityUnitInfoV2;
            EndogenousSupplementalTypes[magneticFluxTypeIdV2] = magneticFluxInfoV2;
            EndogenousSupplementalTypes[magneticFluxUnitTypeIdV2] = magneticFluxUnitInfoV2;
            EndogenousSupplementalTypes[magneticInductionTypeIdV2] = magneticInductionInfoV2;
            EndogenousSupplementalTypes[magneticInductionUnitTypeIdV2] = magneticInductionUnitInfoV2;
            EndogenousSupplementalTypes[massTypeIdV2] = massInfoV2;
            EndogenousSupplementalTypes[massFlowRateTypeIdV2] = massFlowRateInfoV2;
            EndogenousSupplementalTypes[massFlowRateUnitTypeIdV2] = massFlowRateUnitInfoV2;
            EndogenousSupplementalTypes[massUnitTypeIdV2] = massUnitInfoV2;
            EndogenousSupplementalTypes[powerTypeIdV2] = powerInfoV2;
            EndogenousSupplementalTypes[powerUnitTypeIdV2] = powerUnitInfoV2;
            EndogenousSupplementalTypes[pressureTypeIdV2] = pressureInfoV2;
            EndogenousSupplementalTypes[pressureUnitTypeIdV2] = pressureUnitInfoV2;
            EndogenousSupplementalTypes[quantitativeTypeTypeIdV2] = quantitativeTypeInfoV2;
            EndogenousSupplementalTypes[ratioUnitTypeIdV2] = ratioUnitInfoV2;
            EndogenousSupplementalTypes[relativeHumidityTypeIdV2] = relativeHumidityInfoV2;
            EndogenousSupplementalTypes[resistanceTypeIdV2] = resistanceInfoV2;
            EndogenousSupplementalTypes[resistanceUnitTypeIdV2] = resistanceUnitInfoV2;
            EndogenousSupplementalTypes[soundPressureTypeIdV2] = soundPressureInfoV2;
            EndogenousSupplementalTypes[soundPressureUnitTypeIdV2] = soundPressureUnitInfoV2;
            EndogenousSupplementalTypes[temperatureTypeIdV2] = temperatureInfoV2;
            EndogenousSupplementalTypes[temperatureUnitTypeIdV2] = temperatureUnitInfoV2;
            EndogenousSupplementalTypes[thrustTypeIdV2] = thrustInfoV2;
            EndogenousSupplementalTypes[timeSpanTypeIdV2] = timeSpanInfoV2;
            EndogenousSupplementalTypes[timeUnitTypeIdV2] = timeUnitInfoV2;
            EndogenousSupplementalTypes[torqueTypeIdV2] = torqueInfoV2;
            EndogenousSupplementalTypes[torqueUnitTypeIdV2] = torqueUnitInfoV2;
            EndogenousSupplementalTypes[unitlessTypeIdV2] = unitlessInfoV2;
            EndogenousSupplementalTypes[velocityTypeIdV2] = velocityInfoV2;
            EndogenousSupplementalTypes[velocityUnitTypeIdV2] = velocityUnitInfoV2;
            EndogenousSupplementalTypes[voltageTypeIdV2] = voltageInfoV2;
            EndogenousSupplementalTypes[voltageUnitTypeIdV2] = voltageUnitInfoV2;
            EndogenousSupplementalTypes[volumeTypeIdV2] = volumeInfoV2;
            EndogenousSupplementalTypes[volumeFlowRateTypeIdV2] = volumeFlowRateInfoV2;
            EndogenousSupplementalTypes[volumeFlowRateUnitTypeIdV2] = volumeFlowRateUnitInfoV2;
            EndogenousSupplementalTypes[volumeUnitTypeIdV2] = volumeUnitInfoV2;

            ConnectEndogenousPropertySetters();
        }

        private static bool TryGetKindsAndVersions(Dtmi extensionId, Dtmi typeId, HashSet<Dtmi> cotypeIds, List<JsonLdValue> allowedCotypes, out HashSet<DTEntityKind> kinds, out HashSet<int> versions, ParsingErrorCollection parsingErrorCollection)
        {
            kinds = new HashSet<DTEntityKind>();
            versions = new HashSet<int>();

            foreach (Dtmi cotypeId in cotypeIds)
            {
                DTEntityKind kind;
                if (!Enum.TryParse(ContextCollection.GetTermOrUri(cotypeId), out kind))
                {
                    string cotypeIdTerm = ContextCollection.GetTermOrUri(cotypeId);
                    JsonLdValue allowedCotype = allowedCotypes.First(c => c.StringValue == cotypeIdTerm || c.StringValue == cotypeId.OriginalString);
                    parsingErrorCollection.Notify(
                        "cotypeNotConcreteMaterial",
                        contextId: extensionId,
                        elementId: typeId,
                        cotype: allowedCotype.StringValue,
                        incidentValue: allowedCotype);

                    return false;
                }

                kinds.Add(kind);
                versions.Add(cotypeId.MajorVersion);
            }

            return true;
        }

        private static bool TrySetAllowedCotypes(Dtmi extensionId, Dtmi typeId, List<JsonLdValue> allowedCotypes, DTSupplementalTypeInfo typeInfo, DTSupplementalTypeInfo parentTypeInfo, AggregateContext aggregateContext, ParsingErrorCollection parsingErrorCollection)
        {
            if (!TryGetClassConstraints(allowedCotypes, "sh:or", typeInfo, aggregateContext, out HashSet<Dtmi> cotypeIds, parsingErrorCollection))
            {
                return false;
            }

            if (cotypeIds != null)
            {
                if (!TryGetKindsAndVersions(extensionId, typeId, cotypeIds, allowedCotypes, out HashSet<DTEntityKind> kinds, out HashSet<int> versions, parsingErrorCollection))
                {
                    return false;
                }

                typeInfo.AllowedCotypeKinds = kinds;
                typeInfo.AllowedCotypeVersions = versions;
                if (parentTypeInfo != null)
                {
                    typeInfo.AllowedCotypeKinds.IntersectWith(parentTypeInfo.AllowedCotypeKinds);
                    typeInfo.AllowedCotypeVersions.IntersectWith(parentTypeInfo.AllowedCotypeVersions);
                }
            }
            else if (parentTypeInfo != null)
            {
                typeInfo.AllowedCotypeKinds = parentTypeInfo.AllowedCotypeKinds;
                typeInfo.AllowedCotypeVersions = parentTypeInfo.AllowedCotypeVersions;
            }

            return true;
        }
    }
}
