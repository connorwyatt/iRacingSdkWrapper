using System.Collections.Generic;
using iRSDKSharp;
using iRacingSdkWrapper.Bitfields;

namespace iRacingSdkWrapper
{
    /// <summary>
    /// Represents an object from which you can get Telemetry var headers by name
    /// </summary>
    public sealed class TelemetryInfo
    {
        private readonly iRacingSDK sdk;

        public TelemetryInfo(iRacingSDK sdk)
        {
            this.sdk = sdk;
        }

        public TelemetryValue<float> MGUKDeployAdapt { get { return new TelemetryValue<float>(sdk, "dcMGUKDeployAdapt"); } }

        public TelemetryValue<float> MGUKDeployFixed { get { return new TelemetryValue<float>(sdk, "dcMGUKDeployFixed"); } }

        public TelemetryValue<float> MGUKRegenGain { get { return new TelemetryValue<float>(sdk, "dcMGUKRegenGain"); } }

        public TelemetryValue<float> EnergyBatteryToMGU { get { return new TelemetryValue<float>(sdk, "EnergyBatteryToMGU_KLap"); } }

        public TelemetryValue<float> EnergyBudgetBattToMGU { get { return new TelemetryValue<float>(sdk, "EnergyBudgetBattToMGU_KLap"); } }

        public TelemetryValue<float> EnergyERSBattery { get { return new TelemetryValue<float>(sdk, "EnergyERSBattery"); } }

        public TelemetryValue<float> PowerMGUH { get { return new TelemetryValue<float>(sdk, "PowerMGU_H"); } }

        public TelemetryValue<float> PowerMGUK { get { return new TelemetryValue<float>(sdk, "PowerMGU_K"); } }

        public TelemetryValue<float> TorqueMGUK { get { return new TelemetryValue<float>(sdk, "TorqueMGU_K"); } }

        /// <summary>
        /// Current DRS status. 0 = inactive, 1 = can be activated in next DRS zone, 2 = can be activated now, 3 = active.
        /// </summary>
        public TelemetryValue<int> DrsStatus { get { return new TelemetryValue<int>(sdk, "DRS_Status"); } }

        /// <summary>
        /// The number of laps you have completed. Note: on Nordschleife Tourist layout, you can complete a lap without starting a new one!
        /// </summary>
        public TelemetryValue<int> LapCompleted { get { return new TelemetryValue<int>(sdk, "LapCompleted"); } }


        /// <summary>
        /// Seconds since session start. Unit: s
        /// </summary>
        public TelemetryValue<double> SessionTime { get { return new TelemetryValue<double>(sdk, "SessionTime"); } }


        /// <summary>
        /// Session number.
        /// </summary>
        public TelemetryValue<int> SessionNum { get { return new TelemetryValue<int>(sdk, "SessionNum"); } }


        /// <summary>
        /// Session state. Unit: irsdk_SessionState
        /// </summary>
        public TelemetryValue<SessionStates> SessionState { get { return new TelemetryValue<SessionStates>(sdk, "SessionState"); } }


        /// <summary>
        /// Session ID.
        /// </summary>
        public TelemetryValue<int> SessionUniqueID { get { return new TelemetryValue<int>(sdk, "SessionUniqueID"); } }


        /// <summary>
        /// Session flags. Unit: irsdk_Flags
        /// </summary>
        public TelemetryValue<SessionFlag> SessionFlags { get { return new TelemetryValue<SessionFlag>(sdk, "SessionFlags"); } }


        /// <summary>
        /// Driver activated flag.
        /// </summary>
        public TelemetryValue<bool> DriverMarker { get { return new TelemetryValue<bool>(sdk, "DriverMarker"); } }


        /// <summary>
        /// 0=replay not playing  1=replay playing.
        /// </summary>
        public TelemetryValue<bool> IsReplayPlaying { get { return new TelemetryValue<bool>(sdk, "IsReplayPlaying"); } }


        /// <summary>
        /// Integer replay frame number (60 per second).
        /// </summary>
        public TelemetryValue<int> ReplayFrameNum { get { return new TelemetryValue<int>(sdk, "ReplayFrameNum"); } }


        /// <summary>
        /// Current lap number by car index
        /// </summary>
        public TelemetryValue<int[]> CarIdxLap { get { return new TelemetryValue<int[]>(sdk, "CarIdxLap"); } }

