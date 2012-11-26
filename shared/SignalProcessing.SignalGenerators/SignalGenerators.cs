using System;
using System.Collections.Generic;

namespace SignalProcessing.SignalGenerators
{
    //using CommonFunctions;

    public struct SamplePoint
    {
        public readonly long Timestamp;
        public readonly double Value;

        public SamplePoint(long timestamp, double value)
        {
            this.Timestamp = timestamp;
            this.Value = value;
        }
    }

    // ********************************************************
    // ********************************************************

    public class SignalVector
    {
        #region backing_data_fields

        private ISignal signal;
        private INoise noise;
        private readonly SamplePoint[] samplePoints;

        #endregion

        // ====================================================

        #region constructors

        public SignalVector(ISignal signal, SamplePoint[] samplePoints)
        {
            this.signal = signal;
            this.samplePoints = samplePoints;
        }

        public SignalVector(ISignal signal, SamplePoint[] samplePoints, INoise noise) 
            : this(signal, samplePoints)
        {
            this.noise = noise;
        }

        #endregion

        // ====================================================

        #region properties

        public SamplePoint[] SamplePoints
        {
            get { return this.samplePoints; }
        }

        #endregion

    }

    // ********************************************************
    // ********************************************************

    public enum NoiseKind
    {
        WhiteNoise,
        PinkNoise,
        RedNoise,
    }

    // ********************************************************
    // ********************************************************

    public interface INoiseKind
    {
        NoiseKind Kind { get; }
    }

    // ********************************************************
    // ********************************************************

    public enum SignalKind
    {
        Sinus,
        Triangular,
        Rectangular,
        Sawtooth,
    }

    // ********************************************************
    // ********************************************************

    public abstract class NoiseBase : INoise, IDisposable
    {
        private bool disposed;
        protected readonly double amplitude;
        protected readonly DateTime t0;
        protected readonly NoiseKind kind;
        protected SamplePoint[] values;
        
        protected NoiseBase(ICommonNoiseParams commonNoiseParams)
        {
            this.disposed = false;
            this.amplitude = commonNoiseParams.Amplitude;
            this.t0 = commonNoiseParams.T0;
        }

        protected NoiseBase(double amplitude, double frequency, double phase, DateTime t0)
        {
            this.disposed = false;
            this.amplitude = amplitude;
            this.t0 = t0;
        }

        ~NoiseBase()
        {
            this.Dispose(false);
        }

        public Double Amplitude
        {
            get { return this.amplitude; }
        }

        public DateTime T0
        {
            get { return this.t0; }
        }

        public NoiseKind Kind
        {
            get { return this.kind; }
        }

        public SamplePoint[] Values
        {
            get { return this.values; }
        }

