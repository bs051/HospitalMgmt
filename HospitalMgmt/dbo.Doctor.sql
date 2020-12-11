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