        /// <summary>
        /// Current number of completed laps by car index. Note: On Nordschleife Tourist layout, cars can complete a lap without starting a new lap!
        /// </summary>
        public TelemetryValue<int[]> CarIdxLapCompleted { get { return new TelemetryValue<int[]>(sdk, "CarIdxLapCompleted"); } }

        /// <summary>
        /// Percentage distance around lap by car index. Unit: %
        /// </summary>
        public TelemetryValue<float[]> CarIdxLapDistPct { get { return new TelemetryValue<float[]>(sdk, "CarIdxLapDistPct"); } }


        /// <summary>
        /// Track surface type by car index. Unit: irsdk_TrkLoc
        /// </summary>
        public TelemetryValue<TrackSurfaces[]> CarIdxTrackSurface { get { return new TelemetryValue<TrackSurfaces[]>(sdk, "CarIdxTrackSurface"); } }


        /// <summary>
        /// Steering wheel angle by car index. Unit: rad
        /// </summary>
        public TelemetryValue<float[]> CarIdxSteer { get { return new TelemetryValue<float[]>(sdk, "CarIdxSteer"); } }


        /// <summary>
        /// Engine rpm by car index. Unit: revs/min
        /// </summary>
        public TelemetryValue<float[]> CarIdxRPM { get { return new TelemetryValue<float[]>(sdk, "CarIdxRPM"); } }


        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear by car index.
        /// </summary>
        public TelemetryValue<int[]> CarIdxGear { get { return new TelemetryValue<int[]>(sdk, "CarIdxGear"); } }

        public TelemetryValue<float[]> CarIdxF2Time { get { return new TelemetryValue<float[]>(sdk, "CarIdxF2Time"); } }

        public TelemetryValue<float[]> CarIdxEstTime { get { return new TelemetryValue<float[]>(sdk, "CarIdxEstTime"); } }

        public TelemetryValue<float[]> CarIdxLastLapTime { get { return new TelemetryValue<float[]>(sdk, "CarIdxLastLapTime"); } }

        public TelemetryValue<float[]> CarIdxBestLapTime { get { return new TelemetryValue<float[]>(sdk, "CarIdxBestLapTime"); } }

        public TelemetryValue<int[]> CarIdxBestLapNum { get { return new TelemetryValue<int[]>(sdk, "CarIdxBestLapNum"); } }

        public TelemetryValue<bool[]> CarIdxOnPitRoad { get { return new TelemetryValue<bool[]>(sdk, "CarIdxOnPitRoad"); } }

        public TelemetryValue<int[]> CarIdxPosition { get { return new TelemetryValue<int[]>(sdk, "CarIdxPosition"); } }

        public TelemetryValue<int[]> CarIdxClassPosition { get { return new TelemetryValue<int[]>(sdk, "CarIdxClassPosition"); } }

        public TelemetryValue<int[]> CarIdxClass { get { return new TelemetryValue<int[]>(sdk, "CarIdxClass"); } }

        public TelemetryValue<int[]> CarIdxTireCompound { get { return new TelemetryValue<int[]>(sdk, "CarIdxTireCompound"); } }

        public TelemetryValue<int[]> CarIdxQualTireCompound { get { return new TelemetryValue<int[]>(sdk, "CarIdxQualTireCompound"); } }

        public TelemetryValue<bool[]> CarIdxQualTireCompoundLocked { get { return new TelemetryValue<bool[]>(sdk, "CarIdxQualTireCompoundLocked"); } }

        public TelemetryValue<int[]> CarIdxFastRepairsUsed { get { return new TelemetryValue<int[]>(sdk, "CarIdxFastRepairsUsed"); } }

        public TelemetryValue<int[]> CarIdxPaceLine { get { return new TelemetryValue<int[]>(sdk, "CarIdxPaceLine"); } }

        public TelemetryValue<int[]> CarIdxPaceRow { get { return new TelemetryValue<int[]>(sdk, "CarIdxPaceRow"); } }

        public TelemetryValue<bool[]> CarIdxP2P_Status { get { return new TelemetryValue<bool[]>(sdk, "CarIdxP2P_Status"); } }

        public TelemetryValue<int[]> CarIdxP2P_Count { get { return new TelemetryValue<int[]>(sdk, "CarIdxP2P_Count"); } }


        /// <summary>
        /// Steering wheel angle. Unit: rad
        /// </summary>
        public TelemetryValue<float> SteeringWheelAngle { get { return new TelemetryValue<float>(sdk, "SteeringWheelAngle"); } }


