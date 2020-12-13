SET IDENTITY_INSERT [dbo].[Medicines] ON
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (1, N'Anticoagulants', N'$79', N'15 Boxes', N'Stroke', 30, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (2, N'Nebulizer', N'$210', N'23 Boxes', N'Trachea', 31, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (3, N'Isoniazid', N'$85', N' 5 Boxes', N'Tuberculosis', 32, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (5, N'Paracetamol', N'$23', N'1 Box', N'Fever', 33, NULL)
INSERT INTO [dbo].[Medicines] ([Medicine_Id], [Medicine_Name], [Price], [Quantity], [Disease], [Doctor_ID], [Doctor_objDoctor_Id]) VALUES (6, N'Eplerenone', N'$33', N'3 Boxes', N'Heart Disease', 34, NULL)
SET IDENTITY_INSERT [dbo].[Medicines] OFF