        /// <exception cref="NotImplementedException"></exception>
        public void Generate(ulong samples)
        {
            TraceLog.AddLogItem(this.GetHashCode(), "NoiseBase.Generate(" + samples.ToString() + ") : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
            throw new NotImplementedException();
        }
        
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.values = null;
                TraceLog.AddLogItem(this.GetHashCode(), "NoiseBase.Dispose(true) : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
            }
            else
            {
                TraceLog.AddLogItem(this.GetHashCode(), "NoiseBase.Dispose(false) : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
            }

            this.disposed = true;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
            TraceLog.AddLogItem(this.GetHashCode(), "NoiseBase.Dispose() : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
        }
    }

    // ********************************************************
    // ********************************************************

    public interface ICommonNoiseParams
    {
        double Amplitude { get; }

        DateTime T0 { get; }
    }


    // ********************************************************
    // ********************************************************

    public interface INoise : ICommonNoiseParams, INoiseKind
    {
        SamplePoint[] Values{ get; }

        void Generate(ulong samples);
    }

    // ********************************************************
    // ********************************************************
    
    public interface ICommonSignalParams
    {
        double Amplitude { get; }

        double Frequency { get; }

        double Phase { get; }

        DateTime T0 { get; }
    }

    // ********************************************************
    // ********************************************************

    public interface ISignal : ICommonSignalParams, ISignalKind
    {
        SamplePoint[] Values{ get; }

        SamplePoint[] Generate(double samplingRate, ulong samples);
    }

    // ********************************************************
    // ********************************************************

    public interface ISignalKind
    {
        SignalKind Kind { get; }
    }

    // ********************************************************
    // ********************************************************

    public sealed class SignalGeneratedEventArgs : EventArgs
    {
        
    }

    // ********************************************************
    // ********************************************************

    public abstract class SignalBase : ISignal, IDisposable
    {
        #region backing_data_fields

        private bool disposed;
        protected readonly double amplitude;
        protected readonly double frequency;
        protected readonly double phase;
        protected readonly DateTime t0;
        protected SignalKind kind;
        protected SamplePoint[] values;

        public event EventHandler<SignalGeneratedEventArgs> SignalGenerated; 

        #endregion

        // ====================================================

        #region properties

        public double Amplitude
        {
            get { return this.amplitude; }
        }

        // -----------------

        public double Frequency
        {
            get { return this.frequency; }
        }

        // -----------------

        public double Phase
        {
            get { return this.phase; }
        }

        // -----------------

        public DateTime T0
        {
            get { return this.t0; }
        }

        // -----------------
            
        public SamplePoint[] Values
        {
            get { return this.values; }
        }

        // -----------------

        public SignalKind Kind
        {
            get { return this.kind; }
        }

        #endregion

        // ====================================================

        #region constructors

        protected SignalBase(ICommonSignalParams commonSignalParams)
        {
            this.amplitude = commonSignalParams.Amplitude;
            this.frequency = commonSignalParams.Frequency;
            this.phase = commonSignalParams.Phase;
            this.t0 = commonSignalParams.T0; 
            TraceLog.AddLogItem(this.GetHashCode(), string.Format("SignalBase.ctor({0}) : void", commonSignalParams), true, String.Empty, CommonDefines.TraceCategoryInfo);
        }

        protected SignalBase(double amplitude, double frequency, double phase, DateTime t0)
        {
            this.amplitude = amplitude;
            this.frequency = frequency;
            this.phase = phase;
            this.t0 = t0;
            TraceLog.AddLogItem(this.GetHashCode(), string.Format("SignalBase.ctor({0}, {1}, {2}, {3}) : void", amplitude, frequency, phase, t0), true, String.Empty, CommonDefines.TraceCategoryInfo);
        }

        #endregion

        // ====================================================

        #region finalizer

        ~SignalBase()
        {
            this.Dispose(false);
            TraceLog.AddLogItem(this.GetHashCode(), "SignalBase.finalizer()", true, String.Empty, CommonDefines.TraceCategoryInfo);
        }

        #endregion

        // ====================================================

        #region private_methods

        #endregion

        // ====================================================

        #region protected_methods
        
        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                TraceLog.AddLogItem(this.GetHashCode(), string.Format("SignalBase.Dispose({0}) : void", disposing), true, String.Empty, CommonDefines.TraceCategoryInfo);
                return;
            }

            if (disposing)
            {
                this.SignalGenerated = null;
                TraceLog.AddLogItem(this.GetHashCode(), "SignalBase.Dispose(true) : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
            }
            else
            {
                TraceLog.AddLogItem(this.GetHashCode(), "SignalBase.Dispose(false) : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
            }

            this.disposed = true;
        }

        // -----------------

        protected virtual void OnSignalGenerated(SignalGeneratedEventArgs e)
        {
            if (this.SignalGenerated != null)
            {
                this.SignalGenerated(this, e);
            }
        }

        #endregion

        // ====================================================

        #region public_methods

        public abstract SamplePoint[] Generate(double samplingRate, ulong samples);

        #endregion
        
        // ====================================================

        #region IDisposable

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
            TraceLog.AddLogItem(this.GetHashCode(), "SignalBase.Dispose() : void", true, String.Empty, CommonDefines.TraceCategoryInfo);
        }
        
        #endregion
    }