        /// <summary>
        /// 0=off throttle to 1=full throttle. Unit: %
        /// </summary>
        public TelemetryValue<float> Throttle { get { return new TelemetryValue<float>(sdk, "Throttle"); } }


        /// <summary>
        /// 0=brake released to 1=max pedal force. Unit: %
        /// </summary>
        public TelemetryValue<float> Brake { get { return new TelemetryValue<float>(sdk, "Brake"); } }


        /// <summary>
        /// 0=disengaged to 1=fully engaged. Unit: %
        /// </summary>
        public TelemetryValue<float> Clutch { get { return new TelemetryValue<float>(sdk, "Clutch"); } }


        /// <summary>
        /// -1=reverse  0=neutral  1..n=current gear.
        /// </summary>
        public TelemetryValue<int> Gear { get { return new TelemetryValue<int>(sdk, "Gear"); } }


        /// <summary>
        /// Engine rpm. Unit: revs/min
        /// </summary>
        public TelemetryValue<float> RPM { get { return new TelemetryValue<float>(sdk, "RPM"); } }


        /// <summary>
        /// Lap count.
        /// </summary>
        public TelemetryValue<int> Lap { get { return new TelemetryValue<int>(sdk, "Lap"); } }


        /// <summary>
        /// Meters traveled from S/F this lap. Unit: m
        /// </summary>
        public TelemetryValue<float> LapDist { get { return new TelemetryValue<float>(sdk, "LapDist"); } }


        /// <summary>
        /// Percentage distance around lap. Unit: %
        /// </summary>
        public TelemetryValue<float> LapDistPct { get { return new TelemetryValue<float>(sdk, "LapDistPct"); } }


        /// <summary>
        /// Laps completed in race.
        /// </summary>
        public TelemetryValue<int> RaceLaps { get { return new TelemetryValue<int>(sdk, "RaceLaps"); } }


        /// <summary>
        /// Longitudinal acceleration (including gravity). Unit: m/s^2
        /// </summary>
        public TelemetryValue<float> LongAccel { get { return new TelemetryValue<float>(sdk, "LongAccel"); } }


        /// <summary>
        /// Lateral acceleration (including gravity). Unit: m/s^2
        /// </summary>
        public TelemetryValue<float> LatAccel { get { return new TelemetryValue<float>(sdk, "LatAccel"); } }


        /// <summary>
        /// Vertical acceleration (including gravity). Unit: m/s^2
        /// </summary>
        public TelemetryValue<float> VertAccel { get { return new TelemetryValue<float>(sdk, "VertAccel"); } }


        /// <summary>
        /// Roll rate. Unit: rad/s
        /// </summary>
        public TelemetryValue<float> RollRate { get { return new TelemetryValue<float>(sdk, "RollRate"); } }


        /// <summary>
        /// Pitch rate. Unit: rad/s
        /// </summary>
        public TelemetryValue<float> PitchRate { get { return new TelemetryValue<float>(sdk, "PitchRate"); } }


        /// <summary>
        /// Yaw rate. Unit: rad/s
        /// </summary>
        public TelemetryValue<float> YawRate { get { return new TelemetryValue<float>(sdk, "YawRate"); } }


        /// <summary>
        /// GPS vehicle speed. Unit: m/s
        /// </summary>
        public TelemetryValue<float> Speed { get { return new TelemetryValue<float>(sdk, "Speed"); } }


        /// <summary>
        /// X velocity. Unit: m/s
        /// </summary>
        public TelemetryValue<float> VelocityX { get { return new TelemetryValue<float>(sdk, "VelocityX"); } }


        /// <summary>
        /// Y velocity. Unit: m/s
        /// </summary>
        public TelemetryValue<float> VelocityY { get { return new TelemetryValue<float>(sdk, "VelocityY"); } }


        /// <summary>
        /// Z velocity. Unit: m/s
        /// </summary>
        public TelemetryValue<float> VelocityZ { get { return new TelemetryValue<float>(sdk, "VelocityZ"); } }


        /// <summary>
        /// Yaw orientation. Unit: rad
        /// </summary>
        public TelemetryValue<float> Yaw { get { return new TelemetryValue<float>(sdk, "Yaw"); } }


        /// <summary>
        /// Pitch orientation. Unit: rad
        /// </summary>
        public TelemetryValue<float> Pitch { get { return new TelemetryValue<float>(sdk, "Pitch"); } }


