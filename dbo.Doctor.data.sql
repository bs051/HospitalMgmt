SET IDENTITY_INSERT [dbo].[Doctor] ON
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (1, N'Parminder Singh', N'Heart Specialists', N'Morning', 2, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (2, N'Lilly', N'Cardiologists', N'Afternoon', 3, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (3, N'Jack', N'Urologists', N'Evening', 1, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (4, N'Thomas', N'Neurologists', N'Afternoon', 5, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (5, N'Keren', N'Psychiatrists', N'Evening', 6, NULL)
INSERT INTO [dbo].[Doctor] ([Doctor_Id], [Doctor_Name], [Specialists], [Availability], [Patient_ID], [Patient_objPatient_Id]) VALUES (6, N'Ammy', N'Cardiac Surgeons', N'Morning', 4, NULL)
SET IDENTITY_INSERT [dbo].[Doctor] OFF
