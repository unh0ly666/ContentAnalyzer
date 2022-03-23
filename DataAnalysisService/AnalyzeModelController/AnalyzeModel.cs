﻿using Interfaces;

namespace DataAnalysisService.AnalyzeModelController;

public abstract class AnalyzeModel : IAnalyzeModel
{
    protected PythonRunner Runner;
    protected readonly string Interpreter;
    protected readonly string PredictScript;
    protected readonly string TrainScript;
    protected readonly string DataSet;
    protected readonly string Model;

    protected delegate void OnErrorArrived(string errorText);
    protected delegate void OnPredictArrived(PredictResult warningText);

    protected OnErrorArrived OnErrorArrivedEvent;
    protected OnPredictArrived OnPredictResultArrivedEvent;
    protected OnPredictArrived OnEvaluateResultArrivedEvent;

    protected string[] Categories { get; }
    public abstract bool IsRunning { get; protected set; }

    protected AnalyzeModel(string interpreter, string predictScript, string trainScript, string dataSet, string model, string[] categories)
    {
        Interpreter = Path.GetFullPath(interpreter);
        PredictScript = Path.GetFullPath(predictScript);
        TrainScript = Path.GetFullPath(trainScript);
        DataSet = Path.GetFullPath(dataSet);
        Model = Path.GetFullPath(model);
        Categories = categories;
    }
    public void Subscribe(Action<PredictResult> predictionResultHandler, Action<PredictResult> evaluateResultHandler, Action<string> errorHandler)
    {
        OnErrorArrivedEvent += errorHandler.Invoke;
        OnPredictResultArrivedEvent += predictionResultHandler.Invoke;
        OnEvaluateResultArrivedEvent += evaluateResultHandler.Invoke;
    }

    public abstract void StartPredictiveListenerScriptAsync();

    public abstract void StartTrainModelScriptAsync();

    public abstract void Predict(ICommentData text);

    public abstract void AbortScript();
}