        /// <summary>
        /// Roll orientation. Unit: rad
        /// </summary>
        public TelemetryValue<float> Roll { get { return new TelemetryValue<float>(sdk, "Roll"); } }


        /// <summary>
        /// Active camera's focus car index.
        /// </summary>
        public TelemetryValue<int> CamCarIdx { get { return new TelemetryValue<int>(sdk, "CamCarIdx"); } }


        /// <summary>
        /// Active camera number.
        /// </summary>
        public TelemetryValue<int> CamCameraNumber { get { return new TelemetryValue<int>(sdk, "CamCameraNumber"); } }


        /// <summary>
        /// Active camera group number.
        /// </summary>
        public TelemetryValue<int> CamGroupNumber { get { return new TelemetryValue<int>(sdk, "CamGroupNumber"); } }


        /// <summary>
        /// State of camera system. Unit: irsdk_CameraState
        /// </summary>
        public TelemetryValue<CameraState> CamCameraState { get { return new TelemetryValue<CameraState>(sdk, "CamCameraState"); } }


        /// <summary>
        /// 1=Car on track physics running.
        /// </summary>
        public TelemetryValue<bool> IsOnTrack { get { return new TelemetryValue<bool>(sdk, "IsOnTrack"); } }


        /// <summary>
        /// 1=Car in garage physics running.
        /// </summary>
        public TelemetryValue<bool> IsInGarage { get { return new TelemetryValue<bool>(sdk, "IsInGarage"); } }


        /// <summary>
        /// Output torque on steering shaft. Unit: N*m
        /// </summary>
        public TelemetryValue<float> SteeringWheelTorque { get { return new TelemetryValue<float>(sdk, "SteeringWheelTorque"); } }


        /// <summary>
        /// Force feedback % max torque on steering shaft. Unit: %
        /// </summary>
        public TelemetryValue<float> SteeringWheelPctTorque { get { return new TelemetryValue<float>(sdk, "SteeringWheelPctTorque"); } }


        /// <summary>
        /// Percent of shift indicator to light up. Unit: %
        /// </summary>
        public TelemetryValue<float> ShiftIndicatorPct { get { return new TelemetryValue<float>(sdk, "ShiftIndicatorPct"); } }


        /// <summary>
        /// Bitfield for warning lights. Unit: irsdk_EngineWarnings
        /// </summary>
        public TelemetryValue<EngineWarning> EngineWarnings { get { return new TelemetryValue<EngineWarning>(sdk, "EngineWarnings"); } }


        /// <summary>
        /// Liters of fuel remaining. Unit: l
        /// </summary>
        public TelemetryValue<float> FuelLevel { get { return new TelemetryValue<float>(sdk, "FuelLevel"); } }


        /// <summary>
        /// Percent fuel remaining. Unit: %
        /// </summary>
        public TelemetryValue<float> FuelLevelPct { get { return new TelemetryValue<float>(sdk, "FuelLevelPct"); } }


        /// <summary>
        /// Replay playback speed.
        /// </summary>
        public TelemetryValue<int> ReplayPlaySpeed { get { return new TelemetryValue<int>(sdk, "ReplayPlaySpeed"); } }


        /// <summary>
        /// 0=not slow motion  1=replay is in slow motion.
        /// </summary>
        public TelemetryValue<bool> ReplayPlaySlowMotion { get { return new TelemetryValue<bool>(sdk, "ReplayPlaySlowMotion"); } }


        /// <summary>
        /// Seconds since replay session start. Unit: s
        /// </summary>
        public TelemetryValue<double> ReplaySessionTime { get { return new TelemetryValue<double>(sdk, "ReplaySessionTime"); } }


        /// <summary>
        /// Replay session number.
        /// </summary>
        public TelemetryValue<int> ReplaySessionNum { get { return new TelemetryValue<int>(sdk, "ReplaySessionNum"); } }


        /// <summary>
        /// Engine coolant temp. Unit: C
        /// </summary>
        public TelemetryValue<float> WaterTemp { get { return new TelemetryValue<float>(sdk, "WaterTemp"); } }


        /// <summary>
        /// Engine coolant level. Unit: l
        /// </summary>
        public TelemetryValue<float> WaterLevel { get { return new TelemetryValue<float>(sdk, "WaterLevel"); } }


