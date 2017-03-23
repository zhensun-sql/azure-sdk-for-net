// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Information about a start task running on a compute node.
    /// </summary>
    public partial class StartTaskInformation
    {
        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        public StartTaskInformation() { }

        /// <summary>
        /// Initializes a new instance of the StartTaskInformation class.
        /// </summary>
        /// <param name="state">The state of the start task on the compute
        /// node.</param>
        /// <param name="startTime">The time at which the start task started
        /// running.</param>
        /// <param name="retryCount">The number of times the task has been
        /// retried by the Batch service.</param>
        /// <param name="endTime">The time at which the start task stopped
        /// running.</param>
        /// <param name="exitCode">The exit code of the program specified on
        /// the start task command line.</param>
        /// <param name="schedulingError">Any error encountered scheduling the
        /// start task.</param>
        /// <param name="lastRetryTime">The most recent time at which a retry
        /// of the task started running.</param>
        public StartTaskInformation(StartTaskState state, System.DateTime startTime, int retryCount, System.DateTime? endTime = default(System.DateTime?), int? exitCode = default(int?), TaskSchedulingError schedulingError = default(TaskSchedulingError), System.DateTime? lastRetryTime = default(System.DateTime?))
        {
            State = state;
            StartTime = startTime;
            EndTime = endTime;
            ExitCode = exitCode;
            SchedulingError = schedulingError;
            RetryCount = retryCount;
            LastRetryTime = lastRetryTime;
        }

        /// <summary>
        /// Gets or sets the state of the start task on the compute node.
        /// </summary>
        /// <remarks>
        /// running - The start task is currently running. completed - The
        /// start task has exited with exit code 0, or the start task has
        /// failed and the retry limit has reached, or the start task process
        /// did not run due to scheduling errors. Possible values include:
        /// 'running', 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public StartTaskState State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task started running.
        /// </summary>
        /// <remarks>
        /// This value is reset every time the task is restarted or retried
        /// (that is, this is the most recent time at which the start task
        /// started running).
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "startTime")]
        public System.DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the time at which the start task stopped running.
        /// </summary>
        /// <remarks>
        /// This is the end time of the most recent run of the start task, if
        /// that run has completed (even if that run failed and a retry is
        /// pending). This element is not present if the start task is
        /// currently running.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endTime")]
        public System.DateTime? EndTime { get; set; }

        /// <summary>
        /// Gets or sets the exit code of the program specified on the start
        /// task command line.
        /// </summary>
        /// <remarks>
        /// This property is set only if the start task is in the completed
        /// state. In general, the exit code for a process reflects the
        /// specific convention implemented by the application developer for
        /// that process. If you use the exit code value to make decisions in
        /// your code, be sure that you know the exit code convention used by
        /// the application process. However, if the Batch service terminates
        /// the start task (due to timeout, or user termination via the API)
        /// you may see an operating system-defined exit code.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitCode")]
        public int? ExitCode { get; set; }

        /// <summary>
        /// Gets or sets any error encountered scheduling the start task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "schedulingError")]
        public TaskSchedulingError SchedulingError { get; set; }

        /// <summary>
        /// Gets or sets the number of times the task has been retried by the
        /// Batch service.
        /// </summary>
        /// <remarks>
        /// The task is retried if it exits with a nonzero exit code, up to the
        /// specified MaxTaskRetryCount.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "retryCount")]
        public int RetryCount { get; set; }

        /// <summary>
        /// Gets or sets the most recent time at which a retry of the task
        /// started running.
        /// </summary>
        /// <remarks>
        /// This element is present only if the task was retried (i.e.
        /// retryCount is nonzero). If present, this is typically the same as
        /// startTime, but may be different if the task has been restarted for
        /// reasons other than retry; for example, if the compute node was
        /// rebooted during a retry, then the startTime is updated but the
        /// lastRetryTime is not.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastRetryTime")]
        public System.DateTime? LastRetryTime { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.SchedulingError != null)
            {
                this.SchedulingError.Validate();
            }
        }
    }
}