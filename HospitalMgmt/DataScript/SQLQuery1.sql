CREATE TABLE [dbo].[Doctor] (
    [Doctor_Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Doctor_Name]           NVARCHAR (MAX) NULL,
    [Specialists]           NVARCHAR (MAX) NULL,
    [Availability]          NVARCHAR (MAX) NULL,
    [Patient_ID]            INT            NOT NULL,
    [Patient_objPatient_Id] INT            NULL,
    CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED ([Doctor_Id] ASC),
    CONSTRAINT [FK_Doctor_PatientDetails_Patient_objPatient_Id] FOREIGN KEY ([Patient_objPatient_Id]) REFERENCES [dbo].[PatientDetails] ([Patient_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Doctor_Patient_objPatient_Id]
    ON [dbo].[Doctor]([Patient_objPatient_Id] ASC);


    CREATE TABLE [dbo].[Appointments] (
    [Appointment_Id] INT            IDENTITY (1, 1) NOT NULL,
    [Patient_Name]   NVARCHAR (MAX) NULL,
    [Doctor_Name]    NVARCHAR (MAX) NULL,
    [Date]           DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Appointments] PRIMARY KEY CLUSTERED ([Appointment_Id] ASC)
);

CREATE TABLE [dbo].[PatientDetails] (
    [Patient_Id]                    INT            IDENTITY (1, 1) NOT NULL,
    [Patient_Name]                  NVARCHAR (MAX) NULL,
    [Patient_Address]               NVARCHAR (MAX) NULL,
    [Patient_Mobile]                NVARCHAR (MAX) NULL,
    [Patient_Email]                 NVARCHAR (MAX) NULL,
    [Patient_Age]                   NVARCHAR (MAX) NULL,
    [Appointments_ID]               INT            NOT NULL,
    [Appointment_objAppointment_Id] INT            NULL,
    CONSTRAINT [PK_PatientDetails] PRIMARY KEY CLUSTERED ([Patient_Id] ASC),
    CONSTRAINT [FK_PatientDetails_Appointments_Appointment_objAppointment_Id] FOREIGN KEY ([Appointment_objAppointment_Id]) REFERENCES [dbo].[Appointments] ([Appointment_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_PatientDetails_Appointment_objAppointment_Id]
    ON [dbo].[PatientDetails]([Appointment_objAppointment_Id] ASC);

CREATE TABLE [dbo].[Medicines] (
    [Medicine_Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Medicine_Name]       NVARCHAR (MAX) NULL,
    [Price]               NVARCHAR (MAX) NULL,
    [Quantity]            NVARCHAR (MAX) NULL,
    [Disease]             NVARCHAR (MAX) NULL,
    [Doctor_ID]           INT            NOT NULL,
    [Doctor_objDoctor_Id] INT            NULL,
    CONSTRAINT [PK_Medicines] PRIMARY KEY CLUSTERED ([Medicine_Id] ASC),
    CONSTRAINT [FK_Medicines_Doctor_Doctor_objDoctor_Id] FOREIGN KEY ([Doctor_objDoctor_Id]) REFERENCES [dbo].[Doctor] ([Doctor_Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_Medicines_Doctor_objDoctor_Id]
    ON [dbo].[Medicines]([Doctor_objDoctor_Id] ASC);