        /// <summary>
        /// Engine fuel pressure. Unit: bar
        /// </summary>
        public TelemetryValue<float> FuelPress { get { return new TelemetryValue<float>(sdk, "FuelPress"); } }


        /// <summary>
        /// Engine oil temperature. Unit: C
        /// </summary>
        public TelemetryValue<float> OilTemp { get { return new TelemetryValue<float>(sdk, "OilTemp"); } }


        /// <summary>
        /// Engine oil pressure. Unit: bar
        /// </summary>
        public TelemetryValue<float> OilPress { get { return new TelemetryValue<float>(sdk, "OilPress"); } }


        /// <summary>
        /// Engine oil level. Unit: l
        /// </summary>
        public TelemetryValue<float> OilLevel { get { return new TelemetryValue<float>(sdk, "OilLevel"); } }


        /// <summary>
        /// Engine voltage. Unit: V
        /// </summary>
        public TelemetryValue<float> Voltage { get { return new TelemetryValue<float>(sdk, "Voltage"); } }

        public TelemetryValue<double> SessionTimeRemain { get { return new TelemetryValue<double>(sdk, "SessionTimeRemain"); } }

        public TelemetryValue<int> ReplayFrameNumEnd { get { return new TelemetryValue<int>(sdk, "ReplayFrameNumEnd"); } }

        public TelemetryValue<float> AirDensity { get { return new TelemetryValue<float>(sdk, "AirDensity"); } }

        public TelemetryValue<float> AirPressure { get { return new TelemetryValue<float>(sdk, "AirPressure"); } }

        public TelemetryValue<float> AirTemp { get { return new TelemetryValue<float>(sdk, "AirTemp"); } }

        public TelemetryValue<float> FogLevel { get { return new TelemetryValue<float>(sdk, "FogLevel"); } }

        public TelemetryValue<int> Skies { get { return new TelemetryValue<int>(sdk, "Skies"); } }

        public TelemetryValue<float> TrackTemp { get { return new TelemetryValue<float>(sdk, "TrackTemp"); } }

        public TelemetryValue<float> TrackTempCrew { get { return new TelemetryValue<float>(sdk, "TrackTempCrew"); } }

        public TelemetryValue<float> RelativeHumidity { get { return new TelemetryValue<float>(sdk, "RelativeHumidity"); } }

        public TelemetryValue<int> WeatherType { get { return new TelemetryValue<int>(sdk, "WeatherType"); } }

        public TelemetryValue<float> WindDir { get { return new TelemetryValue<float>(sdk, "WindDir"); } }

        public TelemetryValue<float> WindVel { get { return new TelemetryValue<float>(sdk, "WindVel"); } }

        public TelemetryValue<int> PlayerCarTeamIncidentCount { get { return new TelemetryValue<int>(sdk, "PlayerCarTeamIncidentCount"); } }

        public TelemetryValue<int> PlayerCarMyIncidentCount { get { return new TelemetryValue<int>(sdk, "PlayerCarMyIncidentCount"); } }

        public TelemetryValue<int> PlayerCarDriverIncidentCount { get { return new TelemetryValue<int>(sdk, "PlayerCarDriverIncidentCount"); } }

        public TelemetryValue<TrackSurfaces> PlayerTrackSurface { get { return new TelemetryValue<TrackSurfaces>(sdk, "PlayerTrackSurface"); } }

        public TelemetryValue<int> PlayerCarIdx { get { return new TelemetryValue<int>(sdk, "PlayerCarIdx"); } }

        public TelemetryValue<float> PitSvFuel { get { return new TelemetryValue<float>(sdk, "PitSvFuel"); } }

        public TelemetryValue<float> PitOptRepairLeft { get { return new TelemetryValue<float>(sdk, "PitOptRepairLeft"); } }

        public TelemetryValue<float> PitRepairLeft { get { return new TelemetryValue<float>(sdk, "PitRepairLeft"); } }

        public TelemetryValue<int> PlayerCarClassPosition { get { return new TelemetryValue<int>(sdk, "PlayerCarClassPosition"); } }

        public TelemetryValue<int> PlayerCarPosition { get { return new TelemetryValue<int>(sdk, "PlayerCarPosition"); } }

        public TelemetryValue<int> SessionLapsRemainEx { get { return new TelemetryValue<int>(sdk, "SessionLapsRemainEx"); } }

        public TelemetryValue<double> SessionTimeTotal { get { return new TelemetryValue<double>(sdk, "SessionTimeTotal"); } }

