﻿using BottomTimeDives.Enums;
using BottomTimeDives.Models;
using System;

namespace BottomTimeDivesTests.Data.MockData {
	public class MockDive : Dive {
		public MockDive() {
			Id = 342;
			Number = 79;
			Location = "Anacapa; CA; USA";
			DiveSite = "Underwater Island";
			DiveStartTime = new DateTime(2021, 12, 30, 8, 0, 0, DateTimeKind.Utc);
			DiveEndTime = new DateTime(2021, 12, 30, 8, 30, 0, DateTimeKind.Utc);
			StartAirPressure = 2600;
			EndAirPressure = 1000;
			PressureType = PressureType.Psi;
			WetSuitType = WetSuitType.Full;
			WetSuitThickness = 7;
			MaxDepth = 51;
			AvgDepth = 34;
			SafetyStopTime = new TimeSpan(0, 3, 0);
			WaterTemperature = 61;
			TemperatureType = TemperatureType.Fahrenheit;
			Visibility = 20;
			VisibilityType = VisibilityType.Feet;
			Weight = 18;
			WeightType = WeightType.Pounds;
			TankSize = 80;
			TankType = TankType.HighPressureSteel;
			TankPressureType = TankPressureType.CubicFeet;
			DiveComments = "This was a really cool dive!";
			DiveBuddy = "Test diver";
			DiveBuddyCertificationNumber = "TEST001";
			DiveBuddyCertificationType = DiveBuddyCertificationType.PADI;
		}
	}
}
