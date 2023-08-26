--add primary key
alter table AdmissionRecords add primary key (AdmissionRecordID)
alter table Beds add primary key (BedNumber)
alter table Doctors add primary key (DoctorID)
alter table Patients add primary key (HealthNumber)
alter table Extras add primary key (PatientID, AdmissionRecordID)

--add foreign key
alter table AdmissionRecords add DoctorID nchar(4)
alter table Patients add foreign key (Doctor) references Doctors (DoctorID)
alter table AdmissionRecords add foreign key(PatientID) references Patients(HealthNumber)
alter table AdmissionRecords add foreign key(BedNumber) references Beds(BedNumber)
alter table AdmissionRecords add foreign key (DoctorID) references Doctors(DoctorID)
alter table Extras add foreign key (PatientID) references Patients(HealthNumber)
alter table Extras add foreign key (AdmissionRecordID) references AdmissionRecords (AdmissionRecordID)
--add check doctorID lengh
alter table Doctors add constraint CHK_DoctorID_Lengh check (datalength(DoctorID) >= 4) 