        public TelemetryValue<int> SessionLapsTotal { get { return new TelemetryValue<int>(sdk, "SessionLapsTotal"); } }

        public TelemetryValue<float> SessionTimeOfDay { get { return new TelemetryValue<float>(sdk, "SessionTimeOfDay"); } }

        public TelemetryValue<int> RadioTransmitCarIdx { get { return new TelemetryValue<int>(sdk, "RadioTransmitCarIdx"); } }

        public TelemetryValue<bool> PushToPass { get { return new TelemetryValue<bool>(sdk, "PushToPass"); } }

        public TelemetryValue<bool> ManualBoost { get { return new TelemetryValue<bool>(sdk, "ManualBoost"); } }

        public TelemetryValue<bool> ManualNoBoost { get { return new TelemetryValue<bool>(sdk, "ManualNoBoost"); } }

        public TelemetryValue<int> PlayerCarClass { get { return new TelemetryValue<int>(sdk, "PlayerCarClass"); } }

        public TelemetryValue<float> PlayerCarWeightPenalty { get { return new TelemetryValue<float>(sdk, "PlayerCarWeightPenalty"); } }

        public TelemetryValue<float> PlayerCarPowerAdjust { get { return new TelemetryValue<float>(sdk, "PlayerCarPowerAdjust"); } }

        public TelemetryValue<float> PlayerCarTowTime { get { return new TelemetryValue<float>(sdk, "PlayerCarTowTime"); } }

        public TelemetryValue<bool> PlayerCarInPitStall { get { return new TelemetryValue<bool>(sdk, "PlayerCarInPitStall"); } }

        public TelemetryValue<int> PlayerCarDryTireSetLimit { get { return new TelemetryValue<int>(sdk, "PlayerCarDryTireSetLimit"); } }

        public TelemetryValue<int> PlayerTireCompound { get { return new TelemetryValue<int>(sdk, "PlayerTireCompound"); } }

        public TelemetryValue<int> PlayerFastRepairsUsed { get { return new TelemetryValue<int>(sdk, "PlayerFastRepairsUsed"); } }

        public TelemetryValue<bool> PitsOpen { get { return new TelemetryValue<bool>(sdk, "PitsOpen"); } }

        public TelemetryValue<bool> PitstopActive { get { return new TelemetryValue<bool>(sdk, "PitstopActive"); } }

        public TelemetryValue<int> FastRepairUsed { get { return new TelemetryValue<int>(sdk, "FastRepairUsed"); } }

        public TelemetryValue<int> FastRepairAvailable { get { return new TelemetryValue<int>(sdk, "FastRepairAvailable"); } }

        public TelemetryValue<int> BrakeABSactive { get { return new TelemetryValue<int>(sdk, "BrakeABSactive"); } }

        public TelemetryValue<bool> dcStarter { get { return new TelemetryValue<bool>(sdk, "dcStarter"); } }

        public TelemetryValue<bool> dcTractionControlToggle { get { return new TelemetryValue<bool>(sdk, "dcTractionControlToggle"); } }

        public TelemetryValue<bool> dcPitSpeedLimiterToggle { get { return new TelemetryValue<bool>(sdk, "dcPitSpeedLimiterToggle"); } }

        public TelemetryValue<bool> dcHeadlightFlash { get { return new TelemetryValue<bool>(sdk, "dcHeadlightFlash"); } }

        public TelemetryValue<float> dpRFTireChange { get { return new TelemetryValue<float>(sdk, "dpRFTireChange"); } }

        public TelemetryValue<float> dpLFTireChange { get { return new TelemetryValue<float>(sdk, "dpLFTireChange"); } }

        public TelemetryValue<float> dpRRTireChange { get { return new TelemetryValue<float>(sdk, "dpRRTireChange"); } }

        public TelemetryValue<float> dpLRTireChange { get { return new TelemetryValue<float>(sdk, "dpLRTireChange"); } }

        public TelemetryValue<float> dpTireChange { get { return new TelemetryValue<float>(sdk, "dpTireChange"); } }

        public TelemetryValue<float> dpFuelFill { get { return new TelemetryValue<float>(sdk, "dpFuelFill"); } }

        public TelemetryValue<float> dpWindshieldTearoff { get { return new TelemetryValue<float>(sdk, "dpWindshieldTearoff"); } }

        public TelemetryValue<float> dpFuelAddKg { get { return new TelemetryValue<float>(sdk, "dpFuelAddKg"); } }

