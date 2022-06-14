namespace Api.SubItems

{

public class SubItem 

{
    public List<DatumDto> data {get; set;}
    public string subscriptionId {get;set;}

}

public class DatumDto
{
public string id {get; set;}
public IversionOnRobotSubDto versionOnRobotSub{get;set;}
public string type {get; set;} = "Program";

}

public class IversionOnRobotSubDto

{
    public MetadataDto metadata {get; set;}
    public string type {get; set;} ="Float";
    public double value {get; set;}
    
}

public class MetadataDto
{
    
}

}