    // ********************************************************
    // ********************************************************

    public class SinusSignal : SignalBase
    {
        #region backing_data_fields

        private bool disposed;

        #endregion

        // ====================================================

        #region constructors

        public SinusSignal(ICommonSignalParams commonSignalParams) 
            : base(commonSignalParams)
        {
            this.disposed = false;
            this.kind = SignalKind.Sinus;
        }

        public SinusSignal(double amplitude, double frequency, double phase, DateTime t0) 
            : base(amplitude, frequency, phase, t0)
        {
            this.disposed = false;
            this.kind = SignalKind.Sinus;
        }

        #endregion

        // ====================================================

        #region pulbic_methods

        public override SamplePoint[] Generate(double samplingRate, ulong samples)
        {
            double samplingPeriod = 1.0/samplingRate;
            double period = 1.0/this.Frequency;
            SamplePoint[] samplePoints = new SamplePoint[samples];
            for (ulong sampleIndex = 0; sampleIndex < samples; sampleIndex++)
            {
                double scaledValue = this.Amplitude*Math.Sin(2*Math.PI*(1.0/period*samplingPeriod)*sampleIndex);
                samplePoints[sampleIndex] = new SamplePoint(DateTime.Now.ToBinary(), scaledValue);
            }
            
            return samplePoints;
        }

        #endregion

        // ====================================================

        #region private_methods

        protected override void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if (disposing)
            {
                this.disposed = true;
            }

            base.Dispose(disposing);
        }

        #endregion
    }

    // ********************************************************
    // ********************************************************

    public sealed class SignalGenerator : IDisposable
    {
        #region backing_Data_fields

        private bool disposed;
        private ISignal signal;
        private readonly double samplingRate;

        #endregion

        // ====================================================

        #region properties

        #endregion

        // ====================================================

        #region constructors

        public SignalGenerator(ISignal signal, double samplingRate)
        {
            this.disposed = false;
            this.signal = signal;
            this.samplingRate = samplingRate;
        }

        #endregion

        // ====================================================

        #region finalizer
        
        ~SignalGenerator()
        {
            this.Dispose(false);
        }

        #endregion
        
        // ====================================================

        #region private_methods

        private void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                return;
            }

            if(disposing)
            {
                this.signal = null;
            }

            // dispose unmanaged resources here
            this.disposed = true;
        }

        #endregion

        // ====================================================

        #region public_methods

        public SignalVector GenerateSignal(ulong samples)
        {
            SamplePoint[] signalValues = signal.Generate(this.samplingRate, samples);
            SignalVector sinusVector = new SignalVector(signal, signalValues);

            return sinusVector;
        }

        // ---------------------

        public SamplePoint[] GenerateNoise(INoise noise, ulong samples)
        {
            throw new NotImplementedException();
        }

        // ---------------------

        public SamplePoint[] SuperposeSignals(ISignal signal1, ISignal signal2, ulong samples)
        {
            throw new NotImplementedException();
        }

        public SamplePoint[] SuperposeSignals(IEnumerable<ISignal> signals, ulong samples)
        {
            throw new NotImplementedException();
        }

        // ---------------------

        public SamplePoint[] AddNoise(SamplePoint[] signalVector, INoise noise)
        {
            throw new NotImplementedException();
        }

        public SamplePoint[] AddNoise(IEnumerable<SamplePoint[]> signalVectors, INoise noise)
        {
            throw new NotImplementedException();
        }


        #endregion

        // ====================================================
        
        #region IDisposable

        public void Dispose()
        {
            GC.SuppressFinalize(this);
            this.Dispose(true);
        }

        #endregion
    }

    // ********************************************************
    // ********************************************************
}

    