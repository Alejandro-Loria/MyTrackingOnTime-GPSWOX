using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyTrackingOnTime.Models
{
    public class AuthenticationModel
    {
        public class Login
        {
            [Required]
            public string email { get; set; }

            [Required]
            public string password { get; set; }
        }

        public class Token
        {
            public int status { get; set; }

            public string user_api_hash { get; set; }

        }

        public class Error
        {
            public int status { get; set; }

            public string message { get; set; }

        }

        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 
        public class Devices
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Alerts
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Geofences
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Routes
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Poi
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Reports
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class SmsGateway
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class SendCommand
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class History
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Maintenance
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Camera
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceCamera
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Tasks
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Chat
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceImei
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceSimNumber
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceForward
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceProtocol
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceExpirationDate
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceInstallationDate
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceSimActivationDate
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceSimExpirationDate
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceMsisdn
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceCustomFields
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceDeviceTypeId
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Sharing
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class ChecklistTemplate
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Checklist
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class ChecklistActivity
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class ChecklistQrCode
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class ChecklistQrPreStartOnly
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class ChecklistOptionalImage
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class DeviceConfiguration
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class CallActions
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class WidgetTemplateWebhook
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class CustomDeviceAdd
        {
            public bool view { get; set; }
            public bool edit { get; set; }
            public bool remove { get; set; }
        }

        public class Permissions
        {
            public Devices devices { get; set; }
            public Alerts alerts { get; set; }
            public Geofences geofences { get; set; }
            public Routes routes { get; set; }
            public Poi poi { get; set; }
            public Reports reports { get; set; }
            public SmsGateway sms_gateway { get; set; }
            public SendCommand send_command { get; set; }
            public History history { get; set; }
            public Maintenance maintenance { get; set; }
            public Camera camera { get; set; }
            public DeviceCamera device_camera { get; set; }
            public Tasks tasks { get; set; }
            public Chat chat { get; set; }

            [JsonProperty("device.imei")]
            public DeviceImei DeviceImei { get; set; }

            [JsonProperty("device.sim_number")]
            public DeviceSimNumber DeviceSimNumber { get; set; }

            [JsonProperty("device.forward")]
            public DeviceForward DeviceForward { get; set; }

            [JsonProperty("device.protocol")]
            public DeviceProtocol DeviceProtocol { get; set; }

            [JsonProperty("device.expiration_date")]
            public DeviceExpirationDate DeviceExpirationDate { get; set; }

            [JsonProperty("device.installation_date")]
            public DeviceInstallationDate DeviceInstallationDate { get; set; }

            [JsonProperty("device.sim_activation_date")]
            public DeviceSimActivationDate DeviceSimActivationDate { get; set; }

            [JsonProperty("device.sim_expiration_date")]
            public DeviceSimExpirationDate DeviceSimExpirationDate { get; set; }

            [JsonProperty("device.msisdn")]
            public DeviceMsisdn DeviceMsisdn { get; set; }

            [JsonProperty("device.custom_fields")]
            public DeviceCustomFields DeviceCustomFields { get; set; }

            [JsonProperty("device.device_type_id")]
            public DeviceDeviceTypeId DeviceDeviceTypeId { get; set; }
            public Sharing sharing { get; set; }
            public ChecklistTemplate checklist_template { get; set; }
            public Checklist checklist { get; set; }
            public ChecklistActivity checklist_activity { get; set; }
            public ChecklistQrCode checklist_qr_code { get; set; }
            public ChecklistQrPreStartOnly checklist_qr_pre_start_only { get; set; }
            public ChecklistOptionalImage checklist_optional_image { get; set; }
            public DeviceConfiguration device_configuration { get; set; }
            public CallActions call_actions { get; set; }
            public WidgetTemplateWebhook widget_template_webhook { get; set; }
            public CustomDeviceAdd custom_device_add { get; set; }
        }

        public class Root
        {
            public int status { get; set; }
            public string user_api_hash { get; set; }
            public Permissions permissions { get; set; }
        }
    }
}
