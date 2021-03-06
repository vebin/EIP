using System.Collections.Generic;
using System.Threading.Tasks;
using EIP.Common.Business;
using EIP.Common.Entities;
using EIP.Workflow.Models.Dtos.Engine;
using EIP.Workflow.Models.Entities;

namespace EIP.Workflow.Business.Config
{
    public interface IWorkflowProcessInstanceActivityLogic : IAsyncLogic<WorkflowProcessInstanceActivity>
    {
        /// <summary>
        ///     获取下一步所有活动
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IEnumerable<WorkflowEngineNextActivitysDoubleWay>> GetWorkflowEngineNextActivitysDoubleWay(
            WorkflowEngineRunnerInput input);

        /// <summary>
        /// 获取活动监控数据
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<IEnumerable<WorkflowEngineTrackActivityOutput>> GetWorkflowEngineTrackActivityOutput(
            WorkflowEngineRunnerInput input);

        /// <summary>
        ///     更新活动状态
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<OperateStatus> UpdateActivityMarked(WorkflowEngineActivityOrLineMarkedInput input);

        /// <summary>
        ///     获取处理任务信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<WorkflowEngineDealWithTaskOutput> GetWorkflowEngineDealWithTaskOutput(WorkflowEngineRunnerInput input);

        /// <summary>
        ///     获取处理任务信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<WorkflowProcessInstanceActivity> GetProcessInstanceActivityByActivityIdAndProcessInstanceId(WorkflowEngineRunnerInput input);
    }
}