        public TelemetryValue<float> dpFastRepair { get { return new TelemetryValue<float>(sdk, "dpFastRepair"); } }

        public TelemetryValue<float> dpWingFront { get { return new TelemetryValue<float>(sdk, "dpWingFront"); } }

        public TelemetryValue<float> dcBrakeBias { get { return new TelemetryValue<float>(sdk, "dcBrakeBias"); } }

        public TelemetryValue<float> dcDashPage { get { return new TelemetryValue<float>(sdk, "dcDashPage"); } }

        public TelemetryValue<float> dcThrottleShape { get { return new TelemetryValue<float>(sdk, "dcThrottleShape"); } }

        public TelemetryValue<float> dpPowerSteering { get { return new TelemetryValue<float>(sdk, "dpPowerSteering"); } }

        public TelemetryValue<float> dcTractionControl { get { return new TelemetryValue<float>(sdk, "dcTractionControl"); } }

        public TelemetryValue<float> dcTractionControl2 { get { return new TelemetryValue<float>(sdk, "dcTractionControl2"); } }

        public TelemetryValue<float> dcABS { get { return new TelemetryValue<float>(sdk, "dcABS"); } }

        public TelemetryValue<bool> dcDRSToggle { get { return new TelemetryValue<bool>(sdk, "dcDRSToggle"); } }

        public TelemetryValue<float> dcMGUKDeployMode { get { return new TelemetryValue<float>(sdk, "dcMGUKDeployMode"); } }

        public TelemetryValue<float> dcDiffPreload { get { return new TelemetryValue<float>(sdk, "dcDiffPreload"); } }

        public TelemetryValue<float> dcDiffEntry { get { return new TelemetryValue<float>(sdk, "dcDiffEntry"); } }

        public TelemetryValue<float> dcPeakBrakeBias { get { return new TelemetryValue<float>(sdk, "dcPeakBrakeBias"); } }

        public TelemetryValue<int> DRS_Status { get { return new TelemetryValue<int>(sdk, "DRS_Status"); } }

        public TelemetryValue<float> PowerMGU_K { get { return new TelemetryValue<float>(sdk, "PowerMGU_K"); } }

        public TelemetryValue<float> TorqueMGU_K { get { return new TelemetryValue<float>(sdk, "TorqueMGU_K"); } }

        public TelemetryValue<float> PowerMGU_H { get { return new TelemetryValue<float>(sdk, "PowerMGU_H"); } }

        public TelemetryValue<float> EnergyERSBatteryPct { get { return new TelemetryValue<float>(sdk, "EnergyERSBatteryPct"); } }

        public TelemetryValue<float> EnergyBatteryToMGU_KLap { get { return new TelemetryValue<float>(sdk, "EnergyBatteryToMGU_KLap"); } }

        public TelemetryValue<float> EnergyMGU_KLapDeployPct { get { return new TelemetryValue<float>(sdk, "EnergyMGU_KLapDeployPct"); } }

        public TelemetryValue<float> RFtempCL { get { return new TelemetryValue<float>(sdk, "RFtempCL"); } }

        public TelemetryValue<float> RFtempCM { get { return new TelemetryValue<float>(sdk, "RFtempCM"); } }

        public TelemetryValue<float> RFtempCR { get { return new TelemetryValue<float>(sdk, "RFtempCR"); } }

        public TelemetryValue<float> RFwearL { get { return new TelemetryValue<float>(sdk, "RFwearL"); } }

        public TelemetryValue<float> RFwearM { get { return new TelemetryValue<float>(sdk, "RFwearM"); } }

        public TelemetryValue<float> RFwearR { get { return new TelemetryValue<float>(sdk, "RFwearR"); } }

        public TelemetryValue<float> LFtempCL { get { return new TelemetryValue<float>(sdk, "LFtempCL"); } }

        public TelemetryValue<float> LFtempCM { get { return new TelemetryValue<float>(sdk, "LFtempCM"); } }

        public TelemetryValue<float> LFtempCR { get { return new TelemetryValue<float>(sdk, "LFtempCR"); } }

        public TelemetryValue<float> LFwearL { get { return new TelemetryValue<float>(sdk, "LFwearL"); } }

        public TelemetryValue<float> LFwearM { get { return new TelemetryValue<float>(sdk, "LFwearM"); } }

        public TelemetryValue<float> LFwearR { get { return new TelemetryValue<float>(sdk, "LFwearR"); } }

