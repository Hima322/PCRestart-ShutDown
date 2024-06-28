<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <script src="https://code.jquery.com/jquery-3.6.0.min.js"></script>
    <script src="//code.jquery.com/ui/1.10.4/jquery-ui.js"></script>

    <title>PC Restart & Shutdown</title>
    <style>
        body {
            margin: 0;
            padding: 0;
            font-family: 'Franklin Gothic Medium', 'Arial Narrow', Arial, sans-serif;
            color: white;
            background: linear-gradient(270deg, #ff6b6b, #f7c94b, #4bc6f7, #6bff6b);
            background-size: 800% 800%;
            animation: backgroundAnimation 20s ease infinite;
        }

        .navbar {
            background-color: darkolivegreen;
            height: 10vh;
            display: flex;
            justify-content: center;
            align-items: center;
        }

        .button-container {
            display: flex;
            justify-content: center;
            margin-top: 2rem;
            padding: 10px;
        }

        .action-button {
            background-color: blue;
            color: white;
            border: none;
            padding: 1rem 2rem;
            font-size: large;
            cursor: pointer;
            margin: 0 1rem;
            transition: background-color 0.3s ease;
            border: 2px solid white;
            padding: 10px;
            border-radius: 25px;
        }

            .action-button:hover {
                background-color: darkblue;
            }

        .container {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-around;
        }

        .panel {
            width: 35%;
            border: 4px solid aqua;
            height: auto;
            margin: 1rem 0;
            padding: 1rem;
            box-sizing: border-box;
        }

            .panel h1 {
                color: black;
                text-align: center;
                font-family: 'Lucida Sans', 'Lucida Sans Regular', 'Lucida Grande', 'Lucida Sans Unicode', Geneva, Verdana, sans-serif;
                text-decoration: underline;
            }

        .multiplebutton-for-shutdown,
        .multiplebutton-for-restart {
            display: flex;
            flex-wrap: wrap;
            justify-content: center;
            gap: 10px;
            margin-top: 20px;
        }

        .action-button1 {
            background-color: darkcyan;
            color: white;
            border: none;
            padding: 10px 20px;
            font-size: large;
            cursor: pointer;
            transition: background-color 0.3s ease;
            border-radius: 25px;
        }

            .action-button1:hover {
                background-color: darkblue;
            }

        @media only screen and (max-width: 768px) {
            .navbar {
                height: auto;
                padding: 1rem;
            }

            .button-container {
                flex-direction: column;
                align-items: center;
            }

            .action-button {
                margin: 1rem 0;
            }

            .panel {
                width: 100%;
            }
        }
          @keyframes backgroundAnimation {
            0% {
                background-position: 0% 50%;
            }
            50% {
                background-position: 100% 50%;
            }
            100% {
                background-position: 0% 50%;
            }
        }
    </style>


</head>
<body>

    <form id="form1" runat="server">
        <div class="navbar">
            <h1>PC Restart & Shutdown</h1>
        </div>
        <div class="button-container">
            <button type="button" class="action-button" id="restart-button" onclick="restart()">RESTART</button>
            <button type="button" class="action-button" id="shutdown-button" onclick="shutdown()">SHUTDOWN</button>
            <button type="button" class="action-button" id="reload-button">RELOAD</button>

            <%--<button type="button" class="action-button" onclick="report()">Get Report</button>--%>
        </div>

        <div class="container">
            <div class="panel">
                <h1>ShutDown PC</h1>
                <div class="multiplebutton-for-shutdown">
                    <button type="button" class="action-button1" id="Station1" onclick="shutdownStation1()">STATION1</button>
                    <button type="button" class="action-button1" id="Station2" onclick="shutdownStation2()">STATION2</button>
                    <button type="button" class="action-button1" id="Station3" onclick="shutdownStation3()">STATION3</button>
                    <button type="button" class="action-button1" id="Station4" onclick="shutdownStation4()">STATION4</button>
                    <button type="button" class="action-button1" id="Station5" onclick="shutdownStation5()">STATION5</button>
                    <button type="button" class="action-button1" id="Station6" onclick="shutdownStation6()">STATION6</button>
                    <button type="button" class="action-button1" id="Station7" onclick="shutdownStation7()">STATION7</button>
                    <button type="button" class="action-button1" id="Station8" onclick="shutdownStation8()">STATION8</button>
                    <button type="button" class="action-button1" id="Station9" onclick="shutdownStation9()">STATION9</button>
                    <button type="button" class="action-button1" id="Station10" onclick="shutdownStation10()">STATION10</button>
                    <button type="button" class="action-button1" id="Station11" onclick="shutdownStation11()">STATION11</button>
                    <button type="button" class="action-button1" id="Station12" onclick="shutdownStation12()">STATION12</button>
                </div>
            </div>
            <div class="panel">
                <h1>Restart PC</h1>
                <div class="multiplebutton-for-restart">
                    <button type="button" class="action-button1" id="Station16" onclick="restartStation1()">STATION1</button>
                    <button type="button" class="action-button1" id="Station17" onclick="restartStation2()">STATION2</button>
                    <button type="button" class="action-button1" id="Station18" onclick="restartStation3()">STATION3</button>
                    <button type="button" class="action-button1" id="Station19" onclick="restartStation4()">STATION4</button>
                    <button type="button" class="action-button1" id="Station20" onclick="restartStation5()">STATION5</button>
                    <button type="button" class="action-button1" id="Station21" onclick="restartStation6()">STATION6</button>
                    <button type="button" class="action-button1" id="Station22" onclick="restartStation7()">STATION7</button>
                    <button type="button" class="action-button1" id="Station23" onclick="restartStation8()">STATION8</button>
                    <button type="button" class="action-button1" id="Station24" onclick="restartStation9()">STATION9</button>
                    <button type="button" class="action-button1" id="Station25" onclick="restartStation10()">STATION10</button>
                    <button type="button" class="action-button1" id="Station26" onclick="restartStation11()">STATION11</button>
                    <button type="button" class="action-button1" id="Station27" onclick="restartStation12()">STATION12</button>
                </div>
            </div>
        </div>




        <%-- <div class="dropdown-container">
            <label for="Dropdown-Model">Model: </label>
            <select id="Dropdown-Model" class="large-dropdown">
                <option value="" disabled selected>Select Model</option>
            </select>
            &ensp;
    <label for="Dropdown-Varient">Variant: </label>
            <select id="Dropdown-Varient" class="large-dropdown">
                <option value="" disabled selected>Select Variant</option>
            </select>
        </div>

        <label for="DateTime" id="Date">Date: </label>
        <input type="text" id="datepicker" class="datepicker">
        <button type="button" class="action-button" id="Download-REport" onclick="DownloadReport()">DownloadReport</button>--%>
    </form>
    <script>
        $(document).ready(function () {
            //GetModel();
            //$('#Dropdown-Model').change(function () {
            //    const selectedModel = $(this).val();
            //    if (selectedModel) {
            //        GetVariants(selectedModel);
            //    } else {
            //        $('#Dropdown-Varient').empty().append('<option value="">Select Variant</option>');
            //    }
            //});
        });
        function report() {
            window.open('Report1/Report.aspx', '_blank');
        }
        const restart = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/Restart",
                data: JSON.stringify({ ipAddresses: ["192.168.4.10", "192.168.4.11", "192.168.4.12", "192.168.4.13", "192.168.4.20", "192.168.4.21", "192.168.4.22", "192.168.4.23", , "192.168.4.30", "192.168.4.31", "192.168.4.32", "192.168.4.33"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const restartStation1 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION1",
                data: JSON.stringify({ ipAddresses: ["192.168.4.10"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const restartStation2 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION2",
                data: JSON.stringify({ ipAddresses: ["192.168.4.11"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const restartStation3 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION3",
                data: JSON.stringify({ ipAddresses: ["192.168.4.12"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation4 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION4",
                data: JSON.stringify({ ipAddresses: ["192.168.4.13"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation5 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION5",
                data: JSON.stringify({ ipAddresses: ["192.168.4.20"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation6 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION6",
                data: JSON.stringify({ ipAddresses: ["192.168.4.21"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation7 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION7",
                data: JSON.stringify({ ipAddresses: ["192.168.4.22"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation8 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION8",
                data: JSON.stringify({ ipAddresses: ["192.168.4.23"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation9 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION9",
                data: JSON.stringify({ ipAddresses: ["192.168.4.30"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation10 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION10",
                data: JSON.stringify({ ipAddresses: ["192.168.4.31"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation11 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION11",
                data: JSON.stringify({ ipAddresses: ["192.168.4.32"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const restartStation12 = () => {
            alert("Are you sure you want to restart the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/RestartSTATION12",
                data: JSON.stringify({ ipAddresses: ["192.168.4.33"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        //const DownloadReport = () => {
        //    if (confirm("Are you sure you want Download Report")) {
        //        $.ajax({
        //            type: "POST",
        //            url: "WebForm1.aspx/DOWNLOADREPORT",
        //            data: "",
        //            contentType: "application/json; charset=utf-8",
        //            dataType: "json",
        //            success: function (response) {
        //                let reportUrl = response.d;
        //                let a = document.createElement('a');
        //                a.href = reportUrl;
        //                a.download = 'report.pdf';
        //                document.body.appendChild(a);
        //                a.click();
        //                document.body.removeChild(a);
        //            },
        //            error: function (xhr, status, error) {
        //                console.log("Error: " + error);
        //            }
        //        });
        //    }
        //};


        //const GetModel = () => {
        //    $.ajax({
        //        type: "POST",
        //        url: "WebForm1.aspx/GetModels",
        //        data: "{}",
        //        contentType: "application/json; charset=utf-8",
        //        dataType: "json",
        //        success: function (response) {
        //            const models = response.d;
        //            const dropdown = $('#Dropdown-Model');
        //            dropdown.empty();
        //            dropdown.append('<option value="">Select Model</option>');
        //            models.forEach(model => {
        //                dropdown.append(`<option value="${model}">${model}</option>`);
        //            });
        //        },
        //        error: function (xhr, status, error) {
        //            console.log("Error: " + error);
        //        }
        //    });
        //};
        //const GetVariants = (model) => {
        //    $.ajax({
        //        type: "POST",
        //        url: "WebForm1.aspx/GetVariants",
        //        data: JSON.stringify({ model: model }),
        //        contentType: "application/json; charset=utf-8",
        //        dataType: "json",
        //        success: function (response) {
        //            const variants = response.d;
        //            const dropdown = $('#Dropdown-Varient');
        //            dropdown.empty();
        //            dropdown.append('<option value="">Select Variant</option>');
        //            variants.forEach(variant => {
        //                dropdown.append(`<option value="${variant}">${variant}</option>`);
        //            });
        //        },
        //        error: function (xhr, status, error) {
        //            console.log("Error: " + error);
        //        }
        //    });
        //};
        const shutdown = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/Shutdown",
                data: JSON.stringify({ ipAddresses: ["192.168.4.10", "192.168.4.11", "192.168.4.12", "192.168.4.13", "192.168.4.20", "192.168.4.21", "192.168.4.22", "192.168.4.23", , "192.168.4.30", "192.168.4.31", "192.168.4.32", "192.168.4.33"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };

        const shutdownStation1 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION1",
                data: JSON.stringify({ ipAddresses: ["192.168.4.10"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const shutdownStation2 = () => {
            if (confirm("Are you sure you want to shut down the PC?")) {
                $.ajax({
                    type: "POST",
                    url: "WebForm1.aspx/ShutdownSTATION2",
                    data: JSON.stringify({ ipAddresses: ["192.168.4.11"] }),
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    success: function (response) {
                        alert(response.d);
                    },
                    error: function (xhr, status, error) {
                        console.log("Error: " + error);
                    }
                });
            }
        };
        const shutdownStation3 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION3",
                data: JSON.stringify({ ipAddresses: ["192.168.4.12"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const shutdownStation4 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION4",
                data: JSON.stringify({ ipAddresses: ["192.168.4.13"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation5 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION5",
                data: JSON.stringify({ ipAddresses: ["192.168.4.20"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation6 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION6",
                data: JSON.stringify({ ipAddresses: ["192.168.4.21"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation7 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION7",
                data: JSON.stringify({ ipAddresses: ["192.168.4.22"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation8 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION7",
                data: JSON.stringify({ ipAddresses: ["192.168.4.23"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };

        const shutdownStation9 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION9",
                data: JSON.stringify({ ipAddresses: ["192.168.4.30"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });

        };
        const shutdownStation10 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION10",
                data: JSON.stringify({ ipAddresses: ["192.168.4.31"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation11 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION11",
                data: JSON.stringify({ ipAddresses: ["192.168.4.32"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const shutdownStation12 = () => {
            alert("Are you sure you want to shut down the PC?")
            $.ajax({
                type: "POST",
                url: "WebForm1.aspx/ShutdownSTATION12",
                data: JSON.stringify({ ipAddresses: ["192.168.4.33"] }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    alert(response.d);
                },
                error: function (xhr, status, error) {
                    console.log("Error: " + error);
                }
            });
        };
        const reload = () => {
            if (confirm("Are you sure you want to reload the application?")) {
                location.reload();
            }
        };


        $(document).ready(function () {
            $(".datepicker").datepicker();
        });
    </script>
</body>
</html>
