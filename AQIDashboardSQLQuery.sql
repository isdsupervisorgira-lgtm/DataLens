CREATE DATABASE DataLensDB
GO

Use DataLensDB
GO

CREATE TABLE AQIHourlyData (
    -- 🔑 Primary Key
    ID                      INT IDENTITY(1,1)   PRIMARY KEY,

    -- 📍 Station Info
    StnCode                 VARCHAR(20)         NOT NULL,   -- Station Code

    -- 📅 Date & Time
    Dtl_Date                DATE                NOT NULL,   -- Reading Date
    Testing_Time            TIME(0)             NOT NULL,   -- Hourly Time Slot

    -- 🧪 Pollutants
    SO2                     DECIMAL(10,2)       NULL,       -- Sulphur Dioxide (µg/m³)
    NOx                     DECIMAL(10,2)       NULL,       -- Nitrogen Oxides (µg/m³)
    CO                      DECIMAL(10,2)       NULL,       -- Carbon Monoxide (mg/m³)
    PM2_5                   DECIMAL(10,2)       NULL,       -- Fine Particles (µg/m³)
    PM10                    DECIMAL(10,2)       NULL,       -- Coarse Particles (µg/m³)

    -- 🌬️ Wind
    Wind_Speed              DECIMAL(6,2)        NULL,       -- Wind Speed (km/h or m/s)
    Wind_Direction          VARCHAR(10)         NULL,       -- e.g. N, NE, SW

    -- 🌡️ Weather
    Ambient_Temperature     DECIMAL(5,2)        NULL,       -- Temperature (°C)
    Relative_Humidity       DECIMAL(5,2)        NULL,       -- Humidity (%)
    Rain_Fall               DECIMAL(6,2)        NULL,       -- Rainfall (mm)
    Solar_Radiation         DECIMAL(8,2)        NULL,       -- Solar Radiation (W/m²)
    Atmospheric_Pressure    DECIMAL(8,2)        NULL,       -- Pressure (hPa or mmHg)

    -- 🕒 Audit Columns
    CreatedAt               DATETIME            DEFAULT GETDATE(),
    UpdatedAt               DATETIME            NULL
);

INSERT INTO AQIHourlyData 
(
    StnCode, Dtl_Date, Testing_Time, SO2, NOx, CO, PM2_5, PM10, 
    Wind_Speed, Wind_Direction, Ambient_Temperature, 
    Relative_Humidity, Rain_Fall, Solar_Radiation, Atmospheric_Pressure
)
VALUES
(34, '2026-05-25', '06:00:26', 13.5,  9.42, 0.98, 19.0, 9,  0.82, 267.52, 29.64, 80.81, 7.62,  0.02,   1005.05),
(34, '2026-05-25', '07:00:27', 13.3, 10.2,  0.95, 12.4, 15, 1.89, 266.78, 31.04, 70.22, 0.52,  125.69, 1005.8 ),
(34, '2026-05-25', '08:00:28', 11.7,  9.35, 0.98, 17.4, 14, 1.04, 270.00, 34.46, 59.17, 0,     308.59, 1006.35),
(34, '2026-05-25', '09:00:29', 12.0,  9.54, 0.99, 11.5, 21, 0.81,   1.45, 34.91, 57.63, 0,     435.32, 1006.75),
(34, '2026-05-25', '10:00:00', 13.5, 10.01, 0.98, 12.8, 34, 0.96, 247.16, 34.53, 56.83, 0,     630.26, 1007.08),
(34, '2026-05-25', '11:00:01', 12.6,  9.69, 0.98, 18.4, 40, 0.61, 320.20, 35.27, 59.18, 0,     647.19, 1006.81),
(34, '2026-05-25', '12:00:02', 12.5,  9.69, 0.83, 18.0, 40, 0.51, 275.36, 35.32, 57.87, 0,     715.98, 1006.32),
(34, '2026-05-25', '13:00:03', 11.3,  9.64, 0.76, 18.8, 19, 2.10, 282.39, 35.63, 55.02, 0,     727.00, 1005.46),
(34, '2026-05-25', '14:00:04', 11.0,  9.78, 0.67, 11.8, 28, 0.59, 252.44, 35.62, 54.19, 0,     671.35, 1004.67),
(34, '2026-05-25', '15:00:06', 12.3,  8.83, 0.72,  8.7, 27, 2.64, 262.61, 36.13, 54.56, 0,     573.78, 1003.81),
(34, '2026-05-25', '16:00:06', 12.2,  9.05, 0.71, 15.6, 34, 0.56, 308.70, 35.80, 57.47, 0,     438.74, 1003.00),
(34, '2026-05-25', '16:51:37', 12.4,  8.76, 0.71, 13.2, 34, 0.88, 267.00, 34.78, 60.20, 0,     312.38, 1002.89);