        public TelemetryValue<float> RRtempCL { get { return new TelemetryValue<float>(sdk, "RRtempCL"); } }

        public TelemetryValue<float> RRtempCM { get { return new TelemetryValue<float>(sdk, "RRtempCM"); } }

        public TelemetryValue<float> RRtempCR { get { return new TelemetryValue<float>(sdk, "RRtempCR"); } }

        public TelemetryValue<float> RRwearL { get { return new TelemetryValue<float>(sdk, "RRwearL"); } }

        public TelemetryValue<float> RRwearM { get { return new TelemetryValue<float>(sdk, "RRwearM"); } }

        public TelemetryValue<float> RRwearR { get { return new TelemetryValue<float>(sdk, "RRwearR"); } }

        public TelemetryValue<float> LRtempCL { get { return new TelemetryValue<float>(sdk, "LRtempCL"); } }

        public TelemetryValue<float> LRtempCM { get { return new TelemetryValue<float>(sdk, "LRtempCM"); } }

        public TelemetryValue<float> LRtempCR { get { return new TelemetryValue<float>(sdk, "LRtempCR"); } }

        public TelemetryValue<float> LRwearL { get { return new TelemetryValue<float>(sdk, "LRwearL"); } }

        public TelemetryValue<float> LRwearM { get { return new TelemetryValue<float>(sdk, "LRwearM"); } }

        public TelemetryValue<float> LRwearR { get { return new TelemetryValue<float>(sdk, "LRwearR"); } }

        public TelemetryValue<int> LapBestLap { get { return new TelemetryValue<int>(sdk, "LapBestLap"); } }

        public TelemetryValue<float> LapBestLapTime { get { return new TelemetryValue<float>(sdk, "LapBestLapTime"); } }

        public TelemetryValue<float> LapLastLapTime { get { return new TelemetryValue<float>(sdk, "LapLastLapTime"); } }

        public TelemetryValue<float> LapCurrentLapTime { get { return new TelemetryValue<float>(sdk, "LapCurrentLapTime"); } }

        public TelemetryValue<float> LapDeltaToBestLap { get { return new TelemetryValue<float>(sdk, "LapDeltaToBestLap"); } }

        public TelemetryValue<float> LapDeltaToBestLap_DD { get { return new TelemetryValue<float>(sdk, "LapDeltaToBestLap_DD"); } }

        public TelemetryValue<bool> LapDeltaToBestLap_OK { get { return new TelemetryValue<bool>(sdk, "LapDeltaToBestLap_OK"); } }

        public TelemetryValue<float> LapDeltaToOptimalLap { get { return new TelemetryValue<float>(sdk, "LapDeltaToOptimalLap"); } }

        public TelemetryValue<float> LapDeltaToOptimalLap_DD { get { return new TelemetryValue<float>(sdk, "LapDeltaToOptimalLap_DD"); } }

        public TelemetryValue<bool> LapDeltaToOptimalLap_OK { get { return new TelemetryValue<bool>(sdk, "LapDeltaToOptimalLap_OK"); } }

        public TelemetryValue<float> LapDeltaToSessionBestLap { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionBestLap"); } }

        public TelemetryValue<float> LapDeltaToSessionBestLap_DD { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionBestLap_DD"); } }

        public TelemetryValue<bool> LapDeltaToSessionBestLap_OK { get { return new TelemetryValue<bool>(sdk, "LapDeltaToSessionBestLap_OK"); } }

        public TelemetryValue<float> LapDeltaToSessionOptimalLap { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionOptimalLap"); } }

        public TelemetryValue<float> LapDeltaToSessionOptimalLap_DD { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionOptimalLap_DD"); } }

        public TelemetryValue<bool> LapDeltaToSessionOptimalLap_OK { get { return new TelemetryValue<bool>(sdk, "LapDeltaToSessionOptimalLap_OK"); } }

        public TelemetryValue<float> LapDeltaToSessionLastlLap { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionLastlLap"); } }

        public TelemetryValue<float> LapDeltaToSessionLastlLap_DD { get { return new TelemetryValue<float>(sdk, "LapDeltaToSessionLastlLap_DD"); } }

        public TelemetryValue<bool> LapDeltaToSessionLastlLap_OK { get { return new TelemetryValue<bool>(sdk, "LapDeltaToSessionLastlLap_OK"); } }
    }
}
