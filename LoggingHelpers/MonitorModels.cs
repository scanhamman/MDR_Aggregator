﻿using Dapper.Contrib.Extensions;

namespace MDR_Aggregator;

[Table("sf.source_parameters")]
public class Source
{
    public int id { get; }
    public string? source_type { get; }
    public int? preference_rating { get; }
    public string? database_name { get; }
    public string? db_conn { get; set; }
    public string? repo_name { get; set; }
    public bool? has_study_tables { get; }
    public bool? has_study_topics { get; }
    public bool? has_study_conditions { get; }
    public bool? has_study_features { get; }
    public bool? has_study_iec{ get; }
    public bool? has_study_people{ get; }
    public bool? has_study_organisations{ get; }
    public bool? has_study_references { get; }
    public bool? has_study_links { get; }
    public bool? has_study_ipd_available { get; }
    public bool? has_study_relationships { get; }
    public bool? has_study_countries { get; }
    public bool? has_study_locations { get; }
    public string? study_iec_storage_type { get; }
    public bool? has_object_datasets { get; }
    public bool? has_object_instances { get; }
    public bool? has_object_dates { get; }
    public bool? has_object_descriptions { get; }
    public bool? has_object_identifiers { get; }
    public bool? has_object_people { get; }
    public bool? has_object_organisations { get; }
    public bool? has_object_topics { get; }
    public bool? has_object_rights { get; }
    public bool? has_object_relationships { get; }
    public bool? has_object_comments { get; }
    public bool? has_object_db_links { get; }
    public bool? has_journal_details { get; }
    public bool? has_object_publication_types { get; }
    
}
   

[Table("sf.agg_source_summaries")]
public class SourceSummary	
{
    public int agg_event_id { get; set; }
    public DateTime agg_datetime { get; set; }
    public string? database_name { get; set; }
    public int study_recs { get; set; }
    public int study_identifiers_recs { get; set; }
    public int study_titles_recs { get; set; }
    public int study_people_recs { get; set; }
    public int study_organisations_recs { get; set; }
    public int study_topics_recs { get; set; }
    public int study_conditions_recs { get; set; }
    public int study_features_recs { get; set; }
    public int study_countries_recs { get; set; }
    public int study_locations_recs { get; set; }
    public int study_relationships_recs { get; set; }
    public int data_object_recs { get; set; }
    public int object_datasets_recs { get; set; }
    public int object_instances_recs { get; set; }
    public int object_titles_recs { get; set; }
    public int object_dates_recs { get; set; }
    public int object_people_recs { get; set; }
    public int object_organisations_recs { get; set; }
    public int object_topics_recs { get; set; }
    public int object_identifiers_recs { get; set; }
    public int object_descriptions_recs { get; set; }
    public int object_rights_recs { get; set; }
    public int object_relationships_recs { get; set; }

    public SourceSummary(int _aggregation_event_id, string _database_name)
    {
        agg_event_id = _aggregation_event_id;
        agg_datetime = DateTime.Now;
        database_name = _database_name;
    }

    public SourceSummary()
    { }
}

[Table("sf.source_ad_summaries")]
public class SourceADSummary	
{
    public int audit_id { get; set; }
    public DateTime audit_datetime { get; set; }
    public string? database_name { get; set; }
    public int study_recs { get; set; }
    public int study_identifiers_recs { get; set; }
    public int study_titles_recs { get; set; }
    public int study_people_recs { get; set; }
    public int study_organisations_recs { get; set; }
    public int study_topics_recs { get; set; }
    public int study_conditions_recs { get; set; }
    public int study_features_recs { get; set; }
    public int study_countries_recs { get; set; }
    public int study_locations_recs { get; set; }
    public int study_relationships_recs { get; set; }
    public int study_references_recs { get; set; }
    public int study_links_recs { get; set; }
    public int study_ipd_available_recs { get; set; }
    
    public int data_object_recs { get; set; }
    public int object_datasets_recs { get; set; }
    public int object_instances_recs { get; set; }
    public int object_titles_recs { get; set; }
    public int object_dates_recs { get; set; }
    public int object_people_recs { get; set; }
    public int object_organisations_recs { get; set; }
    public int object_topics_recs { get; set; }
    public int object_identifiers_recs { get; set; }
    public int object_descriptions_recs { get; set; }
    public int object_comments_recs { get; set; }
    public int object_db_link_recs { get; set; }
    public int object_journal_detail_recs { get; set; }
    public int object_publication_types_recs { get; set; }
    public int object_rights_recs { get; set; }
    public int object_relationships_recs { get; set; }

    public SourceADSummary(int _aggregation_event_id, string _database_name)
    {
        audit_id = _aggregation_event_id;
        audit_datetime = DateTime.Now;
        database_name = _database_name;
    }

    public SourceADSummary()
    { }
}

[Table("sf.agg_summaries")]
public class CoreSummary
{
    [Key]
    public int id { get; set; }
    public int agg_event_id { get; set; }
    public DateTime agg_datetime { get; set; }
    public int study_recs { get; set; }
    public int study_identifiers_recs { get; set; }
    public int study_titles_recs { get; set; }
    public int study_people_recs { get; set; }
    public int study_organisations_recs { get; set; }
    public int study_topics_recs { get; set; }
    public int study_conditions_recs { get; set; }
    public int study_icd_recs { get; set; }
    public int study_features_recs { get; set; }
    public int study_countries_recs { get; set; }
    public int study_locations_recs { get; set; }
    public int study_relationships_recs { get; set; }

