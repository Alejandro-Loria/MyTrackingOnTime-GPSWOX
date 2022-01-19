using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrackingOnTime.Models
{
    public class GetDevicesLatestModel
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class IconColors
        {
            [JsonProperty("moving")]
            public string Moving { get; set; }

            [JsonProperty("stopped")]
            public string Stopped { get; set; }

            [JsonProperty("offline")]
            public string Offline { get; set; }

            [JsonProperty("engine")]
            public string Engine { get; set; }
        }

        public class Icon
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("user_id")]
            public object UserId { get; set; }

            [JsonProperty("type")]
            public string Type { get; set; }

            [JsonProperty("order")]
            public int Order { get; set; }

            [JsonProperty("width")]
            public int Width { get; set; }

            [JsonProperty("height")]
            public int Height { get; set; }

            [JsonProperty("path")]
            public string Path { get; set; }

            [JsonProperty("by_status")]
            public int ByStatus { get; set; }
        }

        public class DriverData
        {
            [JsonProperty("id")]
            public object Id { get; set; }

            [JsonProperty("user_id")]
            public object UserId { get; set; }

            [JsonProperty("device_id")]
            public object DeviceId { get; set; }

            [JsonProperty("name")]
            public object Name { get; set; }

            [JsonProperty("rfid")]
            public object Rfid { get; set; }

            [JsonProperty("phone")]
            public object Phone { get; set; }

            [JsonProperty("email")]
            public object Email { get; set; }

            [JsonProperty("description")]
            public object Description { get; set; }

            [JsonProperty("created_at")]
            public object CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public object UpdatedAt { get; set; }
        }

        public class Pivot
        {
            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("device_id")]
            public int DeviceId { get; set; }

            [JsonProperty("group_id")]
            public int GroupId { get; set; }

            [JsonProperty("current_driver_id")]
            public object CurrentDriverId { get; set; }

            [JsonProperty("active")]
            public int Active { get; set; }

            [JsonProperty("timezone_id")]
            public object TimezoneId { get; set; }
        }

        public class Traccar
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("uniqueId")]
            public string UniqueId { get; set; }

            [JsonProperty("latestPosition_id")]
            public int LatestPositionId { get; set; }

            [JsonProperty("lastValidLatitude")]
            public double LastValidLatitude { get; set; }

            [JsonProperty("lastValidLongitude")]
            public double LastValidLongitude { get; set; }

            [JsonProperty("other")]
            public string Other { get; set; }

            [JsonProperty("speed")]
            public string Speed { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("device_time")]
            public string DeviceTime { get; set; }

            [JsonProperty("server_time")]
            public string ServerTime { get; set; }

            [JsonProperty("ack_time")]
            public string AckTime { get; set; }

            [JsonProperty("altitude")]
            public int Altitude { get; set; }

            [JsonProperty("course")]
            public double Course { get; set; }

            [JsonProperty("power")]
            public object Power { get; set; }

            [JsonProperty("address")]
            public object Address { get; set; }

            [JsonProperty("protocol")]
            public string Protocol { get; set; }

            [JsonProperty("latest_positions")]
            public string LatestPositions { get; set; }

            [JsonProperty("moved_at")]
            public string MovedAt { get; set; }

            [JsonProperty("stoped_at")]
            public string StopedAt { get; set; }

            [JsonProperty("engine_on_at")]
            public string EngineOnAt { get; set; }

            [JsonProperty("engine_off_at")]
            public string EngineOffAt { get; set; }

            [JsonProperty("engine_changed_at")]
            public string EngineChangedAt { get; set; }

            [JsonProperty("database_id")]
            public object DatabaseId { get; set; }
        }

        public class DeviceData
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("user_id")]
            public int UserId { get; set; }

            [JsonProperty("current_driver_id")]
            public object CurrentDriverId { get; set; }

            [JsonProperty("timezone_id")]
            public object TimezoneId { get; set; }

            [JsonProperty("traccar_device_id")]
            public int TraccarDeviceId { get; set; }

            [JsonProperty("icon_id")]
            public int IconId { get; set; }

            [JsonProperty("icon_colors")]
            public IconColors IconColors { get; set; }

            [JsonProperty("active")]
            public int Active { get; set; }

            [JsonProperty("deleted")]
            public int Deleted { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("imei")]
            public string Imei { get; set; }

            [JsonProperty("fuel_measurement_id")]
            public int FuelMeasurementId { get; set; }

            [JsonProperty("fuel_quantity")]
            public string FuelQuantity { get; set; }

            [JsonProperty("fuel_price")]
            public string FuelPrice { get; set; }

            [JsonProperty("fuel_per_km")]
            public string FuelPerKm { get; set; }

            [JsonProperty("sim_number")]
            public string SimNumber { get; set; }

            [JsonProperty("msisdn")]
            public object Msisdn { get; set; }

            [JsonProperty("device_model")]
            public string DeviceModel { get; set; }

            [JsonProperty("plate_number")]
            public string PlateNumber { get; set; }

            [JsonProperty("vin")]
            public string Vin { get; set; }

            [JsonProperty("registration_number")]
            public string RegistrationNumber { get; set; }

            [JsonProperty("object_owner")]
            public string ObjectOwner { get; set; }

            [JsonProperty("additional_notes")]
            public string AdditionalNotes { get; set; }

            [JsonProperty("expiration_date")]
            public object ExpirationDate { get; set; }

            [JsonProperty("sim_expiration_date")]
            public string SimExpirationDate { get; set; }

            [JsonProperty("sim_activation_date")]
            public string SimActivationDate { get; set; }

            [JsonProperty("installation_date")]
            public string InstallationDate { get; set; }

            [JsonProperty("tail_color")]
            public string TailColor { get; set; }

            [JsonProperty("tail_length")]
            public int TailLength { get; set; }

            [JsonProperty("engine_hours")]
            public string EngineHours { get; set; }

            [JsonProperty("detect_engine")]
            public string DetectEngine { get; set; }

            [JsonProperty("min_moving_speed")]
            public int MinMovingSpeed { get; set; }

            [JsonProperty("min_fuel_fillings")]
            public int MinFuelFillings { get; set; }

            [JsonProperty("min_fuel_thefts")]
            public int MinFuelThefts { get; set; }

            [JsonProperty("snap_to_road")]
            public int SnapToRoad { get; set; }

            [JsonProperty("gprs_templates_only")]
            public int GprsTemplatesOnly { get; set; }

            [JsonProperty("valid_by_avg_speed")]
            public int ValidByAvgSpeed { get; set; }

            [JsonProperty("parameters")]
            public string Parameters { get; set; }

            [JsonProperty("currents")]
            public object Currents { get; set; }

            [JsonProperty("created_at")]
            public string CreatedAt { get; set; }

            [JsonProperty("updated_at")]
            public string UpdatedAt { get; set; }

            [JsonProperty("forward")]
            public object Forward { get; set; }

            [JsonProperty("device_type_id")]
            public object DeviceTypeId { get; set; }

            [JsonProperty("stop_duration")]
            public string StopDuration { get; set; }

            [JsonProperty("pivot")]
            public Pivot Pivot { get; set; }

            [JsonProperty("traccar")]
            public Traccar Traccar { get; set; }

            [JsonProperty("icon")]
            public Icon Icon { get; set; }

            [JsonProperty("sensors")]
            public List<object> Sensors { get; set; }

            [JsonProperty("services")]
            public List<object> Services { get; set; }

            [JsonProperty("driver")]
            public object Driver { get; set; }

            [JsonProperty("lastValidLatitude")]
            public double LastValidLatitude { get; set; }

            [JsonProperty("lastValidLongitude")]
            public double LastValidLongitude { get; set; }

            [JsonProperty("latest_positions")]
            public string LatestPositions { get; set; }

            [JsonProperty("icon_type")]
            public string IconType { get; set; }

            [JsonProperty("group_id")]
            public int GroupId { get; set; }

            [JsonProperty("user_timezone_id")]
            public object UserTimezoneId { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("course")]
            public int Course { get; set; }

            [JsonProperty("speed")]
            public int Speed { get; set; }
        }

        public class Item
        {
            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("alarm")]
            public int Alarm { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("online")]
            public string Online { get; set; }

            [JsonProperty("time")]
            public string Time { get; set; }

            [JsonProperty("timestamp")]
            public int Timestamp { get; set; }

            [JsonProperty("acktimestamp")]
            public int Acktimestamp { get; set; }

            [JsonProperty("lat")]
            public double Lat { get; set; }

            [JsonProperty("lng")]
            public double Lng { get; set; }

            [JsonProperty("course")]
            public int Course { get; set; }

            [JsonProperty("speed")]
            public int Speed { get; set; }

            [JsonProperty("altitude")]
            public int Altitude { get; set; }

            [JsonProperty("icon_type")]
            public string IconType { get; set; }

            [JsonProperty("icon_color")]
            public string IconColor { get; set; }

            [JsonProperty("icon_colors")]
            public IconColors IconColors { get; set; }

            [JsonProperty("icon")]
            public Icon Icon { get; set; }

            [JsonProperty("power")]
            public string Power { get; set; }

            [JsonProperty("address")]
            public string Address { get; set; }

            [JsonProperty("protocol")]
            public string Protocol { get; set; }

            [JsonProperty("driver")]
            public string Driver { get; set; }

            [JsonProperty("driver_data")]
            public DriverData DriverData { get; set; }

            [JsonProperty("sensors")]
            public string Sensors { get; set; }

            [JsonProperty("services")]
            public string Services { get; set; }

            [JsonProperty("tail")]
            public string Tail { get; set; }

            [JsonProperty("distance_unit_hour")]
            public string DistanceUnitHour { get; set; }

            [JsonProperty("unit_of_distance")]
            public string UnitOfDistance { get; set; }

            [JsonProperty("unit_of_altitude")]
            public string UnitOfAltitude { get; set; }

            [JsonProperty("unit_of_capacity")]
            public string UnitOfCapacity { get; set; }

            [JsonProperty("stop_duration")]
            public string StopDuration { get; set; }

            [JsonProperty("stop_duration_sec")]
            public int StopDurationSec { get; set; }

            [JsonProperty("moved_timestamp")]
            public int MovedTimestamp { get; set; }

            [JsonProperty("engine_status")]
            public object EngineStatus { get; set; }

            [JsonProperty("detect_engine")]
            public string DetectEngine { get; set; }

            [JsonProperty("engine_hours")]
            public string EngineHours { get; set; }

            [JsonProperty("total_distance")]
            public double TotalDistance { get; set; }

            [JsonProperty("device_data")]
            public DeviceData DeviceData { get; set; }
        }

        public class Root
        {
            [JsonProperty("items")]
            public List<Item> Items { get; set; }

            [JsonProperty("events")]
            public List<object> Events { get; set; }

            [JsonProperty("time")]
            public int Time { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }
        }
    }
}
