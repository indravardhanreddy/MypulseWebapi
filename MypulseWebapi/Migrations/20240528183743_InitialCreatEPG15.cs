using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MypulseWebapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreatEPG15 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Specializations = table.Column<List<string>>(type: "text[]", nullable: false),
                    Cities = table.Column<List<string>>(type: "text[]", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Latitude = table.Column<string>(type: "text", nullable: false),
                    Longitude = table.Column<string>(type: "text", nullable: false),
                    FullAddress = table.Column<string>(type: "text", nullable: false),
                    Street = table.Column<string>(type: "text", nullable: false),
                    City = table.Column<string>(type: "text", nullable: false),
                    State = table.Column<string>(type: "text", nullable: false),
                    Country = table.Column<string>(type: "text", nullable: false),
                    PostalCode = table.Column<string>(type: "text", nullable: false),
                    District = table.Column<string>(type: "text", nullable: false),
                    Sublocality = table.Column<string>(type: "text", nullable: false),
                    Owner = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityManagers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "text", nullable: true),
                    PhoneNumberVerified = table.Column<bool>(name: "Phone_Number_Verified", type: "boolean", nullable: true),
                    Website = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailVerified = table.Column<bool>(name: "Email_Verified", type: "boolean", nullable: true),
                    Specializations = table.Column<List<string>>(type: "text[]", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    CognitoUserId = table.Column<string>(type: "text", nullable: true),
                    entityVerified = table.Column<bool>(type: "boolean", nullable: true),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false),
                    AvatarS3Key = table.Column<List<string>>(type: "text[]", nullable: true),
                    LocationId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityManagers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EntityManagers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Managers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Qualification = table.Column<string>(type: "text", nullable: true),
                    Specializations = table.Column<List<string>>(type: "text[]", nullable: true),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "text", nullable: true),
                    PhoneNumberVerified = table.Column<bool>(name: "Phone_Number_Verified", type: "boolean", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailVerified = table.Column<bool>(name: "Email_Verified", type: "boolean", nullable: true),
                    entityVerified = table.Column<bool>(type: "boolean", nullable: true),
                    AvatarS3Key = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    OfflineConsultationCharges = table.Column<int>(name: "Offline_Consultation_Charges", type: "integer", nullable: true),
                    RemoteConsultationCharges = table.Column<int>(name: "Remote_Consultation_Charges", type: "integer", nullable: true),
                    LocationId = table.Column<string>(type: "text", nullable: true),
                    managerLocationId = table.Column<string>(type: "text", nullable: true),
                    deleted = table.Column<bool>(name: "_deleted", type: "boolean", nullable: true),
                    AvailabilityJSON = table.Column<string>(type: "text", nullable: true),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: true),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: true),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: true),
                    CognitoUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Managers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Managers_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    About = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    PhoneNumber = table.Column<string>(name: "Phone_Number", type: "text", nullable: true),
                    PhoneNumberVerified = table.Column<bool>(name: "Phone_Number_Verified", type: "boolean", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    EmailVerified = table.Column<bool>(name: "Email_Verified", type: "boolean", nullable: true),
                    entityVerified = table.Column<bool>(type: "boolean", nullable: true),
                    AvatarS3Key = table.Column<List<string>>(type: "text[]", nullable: true),
                    KnownInterests = table.Column<List<string>>(type: "text[]", nullable: true),
                    Status = table.Column<bool>(type: "boolean", nullable: true),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: true),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: true),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: true),
                    userHealthInfoId = table.Column<string>(type: "text", nullable: true),
                    userLocationId = table.Column<string>(type: "text", nullable: true),
                    LocationId = table.Column<string>(type: "text", nullable: true),
                    City = table.Column<string>(type: "text", nullable: true),
                    Latitude = table.Column<string>(type: "text", nullable: true),
                    Longitude = table.Column<string>(type: "text", nullable: true),
                    CognitoUserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Expertise = table.Column<List<string>>(type: "text[]", nullable: true),
                    entityVerified = table.Column<bool>(type: "boolean", nullable: false),
                    Status = table.Column<bool>(type: "boolean", nullable: false),
                    EntityManagerId = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Department_EntityManagers_EntityManagerId",
                        column: x => x.EntityManagerId,
                        principalTable: "EntityManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    LicenseNumber = table.Column<string>(type: "text", nullable: false),
                    IssueDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Type = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    EntityManagerId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Licenses_EntityManagers_EntityManagerId",
                        column: x => x.EntityManagerId,
                        principalTable: "EntityManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityManagerManager",
                columns: table => new
                {
                    EntityManagersId = table.Column<string>(type: "text", nullable: false),
                    ManagersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityManagerManager", x => new { x.EntityManagersId, x.ManagersId });
                    table.ForeignKey(
                        name: "FK_EntityManagerManager_EntityManagers_EntityManagersId",
                        column: x => x.EntityManagersId,
                        principalTable: "EntityManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityManagerManager_Managers_ManagersId",
                        column: x => x.ManagersId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    AppointmentStartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    AppointmentEndTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Frequency = table.Column<int>(type: "integer", nullable: true),
                    Notes = table.Column<string>(type: "text", nullable: true),
                    AppMeetLink = table.Column<string>(type: "text", nullable: true),
                    MeetLink = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Scheduled = table.Column<bool>(type: "boolean", nullable: true),
                    AppointmentFees = table.Column<int>(type: "integer", nullable: true),
                    PaymentStatus = table.Column<string>(type: "text", nullable: true),
                    ManagerId = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: true),
                    EntityManagerId = table.Column<string>(type: "text", nullable: true),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: true),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: true),
                    AppointmentMode = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_EntityManagers_EntityManagerId",
                        column: x => x.EntityManagerId,
                        principalTable: "EntityManagers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Appointments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ChatSessions",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ManagerId = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    StartTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    IsManagerRead = table.Column<bool>(type: "boolean", nullable: false),
                    IsUserRead = table.Column<bool>(type: "boolean", nullable: false),
                    LastMessage = table.Column<string>(type: "text", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChatSessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ChatSessions_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChatSessions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EntityManagerUser",
                columns: table => new
                {
                    EntityManagersId = table.Column<string>(type: "text", nullable: false),
                    UsersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityManagerUser", x => new { x.EntityManagersId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_EntityManagerUser_EntityManagers_EntityManagersId",
                        column: x => x.EntityManagersId,
                        principalTable: "EntityManagers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EntityManagerUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HealthInfos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    BloodGroup = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    BloodPressure = table.Column<string>(type: "text", nullable: false),
                    SugarLevel = table.Column<int>(type: "integer", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false),
                    Owner = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HealthInfos_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerUser",
                columns: table => new
                {
                    ManagersId = table.Column<string>(type: "text", nullable: false),
                    UsersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManagerUser", x => new { x.ManagersId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_ManagerUser_Managers_ManagersId",
                        column: x => x.ManagersId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ManagerUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ManagerId = table.Column<string>(type: "text", nullable: false),
                    Role = table.Column<string>(type: "text", nullable: false),
                    Message = table.Column<string>(type: "text", nullable: false),
                    IsSeen = table.Column<bool>(type: "boolean", nullable: false),
                    Type = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_Managers_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Notifications_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentManager",
                columns: table => new
                {
                    DepartmentsId = table.Column<string>(type: "text", nullable: false),
                    ManagersId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentManager", x => new { x.DepartmentsId, x.ManagersId });
                    table.ForeignKey(
                        name: "FK_DepartmentManager_Department_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentManager_Managers_ManagersId",
                        column: x => x.ManagersId,
                        principalTable: "Managers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    ChatSessionId = table.Column<string>(type: "text", nullable: false),
                    SenderId = table.Column<string>(type: "text", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    createdAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    updatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    lastChangedAt = table.Column<long>(name: "_lastChangedAt", type: "bigint", nullable: false),
                    version = table.Column<int>(name: "_version", type: "integer", nullable: false),
                    typeName = table.Column<string>(name: "__typeName", type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Messages_ChatSessions_ChatSessionId",
                        column: x => x.ChatSessionId,
                        principalTable: "ChatSessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_EntityManagerId",
                table: "Appointments",
                column: "EntityManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_ManagerId",
                table: "Appointments",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatSessions_ManagerId",
                table: "ChatSessions",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ChatSessions_UserId",
                table: "ChatSessions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Department_EntityManagerId",
                table: "Department",
                column: "EntityManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentManager_ManagersId",
                table: "DepartmentManager",
                column: "ManagersId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityManagerManager_ManagersId",
                table: "EntityManagerManager",
                column: "ManagersId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityManagers_LocationId",
                table: "EntityManagers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_EntityManagerUser_UsersId",
                table: "EntityManagerUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_HealthInfos_UserId",
                table: "HealthInfos",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Licenses_EntityManagerId",
                table: "Licenses",
                column: "EntityManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Managers_LocationId",
                table: "Managers",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_ManagerUser_UsersId",
                table: "ManagerUser",
                column: "UsersId");

            migrationBuilder.CreateIndex(
                name: "IX_Messages_ChatSessionId",
                table: "Messages",
                column: "ChatSessionId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_ManagerId",
                table: "Notifications",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_UserId",
                table: "Notifications",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_LocationId",
                table: "Users",
                column: "LocationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Configurations");

            migrationBuilder.DropTable(
                name: "DepartmentManager");

            migrationBuilder.DropTable(
                name: "EntityManagerManager");

            migrationBuilder.DropTable(
                name: "EntityManagerUser");

            migrationBuilder.DropTable(
                name: "HealthInfos");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "ManagerUser");

            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "ChatSessions");

            migrationBuilder.DropTable(
                name: "EntityManagers");

            migrationBuilder.DropTable(
                name: "Managers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Locations");
        }
    }
}