    public int data_object_recs { get; set; }
    public int object_datasets_recs { get; set; }
    public int object_instances_recs { get; set; }
    public int object_titles_recs { get; set; }
    public int object_dates_recs { get; set; }
    public int object_people_recs { get; set; }
    public int object_organisations_recs { get; set; }
    public int object_topics_recs { get; set; }
    public int object_identifiers_recs { get; set; }
    public int object_descriptions_recs { get; set; }
    public int object_rights_recs { get; set; }
    public int object_relationships_recs { get; set; }
    public int study_object_link_recs { get; set; }

    public CoreSummary()
    {
    }
    
    public CoreSummary(int _aggregation_event_id)
    {
        agg_event_id = _aggregation_event_id;
        agg_datetime = DateTime.Now;
    }
}

[Table("sf.agg_object_numbers")]
public class AggregationObjectNum
{
    [Key]
    public int id { get; set; }
    public int agg_event_id { get; set; }
    public int object_type_id { get; set; }
    public string? object_type_name { get; set; }
    public int number_of_type { get; set; }
}


[Table("sf.agg_study_1to1_link_data")]
public class Study1To1LinkData
{
    [Key]
    public int id { get; set; }
    public int agg_event_id { get; set; }
    public int source_id { get; set; }
    public string? source_name { get; set; }
    public int other_source_id { get; set; }
    public string? other_source_name { get; set; }
    public int number_in_other_source { get; set; }
}


[Table("sf.agg_study_1ton_link_data")]
public class Study1ToNLinkData
{
    [Key]
    public int id { get; set; }
    public int agg_event_id { get; set; }
    public int source_id { get; set; }
    public string? source_name { get; set; }
    public int relationship_id { get; set; }
    public string? relationship { get; set; }
    public int target_source_id { get; set; }
    public string? target_source_name { get; set; }
    public int number_in_other_source { get; set; }
}


[Table("sf.agg_events")]
public class AggregationEvent
{
    [ExplicitKey]
    public int id { get; set; }
    public DateTime? time_started { get; set; }
    public DateTime? time_ended { get; set; }
    public int? num_studies_imported { get; set; }
    public int? num_objects_imported { get; set; }
    public int? num_total_studies { get; set; }
    public int? num_total_objects { get; set; }
    public int? num_total_study_object_links { get; set; }
    public string? comments { get; set; }

    public AggregationEvent(int _id)
    {
        id = _id;
        time_started = DateTime.Now;
    }

    public AggregationEvent() { }
}


[Table("sf.agg_iec_events")]
public class IECAggregationEvent
{
    [ExplicitKey] public int id { get; set; }
    public DateTime? time_started { get; set; }
    public DateTime? time_ended { get; set; }
    public Int64? iec_null_recs { get; set; }
    public Int64? iec_pre06_recs { get; set; }
    public Int64? iec_0608_recs { get; set; }
    public Int64? iec_0910_recs { get; set; }
    public Int64? iec_1112_recs { get; set; }
    public Int64? iec_1314_recs { get; set; }
    public Int64? iec_15_recs { get; set; }
    public Int64? iec_16_recs { get; set; }
    public Int64? iec_17_recs { get; set; }
    public Int64? iec_18_recs { get; set; }
    public Int64? iec_19_recs { get; set; }
    public Int64? iec_20_recs { get; set; }
    public Int64? iec_21_recs { get; set; }
    public Int64? iec_22_recs { get; set; }
    public Int64? iec_23_recs { get; set; }
    public Int64? iec_24_recs { get; set; }
    public Int64? iec_25_recs { get; set; }
    public Int64? iec_26_recs { get; set; }
    public Int64? iec_27_recs { get; set; }
    public Int64? iec_28_recs { get; set; }
    public Int64? iec_29_recs { get; set; }
    public Int64? iec_30_recs { get; set; }
    public Int64? total_records_imported { get; set; }
    public Int64? comments { get; set; }

    public IECAggregationEvent(int _id)
    {
        id = _id;
        time_started = DateTime.Now;
    }

    public IECAggregationEvent() { }
}

[Table("sf.agg_iec_source_numbers")]
public class IECAggregationSourceNum
{
    [Key]
    public int id { get; set; }
    public int iec_agg_event_id { get; set; }
    public int source_id { get; set; }
    public string? source_db_name { get; set; }
    public Int64 number_of_iec_recs { get; set; }

    public IECAggregationSourceNum(int iecAggEventId, int sourceId, 
                                   string? sourceDbName, Int64 numberOfIecRecs)
    {
        iec_agg_event_id = iecAggEventId;
        source_id = sourceId;
        source_db_name = sourceDbName;
        number_of_iec_recs = numberOfIecRecs;
    }
}



public class DataSource
{
    public int id { get; set; }
    public int? preference_rating { get; set; }
    public string database_name { get; set; }

    public DataSource(int _id, int? _preference_rating, string _database_name)
    {
        id = _id;
        preference_rating = _preference_rating;
        database_name = _database_name;
    }
}
