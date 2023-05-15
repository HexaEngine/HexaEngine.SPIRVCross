// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Runtime.InteropServices;

namespace HexaEngine.SPIRVCross
{
	public unsafe partial class SPIRV
	{
		internal const string LibName = "spirv-cross-c-shared";

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_get_version")]
		public static extern void SpvcGetVersion(uint* major, uint* minor, uint* patch);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_get_commit_revision_and_timestamp")]
		public static extern sbyte* SpvcGetCommitRevisionAndTimestamp();

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_vertex_attribute_init")]
		public static extern void SpvcMslVertexAttributeInit(SpvcMslVertexAttribute* attr);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_shader_interface_var_init")]
		public static extern void SpvcMslShaderInterfaceVarInit(SpvcMslShaderInterfaceVar* var);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_shader_input_init")]
		public static extern void SpvcMslShaderInputInit(SpvcMslShaderInterfaceVar* input);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_shader_interface_var_init_2")]
		public static extern void SpvcMslShaderInterfaceVarInit2(SpvcMslShaderInterfaceVar2* var);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_resource_binding_init")]
		public static extern void SpvcMslResourceBindingInit(SpvcMslResourceBinding* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_get_aux_buffer_struct_version")]
		public static extern uint SpvcMslGetAuxBufferStructVersion();

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_constexpr_sampler_init")]
		public static extern void SpvcMslConstexprSamplerInit(SpvcMslConstexprSampler* sampler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_msl_sampler_ycbcr_conversion_init")]
		public static extern void SpvcMslSamplerYcbcrConversionInit(SpvcMslSamplerYcbcrConversion* conv);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_hlsl_resource_binding_init")]
		public static extern void SpvcHlslResourceBindingInit(SpvcHlslResourceBinding* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_create")]
		public static extern SpvcResult SpvcContextCreate(SpvcContext* context);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_destroy")]
		public static extern void SpvcContextDestroy(SpvcContext context);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_release_allocations")]
		public static extern void SpvcContextReleaseAllocations(SpvcContext context);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_get_last_error_string")]
		public static extern sbyte* SpvcContextGetLastErrorString(SpvcContext context);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_set_error_callback")]
		public static extern void SpvcContextSetErrorCallback(SpvcContext context, SpvcErrorCallback cb, void* userdata);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_parse_spirv")]
		public static extern SpvcResult SpvcContextParseSpirv(SpvcContext context, SpvId* spirv, nuint word_count, SpvcParsedIr* parsed_ir);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_context_create_compiler")]
		public static extern SpvcResult SpvcContextCreateCompiler(SpvcContext context, SpvcBackend backend, SpvcParsedIr parsed_ir, SpvcCaptureMode mode, SpvcCompiler* compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_current_id_bound")]
		public static extern uint SpvcCompilerGetCurrentIdBound(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_create_compiler_options")]
		public static extern SpvcResult SpvcCompilerCreateCompilerOptions(SpvcCompiler compiler, SpvcCompilerOptions* options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_options_set_bool")]
		public static extern SpvcResult SpvcCompilerOptionsSetBool(SpvcCompilerOptions options, SpvcCompilerOption option, bool value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_options_set_uint")]
		public static extern SpvcResult SpvcCompilerOptionsSetUint(SpvcCompilerOptions options, SpvcCompilerOption option, uint value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_install_compiler_options")]
		public static extern SpvcResult SpvcCompilerInstallCompilerOptions(SpvcCompiler compiler, SpvcCompilerOptions options);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_compile")]
		public static extern SpvcResult SpvcCompilerCompile(SpvcCompiler compiler, sbyte* source);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_add_header_line")]
		public static extern SpvcResult SpvcCompilerAddHeaderLine(SpvcCompiler compiler, sbyte* line);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_require_extension")]
		public static extern SpvcResult SpvcCompilerRequireExtension(SpvcCompiler compiler, sbyte* ext);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_flatten_buffer_block")]
		public static extern SpvcResult SpvcCompilerFlattenBufferBlock(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_variable_is_depth_or_compare")]
		public static extern bool SpvcCompilerVariableIsDepthOrCompare(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_mask_stage_output_by_location")]
		public static extern SpvcResult SpvcCompilerMaskStageOutputByLocation(SpvcCompiler compiler, uint location, uint component);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_mask_stage_output_by_builtin")]
		public static extern SpvcResult SpvcCompilerMaskStageOutputByBuiltin(SpvcCompiler compiler, SpvBuiltIn builtin);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_set_root_constants_layout")]
		public static extern SpvcResult SpvcCompilerHlslSetRootConstantsLayout(SpvcCompiler compiler, SpvcHlslRootConstants* constant_info, nuint count);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_add_vertex_attribute_remap")]
		public static extern SpvcResult SpvcCompilerHlslAddVertexAttributeRemap(SpvcCompiler compiler, SpvcHlslVertexAttributeRemap* remap, nuint remaps);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_remap_num_workgroups_builtin")]
		public static extern uint SpvcCompilerHlslRemapNumWorkgroupsBuiltin(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_set_resource_binding_flags")]
		public static extern SpvcResult SpvcCompilerHlslSetResourceBindingFlags(SpvcCompiler compiler, uint flags);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_add_resource_binding")]
		public static extern SpvcResult SpvcCompilerHlslAddResourceBinding(SpvcCompiler compiler, SpvcHlslResourceBinding* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_hlsl_is_resource_used")]
		public static extern bool SpvcCompilerHlslIsResourceUsed(SpvcCompiler compiler, SpvExecutionModel model, uint set, uint binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_is_rasterization_disabled")]
		public static extern bool SpvcCompilerMslIsRasterizationDisabled(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_aux_buffer")]
		public static extern bool SpvcCompilerMslNeedsAuxBuffer(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_swizzle_buffer")]
		public static extern bool SpvcCompilerMslNeedsSwizzleBuffer(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_buffer_size_buffer")]
		public static extern bool SpvcCompilerMslNeedsBufferSizeBuffer(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_output_buffer")]
		public static extern bool SpvcCompilerMslNeedsOutputBuffer(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_patch_output_buffer")]
		public static extern bool SpvcCompilerMslNeedsPatchOutputBuffer(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_needs_input_threadgroup_mem")]
		public static extern bool SpvcCompilerMslNeedsInputThreadgroupMem(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_vertex_attribute")]
		public static extern SpvcResult SpvcCompilerMslAddVertexAttribute(SpvcCompiler compiler, SpvcMslVertexAttribute* attrs);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_resource_binding")]
		public static extern SpvcResult SpvcCompilerMslAddResourceBinding(SpvcCompiler compiler, SpvcMslResourceBinding* binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_shader_input")]
		public static extern SpvcResult SpvcCompilerMslAddShaderInput(SpvcCompiler compiler, SpvcMslShaderInterfaceVar* input);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_shader_input_2")]
		public static extern SpvcResult SpvcCompilerMslAddShaderInput2(SpvcCompiler compiler, SpvcMslShaderInterfaceVar2* input);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_shader_output")]
		public static extern SpvcResult SpvcCompilerMslAddShaderOutput(SpvcCompiler compiler, SpvcMslShaderInterfaceVar* output);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_shader_output_2")]
		public static extern SpvcResult SpvcCompilerMslAddShaderOutput2(SpvcCompiler compiler, SpvcMslShaderInterfaceVar2* output);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_discrete_descriptor_set")]
		public static extern SpvcResult SpvcCompilerMslAddDiscreteDescriptorSet(SpvcCompiler compiler, uint desc_set);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_set_argument_buffer_device_address_space")]
		public static extern SpvcResult SpvcCompilerMslSetArgumentBufferDeviceAddressSpace(SpvcCompiler compiler, uint desc_set, bool device_address);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_is_vertex_attribute_used")]
		public static extern bool SpvcCompilerMslIsVertexAttributeUsed(SpvcCompiler compiler, uint location);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_is_shader_input_used")]
		public static extern bool SpvcCompilerMslIsShaderInputUsed(SpvcCompiler compiler, uint location);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_is_shader_output_used")]
		public static extern bool SpvcCompilerMslIsShaderOutputUsed(SpvcCompiler compiler, uint location);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_is_resource_used")]
		public static extern bool SpvcCompilerMslIsResourceUsed(SpvcCompiler compiler, SpvExecutionModel model, uint set, uint binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler")]
		public static extern SpvcResult SpvcCompilerMslRemapConstexprSampler(SpvcCompiler compiler, uint id, SpvcMslConstexprSampler* sampler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding")]
		public static extern SpvcResult SpvcCompilerMslRemapConstexprSamplerByBinding(SpvcCompiler compiler, uint desc_set, uint binding, SpvcMslConstexprSampler* sampler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_ycbcr")]
		public static extern SpvcResult SpvcCompilerMslRemapConstexprSamplerYcbcr(SpvcCompiler compiler, uint id, SpvcMslConstexprSampler* sampler, SpvcMslSamplerYcbcrConversion* conv);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_remap_constexpr_sampler_by_binding_ycbcr")]
		public static extern SpvcResult SpvcCompilerMslRemapConstexprSamplerByBindingYcbcr(SpvcCompiler compiler, uint desc_set, uint binding, SpvcMslConstexprSampler* sampler, SpvcMslSamplerYcbcrConversion* conv);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_set_fragment_output_components")]
		public static extern SpvcResult SpvcCompilerMslSetFragmentOutputComponents(SpvcCompiler compiler, uint location, uint components);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding")]
		public static extern uint SpvcCompilerMslGetAutomaticResourceBinding(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_get_automatic_resource_binding_secondary")]
		public static extern uint SpvcCompilerMslGetAutomaticResourceBindingSecondary(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_dynamic_buffer")]
		public static extern SpvcResult SpvcCompilerMslAddDynamicBuffer(SpvcCompiler compiler, uint desc_set, uint binding, uint index);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_add_inline_uniform_block")]
		public static extern SpvcResult SpvcCompilerMslAddInlineUniformBlock(SpvcCompiler compiler, uint desc_set, uint binding);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_set_combined_sampler_suffix")]
		public static extern SpvcResult SpvcCompilerMslSetCombinedSamplerSuffix(SpvcCompiler compiler, sbyte* suffix);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_msl_get_combined_sampler_suffix")]
		public static extern sbyte* SpvcCompilerMslGetCombinedSamplerSuffix(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_active_interface_variables")]
		public static extern SpvcResult SpvcCompilerGetActiveInterfaceVariables(SpvcCompiler compiler, SpvcSet* set);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_enabled_interface_variables")]
		public static extern SpvcResult SpvcCompilerSetEnabledInterfaceVariables(SpvcCompiler compiler, SpvcSet set);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_create_shader_resources")]
		public static extern SpvcResult SpvcCompilerCreateShaderResources(SpvcCompiler compiler, SpvcResources* resources);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_create_shader_resources_for_active_variables")]
		public static extern SpvcResult SpvcCompilerCreateShaderResourcesForActiveVariables(SpvcCompiler compiler, SpvcResources* resources, SpvcSet active);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_resources_get_resource_list_for_type")]
		public static extern SpvcResult SpvcResourcesGetResourceListForType(SpvcResources resources, SpvcResourceType type, SpvcReflectedResource* resource_list, nuint* resource_size);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_resources_get_builtin_resource_list_for_type")]
		public static extern SpvcResult SpvcResourcesGetBuiltinResourceListForType(SpvcResources resources, SpvcBuiltinResourceType type, SpvcReflectedBuiltinResource* resource_list, nuint* resource_size);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_decoration")]
		public static extern void SpvcCompilerSetDecoration(SpvcCompiler compiler, SpvId id, SpvDecoration decoration, uint argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_decoration_string")]
		public static extern void SpvcCompilerSetDecorationString(SpvcCompiler compiler, SpvId id, SpvDecoration decoration, sbyte* argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_name")]
		public static extern void SpvcCompilerSetName(SpvcCompiler compiler, SpvId id, sbyte* argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_member_decoration")]
		public static extern void SpvcCompilerSetMemberDecoration(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration, uint argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_member_decoration_string")]
		public static extern void SpvcCompilerSetMemberDecorationString(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration, sbyte* argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_member_name")]
		public static extern void SpvcCompilerSetMemberName(SpvcCompiler compiler, uint id, uint member_index, sbyte* argument);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_unset_decoration")]
		public static extern void SpvcCompilerUnsetDecoration(SpvcCompiler compiler, SpvId id, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_unset_member_decoration")]
		public static extern void SpvcCompilerUnsetMemberDecoration(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_has_decoration")]
		public static extern bool SpvcCompilerHasDecoration(SpvcCompiler compiler, SpvId id, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_has_member_decoration")]
		public static extern bool SpvcCompilerHasMemberDecoration(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_name")]
		public static extern sbyte* SpvcCompilerGetName(SpvcCompiler compiler, SpvId id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_decoration")]
		public static extern uint SpvcCompilerGetDecoration(SpvcCompiler compiler, SpvId id, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_decoration_string")]
		public static extern sbyte* SpvcCompilerGetDecorationString(SpvcCompiler compiler, SpvId id, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_member_decoration")]
		public static extern uint SpvcCompilerGetMemberDecoration(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_member_decoration_string")]
		public static extern sbyte* SpvcCompilerGetMemberDecorationString(SpvcCompiler compiler, uint id, uint member_index, SpvDecoration decoration);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_member_name")]
		public static extern sbyte* SpvcCompilerGetMemberName(SpvcCompiler compiler, uint id, uint member_index);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_entry_points")]
		public static extern SpvcResult SpvcCompilerGetEntryPoints(SpvcCompiler compiler, SpvcEntryPoint* entry_points, nuint* num_entry_points);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_entry_point")]
		public static extern SpvcResult SpvcCompilerSetEntryPoint(SpvcCompiler compiler, sbyte* name, SpvExecutionModel model);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_rename_entry_point")]
		public static extern SpvcResult SpvcCompilerRenameEntryPoint(SpvcCompiler compiler, sbyte* old_name, sbyte* new_name, SpvExecutionModel model);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_cleansed_entry_point_name")]
		public static extern sbyte* SpvcCompilerGetCleansedEntryPointName(SpvcCompiler compiler, sbyte* name, SpvExecutionModel model);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_execution_mode")]
		public static extern void SpvcCompilerSetExecutionMode(SpvcCompiler compiler, SpvExecutionMode mode);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_unset_execution_mode")]
		public static extern void SpvcCompilerUnsetExecutionMode(SpvcCompiler compiler, SpvExecutionMode mode);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_set_execution_mode_with_arguments")]
		public static extern void SpvcCompilerSetExecutionModeWithArguments(SpvcCompiler compiler, SpvExecutionMode mode, uint arg0, uint arg1, uint arg2);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_execution_modes")]
		public static extern SpvcResult SpvcCompilerGetExecutionModes(SpvcCompiler compiler, SpvExecutionMode* modes, nuint* num_modes);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_execution_mode_argument")]
		public static extern uint SpvcCompilerGetExecutionModeArgument(SpvcCompiler compiler, SpvExecutionMode mode);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_execution_mode_argument_by_index")]
		public static extern uint SpvcCompilerGetExecutionModeArgumentByIndex(SpvcCompiler compiler, SpvExecutionMode mode, uint index);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_execution_model")]
		public static extern SpvExecutionModel SpvcCompilerGetExecutionModel(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_update_active_builtins")]
		public static extern void SpvcCompilerUpdateActiveBuiltins(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_has_active_builtin")]
		public static extern bool SpvcCompilerHasActiveBuiltin(SpvcCompiler compiler, SpvBuiltIn builtin, SpvStorageClass storage);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_type_handle")]
		public static extern SpvcType SpvcCompilerGetTypeHandle(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_base_type_id")]
		public static extern uint SpvcTypeGetBaseTypeId(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_basetype")]
		public static extern SpvcBasetype SpvcTypeGetBasetype(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_bit_width")]
		public static extern uint SpvcTypeGetBitWidth(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_vector_size")]
		public static extern uint SpvcTypeGetVectorSize(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_columns")]
		public static extern uint SpvcTypeGetColumns(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_num_array_dimensions")]
		public static extern uint SpvcTypeGetNumArrayDimensions(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_array_dimension_is_literal")]
		public static extern bool SpvcTypeArrayDimensionIsLiteral(SpvcType type, uint dimension);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_array_dimension")]
		public static extern SpvId SpvcTypeGetArrayDimension(SpvcType type, uint dimension);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_num_member_types")]
		public static extern uint SpvcTypeGetNumMemberTypes(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_member_type")]
		public static extern uint SpvcTypeGetMemberType(SpvcType type, uint index);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_storage_class")]
		public static extern SpvStorageClass SpvcTypeGetStorageClass(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_sampled_type")]
		public static extern uint SpvcTypeGetImageSampledType(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_dimension")]
		public static extern SpvDim SpvcTypeGetImageDimension(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_is_depth")]
		public static extern bool SpvcTypeGetImageIsDepth(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_arrayed")]
		public static extern bool SpvcTypeGetImageArrayed(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_multisampled")]
		public static extern bool SpvcTypeGetImageMultisampled(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_is_storage")]
		public static extern bool SpvcTypeGetImageIsStorage(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_storage_format")]
		public static extern SpvImageFormat SpvcTypeGetImageStorageFormat(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_type_get_image_access_qualifier")]
		public static extern SpvAccessQualifier SpvcTypeGetImageAccessQualifier(SpvcType type);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_declared_struct_size")]
		public static extern SpvcResult SpvcCompilerGetDeclaredStructSize(SpvcCompiler compiler, SpvcType struct_type, nuint* size);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_declared_struct_size_runtime_array")]
		public static extern SpvcResult SpvcCompilerGetDeclaredStructSizeRuntimeArray(SpvcCompiler compiler, SpvcType struct_type, nuint array_size, nuint* size);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_declared_struct_member_size")]
		public static extern SpvcResult SpvcCompilerGetDeclaredStructMemberSize(SpvcCompiler compiler, SpvcType type, uint index, nuint* size);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_type_struct_member_offset")]
		public static extern SpvcResult SpvcCompilerTypeStructMemberOffset(SpvcCompiler compiler, SpvcType type, uint index, uint* offset);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_type_struct_member_array_stride")]
		public static extern SpvcResult SpvcCompilerTypeStructMemberArrayStride(SpvcCompiler compiler, SpvcType type, uint index, uint* stride);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_type_struct_member_matrix_stride")]
		public static extern SpvcResult SpvcCompilerTypeStructMemberMatrixStride(SpvcCompiler compiler, SpvcType type, uint index, uint* stride);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_build_dummy_sampler_for_combined_images")]
		public static extern SpvcResult SpvcCompilerBuildDummySamplerForCombinedImages(SpvcCompiler compiler, uint* id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_build_combined_image_samplers")]
		public static extern SpvcResult SpvcCompilerBuildCombinedImageSamplers(SpvcCompiler compiler);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_combined_image_samplers")]
		public static extern SpvcResult SpvcCompilerGetCombinedImageSamplers(SpvcCompiler compiler, SpvcCombinedImageSampler* samplers, nuint* num_samplers);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_specialization_constants")]
		public static extern SpvcResult SpvcCompilerGetSpecializationConstants(SpvcCompiler compiler, SpvcSpecializationConstant* constants, nuint* num_constants);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_constant_handle")]
		public static extern SpvcConstant SpvcCompilerGetConstantHandle(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_work_group_size_specialization_constants")]
		public static extern uint SpvcCompilerGetWorkGroupSizeSpecializationConstants(SpvcCompiler compiler, SpvcSpecializationConstant* x, SpvcSpecializationConstant* y, SpvcSpecializationConstant* z);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_active_buffer_ranges")]
		public static extern SpvcResult SpvcCompilerGetActiveBufferRanges(SpvcCompiler compiler, uint id, SpvcBufferRange* ranges, nuint* num_ranges);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_fp16")]
		public static extern float SpvcConstantGetScalarFp16(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_fp32")]
		public static extern float SpvcConstantGetScalarFp32(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_fp64")]
		public static extern double SpvcConstantGetScalarFp64(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_u32")]
		public static extern uint SpvcConstantGetScalarU32(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_i32")]
		public static extern int SpvcConstantGetScalarI32(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_u16")]
		public static extern uint SpvcConstantGetScalarU16(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_i16")]
		public static extern int SpvcConstantGetScalarI16(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_u8")]
		public static extern uint SpvcConstantGetScalarU8(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_scalar_i8")]
		public static extern int SpvcConstantGetScalarI8(SpvcConstant constant, uint column, uint row);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_subconstants")]
		public static extern void SpvcConstantGetSubconstants(SpvcConstant constant, uint* constituents, nuint* count);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_get_type")]
		public static extern uint SpvcConstantGetType(SpvcConstant constant);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_fp16")]
		public static extern void SpvcConstantSetScalarFp16(SpvcConstant constant, uint column, uint row, ushort value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_fp32")]
		public static extern void SpvcConstantSetScalarFp32(SpvcConstant constant, uint column, uint row, float value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_fp64")]
		public static extern void SpvcConstantSetScalarFp64(SpvcConstant constant, uint column, uint row, double value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_u32")]
		public static extern void SpvcConstantSetScalarU32(SpvcConstant constant, uint column, uint row, uint value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_i32")]
		public static extern void SpvcConstantSetScalarI32(SpvcConstant constant, uint column, uint row, int value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_u16")]
		public static extern void SpvcConstantSetScalarU16(SpvcConstant constant, uint column, uint row, ushort value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_i16")]
		public static extern void SpvcConstantSetScalarI16(SpvcConstant constant, uint column, uint row, short value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_u8")]
		public static extern void SpvcConstantSetScalarU8(SpvcConstant constant, uint column, uint row, byte value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_constant_set_scalar_i8")]
		public static extern void SpvcConstantSetScalarI8(SpvcConstant constant, uint column, uint row, sbyte value);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_binary_offset_for_decoration")]
		public static extern bool SpvcCompilerGetBinaryOffsetForDecoration(SpvcCompiler compiler, uint id, SpvDecoration decoration, uint* word_offset);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_buffer_is_hlsl_counter_buffer")]
		public static extern bool SpvcCompilerBufferIsHlslCounterBuffer(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_buffer_get_hlsl_counter_buffer")]
		public static extern bool SpvcCompilerBufferGetHlslCounterBuffer(SpvcCompiler compiler, uint id, uint* counter_id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_declared_capabilities")]
		public static extern SpvcResult SpvcCompilerGetDeclaredCapabilities(SpvcCompiler compiler, SpvCapability* capabilities, nuint* num_capabilities);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_declared_extensions")]
		public static extern SpvcResult SpvcCompilerGetDeclaredExtensions(SpvcCompiler compiler, sbyte* extensions, nuint* num_extensions);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_remapped_declared_block_name")]
		public static extern sbyte* SpvcCompilerGetRemappedDeclaredBlockName(SpvcCompiler compiler, uint id);

		[DllImport(LibName, CallingConvention = CallingConvention.Cdecl, EntryPoint = "spvc_compiler_get_buffer_block_decorations")]
		public static extern SpvcResult SpvcCompilerGetBufferBlockDecorations(SpvcCompiler compiler, uint id, SpvDecoration* decorations, nuint* num_decorations);

	}
}
