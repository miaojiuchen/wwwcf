using Microsoft.Exchange.WcfWebClient.EWS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ExchangeServiceImpl : ExchangeServicePortType
    {
        public AcceptSharedCalendarInviteResponse AcceptSharedCalendarInvite(AcceptSharedCalendarInviteRequest request)
        {
            return new AcceptSharedCalendarInviteResponse
            {
                AcceptSharedCalendarInviteResponse1 = new AcceptSharedCalendarInviteResponseMessageType
                {
                    NewCalendarEntryId = new ItemIdType
                    {
                        Id = "Hello World"
                    }
                }
            };
        }

        public ActivateSharingInvitationResponse ActivateSharingInvitation(ActivateSharingInvitationRequest request)
        {
            return new ActivateSharingInvitationResponse
            {
                ActivateSharingInvitationResponse1 = new ActivateSharingInvitationResponseMessageType
                {
                    SuggestedCalendarName = "Hello World"
                }
            };
        }

        public AddDelegateResponse AddDelegate(AddDelegateRequest request)
        {
            throw new NotImplementedException();
        }

        public AddDistributionGroupToImListResponse AddDistributionGroupToImList(AddDistributionGroupToImListRequest request)
        {
            throw new NotImplementedException();
        }

        public AddEntityFeedbackResponse AddEntityFeedback(AddEntityFeedbackRequest request)
        {
            throw new NotImplementedException();
        }

        public AddEventToMyCalanderResponse AddEventToMyCalander(AddEventToMyCalanderRequest request)
        {
            throw new NotImplementedException();
        }

        public AddImContactToGroupResponse AddImContactToGroup(AddImContactToGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public AddImGroupResponse AddImGroup(AddImGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public AddNewImContactToGroupResponse AddNewImContactToGroup(AddNewImContactToGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public AddNewTelUriContactToGroupResponse AddNewTelUriContactToGroup(AddNewTelUriContactToGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public AddPeopleCommunicationSignalResponse AddPeopleCommunicationSignal(AddPeopleCommunicationSignalRequest request)
        {
            throw new NotImplementedException();
        }

        public AddTagResponse AddTag(AddTagRequest request)
        {
            throw new NotImplementedException();
        }

        public AddTailoredExperienceEventsToCalendarResponse AddTailoredExperienceEventsToCalendar(AddTailoredExperienceEventsToCalendarRequest request)
        {
            throw new NotImplementedException();
        }

        public ApplyConversationActionResponse ApplyConversationAction(ApplyConversationActionRequest request)
        {
            throw new NotImplementedException();
        }

        public ApplyEventCoauthoringUpdateResponse ApplyEventCoauthoringUpdate(ApplyEventCoauthoringUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public ApplyEventCoOrganizerUpdateResponse ApplyEventCoOrganizerUpdate(ApplyEventCoOrganizerUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public ArchiveItemResponse ArchiveItem(ArchiveItemRequest request)
        {
            throw new NotImplementedException();
        }

        public BatchShareExistingXrmActivitiesResponse BatchShareExistingXrmActivities(BatchShareExistingXrmActivitiesRequest request)
        {
            throw new NotImplementedException();
        }

        public ChannelSubscribeResponse ChannelSubscribe(ChannelSubscribeRequest request)
        {
            throw new NotImplementedException();
        }

        public ChannelUnsubscribeResponse ChannelUnsubscribe(ChannelUnsubscribeRequest request)
        {
            throw new NotImplementedException();
        }

        public CompleteFindInGALSpeechRecognitionResponse CompleteFindInGALSpeechRecognition(CompleteFindInGALSpeechRecognitionRequest request)
        {
            throw new NotImplementedException();
        }

        public ConfigureConsumerGroupMemberSharingResponse ConfigureConsumerGroupMemberSharing(ConfigureConsumerGroupMemberSharingRequest request)
        {
            throw new NotImplementedException();
        }

        public ContactPropertySuggestionResponse ContactPropertySuggestion(ContactPropertySuggestionRequest request)
        {
            throw new NotImplementedException();
        }

        public ConvertIdResponse ConvertId(ConvertIdRequest request)
        {
            throw new NotImplementedException();
        }

        public CopyFolderResponse CopyFolder(CopyFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public CopyItemResponse CopyItem(CopyItemRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateAndRespondToMeetingByDelegateResponse CreateAndRespondToMeetingByDelegate(CreateAndRespondToMeetingByDelegateRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateAttachmentResponse CreateAttachment(CreateAttachmentRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateBookingCustomerResponse CreateBookingCustomer(CreateBookingCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateBookingCustomQuestionCommandResponse CreateBookingCustomQuestionCommand(CreateBookingCustomQuestionCommandRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateBookingServiceResponse CreateBookingService(CreateBookingServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateBookingStaffResponse CreateBookingStaff(CreateBookingStaffRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateFolderResponse CreateFolder(CreateFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateFolderPathResponse CreateFolderPath(CreateFolderPathRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateItemResponse CreateItem(CreateItemRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateManagedFolderResponse CreateManagedFolder(CreateManagedFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateMeetingInstanceResponse CreateMeetingInstance(CreateMeetingInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateMeetingPollResponse CreateMeetingPoll(CreateMeetingPollRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateMeetingSpaceResponse CreateMeetingSpace(CreateMeetingSpaceRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateOrUpdateFocusedOtherOverrideResponse CreateOrUpdateFocusedOtherOverride(CreateOrUpdateFocusedOtherOverrideRequest request)
        {
            throw new NotImplementedException();
        }

        public CreatePhotoTaskResponse CreatePhotoTask(CreatePhotoTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateSharingInvitationResponse CreateSharingInvitation(CreateSharingInvitationRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateSharingPermissionResponse CreateSharingPermission(CreateSharingPermissionRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateUMCallDataRecordResponse CreateUMCallDataRecord(CreateUMCallDataRecordRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateUMPromptResponse CreateUMPrompt(CreateUMPromptRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateUnifiedGroupResponse CreateUnifiedGroup(CreateUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateUserConfigurationResponse CreateUserConfiguration(CreateUserConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateXrmActivityStreamResponse CreateXrmActivityStream(CreateXrmActivityStreamRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateXrmDealResponse CreateXrmDeal(CreateXrmDealRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateXrmGraphRelationshipResponse CreateXrmGraphRelationship(CreateXrmGraphRelationshipRequest request)
        {
            throw new NotImplementedException();
        }

        public CreateXrmOrganizationResponse CreateXrmOrganization(CreateXrmOrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteBookingCustomQuestionResponse DeleteBookingCustomQuestion(DeleteBookingCustomQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteBookingServiceResponse DeleteBookingService(DeleteBookingServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteBookingStaffResponse DeleteBookingStaff(DeleteBookingStaffRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteFocusedOtherOverrideResponse DeleteFocusedOtherOverride(DeleteFocusedOtherOverrideRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteFolderResponse DeleteFolder(DeleteFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteItemResponse DeleteItem(DeleteItemRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteMeetingInstanceResponse DeleteMeetingInstance(DeleteMeetingInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteMeetingSpaceResponse DeleteMeetingSpace(DeleteMeetingSpaceRequest request)
        {
            throw new NotImplementedException();
        }

        public DeletePdpFacetsResponse1 DeletePdpFacets(DeletePdpFacetsRequest request)
        {
            throw new NotImplementedException();
        }

        public DeletePeopleInsightsTokensResponse DeletePeopleInsightsTokens(DeletePeopleInsightsTokensRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteSearchSuggestionResponse DeleteSearchSuggestion(DeleteSearchSuggestionRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteSharingInvitationResponse DeleteSharingInvitation(DeleteSharingInvitationRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteSharingPermissionResponse DeleteSharingPermission(DeleteSharingPermissionRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteUMPromptsResponse DeleteUMPrompts(DeleteUMPromptsRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteUserConfigurationResponse DeleteUserConfiguration(DeleteUserConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteXrmActivityStreamResponse DeleteXrmActivityStream(DeleteXrmActivityStreamRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteXrmDealResponse DeleteXrmDeal(DeleteXrmDealRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteXrmGraphRelationshipResponse DeleteXrmGraphRelationship(DeleteXrmGraphRelationshipRequest request)
        {
            throw new NotImplementedException();
        }

        public DeleteXrmOrganizationResponse DeleteXrmOrganization(DeleteXrmOrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public DisableAppResponse DisableApp(DisableAppRequest request)
        {
            throw new NotImplementedException();
        }

        public DisconnectPhoneCallResponse DisconnectPhoneCall(DisconnectPhoneCallRequest request)
        {
            throw new NotImplementedException();
        }

        public EmptyFolderResponse EmptyFolder(EmptyFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public EndSearchSessionResponse EndSearchSession(EndSearchSessionRequest request)
        {
            throw new NotImplementedException();
        }

        public EstablishConsumerGroupMemberSharingResponse EstablishConsumerGroupMemberSharing(EstablishConsumerGroupMemberSharingRequest request)
        {
            throw new NotImplementedException();
        }

        public ExecuteComplianceTaskResponse ExecuteComplianceTask(ExecuteComplianceTaskRequest request)
        {
            throw new NotImplementedException();
        }

        public ExecuteSearchResponse ExecuteSearch(ExecuteSearchRequest request)
        {
            throw new NotImplementedException();
        }

        public ExpandDLResponse ExpandDL(ExpandDLRequest request)
        {
            throw new NotImplementedException();
        }

        public ExportItemsResponse ExportItems(ExportItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindAddressListIndexContactsResponse FindAddressListIndexContacts(FindAddressListIndexContactsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindBookingCustomersResponse FindBookingCustomers(FindBookingCustomersRequest request)
        {
            throw new NotImplementedException();
        }

        public FindConversationResponse FindConversation(FindConversationRequest request)
        {
            throw new NotImplementedException();
        }

        public FindFolderResponse FindFolder(FindFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public FindInsightsResponse FindInsights(FindInsightsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindItemResponse FindItem(FindItemRequest request)
        {
            throw new NotImplementedException();
        }

        public FindMailboxStatisticsByKeywordsResponse FindMailboxStatisticsByKeywords(FindMailboxStatisticsByKeywordsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindMeetingSpaceByJoinUrlResponse FindMeetingSpaceByJoinUrl(FindMeetingSpaceByJoinUrlRequest request)
        {
            throw new NotImplementedException();
        }

        public FindMeetingTimeCandidatesResponse FindMeetingTimeCandidates(FindMeetingTimeCandidatesRequest request)
        {
            throw new NotImplementedException();
        }

        public FindMessageTrackingReportResponse FindMessageTrackingReport(FindMessageTrackingReportRequest request)
        {
            throw new NotImplementedException();
        }

        public FindPeopleResponse FindPeople(FindPeopleRequest request)
        {
            throw new NotImplementedException();
        }

        public FindPlacesResponse FindPlaces(FindPlacesRequest request)
        {
            throw new NotImplementedException();
        }

        public FindTagsResponse FindTags(FindTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindUnifiedGroupsResponse FindUnifiedGroups(FindUnifiedGroupsRequest request)
        {
            throw new NotImplementedException();
        }

        public FindXrmActivityStreamResponse FindXrmActivityStream(FindXrmActivityStreamRequest request)
        {
            throw new NotImplementedException();
        }

        public FindXrmDealResponse FindXrmDeal(FindXrmDealRequest request)
        {
            throw new NotImplementedException();
        }

        public FindXrmGraphRelationshipResponse FindXrmGraphRelationship(FindXrmGraphRelationshipRequest request)
        {
            throw new NotImplementedException();
        }

        public FindXrmOrganizationResponse FindXrmOrganization(FindXrmOrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAggregatedXrmActivitiesResponse GetAggregatedXrmActivities(GetAggregatedXrmActivitiesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAllClientExtensionsNotificationsResponse GetAllClientExtensionsNotifications(GetAllClientExtensionsNotificationsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAppManifestsResponse GetAppManifests(GetAppManifestsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAppMarketplaceUrlResponse GetAppMarketplaceUrl(GetAppMarketplaceUrlRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAttachmentResponse GetAttachment(GetAttachmentRequest request)
        {
            throw new NotImplementedException();
        }

        public GetAvailableCulturesResponse GetAvailableCultures(GetAvailableCulturesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingAdminSettingsResponse GetBookingAdminSettings(GetBookingAdminSettingsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingCalendarPublishingResponse GetBookingCalendarPublishing(GetBookingCalendarPublishingRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingCustomQuestionsCommandResponse GetBookingCustomQuestionsCommand(GetBookingCustomQuestionsCommandRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingMailboxDiagnosticsResponse GetBookingMailboxDiagnostics(GetBookingMailboxDiagnosticsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingMailboxesResponse GetBookingMailboxes(GetBookingMailboxesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingServiceResponse GetBookingService(GetBookingServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingServicesResponse GetBookingServices(GetBookingServicesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBookingStaffResponse GetBookingStaff(GetBookingStaffRequest request)
        {
            throw new NotImplementedException();
        }

        public GetBusinessInformationResponse GetBusinessInformation(GetBusinessInformationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetCalendarSharedInformationResponse GetCalendarSharedInformation(GetCalendarSharedInformationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetChannelEventsResponse GetChannelEvents(GetChannelEventsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetClientAccessTokenResponse GetClientAccessToken(GetClientAccessTokenRequest request)
        {
            throw new NotImplementedException();
        }

        public GetClientExtensionResponse GetClientExtension(GetClientExtensionRequest request)
        {
            throw new NotImplementedException();
        }

        public GetClientIntentResponse GetClientIntent(GetClientIntentRequest request)
        {
            throw new NotImplementedException();
        }

        public GetConsumerCalendarSharedInformationResponse GetConsumerCalendarSharedInformation(GetConsumerCalendarSharedInformationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetConversationItemsResponse GetConversationItems(GetConversationItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetDelegateResponse GetDelegate(GetDelegateRequest request)
        {
            throw new NotImplementedException();
        }

        public GetDiscoverySearchConfigurationResponse GetDiscoverySearchConfiguration(GetDiscoverySearchConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetDlMembersForUnifiedGroupResponse GetDlMembersForUnifiedGroup(GetDlMembersForUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public GetEventsResponse GetEvents(GetEventsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetFileItemsResponse GetFileItems(GetFileItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetFocusedOtherOverridesResponse GetFocusedOtherOverrides(GetFocusedOtherOverridesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetFolderResponse GetFolder(GetFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public GetHoldOnMailboxesResponse GetHoldOnMailboxes(GetHoldOnMailboxesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetImItemListResponse GetImItemList(GetImItemListRequest request)
        {
            throw new NotImplementedException();
        }

        public GetImItemsResponse GetImItems(GetImItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetInboxRulesResponse GetInboxRules(GetInboxRulesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetInsightsResponse GetInsights(GetInsightsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetIsFocusedInboxOnResponse GetIsFocusedInboxOn(GetIsFocusedInboxOnRequest request)
        {
            throw new NotImplementedException();
        }

        public GetItemResponse GetItem(GetItemRequest request)
        {
            throw new NotImplementedException();
        }

        public GetLastPrivateCatalogUpdateResponse GetLastPrivateCatalogUpdate(GetLastPrivateCatalogUpdateRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMailTipsResponse GetMailTips(GetMailTipsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMasterCategoryListResponse GetMasterCategoryList(GetMasterCategoryListRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMeetingInstanceResponse GetMeetingInstance(GetMeetingInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMeetingParticipantAvailabilityResponse GetMeetingParticipantAvailability(GetMeetingParticipantAvailabilityRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMeetingSpaceResponse GetMeetingSpace(GetMeetingSpaceRequest request)
        {
            throw new NotImplementedException();
        }

        public GetMessageTrackingReportResponse GetMessageTrackingReport(GetMessageTrackingReportRequest request)
        {
            throw new NotImplementedException();
        }

        public GetNextMeetingWithHashtagResponse GetNextMeetingWithHashtag(GetNextMeetingWithHashtagRequest request)
        {
            throw new NotImplementedException();
        }

        public GetNextMeetingWithPeopleResponse GetNextMeetingWithPeople(GetNextMeetingWithPeopleRequest request)
        {
            throw new NotImplementedException();
        }

        public GetNextMeetingWithPersonResponse GetNextMeetingWithPerson(GetNextMeetingWithPersonRequest request)
        {
            throw new NotImplementedException();
        }

        public GetNonIndexableItemDetailsResponse GetNonIndexableItemDetails(GetNonIndexableItemDetailsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetNonIndexableItemStatisticsResponse GetNonIndexableItemStatistics(GetNonIndexableItemStatisticsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetParcelDeliveryStatusResponse GetParcelDeliveryStatus(GetParcelDeliveryStatusRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPasswordExpirationDateResponse GetPasswordExpirationDate(GetPasswordExpirationDateRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPeopleInsightsResponse GetPeopleInsights(GetPeopleInsightsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPeopleInsightsTokensResponse GetPeopleInsightsTokens(GetPeopleInsightsTokensRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPersonaResponse GetPersona(GetPersonaRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPersonalNotesForPersonaResponse GetPersonalNotesForPersona(GetPersonalNotesForPersonaRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPhoneCallInformationResponse GetPhoneCallInformation(GetPhoneCallInformationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPhotoStripForItemResponse GetPhotoStripForItem(GetPhotoStripForItemRequest request)
        {
            throw new NotImplementedException();
        }

        public GetPrivateCatalogAddInsResponse GetPrivateCatalogAddIns(GetPrivateCatalogAddInsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetRoomListsResponse GetRoomLists(GetRoomListsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetRoomsResponse GetRooms(GetRoomsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSearchableMailboxesResponse GetSearchableMailboxes(GetSearchableMailboxesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSearchSuggestionsResponse GetSearchSuggestions(GetSearchSuggestionsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetServerTimeZonesResponse GetServerTimeZones(GetServerTimeZonesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetServiceConfigurationResponse GetServiceConfiguration(GetServiceConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetShardRelevancyDataResponse1 GetShardRelevancyData(GetShardRelevancyDataRequest request)
        {
            throw new NotImplementedException();
        }

        public GetShardRelevancyScoreResponse1 GetShardRelevancyScore(GetShardRelevancyScoreRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSharingFolderResponse GetSharingFolder(GetSharingFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSharingInvitationsResponse GetSharingInvitations(GetSharingInvitationsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSharingMetadataResponse GetSharingMetadata(GetSharingMetadataRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSharingPermissionInfoResponse GetSharingPermissionInfo(GetSharingPermissionInfoRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSharingPermissionsResponse GetSharingPermissions(GetSharingPermissionsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetSpecificUserConfigurationResponse GetSpecificUserConfiguration(GetSpecificUserConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetStaffAvailabilityResponse GetStaffAvailability(GetStaffAvailabilityRequest request)
        {
            throw new NotImplementedException();
        }

        public GetStreamingEventsResponse GetStreamingEvents(GetStreamingEventsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetTopShelfResponse GetTopShelf(GetTopShelfRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMCallDataRecordsResponse GetUMCallDataRecords(GetUMCallDataRecordsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMCallSummaryResponse GetUMCallSummary(GetUMCallSummaryRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMPinResponse GetUMPin(GetUMPinRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMPromptResponse GetUMPrompt(GetUMPromptRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMPromptNamesResponse GetUMPromptNames(GetUMPromptNamesRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUMSubscriberCallAnsweringDataResponse GetUMSubscriberCallAnsweringData(GetUMSubscriberCallAnsweringDataRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUnifiedGroupDetailsResponse GetUnifiedGroupDetails(GetUnifiedGroupDetailsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUnifiedGroupMembersResponse GetUnifiedGroupMembers(GetUnifiedGroupMembersRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUnifiedGroupMembershipRequestsResponse GetUnifiedGroupMembershipRequests(GetUnifiedGroupMembershipRequestsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUnifiedGroupsSettingsResponse GetUnifiedGroupsSettings(GetUnifiedGroupsSettingsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUnifiedGroupUnseenCountResponse GetUnifiedGroupUnseenCount(GetUnifiedGroupUnseenCountRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserAvailabilityResponse GetUserAvailability(GetUserAvailabilityRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserConfigurationResponse GetUserConfiguration(GetUserConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserOofSettingsResponse1 GetUserOofSettings(GetUserOofSettingsRequest1 request)
        {
            throw new NotImplementedException();
        }

        public GetUserPhotoResponse GetUserPhoto(GetUserPhotoRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserRetentionPolicyTagsResponse GetUserRetentionPolicyTags(GetUserRetentionPolicyTagsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserUnifiedGroupResponse GetUserUnifiedGroup(GetUserUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public GetUserUnifiedGroupsResponse GetUserUnifiedGroups(GetUserUnifiedGroupsRequest request)
        {
            throw new NotImplementedException();
        }

        public GetXrmActivityStreamResponse GetXrmActivityStream(GetXrmActivityStreamRequest request)
        {
            throw new NotImplementedException();
        }

        public GetXrmDealResponse GetXrmDeal(GetXrmDealRequest request)
        {
            throw new NotImplementedException();
        }

        public GetXrmOrganizationResponse GetXrmOrganization(GetXrmOrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public HideTagResponse HideTag(HideTagRequest request)
        {
            throw new NotImplementedException();
        }

        public InitUMMailboxResponse InitUMMailbox(InitUMMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public InstallAppResponse InstallApp(InstallAppRequest request)
        {
            throw new NotImplementedException();
        }

        public JoinPrivateUnifiedGroupResponse JoinPrivateUnifiedGroup(JoinPrivateUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public MarkAllItemsAsReadResponse MarkAllItemsAsRead(MarkAllItemsAsReadRequest request)
        {
            throw new NotImplementedException();
        }

        public MarkAsJunkResponse MarkAsJunk(MarkAsJunkRequest request)
        {
            throw new NotImplementedException();
        }

        public MaskAutoCompleteRecipientResponse MaskAutoCompleteRecipient(MaskAutoCompleteRecipientRequest request)
        {
            throw new NotImplementedException();
        }

        public MoveFolderResponse MoveFolder(MoveFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public MoveItemResponse MoveItem(MoveItemRequest request)
        {
            throw new NotImplementedException();
        }

        public NewBookingMailboxResponse NewBookingMailbox(NewBookingMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public NotifyOneDriveSyncResponse NotifyOneDriveSync(NotifyOneDriveSyncRequest request)
        {
            throw new NotImplementedException();
        }

        public PlayOnPhoneResponse PlayOnPhone(PlayOnPhoneRequest request)
        {
            throw new NotImplementedException();
        }

        public PostGroupItemResponse PostGroupItem(PostGroupItemRequest request)
        {
            throw new NotImplementedException();
        }

        public PostModernGroupItemResponse PostModernGroupItem(PostModernGroupItemRequest request)
        {
            throw new NotImplementedException();
        }

        public PostUnifiedGroupItemResponse PostUnifiedGroupItem(PostUnifiedGroupItemRequest request)
        {
            throw new NotImplementedException();
        }

        public ProcessComplianceOperationResponse ProcessComplianceOperation(ProcessComplianceOperationRequest request)
        {
            throw new NotImplementedException();
        }

        public ProcessTailoredExperienceEntitiesResponse ProcessTailoredExperienceEntities(ProcessTailoredExperienceEntitiesRequest request)
        {
            throw new NotImplementedException();
        }

        public ReadPdpFacetsResponse1 ReadPdpFacets(ReadPdpFacetsRequest request)
        {
            throw new NotImplementedException();
        }

        public RecordBookingPageLinkingActionResponse RecordBookingPageLinkingAction(RecordBookingPageLinkingActionRequest request)
        {
            throw new NotImplementedException();
        }

        public RecordCoauthoringInvitationResponseResponse RecordCoauthoringInvitationResponse(RecordCoauthoringInvitationResponseRequest request)
        {
            throw new NotImplementedException();
        }

        public RecordCoOrganizerInvitationResponseResponse RecordCoOrganizerInvitationResponse(RecordCoOrganizerInvitationResponseRequest request)
        {
            throw new NotImplementedException();
        }

        public RefreshSharingFolderResponse RefreshSharingFolder(RefreshSharingFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveContactFromImListResponse RemoveContactFromImList(RemoveContactFromImListRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveDelegateResponse RemoveDelegate(RemoveDelegateRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveDistributionGroupFromImListResponse RemoveDistributionGroupFromImList(RemoveDistributionGroupFromImListRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveImContactFromGroupResponse RemoveImContactFromGroup(RemoveImContactFromGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveImGroupResponse RemoveImGroup(RemoveImGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveTailoredExperienceEventsFromCalendarResponse RemoveTailoredExperienceEventsFromCalendar(RemoveTailoredExperienceEventsFromCalendarRequest request)
        {
            throw new NotImplementedException();
        }

        public RemoveUnifiedGroupResponse RemoveUnifiedGroup(RemoveUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public ReportMessageResponse ReportMessage(ReportMessageRequest request)
        {
            throw new NotImplementedException();
        }

        public ResetUMMailboxResponse ResetUMMailbox(ResetUMMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public ResolveNamesResponse ResolveNames(ResolveNamesRequest request)
        {
            throw new NotImplementedException();
        }

        public RespondToCoauthoringInvitationResponse RespondToCoauthoringInvitation(RespondToCoauthoringInvitationRequest request)
        {
            throw new NotImplementedException();
        }

        public RespondToCoOrganizerInvitationResponse RespondToCoOrganizerInvitation(RespondToCoOrganizerInvitationRequest request)
        {
            throw new NotImplementedException();
        }

        public RouteComplaintResponse RouteComplaint(RouteComplaintRequest request)
        {
            throw new NotImplementedException();
        }

        public SaveUMPinResponse SaveUMPin(SaveUMPinRequest request)
        {
            throw new NotImplementedException();
        }

        public ScheduleFollowupResponse ScheduleFollowup(ScheduleFollowupRequest request)
        {
            throw new NotImplementedException();
        }

        public ScheduleItemResponse ScheduleItem(ScheduleItemRequest request)
        {
            throw new NotImplementedException();
        }

        public SearchMailboxesResponse SearchMailboxes(SearchMailboxesRequest request)
        {
            throw new NotImplementedException();
        }

        public SendItemResponse SendItem(SendItemRequest request)
        {
            throw new NotImplementedException();
        }

        public SetBookingCalendarPublishingResponse SetBookingCalendarPublishing(SetBookingCalendarPublishingRequest request)
        {
            throw new NotImplementedException();
        }

        public SetBookingMailboxPhotoResponse SetBookingMailboxPhoto(SetBookingMailboxPhotoRequest request)
        {
            throw new NotImplementedException();
        }

        public SetBookingMailboxSBGraphLinkingResponse SetBookingMailboxSBGraphLinking(SetBookingMailboxSBGraphLinkingRequest request)
        {
            throw new NotImplementedException();
        }

        public SetBusinessInformationResponse SetBusinessInformation(SetBusinessInformationRequest request)
        {
            throw new NotImplementedException();
        }

        public SetClientExtensionResponse SetClientExtension(SetClientExtensionRequest request)
        {
            throw new NotImplementedException();
        }

        public SetHoldOnMailboxesResponse SetHoldOnMailboxes(SetHoldOnMailboxesRequest request)
        {
            throw new NotImplementedException();
        }

        public SetImGroupResponse SetImGroup(SetImGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public SetImListMigrationCompletedResponse SetImListMigrationCompleted(SetImListMigrationCompletedRequest request)
        {
            throw new NotImplementedException();
        }

        public SetPeopleInsightsTokensResponse SetPeopleInsightsTokens(SetPeopleInsightsTokensRequest request)
        {
            throw new NotImplementedException();
        }

        public SetProfilePhotoResponse SetProfilePhoto(SetProfilePhotoRequest request)
        {
            throw new NotImplementedException();
        }

        public SetShardRelevancyDataResponse1 SetShardRelevancyData(SetShardRelevancyDataRequest request)
        {
            throw new NotImplementedException();
        }

        public SetTeamMailboxResponse SetTeamMailbox(SetTeamMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUnifiedGroupFavoriteStateResponse SetUnifiedGroupFavoriteState(SetUnifiedGroupFavoriteStateRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUnifiedGroupLastVisitedTimeResponse SetUnifiedGroupLastVisitedTime(SetUnifiedGroupLastVisitedTimeRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUnifiedGroupMembershipStateResponse SetUnifiedGroupMembershipState(SetUnifiedGroupMembershipStateRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUnifiedGroupUnseenDataResponse SetUnifiedGroupUnseenData(SetUnifiedGroupUnseenDataRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUnifiedGroupUserSubscribeStateResponse SetUnifiedGroupUserSubscribeState(SetUnifiedGroupUserSubscribeStateRequest request)
        {
            throw new NotImplementedException();
        }

        public SetUserOofSettingsResponse1 SetUserOofSettings(SetUserOofSettingsRequest1 request)
        {
            throw new NotImplementedException();
        }

        public SetUserPhotoResponse SetUserPhoto(SetUserPhotoRequest request)
        {
            throw new NotImplementedException();
        }

        public ShareSingleXrmActivityResponse ShareSingleXrmActivity(ShareSingleXrmActivityRequest request)
        {
            throw new NotImplementedException();
        }

        public ShareTailoredExperienceEventResponse ShareTailoredExperienceEvent(ShareTailoredExperienceEventRequest request)
        {
            throw new NotImplementedException();
        }

        public StartFindInGALSpeechRecognitionResponse StartFindInGALSpeechRecognition(StartFindInGALSpeechRecognitionRequest request)
        {
            throw new NotImplementedException();
        }

        public StartSearchSessionResponse StartSearchSession(StartSearchSessionRequest request)
        {
            throw new NotImplementedException();
        }

        public StartXrmSessionResponse StartXrmSession(StartXrmSessionRequest request)
        {
            throw new NotImplementedException();
        }

        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            throw new NotImplementedException();
        }

        public SyncFolderHierarchyResponse SyncFolderHierarchy(SyncFolderHierarchyRequest request)
        {
            throw new NotImplementedException();
        }

        public SyncFolderItemsResponse SyncFolderItems(SyncFolderItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public SyncUnifiedGroupResponse SyncUnifiedGroup(SyncUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public UninstallAppResponse UninstallApp(UninstallAppRequest request)
        {
            throw new NotImplementedException();
        }

        public UnpinTeamMailboxResponse UnpinTeamMailbox(UnpinTeamMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public UnscheduleItemResponse UnscheduleItem(UnscheduleItemRequest request)
        {
            throw new NotImplementedException();
        }

        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateBookingCustomerResponse UpdateBookingCustomer(UpdateBookingCustomerRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateBookingCustomQuestionResponse UpdateBookingCustomQuestion(UpdateBookingCustomQuestionRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateBookingServiceResponse UpdateBookingService(UpdateBookingServiceRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateBookingServiceOrderResponse UpdateBookingServiceOrder(UpdateBookingServiceOrderRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateBookingStaffResponse UpdateBookingStaff(UpdateBookingStaffRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateClientExtensionNotificationsResponse UpdateClientExtensionNotifications(UpdateClientExtensionNotificationsRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateDelegateResponse UpdateDelegate(UpdateDelegateRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateDelegateSharingPermissionResponse UpdateDelegateSharingPermission(UpdateDelegateSharingPermissionRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateExtensionUsageResponse UpdateExtensionUsage(UpdateExtensionUsageRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateFolderResponse UpdateFolder(UpdateFolderRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateGroupMailboxResponse UpdateGroupMailbox(UpdateGroupMailboxRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateInboxRulesResponse UpdateInboxRules(UpdateInboxRulesRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateItemResponse UpdateItem(UpdateItemRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateItemInRecoverableItemsResponse UpdateItemInRecoverableItems(UpdateItemInRecoverableItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateMailboxAssociationResponse UpdateMailboxAssociation(UpdateMailboxAssociationRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateMasterCategoryListResponse UpdateMasterCategoryList(UpdateMasterCategoryListRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateMeetingInstanceResponse UpdateMeetingInstance(UpdateMeetingInstanceRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateMeetingSpaceResponse UpdateMeetingSpace(UpdateMeetingSpaceRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateSharingInvitationResponse UpdateSharingInvitation(UpdateSharingInvitationRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateSharingPermissionsResponse UpdateSharingPermissions(UpdateSharingPermissionsRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateTopShelfResponse UpdateTopShelf(UpdateTopShelfRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateUnifiedGroupResponse UpdateUnifiedGroup(UpdateUnifiedGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateUserConfigurationResponse UpdateUserConfiguration(UpdateUserConfigurationRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateXrmActivityStreamResponse UpdateXrmActivityStream(UpdateXrmActivityStreamRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateXrmDealResponse UpdateXrmDeal(UpdateXrmDealRequest request)
        {
            throw new NotImplementedException();
        }

        public UpdateXrmOrganizationResponse UpdateXrmOrganization(UpdateXrmOrganizationRequest request)
        {
            throw new NotImplementedException();
        }

        public UpgradeDistributionGroupResponse UpgradeDistributionGroup(UpgradeDistributionGroupRequest request)
        {
            throw new NotImplementedException();
        }

        public UploadItemsResponse UploadItems(UploadItemsRequest request)
        {
            throw new NotImplementedException();
        }

        public ValidateUMPinResponse ValidateUMPin(ValidateUMPinRequest request)
        {
            throw new NotImplementedException();
        }

        public ValidateUnifiedGroupAliasResponse ValidateUnifiedGroupAlias(ValidateUnifiedGroupAliasRequest request)
        {
            throw new NotImplementedException();
        }

        public WritePdpFacetsResponse1 WritePdpFacets(WritePdpFacetsRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
