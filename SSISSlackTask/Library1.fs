namespace SSISSlackTask

open Microsoft.SqlServer.Dts.Runtime

[<DtsTask (DisplayName ="Slack Message", Description = "Send message to Slack webhook")>]
type SlackMessage() = 
    inherit Task()

    member this.Message = "F#"

    override this.InitializeTask
                    (connections: Connections, variableDispenser: VariableDispenser,
                     events : IDTSInfoEvents, log : IDTSLogging,
                     eventInfos : EventInfos, logEntryInfos: LogEntryInfos,
                     refTracker : ObjectReferenceTracker)  =
        
        ()

    override this.Validate(connections: Connections, variableDispenser: VariableDispenser,
                           componentEvents : IDTSComponentEvents, log : IDTSLogging) =

        DTSExecResult.Success

    override this.Execute(connections: Connections, variableDispenser: VariableDispenser,
                          componentEvents : IDTSComponentEvents, 
                          log : IDTSLogging, transaction : obj) =
        
        DTSExecResult.Success