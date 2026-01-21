using System.Runtime.Serialization;

namespace BerryAIGC.Civitai.Models;

public enum ModelFormat
{
    SafeTensor,
    PickleTensor,
    Diffusers,
    GGUF,
    [EnumMember(Value = "Core ML")]
    CoreML,
    ONNX,
    Other,
    pt,
}

