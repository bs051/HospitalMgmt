 SET IDENTITY_INSERT [dbo].[PatientDetails] ON
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (1, N'Arun', N'1/204 old farm road', N'0221364953', N'arun134@gmail.com', N'23', 1, NULL)
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (2, N'Rahul', N'6/9 maitland street', N'0223451567', N'rahul567@gmail.com', N'78', 2, NULL)
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (3, N'Malisha', N'2 mahui street terapa', N'022 4569807', N'malisha5675@gamil.com', N'26', 3, NULL)
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (4, N'David', N'8 glennis Place Frankton', N'0223451324', N'david23@!gmail.com', N'34', 4, NULL)
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (5, N'Gurpreet', N'6 Bryce street Hmailton Central', N'0223445677', N'Guri@#$123@gmail.com', N'56', 5, NULL)
INSERT INTO [dbo].[PatientDetails] ([Patient_Id], [Patient_Name], [Patient_Address], [Patient_Mobile], [Patient_Email], [Patient_Age], [Appointments_ID], [Appointment_objAppointment_Id]) VALUES (6, N'Maninder', N'8 Great south road Huntly', N'0223457789', N'Mani34567@gmail.com', N'45', 6, NULL)
SET IDENTITY_INSERT [dbo].[PatientDetails] OFF

SET IDENTITY_INSERT [dbo].[Medicines] ON
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (1, N'Anticoagulants', N'$79', N'15 Boxes', N'Stroke', 30, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (2, N'Nebulizer', N'$210', N'23 Boxes', N'Trachea', 31, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (3, N'Isoniazid', N'$85', N' 5 Boxes', N'Tuberculosis', 32, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (5, N'Paracetamol', N'$23', N'1 Box', N'Fever', 33, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (6, N'Eplerenone', N'$33', N'3 Boxes', N'Heart Disease', 34, NULL)
SET IDENTITY_INSERT [dbo].[Medicines] OFF

SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (1, N'Parminder Singh', N'Heart Specialists', N'Morning', 2, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (2, N'Lilly', N'Cardiologists', N'Afternoon', 3, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (3, N'Jack', N'Urologists', N'Evening', 1, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (4, N'Thomas', N'Neurologists', N'Afternoon', 5, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (5, N'Keren', N'Psychiatrists', N'Evening', 6, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (6, N'Ammy', N'Cardiac Surgeons', N'Morning', 4, NULL)
SET IDENTITY_INSERT [dbo].[Doctor] OFF

SET IDENTITY_INSERT [dbo].[Appointments] ON
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (1, N'Rohan', N'Parminder Singh', N'2020-12-13 09:38:00')
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (2, N'Sandeep', N'Jack', N'2020-12-14 09:40:00')
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (3, N'Berlin', N'Lilly', N'2020-12-14 11:40:00')
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (4, N'James', N'Ammy', N'2020-12-15 02:41:00')
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (5, N'Rock', N'Thomas', N'2020-12-16 03:42:00')
INSERT INTO [dbo].[Appointments] ([Appointment_Id], [Patient_Name], [Doctor_Name], [Date]) VALUES (6, N'Mandeep', N'keren', N'2020-12-17 03:43:00')
SET IDENTITY_INSERT [dbo].[Appointments] OFF
