CREATE PROCEDURE usp_AddAdmissionRecord
(@AdmissionRecordID nvarchar(30), @PatientID nvarchar(15),@BedNumber nvarchar(3), @SurgeryScheduled bit,
@AdmitDate datetime, @SurgeryDate datetime, @DischargeDate datetime, @DoctorID nchar(4)) 
AS
BEGIN TRANSACTION
SET @AdmitDate = GETDATE();
INSERT INTO AdmissionRecords
(AdmissionRecordID, PatientID, BedNumber, SurgeryScheduled, AdmitDate, SurgeryDate, DischargeDate, DoctorID)
VALUES
(@AdmissionRecordID, @PatientID, @BedNumber, @SurgeryScheduled, @AdmitDate, @SurgeryDate, @DischargeDate, @DoctorID)
COMMIT
SELECT @@IDENTITY AS 'New Admission ID'

