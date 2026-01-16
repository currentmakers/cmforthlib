\
\ @file ddrctrl.fs
\ @brief DDRCTRL
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DDRCTRL master register 0
\ Address offset: 0x00
\ Reset value: 0x00040001
\

$00000001 constant DDRCTRL_DDRCTRL_MSTR_DDR3                        \ Selects DDR3 SDRAM - 1 - DDR3 SDRAM device in use - 0 - non-DDR3 SDRAM device in use Only present in designs that support DDR3. Programming mode: Static
$00000004 constant DDRCTRL_DDRCTRL_MSTR_LPDDR2                      \ Selects LPDDR2 SDRAM - 1 - LPDDR2 SDRAM device in use. - 0 - non-LPDDR2 device in use Present only in designs configured to support LPDDR2. Programming mode: Static
$00000008 constant DDRCTRL_DDRCTRL_MSTR_LPDDR3                      \ Selects LPDDR3 SDRAM - 1 - LPDDR3 SDRAM device in use. - 0 - non-LPDDR3 device in use Present only in designs configured to support LPDDR3. Programming mode: Static
$00000200 constant DDRCTRL_DDRCTRL_MSTR_BURSTCHOP                   \ When set, enable burst-chop (BC4 or 8 on-the-fly) in DDR3/DDR4. The burst-chop for Reads is exercised only in HIF configurations (UMCTL2_INCL_ARB not set) and if in full bus width mode (MSTR.data_bus_width = 00) and if MEMC_BURST_LENGTH=8 or 16. The burst-chop for writes is exercised only if partial writes enabled (UMCTL2_PARTIAL_WR=1) and if CRC is disabled (CRCPARCTL1.crc_enable = 0). The BC4 (fixed) mode is not supported. Programming mode: Static
$00000400 constant DDRCTRL_DDRCTRL_MSTR_EN_2T_TIMING_MODE           \ If 1, then the DDRCTRL uses 2T timing. Otherwise, uses 1T timing. In 2T timing, all command signals (except chip select) are held for 2 clocks on the SDRAM bus. The chip select is asserted on the second cycle of the command Note: 2T timing is not supported in LPDDR2/LPDDR3/LPDDR4 mode Note: 2T timing is not supported if the configuration parameter MEMC_CMD_RTN2IDLE is set Note: 2T timing is not supported in DDR4 geardown mode. Note: 2T timing is not supported in Shared-AC dual channel mode and the register value is don't care. Programming mode: Static
$00003000 constant DDRCTRL_DDRCTRL_MSTR_DATA_BUS_WIDTH              \ Selects proportion of DQ bus width that is used by the SDRAM - 00 - Full DQ bus width to SDRAM - 01 - Half DQ bus width to SDRAM - 10 - Quarter DQ bus width to SDRAM - 11 - Reserved. Note that half bus width mode is only supported when the SDRAM bus width is a multiple of 16, and quarter bus width mode is only supported when the SDRAM bus width is a multiple of 32 and the configuration parameter MEMC_QBUS_SUPPORT is set. the bus width refers to DQ bus width (excluding any ECC width). Programming mode: Static
$00008000 constant DDRCTRL_DDRCTRL_MSTR_DLL_OFF_MODE                \ Set to 1 when the DDRCTRL and DRAM has to be put in DLL-off mode for low frequency operation. Set to 0 to put DDRCTRL and DRAM in DLL-on mode for normal frequency operation. If DDR4 CRC/parity retry is enabled (CRCPARCTL1.crc_parity_retry_enable = 1), dll_off_mode is not supported, and this bit must be set to '0'. Programming mode: Quasi-dynamic Group 2
$000f0000 constant DDRCTRL_DDRCTRL_MSTR_BURST_RDWR                  \ SDRAM burst length used: - 0001 - Burst length of 2 (only supported for mDDR) - 0010 - Burst length of 4 - 0100 - Burst length of 8 - 1000 - Burst length of 16 (only supported for mDDR, LPDDR2, and LPDDR4) All other values are reserved. This controls the burst size used to access the SDRAM. This must match the burst length mode register setting in the SDRAM. (For BC4/8 on-the-fly mode of DDR3 and DDR4, set this field to 0x0100) The burst length of 2 is not supported with the AXI port when MEMC_BURST_LENGTH is 8. The burst length of 2 is only supported when the controller is operating in 1:1 frequency mode. For DDR3, DDR4 and LPDDR3, this must be set to 0x0100 (BL8). For LPDDR4, this must be set to 0x1000 (BL16). Programming mode: Static


\
\ @brief DDRCTRL operating mode status register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant DDRCTRL_DDRCTRL_STAT_OPERATING_MODE              \ Operating mode. This is 3-bits wide in configurations with mDDR/LPDDR2/LPDDR3/LPDDR4/DDR4 support and 2-bits in all other configurations. Condition non-mDDR/LPDDR2/LPDDR3/LPDDR4 and non-DDR4 designs: - 000 - Init - 001 - Normal - 010 - Power-down - 011 - Self refresh Condition mDDR/LPDDR2/LPDDR3 or DDR4 designs: - 000 - Init - 001 - Normal - 010 - Power-down - 011 - Self refresh - 1XX - Deep power-down / Maximum Power Saving Mode - 000 - Init - 001 - Normal - 010 - Power-down - 011 - Self refresh / Self refresh power-down Programming mode: Dynamic
$00000030 constant DDRCTRL_DDRCTRL_STAT_SELFREF_TYPE                \ Flags if Self Refresh (except LPDDR4) or SR-Powerdown (LPDDR4) is entered and if it was under Automatic Self Refresh control only or not. - 00 - SDRAM is not in Self Refresh (except LPDDR4) or SR-Powerdown (LPDDR4). If retry is enabled by CRCPARCTRL1.crc_parity_retry_enable, this also indicates SRE command is still in parity error window or retry is in-progress. - 11 - SDRAM is in Self Refresh (except LPDDR4) or SR-Powerdown (LPDDR4), which was caused by Automatic Self Refresh only. If retry is enabled, this guarantees SRE command is executed correctly without parity error. - 10 - SDRAM is in Self Refresh (except LPDDR4) or SR-Powerdown (LPDDR4), which was not caused solely under Automatic Self Refresh control. It could have been caused by Hardware Low-power Interface and/or Software (PWRCTL.selfref_sw). If retry is enabled, this guarantees SRE command is executed correctly without parity error. - 01 - SDRAM is in Self Refresh, which was caused by PHY Master Request. Programming mode: Dynamic
$00001000 constant DDRCTRL_DDRCTRL_STAT_SELFREF_CAM_NOT_EMPTY       \ Self refresh with CAMs not empty. Set to 1 when Self Refresh is entered but CAMs are not drained. Cleared after exiting Self Refresh. Programming mode: Dynamic


\
\ @brief DDRCTRL mode register read/write control register 0
\ Address offset: 0x10
\ Reset value: 0x00000010
\

$00000001 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_TYPE                  \ Indicates whether the mode register operation is read or write. Only used for LPDDR2/LPDDR3/LPDDR4/DDR4. - 0 - Write - 1 - Read Programming mode: Dynamic
$0000f000 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_ADDR                  \ Address of the mode register that is to be written to. - 0000 - MR0 - 0001 - MR1 - 0010 - MR2 - 0011 - MR3 - 0100 - MR4 - 0101 - MR5 - 0110 - MR6 - 0111 - MR7 Don't Care for LPDDR2/LPDDR3/LPDDR4 (see MRCTRL1.mr_data for mode register addressing in LPDDR2/LPDDR3/LPDDR4) This signal is also used for writing to control words of the register chip on RDIMMs/LRDIMMs. In that case, it corresponds to the bank address bits sent to the RDIMM/LRDIMM In case of DDR4, the bit[3:2] corresponds to the bank group bits. Therefore, the bit[3] as well as the bit[2:0] must be set to an appropriate value which is considered both the Address Mirroring of UDIMMs/RDIMMs/LRDIMMs and the Output Inversion of RDIMMs/LRDIMMs. Programming mode: Dynamic
$80000000 constant DDRCTRL_DDRCTRL_MRCTRL0_MR_WR                    \ Setting this register bit to 1 triggers a mode register read or write operation. When the MR operation is complete, the DDRCTRL automatically clears this bit. The other register fields of this register must be written in a separate APB transaction, before setting this mr_wr bit. It is recommended NOT to set this signal if in Init, Deep power-down or MPSM operating modes. Programming mode: Dynamic


\
\ @brief DDRCTRL mode register read/write control register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_MRCTRL1_MR_DATA                  \ Mode register write data for all non-LPDDR2/non-LPDDR3/non-LPDDR4 modes. For LPDDR2/LPDDR3/LPDDR4, MRCTRL1[15:0] are interpreted as [15:8] MR Address [7:0] MR data for writes, don't care for reads. This is 18-bits wide in configurations with DDR4 support and 16-bits in all other configurations. Programming mode: Dynamic


\
\ @brief DDRCTRL mode register read/write status register
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_MRSTAT_MR_WR_BUSY                \ The SoC core may initiate a MR write operation only if this signal is low. This signal goes high in the clock after the DDRCTRL accepts the MRW/MRR request. It goes low when the MRW/MRR command is issued to the SDRAM. It is recommended not to perform MRW/MRR commands when 'MRSTAT.mr_wr_busy' is high. - 0 - Indicates that the SoC core can initiate a mode register write operation - 1 - Indicates that mode register write operation is in progress Programming mode: Dynamic


\
\ @brief DDRCTRL temperature derate enable register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_ENABLE           \ Enables derating - 0 - Timing parameter derating is disabled - 1 - Timing parameter derating is enabled using MR4 read value. Present only in designs configured to support LPDDR2/LPDDR3/LPDDR4 This field must be set to '0' for non-LPDDR2/LPDDR3/LPDDR4 mode. Programming mode: Dynamic
$00000006 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_VALUE            \ Derate value - 0 - Derating uses +1. - 1 - Derating uses +2. Present only in designs configured to support LPDDR2/LPDDR3/LPDDR4 Set to 0 for all LPDDR2 speed grades as derating value of +1.875 ns is less than a core_ddrc_core_clk period. For LPDDR3/4, if the period of core_ddrc_core_clk is less than 1.875ns, this register field should be set to 1; otherwise it should be set to 0. Programming mode: Quasi-dynamic Group 2 and Group 4
$000000f0 constant DDRCTRL_DDRCTRL_DERATEEN_DERATE_BYTE             \ Derate byte Present only in designs configured to support LPDDR2/LPDDR3/LPDDR4 Indicates which byte of the MRR data is used for derating. The maximum valid value depends on MEMC_DRAM_TOTAL_DATA_WIDTH. Programming mode: Static


\
\ @brief DDRCTRL temperature derate interval register
\ Address offset: 0x24
\ Reset value: 0x00800000
\

$00000000 constant DDRCTRL_DDRCTRL_DERATEINT_MR4_READ_INTERVAL      \ Interval between two MR4 reads, used to derate the timing parameters. Present only in designs configured to support LPDDR2/LPDDR3/LPDDR4. This register must not be set to zero. Unit: DFI clock cycle. Programming mode: Static


\
\ @brief DDRCTRL low power control register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PWRCTL_SELFREF_EN                \ If true then the DDRCTRL puts the SDRAM into Self Refresh after a programmable number of cycles "maximum idle clocks before Self Refresh (PWRTMG.selfref_to_x32)". This register bit may be re-programmed during the course of normal operation. Programming mode: Dynamic
$00000002 constant DDRCTRL_DDRCTRL_PWRCTL_POWERDOWN_EN              \ If true then the DDRCTRL goes into power-down after a programmable number of cycles "maximum idle clocks before power down" (PWRTMG.powerdown_to_x32). This register bit may be re-programmed during the course of normal operation. Programming mode: Dynamic
$00000004 constant DDRCTRL_DDRCTRL_PWRCTL_DEEPPOWERDOWN_EN          \ When this is 1, DDRCTRL puts the SDRAM into deep power-down mode when the transaction store is empty. This register must be reset to '0' to bring DDRCTRL out of deep power-down mode. Controller performs automatic SDRAM initialization on deep power-down exit. Present only in designs configured to support mDDR or LPDDR2 or LPDDR3. For non-mDDR/non-LPDDR2/non-LPDDR3, this register should not be set to 1. For performance only Programming mode: Dynamic
$00000008 constant DDRCTRL_DDRCTRL_PWRCTL_EN_DFI_DRAM_CLK_DISABLE    \ Enable the assertion of dfi_dram_clk_disable whenever a clock is not required by the SDRAM. If set to 0, dfi_dram_clk_disable is never asserted. Assertion of dfi_dram_clk_disable is as follows: In DDR2/DDR3, can only be asserted in Self Refresh. In DDR4, can be asserted in following: - in Self Refresh. - in Maximum Power Saving Mode In mDDR/LPDDR2/LPDDR3, can be asserted in following: - in Self Refresh - in Power Down - in Deep Power Down - during Normal operation (Clock Stop) In LPDDR4, can be asserted in following: - in Self Refresh Power Down - in Power Down - during Normal operation (Clock Stop) Programming mode: Dynamic
$00000020 constant DDRCTRL_DDRCTRL_PWRCTL_SELFREF_SW                \ A value of 1 to this register causes system to move to Self Refresh state immediately, as long as it is not in INIT or DPD/MPSM operating_mode. This is referred to as Software Entry/Exit to Self Refresh. - 1 - Software Entry to Self Refresh - 0 - Software Exit from Self Refresh Programming mode: Dynamic
$00000080 constant DDRCTRL_DDRCTRL_PWRCTL_DIS_CAM_DRAIN_SELFREF     \ Indicates whether skipping CAM draining is allowed when entering Self-Refresh. This register field cannot be modified while PWRCTL.selfref_sw==1. - 0 - CAMs must be empty before entering SR - 1 - CAMs are not emptied before entering SR (unsupported) Note, PWRCTL.dis_cam_drain_selfref=1 is unsupported in this release. PWRCTL.dis_cam_drain_selfref=0 is required. Programming mode: Dynamic


\
\ @brief DDRCTRL low power timing register
\ Address offset: 0x34
\ Reset value: 0x00402010
\

$0000001f constant DDRCTRL_DDRCTRL_PWRTMG_POWERDOWN_TO_X32          \ After this many clocks of the DDRC command channel being idle the DDRCTRL automatically puts the SDRAM into power-down. The DDRC command channel is considered idle when there are no HIF commands outstanding. This must be enabled in the PWRCTL.powerdown_en. Unit: Multiples of 32 DFI clocks For performance only. Programming mode: Quasi-dynamic Group 4
$0000ff00 constant DDRCTRL_DDRCTRL_PWRTMG_T_DPD_X4096               \ Minimum deep power-down time. For mDDR, value from the JEDEC specification is 0 as mDDR exits from deep power-down mode immediately after PWRCTL.deeppowerdown_en is de-asserted. For LPDDR2/LPDDR3, value from the JEDEC specification is 500 us. Unit: Multiples of 4096 DFI clocks. Present only in designs configured to support mDDR, LPDDR2 or LPDDR3. For performance only. Programming mode: Quasi-dynamic Group 4
$00ff0000 constant DDRCTRL_DDRCTRL_PWRTMG_SELFREF_TO_X32            \ After this many clocks of the DDRC command channel being idle the DDRCTRL automatically puts the SDRAM into Self Refresh. The DDRC command channel is considered idle when there are no HIF commands outstanding. This must be enabled in the PWRCTL.selfref_en. Unit: Multiples of 32 DFI clocks. For performance only. Programming mode: Quasi-dynamic Group 4


\
\ @brief DDRCTRL hardware low power control register
\ Address offset: 0x38
\ Reset value: 0x00000003
\

$00000001 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_EN                 \ Enable for hardware low power interface. Programming mode: Quasi-dynamic Group 3
$00000002 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_EXIT_IDLE_EN       \ When this bit is programmed to 1 the cactive_in_ddrc pin of the DDRC can be used to exit from the automatic clock stop, automatic power down or automatic self-refresh modes. Note, it does not cause exit of Self-Refresh that is caused by Hardware Low power interface and/or software (PWRCTL.selfref_sw). Programming mode: Static
$0fff0000 constant DDRCTRL_DDRCTRL_HWLPCTL_HW_LP_IDLE_X32           \ Hardware idle period. The cactive_ddrc output is driven low if the DDRC command channel is idle for hw_lp_idle * 32 cycles if not in INIT or DPD/MPSM operating_mode. The DDRC command channel is considered idle when there are no HIF commands outstanding. The hardware idle function is disabled when hw_lp_idle_x32=0. Unit: Multiples of 32 DFI clocks. For performance only. Programming mode: Static


\
\ @brief DDRCTRL refresh control register 0
\ Address offset: 0x50
\ Reset value: 0x00210000
\

$00000004 constant DDRCTRL_DDRCTRL_RFSHCTL0_PER_BANK_REFRESH        \ - 1 - Per bank refresh; - 0 - All bank refresh. Per bank refresh allows traffic to flow to other banks. Per bank refresh is not supported by all LPDDR2 devices but should be supported by all LPDDR3/LPDDR4 devices. Present only in designs configured to support LPDDR2/LPDDR3/LPDDR4 Programming mode: Static
$000001f0 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_BURST           \ The programmed value + 1 is the number of refresh timeouts that is allowed to accumulate before traffic is blocked and the refreshes are forced to execute. Closing pages to perform a refresh is a one-time penalty that must be paid for each group of refreshes. Therefore, performing refreshes in a burst reduces the per-refresh penalty of these page closings. Higher numbers for RFSHCTL.refresh_burst slightly increases utilization; lower numbers decreases the worst-case latency associated with refreshes. - 0 - single refresh - 1 - burst-of-2 refresh - 7 - burst-of-8 refresh For information on burst refresh feature refer to section 3.9 of DDR2 JEDEC specification - JESD79-2F.pdf. For DDR2/3, the refresh is always per-rank and not per-bank. The rank refresh can be accumulated over 8*tREFI cycles using the burst refresh feature. In DDR4 mode, according to Fine Granularity feature, 8 refreshes can be postponed in 1X mode, 16 refreshes in 2X mode and 32 refreshes in 4X mode. If using PHY-initiated updates, care must be taken in the setting of RFSHCTL0.refresh_burst, to ensure that tRFCmax is not violated due to a PHY-initiated update occurring shortly before a refresh burst was due. In this situation, the refresh burst is delayed until the PHY-initiated update is complete. Programming mode: dynamic - refresh related
$0001f000 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_TO_X32          \ If the refresh timer (tRFCnom, also known as tREFI) has expired at least once, but it has not expired (RFSHCTL0.refresh_burst+1) times yet, then a speculative refresh may be performed. A speculative refresh is a refresh performed at a time when refresh would be useful, but before it is absolutely required. When the SDRAM bus is idle for a period of time determined by this RFSHCTL0.refresh_to_x32 and the refresh timer has expired at least once since the last refresh, then a speculative refresh is performed. Speculative refreshes continues successively until there are no refreshes pending or until new reads or writes are issued to the DDRCTRL. For performance only. Unit: Multiples of 32 DFI clocks. Programming mode: Dynamic - Refresh Related
$00f00000 constant DDRCTRL_DDRCTRL_RFSHCTL0_REFRESH_MARGIN          \ Threshold value in number of DFI clock cycles before the critical refresh or page timer expires. A critical refresh is to be issued before this threshold is reached. It is recommended that this not be changed from the default value, currently shown as 0x2. It must always be less than internally used t_rfc_nom/32. Note that internally used t_rfc_nom is equal to RFSHTMG.t_rfc_nom_x1_x32 * 32 if RFSHTMG.t_rfc_nom_x1_sel=0. If RFSHTMG.t_rfc_nom_x1_sel=1 (for LPDDR2/LPDDR3/LPDDR4 per-bank refresh only), internally used t_rfc_nom is equal to RFSHTMG.t_rfc_nom_x1_x32. Note that, in LPDDR2/LPDDR3/LPDDR4, internally used t_rfc_nom may be divided by four if derating is enabled (DERATEEN.derate_enable=1). Unit: Multiples of 32 DFI clocks. Programming mode: Dynamic - Refresh Related


\
\ @brief DDRCTRL refresh control register 3
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_RFSHCTL3_DIS_AUTO_REFRESH        \ When '1', disable auto-refresh generated by the DDRCTRL. When auto-refresh is disabled, the SoC core must generate refreshes using the registers DBGCMD.rankn_refresh. When dis_auto_refresh transitions from 0 to 1, any pending refreshes are immediately scheduled by the DDRCTRL. If DDR4 CRC/parity retry is enabled (CRCPARCTL1.crc_parity_retry_enable = 1), disable auto-refresh is not supported, and this bit must be set to '0'. (DDR4 only) If FGR mode is enabled (RFSHCTL3.refresh_mode > 0), disable auto-refresh is not supported, and this bit must be set to '0'. This register field is changeable on the fly. Programming mode: Dynamic - Refresh Related
$00000002 constant DDRCTRL_DDRCTRL_RFSHCTL3_REFRESH_UPDATE_LEVEL    \ Toggles this signal (either from 0 to 1 or from 1 to 0) to indicate that the refresh register(s) have been updated. refresh_update_level must not be toggled when the DDRC is in reset (core_ddrc_rstn = 0). The refresh register(s) are automatically updated when exiting reset. Programming mode: Dynamic


\
\ @brief DDRCTRL refresh timing register
\ Address offset: 0x64
\ Reset value: 0x0062008C
\

$000003ff constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_MIN                \ tRFC (min): Minimum time from refresh to refresh or activate. When the controller is operating in 1:1 mode, t_rfc_min should be set to RoundUp(tRFCmin/tCK). When the controller is operating in 1:2 mode, t_rfc_min should be set to RoundUp(RoundUp(tRFCmin/tCK)/2). In LPDDR2/LPDDR3/LPDDR4 mode: - If using all-bank refreshes, the tRFCmin value in the above equations is equal to tRFCab - If using per-bank refreshes, the tRFCmin value in the above equations is equal to tRFCpb In DDR4 mode, the tRFCmin value in the above equations is different depending on the refresh mode (fixed 1X,2X,4X) and the device density. The user should program the appropriate value from the spec based on the 'refresh_mode' and the device density that is used. Unit: Clocks. Programming mode: Dynamic - Refresh Related
$00008000 constant DDRCTRL_DDRCTRL_RFSHTMG_LPDDR3_TREFBW_EN         \ Used only when LPDDR3 memory type is connected. Should only be changed when DDRCTRL is in reset. Specifies whether to use the tREFBW parameter (required by some LPDDR3 devices which comply with earlier versions of the LPDDR3 JEDEC specification) or not: - 0 - tREFBW parameter not used - 1 - tREFBW parameter used Programming mode: Static
$0fff0000 constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_NOM_X1_X32         \ tREFI: Average time interval between refreshes per rank (Specification: 7.8us for DDR2, DDR3 and DDR4. See JEDEC specification for mDDR, LPDDR2, LPDDR3 and LPDDR4). For LPDDR2/LPDDR3/LPDDR4: - If using all-bank refreshes (RFSHCTL0.per_bank_refresh = 0), this register should be set to tREFIab - If using per-bank refreshes (RFSHCTL0.per_bank_refresh = 1), this register should be set to tREFIpb When the controller is operating in 1:2 frequency ratio mode, program this to (tREFI/2), no rounding up. In DDR4 mode, tREFI value is different depending on the refresh mode. The user should program the appropriate value from the spec based on the value programmed in the refresh mode register. Note that if RFSHTMG.t_rfc_nom_x1_sel == 1, RFSHTMG.t_rfc_nom_x1_x32 must be greater than RFSHTMG.t_rfc_min; if RFSHTMG.t_rfc_nom_x1_sel == 0, RFSHTMG.t_rfc_nom_x1_x32 * 32 must be greater than RFSHTMG.t_rfc_min; RFSHTMG.t_rfc_nom_x1_x32 must be greater than 0x1. - Non-DDR4 or DDR4 Fixed 1x mode: RFSHTMG.t_rfc_nom_x1_x32 must be less than or equal to 0xFFE. - DDR4 Fixed 2x mode: RFSHTMG.t_rfc_nom_x1_x32 must be less than or equal to 0x7FF. - DDR4 Fixed 4x mode: RFSHTMG.t_rfc_nom_x1_x32 must be less than or equal to 0x3FF. Unit: Clocks or multiples of 32 clocks, depending on RFSHTMG.t_rfc_nom_x1_sel. Programming mode: Dynamic - Refresh Related
$80000000 constant DDRCTRL_DDRCTRL_RFSHTMG_T_RFC_NOM_X1_SEL         \ Specifies whether the t_rfc_nom_x1_x32 register value is x1 or x32. Programming mode: Dynamic - Refresh Related


\
\ @brief DDRCTRL CRC parity control register 0
\ Address offset: 0xC0
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_INT_EN    \ Interrupt enable bit for DFI alert error. If this bit is set, any parity/CRC error detected on the dfi_alert_n input results in an interrupt being set on CRCPARSTAT.dfi_alert_err_int. Programming mode: Dynamic
$00000002 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_INT_CLR    \ Interrupt clear bit for DFI alert error. If this bit is set, the alert error interrupt on CRCPARSTAT.dfi_alert_err_int is cleared. When the clear operation is complete, the DDRCTRL automatically clears this bit. Programming mode: Dynamic
$00000004 constant DDRCTRL_DDRCTRL_CRCPARCTL0_DFI_ALERT_ERR_CNT_CLR    \ DFI alert error count clear. Clear bit for DFI alert error counter. Asserting this bit, clears the DFI alert error counter, CRCPARSTAT.dfi_alert_err_cnt. When the clear operation is complete, the DDRCTRL automatically clears this bit. Programming mode: Dynamic


\
\ @brief DDRCTRL CRC parity status register
\ Address offset: 0xCC
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_CRCPARSTAT_DFI_ALERT_ERR_CNT     \ DFI alert error count. If a parity/CRC error is detected on dfi_alert_n, this counter be incremented. This is independent of the setting of CRCPARCTL0.dfi_alert_err_int_en. It saturates at 0xFFFF, and can be cleared by asserting CRCPARCTL0.dfi_alert_err_cnt_clr. Programming mode: Static
$00010000 constant DDRCTRL_DDRCTRL_CRCPARSTAT_DFI_ALERT_ERR_INT     \ DFI alert error interrupt. If a parity/CRC error is detected on dfi_alert_n, and the interrupt is enabled by CRCPARCTL0.dfi_alert_err_int_en, this interrupt bit is set. It remains set until cleared by CRCPARCTL0.dfi_alert_err_int_clr Programming mode: Static


\
\ @brief DDRCTRL SDRAM initialization register 0
\ Address offset: 0xD0
\ Reset value: 0x0002004E
\

$00000fff constant DDRCTRL_DDRCTRL_INIT0_PRE_CKE_X1024              \ Cycles to wait after reset before driving CKE high to start the SDRAM initialization sequence. Unit: 1024 DFI clock cycles. DDR2 specifications typically require this to be programmed for a delay of >= 200 us. LPDDR2/LPDDR3: tINIT1 of 100 ns (min) LPDDR4: tINIT3 of 2 ms (min) When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. For DDR3/DDR4 RDIMMs, this should include the time needed to satisfy tSTAB Programming mode: Static
$03ff0000 constant DDRCTRL_DDRCTRL_INIT0_POST_CKE_X1024             \ Cycles to wait after driving CKE high to start the SDRAM initialization sequence. Unit: 1024 DFI clock cycles. DDR2 typically requires a 400 ns delay, requiring this value to be programmed to 2 at all clock speeds. LPDDR2/LPDDR3 typically requires this to be programmed for a delay of 200 us. LPDDR4 typically requires this to be programmed for a delay of 2 us. When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. Programming mode: Static
$c0000000 constant DDRCTRL_DDRCTRL_INIT0_SKIP_DRAM_INIT             \ If lower bit is enabled the SDRAM initialization routine is skipped. The upper bit decides what state the controller starts up in when reset is removed - 00 - SDRAM Initialization routine is run after power-up - 01 - SDRAM Initialization routine is skipped after power-up. Controller starts up in Normal Mode - 11 - SDRAM Initialization routine is skipped after power-up. Controller starts up in Self-refresh Mode - 10 - Reserved. Programming mode: Quasi-dynamic Group 2


\
\ @brief DDRCTRL SDRAM initialization register 1
\ Address offset: 0xD4
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_INIT1_PRE_OCD_X32                \ Wait period before driving the OCD complete command to SDRAM. Unit: Counts of a global timer that pulses every 32 DFI clock cycles. There is no known specific requirement for this; it may be set to zero. Programming mode: Static
$01ff0000 constant DDRCTRL_DDRCTRL_INIT1_DRAM_RSTN_X1024            \ Number of cycles to assert SDRAM reset signal during init sequence. This is only present for designs supporting DDR3, DDR4 or LPDDR4 devices. For use with a DDR PHY, this should be set to a minimum of 1. When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. Unit: 1024 DFI clock cycles. Programming mode: Static


\
\ @brief DDRCTRL SDRAM initialization register 2
\ Address offset: 0xD8
\ Reset value: 0x00000D05
\

$0000000f constant DDRCTRL_DDRCTRL_INIT2_MIN_STABLE_CLOCK_X1        \ Time to wait after the first CKE high, tINIT2. Present only in designs configured to support LPDDR2/LPDDR3. LPDDR2/LPDDR3 typically requires 5 x tCK delay. When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. Unit: DFI clock cycles. Programming mode: Static
$0000ff00 constant DDRCTRL_DDRCTRL_INIT2_IDLE_AFTER_RESET_X32       \ Idle time after the reset command, tINIT4. Present only in designs configured to support LPDDR2. When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. Unit: 32 DFI clock cycles. Programming mode: Static


\
\ @brief DDRCTRL SDRAM initialization register 3
\ Address offset: 0xDC
\ Reset value: 0x00000510
\

$0000ffff constant DDRCTRL_DDRCTRL_INIT3_EMR                        \ DDR2: Value to write to EMR register. Bits 9:7 are for OCD and the setting in this register is ignored. The DDRCTRL sets those bits appropriately. DDR3/DDR4: Value to write to MR1 register Set bit 7 to 0. If PHY-evaluation mode training is enabled, this bit is set appropriately by the DDRCTRL during write leveling. mDDR: Value to write to EMR register. LPDDR2/LPDDR3/LPDDR4 - Value to write to MR2 register Programming mode: Quasi-dynamic Group 4
$ffff0000 constant DDRCTRL_DDRCTRL_INIT3_MR                         \ DDR2: Value to write to MR register. Bit 8 is for DLL and the setting here is ignored. The DDRCTRL sets this bit appropriately. DDR3/DDR4: Value loaded into MR0 register. mDDR: Value to write to MR register. LPDDR2/LPDDR3/LPDDR4 - Value to write to MR1 register Programming mode: Quasi-dynamic Group 1 and Group 4


\
\ @brief DDRCTRL SDRAM initialization register 4
\ Address offset: 0xE0
\ Reset value: 0x00000000
\

$0000ffff constant DDRCTRL_DDRCTRL_INIT4_EMR3                       \ DDR2: Value to write to EMR3 register. DDR3/DDR4: Value to write to MR3 register mDDR/LPDDR2/LPDDR3: Unused LPDDR4: Value to write to MR13 register Programming mode: Quasi-dynamic Group 2 and Group 4
$ffff0000 constant DDRCTRL_DDRCTRL_INIT4_EMR2                       \ DDR2: Value to write to EMR2 register. DDR3/DDR4: Value to write to MR2 register LPDDR2/LPDDR3/LPDDR4: Value to write to MR3 register mDDR: Unused Programming mode: Quasi-dynamic Group 4


\
\ @brief DDRCTRL SDRAM initialization register 5
\ Address offset: 0xE4
\ Reset value: 0x00100004
\

$000003ff constant DDRCTRL_DDRCTRL_INIT5_MAX_AUTO_INIT_X1024        \ Maximum duration of the auto initialization, tINIT5. Present only in designs configured to support LPDDR2/LPDDR3. LPDDR2/LPDDR3 typically requires 10 us. Unit: 1024 DFI clock cycles. Programming mode: Static
$00ff0000 constant DDRCTRL_DDRCTRL_INIT5_DEV_ZQINIT_X32             \ ZQ initial calibration, tZQINIT. Present only in designs configured to support DDR3 or DDR4 or LPDDR2/LPDDR3. DDR3 typically requires 512 SDRAM clock cycles. DDR4 requires 1024 SDRAM clock cycles. LPDDR2/LPDDR3 requires 1 us. When the controller is operating in 1:2 frequency ratio mode, program this to JEDEC spec value divided by 2, and round it up to the next integer value. Unit: 32 DFI clock cycles. Programming mode: Static


\
\ @brief DDRCTRL DIMM control register
\ Address offset: 0xF0
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DIMMCTL_DIMM_STAGGER_CS_EN       \ Staggering enable for multi-rank accesses (for multi-rank UDIMM, RDIMM and LRDIMM implementations only). This is not supported for mDDR, LPDDR2, LPDDR3 or LPDDR4 SDRAMs. Note: Even if this bit is set it does not take care of software driven MR commands (via MRCTRL0/MRCTRL1), where software is responsible to send them to separate ranks as appropriate. - 1 - (DDR4) Send MRS commands to each ranks separately - 1 - (non-DDR4) Send all commands to even and odd ranks separately - 0 - Do not stagger accesses Programming mode: Static.
$00000002 constant DDRCTRL_DDRCTRL_DIMMCTL_DIMM_ADDR_MIRR_EN        \ Address Mirroring Enable (for multi-rank UDIMM implementations and multi-rank DDR4 RDIMM/LRDIMM implementations). Some UDIMMs and DDR4 RDIMMs/LRDIMMs implement address mirroring for odd ranks, which means that the following address, bank address and bank group bits are swapped: (A3, A4), (A5, A6), (A7, A8), (BA0, BA1) and also (A11, A13), (BG0, BG1) for the DDR4. Setting this bit ensures that, for mode register accesses during the automatic initialization routine, these bits are swapped within the DDRCTRL to compensate for this UDIMM/RDIMM/LRDIMM swapping. In addition to the automatic initialization routine, in case of DDR4 UDIMM/RDIMM/LRDIMM, they are swapped during the automatic MRS access to enable/disable of a particular DDR4 feature. Note: This has no effect on the address of any other memory accesses, or of software-driven mode register accesses. This is not supported for mDDR, LPDDR2, LPDDR3 or LPDDR4 SDRAMs. Note: In case of x16 DDR4 DIMMs, BG1 output of MRS for the odd ranks is same as BG0 because BG1 is invalid, hence dimm_dis_bg_mirroring register must be set to 1. - 1 - For odd ranks, implement address mirroring for MRS commands to during initialization and for any automatic DDR4 MRS commands (to be used if UDIMM/RDIMM/LRDIMM implements address mirroring) - 0 - Do not implement address mirroring Programming mode: Static


\
\ @brief DDRCTRL SDRAM timing register 0
\ Address offset: 0x100
\ Reset value: 0x0F101B0F
\

$0000003f constant DDRCTRL_DDRCTRL_DRAMTMG0_T_RAS_MIN               \ tRAS(min): Minimum time between activate and precharge to the same bank. When the controller is operating in 1:2 frequency mode, 1T mode, program this to tRAS(min)/2. No rounding up. When the controller is operating in 1:2 frequency ratio mode, 2T mode or LPDDR4 mode, program this to (tRAS(min)/2) and round it up to the next integer value. Unit: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.
$00007f00 constant DDRCTRL_DDRCTRL_DRAMTMG0_T_RAS_MAX               \ tRAS(max): Maximum time between activate and precharge to same bank. This is the maximum time that a page can be kept open Minimum value of this register is 1. Zero is invalid. When the controller is operating in 1:2 frequency ratio mode, program this to (tRAS(max)-1)/2. No rounding up. Unit: Multiples of 1024 clocks. Programming mode: Quasi-dynamic Group 2 and Group 4
$003f0000 constant DDRCTRL_DDRCTRL_DRAMTMG0_T_FAW                   \ tFAW Valid only when 8 or more banks(or banks x bank groups) are present. In 8-bank design, at most 4 banks must be activated in a rolling window of tFAW cycles. When the controller is operating in 1:2 frequency ratio mode, program this to (tFAW/2) and round up to next integer value. In a 4-bank design, set this register to 0x1 independent of the 1:1/1:2 frequency mode. Unit: Clocks Programming mode: Quasi-dynamic Group 2 and Group 4.
$7f000000 constant DDRCTRL_DDRCTRL_DRAMTMG0_WR2PRE                  \ Minimum time between write and precharge to same bank. Unit: Clocks Specifications: WL + BL/2 + tWR = approximately 8 cycles + 15 ns = 14 clocks @400MHz and less for lower frequencies where: - WL = write latency - BL = burst length. This must match the value programmed in the BL bit of the mode register to the SDRAM. BST (burst terminate) is not supported at present. - tWR = Write recovery time. This comes directly from the SDRAM specification. Add one extra cycle for LPDDR2/LPDDR3/LPDDR4 for this parameter. When the controller is operating in 1:2 frequency ratio mode, 1T mode, divide the above value by 2. No rounding up. When the controller is operating in 1:2 frequency ratio mode, 2T mode or LPDDR4 mode, divide the above value by 2 and round it up to the next integer value. Note that, depending on the PHY, if using LRDIMM, it may be necessary to adjust the value of this parameter to compensate for the extra cycle of latency through the LRDIMM. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4.


\
\ @brief DDRCTRL SDRAM timing register 1
\ Address offset: 0x104
\ Reset value: 0x00080414
\

$0000007f constant DDRCTRL_DDRCTRL_DRAMTMG1_T_RC                    \ tRC: Minimum time between activates to same bank. When the controller is operating in 1:2 frequency ratio mode, program this to (tRC/2) and round up to next integer value. Unit: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG1_RD2PRE                  \ tRTP: Minimum time from read to precharge of same bank. - DDR2: tAL + BL/2 + max(tRTP, 2) - 2 - DDR3: tAL + max (tRTP, 4) - DDR4: Max of following two equations: tAL + max (tRTP, 4) or, RL + BL/2 - tRP (*). - mDDR: BL/2 - LPDDR2: Depends on if it's LPDDR2-S2 or LPDDR2-S4: LPDDR2-S2: BL/2 + tRTP - 1. LPDDR2-S4: BL/2 + max(tRTP,2) - 2. - LPDDR3: BL/2 + max(tRTP,4) - 4 - LPDDR4: BL/2 + max(tRTP,8) - 8 (*) When both DDR4 SDRAM and ST-MRAM are used simultaneously, use SDRAM's tRP value for calculation. When the controller is operating in 1:2 mode, 1T mode, divide the above value by 2. No rounding up. When the controller is operating in 1:2 mode, 2T mode or LPDDR4 mode, divide the above value by 2 and round it up to the next integer value. Unit: Clocks. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4
$001f0000 constant DDRCTRL_DDRCTRL_DRAMTMG1_T_XP                    \ tXP: Minimum time after power-down exit to any operation. For DDR3, this should be programmed to tXPDLL if slow powerdown exit is selected in MR0[12]. If C/A parity for DDR4 is used, set to (tXP+PL) instead. If LPDDR4 is selected and its spec has tCKELPD parameter, set to the larger of tXP and tCKELPD instead. When the controller is operating in 1:2 frequency ratio mode, program this to (tXP/2) and round it up to the next integer value. Units: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.


\
\ @brief DDRCTRL SDRAM timing register 2
\ Address offset: 0x108
\ Reset value: 0x0305060D
\

$0000003f constant DDRCTRL_DDRCTRL_DRAMTMG2_WR2RD                   \ DDR4: CWL + PL + BL/2 + tWTR_L LPDDR2/3/4: WL + BL/2 + tWTR + 1 Others: CWL + BL/2 + tWTR In DDR4, minimum time from write command to read command for same bank group. In others, minimum time from write command to read command. Includes time for bus turnaround, recovery times, and all per-bank, per-rank, and global constraints. Unit: Clocks. Where: - CWL = CAS write latency - WL = Write latency - PL = Parity latency - BL = burst length. This must match the value programmed in the BL bit of the mode register to the SDRAM - tWTR_L = internal write to read command delay for same bank group. This comes directly from the SDRAM specification. - tWTR = internal write to read command delay. This comes directly from the SDRAM specification. Add one extra cycle for LPDDR2/LPDDR3/LPDDR4 operation. When the controller is operating in 1:2 mode, divide the value calculated using the above equation by 2, and round it up to next integer. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG2_RD2WR                   \ DDR2/3/mDDR: RL + BL/2 + 2 - WL DDR4: RL + BL/2 + 1 + WR_PREAMBLE - WL LPDDR2/LPDDR3: RL + BL/2 + RU(tDQSCKmax/tCK) + 1 - WL LPDDR4(DQ ODT is Disabled): RL + BL/2 + RU(tDQSCKmax/tCK) + WR_PREAMBLE + RD_POSTAMBLE - WL LPDDR4(DQ ODT is Enabled) : RL + BL/2 + RU(tDQSCKmax/tCK) + RD_POSTAMBLE - ODTLon - RU(tODTon(min)/tCK) Minimum time from read command to write command. Include time for bus turnaround and all per-bank, per-rank, and global constraints. Please see the relevant PHY databook for details of what should be included here. Unit: Clocks. Where: - WL = write latency - BL = burst length. This must match the value programmed in the BL bit of the mode register to the SDRAM - RL = read latency = CAS latency - WR_PREAMBLE = write preamble. This is unique to DDR4 and LPDDR4. - RD_POSTAMBLE = read postamble. This is unique to LPDDR4. For LPDDR2/LPDDR3/LPDDR4, if derating is enabled (DERATEEN.derate_enable=1), derated tDQSCKmax should be used. When the controller is operating in 1:2 frequency ratio mode, divide the value calculated using the above equation by 2, and round it up to next integer. Note that, depending on the PHY, if using LRDIMM, it may be necessary to adjust the value of this parameter to compensate for the extra cycle of latency through the LRDIMM. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4
$003f0000 constant DDRCTRL_DDRCTRL_DRAMTMG2_READ_LATENCY            \ Set to RL The time from read command to read data on SDRAM interface. This must be set to RL. Note that, depending on the PHY, if using RDIMM/LRDIMM, it may be necessary to adjust the value of RL to compensate for the extra cycle of latency through the RDIMM/LRDIMM. When the controller is operating in 1:2 frequency ratio mode, divide the value calculated using the above equation by 2, and round it up to next integer. This register field is not required for DDR2 and DDR3 (except if MEMC_TRAINING is set), as the DFI read and write latencies defined in DFITMG0 and DFITMG1 are sufficient for those protocols. Unit: clocks. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4.
$3f000000 constant DDRCTRL_DDRCTRL_DRAMTMG2_WRITE_LATENCY           \ Set to WL The time from write command to write data on SDRAM interface. This must be set to WL. For mDDR, it should normally be set to 1. Note that, depending on the PHY, if using RDIMM/LRDIMM, it may be necessary to adjust the value of WL to compensate for the extra cycle of latency through the RDIMM/LRDIMM. When the controller is operating in 1:2 frequency ratio mode, divide the value calculated using the above equation by 2, and round it up to next integer. This register field is not required for DDR2 and DDR3 (except if MEMC_TRAINING is set), as the DFI read and write latencies defined in DFITMG0 and DFITMG1 are sufficient for those protocols. Unit: clocks. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4.


\
\ @brief DDRCTRL SDRAM timing register 3
\ Address offset: 0x10C
\ Reset value: 0x0050400C
\

$000003ff constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MOD                   \ tMOD: Parameter used only in DDR3 and DDR4. Cycles between load mode command and following non-load mode command. If C/A parity for DDR4 is used, set to tMOD_PAR(tMOD+PL) instead. If MPR writes for DDR4 are used, set to tMOD + AL (or tMPD_PAR + AL if C/A parity is also used). Set to tMOD if controller is operating in 1:1 frequency ratio mode, or tMOD/2 (rounded up to next integer) if controller is operating in 1:2 frequency ratio mode. Note that if using RDIMM/LRDIMM, depending on the PHY, it may be necessary to adjust the value of this parameter to compensate for the extra cycle of latency applied to mode register writes by the RDIMM/LRDIMM chip. Also note that if using LRDIMM, the minimum value of this register is tMRD_L2 if controller is operating in 1:1 frequency ratio mode, or tMRD_L2/2 (rounded up to next integer) if controller is operating in 1:2 frequency ratio mode. Programming mode: Quasi-dynamic Group 2 and Group 4
$0003f000 constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MRD                   \ tMRD: Cycles to wait after a mode register write or read. Depending on the connected SDRAM, tMRD represents: DDR2/mDDR: Time from MRS to any command DDR3/4: Time from MRS to MRS command LPDDR2: not used LPDDR3/4: Time from MRS to non-MRS command. When the controller is operating in 1:2 frequency ratio mode, program this to (tMRD/2) and round it up to the next integer value. If C/A parity for DDR4 is used, set to tMRD_PAR(tMOD+PL) instead. Programming mode: Quasi-dynamic Group 2 and Group 4
$3ff00000 constant DDRCTRL_DDRCTRL_DRAMTMG3_T_MRW                   \ Time to wait after a mode register write or read (MRW or MRR). Present only in designs configured to support LPDDR2, LPDDR3 or LPDDR4. LPDDR2 typically requires value of 5. LPDDR3 typically requires value of 10. LPDDR4: Set this to the larger of tMRW and tMRWCKEL. For LPDDR2, this register is used for the time from a MRW/MRR to all other commands. When the controller is operating in 1:2 frequency ratio mode, program this to the above values divided by 2 and round it up to the next integer value. For LDPDR3, this register is used for the time from a MRW/MRR to a MRW/MRR. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 4
\ Address offset: 0x110
\ Reset value: 0x05040405
\

$0000001f constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RP                    \ tRP: Minimum time from precharge to activate of same bank. When the controller is operating in 1:1 frequency ratio mode, t_rp should be set to RoundUp(tRP/tCK). When the controller is operating in 1:2 frequency ratio mode, t_rp should be set to RoundDown(RoundUp(tRP/tCK)/2) + 1. When the controller is operating in 1:2 frequency ratio mode in LPDDR4, t_rp should be set to RoundUp(RoundUp(tRP/tCK)/2). Unit: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.
$00000f00 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RRD                   \ DDR4: tRRD_L: Minimum time between activates from bank "a" to bank "b" for same bank group. Others: tRRD: Minimum time between activates from bank "a" to bank "b" When the controller is operating in 1:2 frequency ratio mode, program this to (tRRD_L/2 or tRRD/2) and round it up to the next integer value. Unit: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_CCD                   \ DDR4: tCCD_L: This is the minimum time between two reads or two writes for same bank group. Others: tCCD: This is the minimum time between two reads or two writes. When the controller is operating in 1:2 frequency ratio mode, program this to (tCCD_L/2 or tCCD/2) and round it up to the next integer value. Unit: clocks. Programming mode: Quasi-dynamic Group 2 and Group 4.
$1f000000 constant DDRCTRL_DDRCTRL_DRAMTMG4_T_RCD                   \ tRCD - tAL: Minimum time from activate to read or write command to same bank. When the controller is operating in 1:2 frequency ratio mode, program this to ((tRCD - tAL)/2) and round it up to the next integer value. Minimum value allowed for this register is 1, which implies minimum (tRCD - tAL) value to be 2 when the controller is operating in 1:2 frequency ratio mode. Unit: Clocks. Programming mode: Quasi-dynamic Group 1 and Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 5
\ Address offset: 0x114
\ Reset value: 0x05050403
\

$0000001f constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKE                   \ Minimum number of cycles of CKE HIGH/LOW during power-down and self refresh. - LPDDR2/LPDDR3 mode: Set this to the larger of tCKE or tCKESR - LPDDR4 mode: Set this to the larger of tCKE or tSR. - Non-LPDDR2/non-LPDDR3/non-LPDDR4 designs: Set this to tCKE value. When the controller is operating in 1:2 frequency ratio mode, program this to (value described above)/2 and round it up to the next integer value. Unit: Clocks. Programming mode: Quasi-dynamic Group 2 and Group 4
$00003f00 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKESR                 \ Minimum CKE low width for Self refresh or Self refresh power down entry to exit timing in memory clock cycles. Recommended settings: - mDDR: tRFC - LPDDR2: tCKESR - LPDDR3: tCKESR - LPDDR4: max(tCKE, tSR) - DDR2: tCKE - DDR3: tCKE + 1 - DDR4: tCKE + 1 (+ PL(parity latency)(*)) (*)Only if CRCPARCTL1.caparity_disable_before_sr=0, this register should be increased by PL. When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. Programming mode: Quasi-dynamic Group 2 and Group 4
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKSRE                 \ This is the time after Self Refresh Down Entry that CK is maintained as a valid clock. Specifies the clock disable delay after SRE. Recommended settings: - mDDR: 0 - LPDDR2: 2 - LPDDR3: 2 - LPDDR4: tCKELCK - DDR2: 1 - DDR3: max (10 ns, 5 tCK) - DDR4: max (10 ns, 5 tCK) (+ PL(parity latency)(*)) (*)Only if CRCPARCTL1.caparity_disable_before_sr=0, this register should be increased by PL. When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. Programming mode: Quasi-dynamic Group 2 and Group 4
$0f000000 constant DDRCTRL_DDRCTRL_DRAMTMG5_T_CKSRX                 \ This is the time before Self Refresh Exit that CK is maintained as a valid clock before issuing SRX. Specifies the clock stable time before SRX. Recommended settings: - mDDR: 1 - LPDDR2: 2 - LPDDR3: 2 - LPDDR4: tCKCKEH - DDR2: 1 - DDR3: tCKSRX - DDR4: tCKSRX When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 6
\ Address offset: 0x118
\ Reset value: 0x02020005
\

$0000000f constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKCSX                 \ This is the time before Clock Stop Exit that CK is maintained as a valid clock before issuing Clock Stop Exit. Specifies the clock stable time before next command after Clock Stop Exit. Recommended settings: - mDDR: 1 - LPDDR2: tXP + 2 - LPDDR3: tXP + 2 - LPDDR4: tXP + 2 When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. This is only present for designs supporting mDDR or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Quasi-dynamic Group 2 and Group 4
$000f0000 constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKDPDX                \ This is the time before Deep Power Down Exit that CK is maintained as a valid clock before issuing DPDX. Specifies the clock stable time before DPDX. Recommended settings: - mDDR: 1 - LPDDR2: 2 - LPDDR3: 2 When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. This is only present for designs supporting mDDR or LPDDR2 devices. Programming mode: Quasi-dynamic Group 2 and Group 4
$0f000000 constant DDRCTRL_DDRCTRL_DRAMTMG6_T_CKDPDE                \ This is the time after Deep Power Down Entry that CK is maintained as a valid clock. Specifies the clock disable delay after DPDE. Recommended settings: - mDDR: 0 - LPDDR2: 2 - LPDDR3: 2 When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. This is only present for designs supporting mDDR or LPDDR2/LPDDR3 devices. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 7
\ Address offset: 0x11C
\ Reset value: 0x00000202
\

$0000000f constant DDRCTRL_DDRCTRL_DRAMTMG7_T_CKPDX                 \ This is the time before Power Down Exit that CK is maintained as a valid clock before issuing PDX. Specifies the clock stable time before PDX. Recommended settings: - mDDR: 0 - LPDDR2: 2 - LPDDR3: 2 - LPDDR4: 2 When using DDR2/3/4 SDRAM, this register should be set to the same value as DRAMTMG5.t_cksrx. When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. This is only present for designs supporting mDDR or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Quasi-dynamic Group 2 and Group 4
$00000f00 constant DDRCTRL_DDRCTRL_DRAMTMG7_T_CKPDE                 \ This is the time after Power Down Entry that CK is maintained as a valid clock. Specifies the clock disable delay after PDE. Recommended settings: - mDDR: 0 - LPDDR2: 2 - LPDDR3: 2 - LPDDR4: tCKELCK When using DDR2/3/4 SDRAM, this register should be set to the same value as DRAMTMG5.t_cksre. When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. This is only present for designs supporting mDDR or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 8
\ Address offset: 0x120
\ Reset value: 0x00004405
\

$0000007f constant DDRCTRL_DDRCTRL_DRAMTMG8_T_XS_X32                \ tXS: Exit Self Refresh to commands not requiring a locked DLL. When the controller is operating in 1:2 frequency ratio mode, program this to the above value divided by 2 and round up to next integer value. Unit: Multiples of 32 clocks. Note: Used only for DDR2, DDR3 and DDR4 SDRAMs. Programming mode: Quasi-dynamic Group 2 and Group 4
$00007f00 constant DDRCTRL_DDRCTRL_DRAMTMG8_T_XS_DLL_X32            \ tXSDLL: Exit Self Refresh to the commands requiring a locked DLL. When the controller is operating in 1:2 frequency ratio mode, program this to the above value divided by 2 and round up to next integer value. Unit: Multiples of 32 clocks. Note: Used only for DDR2, DDR3 and DDR4 SDRAMs. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 14
\ Address offset: 0x138
\ Reset value: 0x000000A0
\

$00000fff constant DDRCTRL_DDRCTRL_DRAMTMG14_T_XSR                  \ tXSR: Exit Self Refresh to any command. When the controller is operating in 1:2 frequency ratio mode, program this to the above value divided by 2 and round up to next integer value. Note: Used only for mDDR/LPDDR2/LPDDR3/LPDDR4 mode. Programming mode: Quasi-dynamic Group 2 and Group 4


\
\ @brief DDRCTRL SDRAM timing register 15
\ Address offset: 0x13C
\ Reset value: 0x00000000
\

$000000ff constant DDRCTRL_DDRCTRL_DRAMTMG15_T_STAB_X32             \ tSTAB: Stabilization time. It is required in the following two cases for DDR3/DDR4 RDIMM: - When exiting power saving mode, if the clock was stopped, after re-enabling it the clock must be stable for a time specified by tSTAB - In the case of input clock frequency change (DDR4) - After issuing control words that refers to clock timing (Specification: 6us for DDR3, 5us for DDR4). When the controller is operating in 1:2 frequency ratio mode, program this to recommended value divided by two and round it up to next integer. Unit: Multiples of 32 clock cycles. Programming mode: Quasi-dynamic Group 2 and Group 4.
$80000000 constant DDRCTRL_DDRCTRL_DRAMTMG15_EN_DFI_LP_T_STAB       \ - 1 - Enable using tSTAB when exiting DFI LP. Needs to be set when the PHY is stopping the clock during DFI LP to save maximum power. - 0 - Disable using tSTAB when exiting DFI LP Programming mode: Quasi-dynamic Group 2 and Group 4.


\
\ @brief DDRCTRL ZQ control register 0
\ Address offset: 0x180
\ Reset value: 0x02000040
\

$000003ff constant DDRCTRL_DDRCTRL_ZQCTL0_T_ZQ_SHORT_NOP            \ tZQCS for DDR3/DD4/LPDDR2/LPDDR3, tZQLAT for LPDDR4: Number of DFI clock cycles of NOP required after a ZQCS (ZQ calibration short)/MPC(ZQ Latch) command is issued to SDRAM. When the controller is operating in 1:2 frequency ratio mode, program this to tZQCS/2 and round it up to the next integer value. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Static.
$07ff0000 constant DDRCTRL_DDRCTRL_ZQCTL0_T_ZQ_LONG_NOP             \ tZQoper for DDR3/DDR4, tZQCL for LPDDR2/LPDDR3, tZQCAL for LPDDR4: Number of DFI clock cycles of NOP required after a ZQCL (ZQ calibration long)/MPC(ZQ Start) command is issued to SDRAM. When the controller is operating in 1:2 frequency ratio mode: DDR3/DDR4: program this to tZQoper/2 and round it up to the next integer value. LPDDR2/LPDDR3: program this to tZQCL/2 and round it up to the next integer value. LPDDR4: program this to tZQCAL/2 and round it up to the next integer value. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Static.
$20000000 constant DDRCTRL_DDRCTRL_ZQCTL0_ZQ_RESISTOR_SHARED        \ - 1 - Denotes that ZQ resistor is shared between ranks. Means ZQinit/ZQCL/ZQCS/MPC(ZQ calibration) commands are sent to one rank at a time with tZQinit/tZQCL/tZQCS/tZQCAL/tZQLAT timing met between commands so that commands to different ranks do not overlap. - 0 - ZQ resistor is not shared. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Static.
$40000000 constant DDRCTRL_DDRCTRL_ZQCTL0_DIS_SRX_ZQCL              \ - 1 - Disable issuing of ZQCL/MPC(ZQ calibration) command at Self-Refresh/SR-Powerdown exit. Only applicable when run in DDR3 or DDR4 or LPDDR2 or LPDDR3 or LPDDR4 mode. - 0 - Enable issuing of ZQCL/MPC(ZQ calibration) command at Self-Refresh/SR-Powerdown exit. Only applicable when run in DDR3 or DDR4 or LPDDR2 or LPDDR3 or LPDDR4 mode. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Quasi-dynamic Group 2 and Group 4.
$80000000 constant DDRCTRL_DDRCTRL_ZQCTL0_DIS_AUTO_ZQ               \ - 1 - Disable DDRCTRL generation of ZQCS/MPC(ZQ calibration) command. Register DBGCMD.zq_calib_short can be used instead to issue ZQ calibration request from APB module. - 0 - Internally generate ZQCS/MPC(ZQ calibration) commands based on ZQCTL1.t_zq_short_interval_x1024. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Dynamic


\
\ @brief DDRCTRL ZQ control register 1
\ Address offset: 0x184
\ Reset value: 0x02000100
\

$000fffff constant DDRCTRL_DDRCTRL_ZQCTL1_T_ZQ_SHORT_INTERVAL_X1024    \ Average interval to wait between automatically issuing ZQCS (ZQ calibration short)/MPC(ZQ calibration) commands to DDR3/DDR4/LPDDR2/LPDDR3/LPDDR4 devices. Meaningless, if ZQCTL0.dis_auto_zq=1. Unit: 1024 DFI clock cycles. This is only present for designs supporting DDR3/DDR4 or LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Static.
$3ff00000 constant DDRCTRL_DDRCTRL_ZQCTL1_T_ZQ_RESET_NOP            \ tZQReset: Number of DFI clock cycles of NOP required after a ZQReset (ZQ calibration Reset) command is issued to SDRAM. When the controller is operating in 1:2 frequency ratio mode, program this to tZQReset/2 and round it up to the next integer value. This is only present for designs supporting LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Static.


\
\ @brief DDRCTRL ZQ control register 2
\ Address offset: 0x188
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_ZQCTL2_ZQ_RESET                  \ Setting this register bit to 1 triggers a ZQ Reset operation. When the ZQ Reset operation is complete, the DDRCTRL automatically clears this bit. It is recommended NOT to set this register bit if in Init, in Self-Refresh(except LPDDR4) or SR-Powerdown(LPDDR4) or Deep power-down operating modes. For Self-Refresh(except LPDDR4) or SR-Powerdown(LPDDR4) it is scheduled after SR(except LPDDR4) or SPRD(LPDDR4) has been exited. For Deep power down, it is not scheduled, although ZQSTAT.zq_reset_busy is de-asserted. This is only present for designs supporting LPDDR2/LPDDR3/LPDDR4 devices. Programming mode: Dynamic


\
\ @brief DDRCTRL ZQ status register
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_ZQSTAT_ZQ_RESET_BUSY             \ SoC core may initiate a ZQ Reset operation only if this signal is low. This signal goes high in the clock after the DDRCTRL accepts the ZQ Reset request. It goes low when the ZQ Reset command is issued to the SDRAM and the associated NOP period is over. It is recommended not to perform ZQ Reset commands when this signal is high. - 0 - Indicates that the SoC core can initiate a ZQ Reset operation - 1 - Indicates that ZQ Reset operation is in progress Programming mode: Dynamic


\
\ @brief DDRCTRL DFI timing register 0
\ Address offset: 0x190
\ Reset value: 0x07020002
\

$0000003f constant DDRCTRL_DDRCTRL_DFITMG0_DFI_TPHY_WRLAT           \ Write latency Number of clocks from the write command to write data enable (dfi_wrdata_en). This corresponds to the DFI timing parameter tphy_wrlat. Refer to PHY specification for correct value.Note that, depending on the PHY, if using RDIMM/LRDIMM, it may be necessary to use the adjusted value of CL in the calculation of tphy_wrlat. This is to compensate for the extra cycle(s) of latency through the RDIMM/LRDIMM. For LPDDR4, dfi_tphy_wrlat>60 is not supported. Unit: DFI clock cycles or DFI PHY clock cycles, depending on DFITMG0.dfi_wrdata_use_dfi_phy_clk. Programming mode: Quasi-dynamic Group 1 and Group 4
$00003f00 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_TPHY_WRDATA          \ Specifies the number of clock cycles between when dfi_wrdata_en is asserted to when the associated write data is driven on the dfi_wrdata signal. This corresponds to the DFI timing parameter tphy_wrdata. Refer to PHY specification for correct value. Note, max supported value is 8. Unit: DFI clock cycles or DFI PHY clock cycles, depending on DFITMG0.dfi_wrdata_use_dfi_phy_clk. Programming mode: Quasi-dynamic Group 4
$007f0000 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_T_RDDATA_EN          \ Time from the assertion of a read command on the DFI interface to the assertion of the dfi_rddata_en signal. Refer to PHY specification for correct value. This corresponds to the DFI parameter trddata_en. Note that, depending on the PHY, if using RDIMM/LRDIMM, it may be necessary to use the adjusted value of CL in the calculation of trddata_en. This is to compensate for the extra cycle(s) of latency through the RDIMM/LRDIMM. Unit: DFI clock cycles or DFI PHY clock cycles, depending on DFITMG0.dfi_rddata_use_dfi_phy_clk. Programming mode: Quasi-dynamic Group 1 and Group 4
$1f000000 constant DDRCTRL_DDRCTRL_DFITMG0_DFI_T_CTRL_DELAY         \ Specifies the number of DFI clock cycles after an assertion or de-assertion of the DFI control signals that the control signals at the PHY-DRAM interface reflect the assertion or de-assertion. If the DFI clock and the memory clock are not phase-aligned, this timing parameter should be rounded up to the next integer value. Note that if using RDIMM/LRDIMM, it is necessary to increment this parameter by RDIMM's/LRDIMM's extra cycle of latency in terms of DFI clock. Programming mode: Quasi-dynamic Group 4


\
\ @brief DDRCTRL DFI timing register 1
\ Address offset: 0x194
\ Reset value: 0x00000404
\

$0000001f constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_DRAM_CLK_ENABLE    \ Specifies the number of DFI clock cycles from the de-assertion of the dfi_dram_clk_disable signal on the DFI until the first valid rising edge of the clock to the DRAM memory devices, at the PHY-DRAM boundary. If the DFI clock and the memory clock are not phase aligned, this timing parameter should be rounded up to the next integer value. Programming mode: Quasi-dynamic Group 4
$00001f00 constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_DRAM_CLK_DISABLE    \ Specifies the number of DFI clock cycles from the assertion of the dfi_dram_clk_disable signal on the DFI until the clock to the DRAM memory devices, at the PHY-DRAM boundary, maintains a low value. If the DFI clock and the memory clock are not phase aligned, this timing parameter should be rounded up to the next integer value. Programming mode: Quasi-dynamic Group 4
$001f0000 constant DDRCTRL_DDRCTRL_DFITMG1_DFI_T_WRDATA_DELAY       \ Specifies the number of DFI clock cycles between when the dfi_wrdata_en signal is asserted and when the corresponding write data transfer is completed on the DRAM bus. This corresponds to the DFI timing parameter twrdata_delay. Refer to PHY specification for correct value. For DFI 3.0 PHY, set to twrdata_delay, a new timing parameter introduced in DFI 3.0. For DFI 2.1 PHY, set to tphy_wrdata + (delay of DFI write data to the DRAM). Value to be programmed is in terms of DFI clocks, not PHY clocks. In FREQ_RATIO=2, divide PHY's value by 2 and round up to next integer. If using DFITMG0.dfi_wrdata_use_dfi_phy_clk=1, add 1 to the value. Unit: Clocks Programming mode: Quasi-dynamic Group 4


\
\ @brief DDRCTRL low power configuration register 0
\ Address offset: 0x198
\ Reset value: 0x07000000
\

$00000001 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_PD           \ Enables DFI Low Power interface handshaking during Power Down Entry/Exit. - 0 - Disabled - 1 - Enabled Programming mode: Static
$000000f0 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_PD       \ Value in DFI clock cycles to drive on dfi_lp_wakeup signal when Power Down mode is entered. Determines the DFI's tlp_wakeup time: - 0x0 - 16 cycles - 0x1 - 32 cycles - 0x2 - 64 cycles - 0x3 - 128 cycles - 0x4 - 256 cycles - 0x5 - 512 cycles - 0x6 - 1024 cycles - 0x7 - 2048 cycles - 0x8 - 4096 cycles - 0x9 - 8192 cycles - 0xA - 16384 cycles - 0xB - 32768 cycles - 0xC - 65536 cycles - 0xD - 131072 cycles - 0xE - 262144 cycles - 0xF - Unlimited Programming mode: Static
$00000100 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_SR           \ Enables DFI Low Power interface handshaking during Self Refresh Entry/Exit. - 0 - Disabled - 1 - Enabled Programming mode: Static
$0000f000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_SR       \ Value in DFI clpck cycles to drive on dfi_lp_wakeup signal when Self Refresh mode is entered. Determines the DFI's tlp_wakeup time: - 0x0 - 16 cycles - 0x1 - 32 cycles - 0x2 - 64 cycles - 0x3 - 128 cycles - 0x4 - 256 cycles - 0x5 - 512 cycles - 0x6 - 1024 cycles - 0x7 - 2048 cycles - 0x8 - 4096 cycles - 0x9 - 8192 cycles - 0xA - 16384 cycles - 0xB - 32768 cycles - 0xC - 65536 cycles - 0xD - 131072 cycles - 0xE - 262144 cycles - 0xF - Unlimited Programming mode: Static
$00010000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_EN_DPD          \ Enables DFI Low-power interface handshaking during Deep Power Down Entry/Exit. - 0 - Disabled - 1 - Enabled This is only present for designs supporting mDDR or LPDDR2/LPDDR3 devices. Programming mode: Static.
$00f00000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_LP_WAKEUP_DPD      \ Value in DFI clock cycles to drive on dfi_lp_wakeup signal when Deep Power Down mode is entered. Determines the DFI's tlp_wakeup time: - 0x0 - 16 cycles - 0x1 - 32 cycles - 0x2 - 64 cycles - 0x3 - 128 cycles - 0x4 - 256 cycles - 0x5 - 512 cycles - 0x6 - 1024 cycles - 0x7 - 2048 cycles - 0x8 - 4096 cycles - 0x9 - 8192 cycles - 0xA - 16384 cycles - 0xB - 32768 cycles - 0xC - 65536 cycles - 0xD - 131072 cycles - 0xE - 262144 cycles - 0xF - Unlimited This is only present for designs supporting mDDR or LPDDR2/LPDDR3 devices. Programming mode: Static.
$1f000000 constant DDRCTRL_DDRCTRL_DFILPCFG0_DFI_TLP_RESP           \ Setting in DFI clock cycles for DFI's tlp_resp time. Same value is used for both Power Down, Self Refresh, Deep Power Down and Maximum Power Saving modes. DFI 2.1 specification onwards, recommends using a fixed value of 7 always. Programming mode: Static


\
\ @brief DDRCTRL DFI update register 0
\ Address offset: 0x1A0
\ Reset value: 0x00400003
\

$000003ff constant DDRCTRL_DDRCTRL_DFIUPD0_DFI_T_CTRLUP_MIN         \ Specifies the minimum number of DFI clock cycles that the dfi_ctrlupd_req signal must be asserted. The DDRCTRL expects the PHY to respond within this time. If the PHY does not respond, the DDRCTRL de-asserts dfi_ctrlupd_req after dfi_t_ctrlup_min + 2 cycles. Lowest value to assign to this variable is 0x3. Programming mode: Static
$03ff0000 constant DDRCTRL_DDRCTRL_DFIUPD0_DFI_T_CTRLUP_MAX         \ Specifies the maximum number of DFI clock cycles that the dfi_ctrlupd_req signal can assert. Lowest value to assign to this variable is 0x40. Programming mode: Static
$20000000 constant DDRCTRL_DDRCTRL_DFIUPD0_CTRLUPD_PRE_SRX          \ Selects dfi_ctrlupd_req requirements at SRX: -0: send ctrlupd after SRX -1: send ctrlupd before SRX If DFIUPD0.dis_auto_ctrlupd_srx=1, this register has no impact, because no dfi_ctrlupd_req is issued when SRX. Programming mode: Static
$40000000 constant DDRCTRL_DDRCTRL_DFIUPD0_DIS_AUTO_CTRLUPD_SRX     \ When '1', disable the automatic dfi_ctrlupd_req generation by the DDRCTRL at self-refresh exit. When '0', DDRCTRL issues a dfi_ctrlupd_req before or after exiting self-refresh, depending on DFIUPD0.ctrlupd_pre_srx. Programming mode: Static
$80000000 constant DDRCTRL_DDRCTRL_DFIUPD0_DIS_AUTO_CTRLUPD         \ When '1', disable the automatic dfi_ctrlupd_req generation by the DDRCTRL. The core must issue the dfi_ctrlupd_req signal using register DBGCMD.ctrlupd. When '0', DDRCTRL issues dfi_ctrlupd_req periodically. Programming mode: Quasi-dynamic Group 3


\
\ @brief DDRCTRL DFI update register 1
\ Address offset: 0x1A4
\ Reset value: 0x00010001
\

$000000ff constant DDRCTRL_DDRCTRL_DFIUPD1_DFI_T_CTRLUPD_INTERVAL_MAX_X1024    \ This is the maximum amount of time between DDRCTRL initiated DFI update requests. This timer resets with each update request; when the timer expires dfi_ctrlupd_req is sent and traffic is blocked until the dfi_ctrlupd_ackx is received. PHY can use this idle time to recalibrate the delay lines to the DLLs. The DFI controller update is also used to reset PHY FIFO pointers in case of data capture errors. Updates are required to maintain calibration over PVT, but frequent updates may impact performance. Minimum allowed value for this field is 1. Note: Value programmed for DFIUPD1.dfi_t_ctrlupd_interval_max_x1024 must be greater than DFIUPD1.dfi_t_ctrlupd_interval_min_x1024. Unit: 1024 DFI clock cycles. Programming mode: Static.
$00ff0000 constant DDRCTRL_DDRCTRL_DFIUPD1_DFI_T_CTRLUPD_INTERVAL_MIN_X1024    \ This is the minimum amount of time between DDRCTRL initiated DFI update requests (which is executed whenever the DDRCTRL is idle). Set this number higher to reduce the frequency of update requests, which can have a small impact on the latency of the first read request when the DDRCTRL is idle. Minimum allowed value for this field is 1. Unit: 1024 DFI clock cycles. Programming mode: Static.


\
\ @brief DDRCTRL DFI update register 2
\ Address offset: 0x1A8
\ Reset value: 0x80000000
\

$80000000 constant DDRCTRL_DDRCTRL_DFIUPD2_DFI_PHYUPD_EN            \ Enables the support for acknowledging PHY-initiated updates: - 0 - Disabled - 1 - Enabled Programming mode: Static


\
\ @brief DDRCTRL DFI miscellaneous control register
\ Address offset: 0x1B0
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_INIT_COMPLETE_EN     \ PHY initialization complete enable signal. When asserted the dfi_init_complete signal can be used to trigger SDRAM initialisation Programming mode: Quasi-dynamic Group 3
$00000010 constant DDRCTRL_DDRCTRL_DFIMISC_CTL_IDLE_EN              \ Enables support of ctl_idle signal Programming mode: Static
$00000020 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_INIT_START           \ PHY init start request signal.When asserted it triggers the PHY init start request Programming mode: Quasi-dynamic Group 3
$00001f00 constant DDRCTRL_DDRCTRL_DFIMISC_DFI_FREQUENCY            \ Indicates the operating frequency of the system. The number of supported frequencies and the mapping of signal values to clock frequencies are defined by the PHY. Programming mode: Quasi-dynamic Group 1


\
\ @brief DDRCTRL DFI status register
\ Address offset: 0x1BC
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DFISTAT_DFI_INIT_COMPLETE        \ The status flag register which announces when the DFI initialization has been completed. The DFI INIT triggered by dfi_init_start signal and then the dfi_init_complete flag is polled to know when the initialization is done. Programming mode: Dynamic
$00000002 constant DDRCTRL_DDRCTRL_DFISTAT_DFI_LP_ACK               \ Stores the value of the dfi_lp_ack input to the controller. Programming mode: Dynamic


\
\ @brief DDRCTRL DFI PHY master register
\ Address offset: 0x1C4
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_DFIPHYMSTR_DFI_PHYMSTR_EN        \ Enables the PHY Master Interface: - 0 - Disabled - 1 - Enabled Programming mode: Dynamic


\
\ @brief DDRCTRL address map register 1
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$0000003f constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B0         \ Selects the HIF address bits used as bank address bit 0. Valid Range: 0 to 32, and 63 Internal Base: 2 The selected HIF address bit for each of the bank address bits is determined by adding the internal base to the value of this field. If unused, set to 63 and then bank address bit 0 is set to 0. Programming mode: Static.
$00003f00 constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B1         \ Selects the HIF address bits used as bank address bit 1. Valid Range: 0 to 32, and 63 Internal Base: 3 The selected HIF address bit for each of the bank address bits is determined by adding the internal base to the value of this field. If unused, set to 63 and then bank address bit 1 is set to 0. Programming mode: Static.
$003f0000 constant DDRCTRL_DDRCTRL_ADDRMAP1_ADDRMAP_BANK_B2         \ Selects the HIF address bit used as bank address bit 2. Valid Range: 0 to 31, and 63 Internal Base: 4 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 63 and then bank address bit 2 is set to 0. Programming mode: Static.


\
\ @brief DDRCTRL address map register 2
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B2          \ - Full bus width mode: Selects the HIF address bit used as column address bit 2. - Half bus width mode: Selects the HIF address bit used as column address bit 3. - Quarter bus width mode: Selects the HIF address bit used as column address bit 4. Valid Range: 0 to 7 Internal Base: 2 The selected HIF address bit is determined by adding the internal base to the value of this field. Note, if UMCTL2_INCL_ARB=1 and MEMC_BURST_LENGTH=8, it is required to program this to 0 unless: - in Half or Quarter bus width (MSTR.data_bus_width!=00) and - PCCFG.bl_exp_mode==1 and either - In DDR4 and ADDRMAP8.addrmap_bg_b0==0 or - In LPDDR4 and ADDRMAP1.addrmap_bank_b0==0 If UMCTL2_INCL_ARB=1 and MEMC_BURST_LENGTH=16, it is required to program this to 0 unless: - in Half or Quarter bus width (MSTR.data_bus_width!=00) and - PCCFG.bl_exp_mode==1 and - In DDR4 and ADDRMAP8.addrmap_bg_b0==0 Otherwise, if MEMC_BURST_LENGTH=8 and Full Bus Width (MSTR.data_bus_width==00), it is recommended to program this to 0 so that HIF[2] maps to column address bit 2. If MEMC_BURST_LENGTH=16 and Full Bus Width (MSTR.data_bus_width==00), it is recommended to program this to 0 so that HIF[2] maps to column address bit 2. If MEMC_BURST_LENGTH=16 and Half Bus Width (MSTR.data_bus_width==01), it is recommended to program this to 0 so that HIF[2] maps to column address bit 3. Programming mode: Static
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B3          \ - Full bus width mode: Selects the HIF address bit used as column address bit 3. - Half bus width mode: Selects the HIF address bit used as column address bit 4. - Quarter bus width mode: Selects the HIF address bit used as column address bit 5. Valid Range: 0 to 7 Internal Base: 3 The selected HIF address bit is determined by adding the internal base to the value of this field. Note, if UMCTL2_INCL_ARB=1, MEMC_BURST_LENGTH=16, Full bus width (MSTR.data_bus_width=00) and BL16 (MSTR.burst_rdwr=1000), it is recommended to program this to 0. Programming mode: Static
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B4          \ - Full bus width mode: Selects the HIF address bit used as column address bit 4. - Half bus width mode: Selects the HIF address bit used as column address bit 5. - Quarter bus width mode: Selects the HIF address bit used as column address bit 6. Valid Range: 0 to 7, and 15 Internal Base: 4 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then this column address bit is set to 0. Programming mode: Static
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP2_ADDRMAP_COL_B5          \ - Full bus width mode: Selects the HIF address bit used as column address bit 5. - Half bus width mode: Selects the HIF address bit used as column address bit 6. - Quarter bus width mode: Selects the HIF address bit used as column address bit 7 . Valid Range: 0 to 7, and 15 Internal Base: 5 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then this column address bit is set to 0. Programming mode: Static


\
\ @brief DDRCTRL address map register 3
\ Address offset: 0x20C
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B6          \ - Full bus width mode: Selects the HIF address bit used as column address bit 6. - Half bus width mode: Selects the HIF address bit used as column address bit 7. - Quarter bus width mode: Selects the HIF address bit used as column address bit 8. Valid Range: 0 to 7, and 15 Internal Base: 6 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then this column address bit is set to 0. Programming mode: Static
$00001f00 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B7          \ - Full bus width mode: Selects the HIF address bit used as column address bit 7. - Half bus width mode: Selects the HIF address bit used as column address bit 8. - Quarter bus width mode: Selects the HIF address bit used as column address bit 9. Valid Range: 0 to 7, x, and 31. x indicate a valid value in inline ECC configuration. Internal Base: 7 The selected HIF address bit is determined by adding the internal base to the value of this field. In Inline ECC configuration (MEMC_INLINE_ECC=1) and ECC is enabled (ECCCFG0.ecc_mode>0), the highest 3 column address bits must map to the highest 3 valid HIF address bits. If column bit 7 is the third highest column address bit, it must map to the third highest valid HIF address bit. (x = the highest valid HIF address bit - 2 - internal base). If unused, set to 31 and then this column address bit is set to 0. Programming mode: Static.
$001f0000 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B8          \ - Full bus width mode: Selects the HIF address bit used as column address bit 8. - Half bus width mode: Selects the HIF address bit used as column address bit 9. - Quarter bus width mode: Selects the HIF address bit used as column address bit 11 (10 in LPDDR2/LPDDR3 mode). Valid Range: 0 to 7, x, and 31. x indicate a valid value in inline ECC configuration. Internal Base: 8 The selected HIF address bit is determined by adding the internal base to the value of this field. Note: Per JEDEC DDR2/3/mDDR specification, column address bit 10 is reserved for indicating auto-precharge, and hence no source address bit can be mapped to column address bit 10. In LPDDR2/LPDDR3, there is a dedicated bit for auto-precharge in the CA bus and hence column bit 10 is used. In Inline ECC configuration (MEMC_INLINE_ECC=1) and ECC is enabled (ECCCFG0.ecc_mode>0), the highest 3 column address bits must map to the highest 3 valid HIF address bits. If column bit 8 is the second highest column address bit, it must map to the second highest valid HIF address bit. (x = the highest valid HIF address bit - 1 - internal base). If column bit 8 is the third highest column address bit, it must map to the third highest valid HIF address bit. (x = the highest valid HIF address bit - 2 - internal base). If unused, set to 31 and then this column address bit is set to 0. Programming mode: Static.
$1f000000 constant DDRCTRL_DDRCTRL_ADDRMAP3_ADDRMAP_COL_B9          \ - Full bus width mode: Selects the HIF address bit used as column address bit 9. - Half bus width mode: Selects the HIF address bit used as column address bit 11 (10 in LPDDR2/LPDDR3 mode). - Quarter bus width mode: Selects the HIF address bit used as column address bit 13 (11 in LPDDR2/LPDDR3 mode). Valid Range: 0 to 7, x, and 31. x indicate a valid value in inline ECC configuration. Internal Base: 9 The selected HIF address bit is determined by adding the internal base to the value of this field. Note: Per JEDEC DDR2/3/mDDR specification, column address bit 10 is reserved for indicating auto-precharge, and hence no source address bit can be mapped to column address bit 10. In LPDDR2/LPDDR3, there is a dedicated bit for auto-precharge in the CA bus and hence column bit 10 is used. In Inline ECC configuration (MEMC_INLINE_ECC=1) and ECC is enabled (ECCCFG0.ecc_mode>0), the highest 3 column address bits must map to the highest 3 valid HIF address bits. If column bit 9 is the highest column address bit, it must map to the highest valid HIF address bit. (x = the highest valid HIF address bit - internal base) If column bit 9 is the second highest column address bit, it must map to the second highest valid HIF address bit. (x = the highest valid HIF address bit - 1 - internal base) If column bit 9 is the third highest column address bit, it must map to the third highest valid HIF address bit. (x = the highest valid HIF address bit - 2 - internal base) If unused, set to 31 and then this column address bit is set to 0. Programming mode: Static.


\
\ @brief DDRCTRL address map register 4
\ Address offset: 0x210
\ Reset value: 0x00000000
\

$0000001f constant DDRCTRL_DDRCTRL_ADDRMAP4_ADDRMAP_COL_B10         \ - Full bus width mode: Selects the HIF address bit used as column address bit 11 (10 in LPDDR2/LPDDR3 mode). - Half bus width mode: Selects the HIF address bit used as column address bit 13 (11 in LPDDR2/LPDDR3 mode). - Quarter bus width mode: UNUSED. See later in this description for value you need to set to make it unused. Valid Range: 0 to 7, x, and 31. x indicate a valid value in inline ECC configuration. Internal Base: 10 The selected HIF address bit is determined by adding the internal base to the value of this field. Note: Per JEDEC DDR2/3/mDDR specification, column address bit 10 is reserved for indicating auto-precharge, and hence no source address bit can be mapped to column address bit 10. In LPDDR2/LPDDR3, there is a dedicated bit for auto-precharge in the CA bus and hence column bit 10 is used. In Inline ECC configuration (MEMC_INLINE_ECC=1) and ECC is enabled (ECCCFG0.ecc_mode>0), the highest 3 column address bits must map to the highest 3 valid HIF address bits. If column bit 10 is the highest column address bit, it must map to the highest valid HIF address bit. (x = the highest valid HIF address bit - internal base) If column bit 10 is the second highest column address bit, it must map to the second highest valid HIF address bit. (x = the highest valid HIF address bit - 1 - internal base) If column bit 10 is the third highest column address bit, it must map to the third highest valid HIF address bit. (x = the highest valid HIF address bit - 2 - internal base) If unused, set to 31 and then this column address bit is set to 0. Programming mode: Static
$00001f00 constant DDRCTRL_DDRCTRL_ADDRMAP4_ADDRMAP_COL_B11         \ - Full bus width mode: Selects the HIF address bit used as column address bit 13 (11 in LPDDR2/LPDDR3 mode). - Half bus width mode: UNUSED. See later in this description for value you need to set to make it unused. - Quarter bus width mode: UNUSED. See later in this description for value you need to set to make it unused. Valid Range: 0 to 7, x, and 31. x indicate a valid value in inline ECC configuration. Internal Base: 11 The selected HIF address bit is determined by adding the internal base to the value of this field. Note: Per JEDEC DDR2/3/mDDR specification, column address bit 10 is reserved for indicating auto-precharge, and hence no source address bit can be mapped to column address bit 10. In LPDDR2/LPDDR3, there is a dedicated bit for auto-precharge in the CA bus and hence column bit 10 is used. In Inline ECC configuration (MEMC_INLINE_ECC=1) and ECC is enabled (ECCCFG0.ecc_mode>0), the highest 3 column address bits must map to the highest 3 valid HIF address bits. If column bit 11 is the highest column address bit, it must map to the highest valid HIF address bit. (x = the highest valid HIF address bit - internal base) If column bit 11 is the second highest column address bit, it must map to the second highest valid HIF address bit. (x = the highest valid HIF address bit - 1 - internal base) If column bit 11 is the third highest column address bit, it must map to the third highest valid HIF address bit. (x = the highest valid HIF address bit - 2 - internal base) If unused, set to 31 and then this column address bit is set to 0. Programming mode: Static


\
\ @brief DDRCTRL address map register 5
\ Address offset: 0x214
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B0          \ Selects the HIF address bits used as row address bit 0. Valid Range: 0 to 11 Internal Base: 6 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. Programming mode: Static
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B1          \ Selects the HIF address bits used as row address bit 1. Valid Range: 0 to 11 Internal Base: 7 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. Programming mode: Static
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B2_10       \ Selects the HIF address bits used as row address bits 2 to 10. Valid Range: 0 to 11, and 15 Internal Base: 8 (for row address bit 2), 9 (for row address bit 3), 10 (for row address bit 4) etc increasing to 16 (for row address bit 10) The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. When set to 15, the values of row address bits 2 to 10 are defined by registers ADDRMAP9, ADDRMAP10, ADDRMAP11. Programming mode: Static
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP5_ADDRMAP_ROW_B11         \ Selects the HIF address bit used as row address bit 11. Valid Range: 0 to 11, and 15 Internal Base: 17 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then row address bit 11 is set to 0. Programming mode: Static


\
\ @brief DDRCTRL address register 6
\ Address offset: 0x218
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B12         \ Selects the HIF address bit used as row address bit 12. Valid Range: 0 to 11, and 15 Internal Base: 18 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then row address bit 12 is set to 0. Programming mode: Static
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B13         \ Selects the HIF address bit used as row address bit 13. Valid Range: 0 to 11, and 15 Internal Base: 19 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then row address bit 13 is set to 0. Programming mode: Static
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B14         \ Selects the HIF address bit used as row address bit 14. Valid Range: 0 to 11, and 15 Internal Base: 20 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then row address bit 14 is set to 0. Programming mode: Static
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP6_ADDRMAP_ROW_B15         \ Selects the HIF address bit used as row address bit 15. Valid Range: 0 to 11, and 15 Internal Base: 21 The selected HIF address bit is determined by adding the internal base to the value of this field. If unused, set to 15 and then row address bit 15 is set to 0. Programming mode: Static
$80000000 constant DDRCTRL_DDRCTRL_ADDRMAP6_LPDDR3_6GB_12GB         \ Set this to 1 if there is an LPDDR3 SDRAM 6Gb or 12Gb device in use. - 1 - LPDDR3 SDRAM 6Gb/12Gb device in use. Every address having row[14:13]==2'b11 is considered as invalid - 0 - non-LPDDR3 6Gb/12Gb device in use. All addresses are valid Present only in designs configured to support LPDDR3. Programming mode: Static


\
\ @brief DDRCTRL address map register 9
\ Address offset: 0x224
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B2          \ Selects the HIF address bits used as row address bit 2. Valid Range: 0 to 11 Internal Base: 8 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B3          \ Selects the HIF address bits used as row address bit 3. Valid Range: 0 to 11 Internal Base: 9 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B4          \ Selects the HIF address bits used as row address bit 4. Valid Range: 0 to 11 Internal Base: 10 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP9_ADDRMAP_ROW_B5          \ Selects the HIF address bits used as row address bit 5. Valid Range: 0 to 11 Internal Base: 11 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static


\
\ @brief DDRCTRL address map register 10
\ Address offset: 0x228
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B6         \ Selects the HIF address bits used as row address bit 6. Valid Range: 0 to 11 Internal Base: 12 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$00000f00 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B7         \ Selects the HIF address bits used as row address bit 7. Valid Range: 0 to 11 Internal Base: 13 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$000f0000 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B8         \ Selects the HIF address bits used as row address bit 8. Valid Range: 0 to 11 Internal Base: 14 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static
$0f000000 constant DDRCTRL_DDRCTRL_ADDRMAP10_ADDRMAP_ROW_B9         \ Selects the HIF address bits used as row address bit 9. Valid Range: 0 to 11 Internal Base: 15 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static


\
\ @brief DDRCTRL address map register 11
\ Address offset: 0x22C
\ Reset value: 0x00000000
\

$0000000f constant DDRCTRL_DDRCTRL_ADDRMAP11_ADDRMAP_ROW_B10        \ Selects the HIF address bits used as row address bit 10. Valid Range: 0 to 11 Internal Base: 16 The selected HIF address bit for each of the row address bits is determined by adding the internal base to the value of this field. This register field is used only when ADDRMAP5.addrmap_row_b2_10 is set to value 15. Programming mode: Static


\
\ @brief DDRCTRL ODT configuration register
\ Address offset: 0x240
\ Reset value: 0x04000400
\

$0000007c constant DDRCTRL_DDRCTRL_ODTCFG_RD_ODT_DELAY              \ The delay, in DFI PHY clock cycles, from issuing a read command to setting ODT values associated with that command. ODT setting must remain constant for the entire time that DQS is driven by the DDRCTRL. Recommended values: DDR2: - CL + AL - 4 (not DDR2-1066), CL + AL - 5 (DDR2-1066) If (CL + AL - 4 < 0), DDRCTRL does not support ODT for read operation. DDR3: - CL - CWL DDR4: - CL - CWL - RD_PREAMBLE + WR_PREAMBLE + DFITMG1.dfi_t_cmd_lat (to adjust for CAL mode) WR_PREAMBLE = 1 (1tCK write preamble), 2 (2tCK write preamble) RD_PREAMBLE = 1 (1tCK write preamble), 2 (2tCK write preamble) If (CL - CWL - RD_PREAMBLE + WR_PREAMBLE) < 0, DDRCTRL does not support ODT for read operation. LPDDR3: - RL + RD(tDQSCK(min)/tCK) - 1 - RU(tODTon(max)/tCK) Programming mode: Quasi-dynamic Group 1 and Group 4.
$00000f00 constant DDRCTRL_DDRCTRL_ODTCFG_RD_ODT_HOLD               \ DFI PHY clock cycles to hold ODT for a read command. The minimum supported value is 2. Recommended values: DDR2: - BL8: 0x6 (not DDR2-1066), 0x7 (DDR2-1066) - BL4: 0x4 (not DDR2-1066), 0x5 (DDR2-1066) DDR3: - BL8 - 0x6 DDR4: - BL8: 5 + RD_PREAMBLE RD_PREAMBLE = 1 (1tCK write preamble), 2 (2tCK write preamble) LPDDR3: - BL8: 5 + RU(tDQSCK(max)/tCK) - RD(tDQSCK(min)/tCK) + RU(tODTon(max)/tCK) Programming mode: Quasi-dynamic Group 1 and Group 4
$001f0000 constant DDRCTRL_DDRCTRL_ODTCFG_WR_ODT_DELAY              \ The delay, in DFI PHY clock cycles, from issuing a write command to setting ODT values associated with that command. ODT setting must remain constant for the entire time that DQS is driven by the DDRCTRL. Recommended values: DDR2: - CWL + AL - 3 (DDR2-400/533/667), CWL + AL - 4 (DDR2-800), CWL + AL - 5 (DDR2-1066) If (CWL + AL - 3 < 0), DDRCTRL does not support ODT for write operation. DDR3: - 0x0 DDR4: - DFITMG1.dfi_t_cmd_lat (to adjust for CAL mode) LPDDR3: - WL - 1 - RU(tODTon(max)/tCK)) Programming mode: Quasi-dynamic Group 1 and Group 4
$0f000000 constant DDRCTRL_DDRCTRL_ODTCFG_WR_ODT_HOLD               \ DFI PHY clock cycles to hold ODT for a write command. The minimum supported value is 2. Recommended values: DDR2: - BL8: 0x5 (DDR2-400/533/667), 0x6 (DDR2-800), 0x7 (DDR2-1066) - BL4: 0x3 (DDR2-400/533/667), 0x4 (DDR2-800), 0x5 (DDR2-1066) DDR3: - BL8: 0x6 DDR4: - BL8: 5 + WR_PREAMBLE + CRC_MODE WR_PREAMBLE = 1 (1tCK write preamble), 2 (2tCK write preamble) CRC_MODE = 0 (not CRC mode), 1 (CRC mode) LPDDR3: - BL8: 7 + RU(tODTon(max)/tCK) Programming mode: Quasi-dynamic Group 1 and Group 4


\
\ @brief DDRCTRL ODT/Rank map register
\ Address offset: 0x244
\ Reset value: 0x00000011
\

$00000001 constant DDRCTRL_DDRCTRL_ODTMAP_RANK0_WR_ODT              \ Indicates which remote ODTs must be turned on during a write to rank 0. Each rank has a remote ODT (in the SDRAM) which can be turned on by setting the appropriate bit here. Rank 0 is controlled by the LSB; rank 1 is controlled by bit next to the LSB, etc. For each rank, set its bit to 1 to enable its ODT. Programming mode: Static
$00000010 constant DDRCTRL_DDRCTRL_ODTMAP_RANK0_RD_ODT              \ Indicates which remote ODTs must be turned on during a read from rank 0. Each rank has a remote ODT (in the SDRAM) which can be turned on by setting the appropriate bit here. Rank 0 is controlled by the LSB; rank 1 is controlled by bit next to the LSB, etc. For each rank, set its bit to 1 to enable its ODT. Programming mode: Static


\
\ @brief DDRCTRL scheduler control register
\ Address offset: 0x250
\ Reset value: 0x00000805
\

$00000001 constant DDRCTRL_DDRCTRL_SCHED_FORCE_LOW_PRI_N            \ Active low signal. When asserted ('0'), all incoming transactions are forced to low priority. This implies that all high priority read (HPR) and variable priority read commands (VPR) are treated as low priority read (LPR) commands. On the write side, all variable priority write (VPW) commands are treated as normal priority write (NPW) commands. Forcing the incoming transactions to low priority implicitly turns off bypass path for read commands. For performance only. Programming mode: Static
$00000002 constant DDRCTRL_DDRCTRL_SCHED_PREFER_WRITE               \ If set then the bank selector prefers writes over reads. FOR DEBUG ONLY. Programming mode: Static
$00000004 constant DDRCTRL_DDRCTRL_SCHED_PAGECLOSE                  \ If true, bank is kept open only while there are page hit transactions available in the CAM to that bank. The last read or write command in the CAM with a bank and page hit is executed with auto-precharge if SCHED1.pageclose_timer=0. Even if this register set to 1 and SCHED1.pageclose_timer is set to 0, explicit precharge (and not auto-precharge) may be issued in some cases where there is a mode switch between write and read or between LPR and HPR. The Read and Write commands that are executed as part of the ECC scrub requests are also executed without auto-precharge. If false, the bank remains open until there is a need to close it (to open a different page, or for page timeout or refresh timeout) - also known as open page policy. The open page policy can be overridden by setting the per-command-autopre bit on the HIF interface (hif_cmd_autopre). The pageclose feature provids a midway between Open and Close page policies. For performance only. Programming mode: Quasi-dynamic Group 3
$00000f00 constant DDRCTRL_DDRCTRL_SCHED_LPR_NUM_ENTRIES            \ Number of entries in the low priority transaction store is this value + 1. (MEMC_NO_OF_ENTRY - (SCHED.lpr_num_entries + 1)) is the number of entries available for the high priority transaction store. Setting this to maximum value allocates all entries to low priority transaction store. Setting this to 0 allocates 1 entry to low priority transaction store and the rest to high priority transaction store. Note: In ECC configurations, the numbers of write and low priority read credits issued is one less than in the non-ECC case. One entry each is reserved in the write and low-priority read CAMs for storing the RMW requests arising out of single bit error correction RMW operation. Programming mode: Static
$00ff0000 constant DDRCTRL_DDRCTRL_SCHED_GO2CRITICAL_HYSTERESIS     \ UNUSED Programming mode: Static
$7f000000 constant DDRCTRL_DDRCTRL_SCHED_RDWR_IDLE_GAP              \ When the preferred transaction store is empty for these many clock cycles, switch to the alternate transaction store if it is non-empty. The read transaction store (both high and low priority) is the default preferred transaction store and the write transaction store is the alternative store. When prefer write over read is set this is reversed. 0x0 is a legal value for this register. When set to 0x0, the transaction store switching happens immediately when the switching conditions become true. FOR PERFORMANCE ONLY Programming mode: Static


\
\ @brief DDRCTRL scheduler control register 1
\ Address offset: 0x254
\ Reset value: 0x00000000
\

$000000ff constant DDRCTRL_DDRCTRL_SCHED1_PAGECLOSE_TIMER           \ This field works in conjunction with SCHED.pageclose. It only has meaning if SCHED.pageclose==1. If SCHED.pageclose==1 and pageclose_timer==0, then an auto-precharge may be scheduled for last read or write command in the CAM with a bank and page hit. Note, sometimes an explicit precharge is scheduled instead of the auto-precharge. See SCHED.pageclose for details of when this may happen. If SCHED.pageclose==1 and pageclose_timer>0, then an auto-precharge is not scheduled for last read or write command in the CAM with a bank and page hit. Instead, a timer is started, with pageclose_timer as the initial value. There is a timer on a per bank basis. The timer decrements unless the next read or write in the CAM to a bank is a page hit. It gets reset to pageclose_timer value if the next read or write in the CAM to a bank is a page hit. Once the timer has reached zero, an explicit precharge is attempted to be scheduled. Programming mode: Static.


\
\ @brief DDRCTRL high priority read CAM register 1
\ Address offset: 0x25C
\ Reset value: 0x0F000001
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFHPR1_HPR_MAX_STARVE          \ Number of DFI clocks that the HPR queue can be starved before it goes critical. The minimum valid functional value for this register is 0x1. Programming it to 0x0 disables the starvation functionality; during normal operation, this function must not be disabled as it causes excessive latencies. For performance only. Programming mode: Quasi-dynamic Group 3
$ff000000 constant DDRCTRL_DDRCTRL_PERFHPR1_HPR_XACT_RUN_LENGTH     \ Number of transactions that are serviced once the HPR queue goes critical is the smaller of: - (a) This number - (b) Number of transactions available. Unit: Transaction. For performance only. Programming mode: Quasi-dynamic Group 3


\
\ @brief DDRCTRL low priority read CAM register 1
\ Address offset: 0x264
\ Reset value: 0x0F00007F
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFLPR1_LPR_MAX_STARVE          \ Number of DFI clocks that the LPR queue can be starved before it goes critical. The minimum valid functional value for this register is 0x1. Programming it to 0x0 disables the starvation functionality; during normal operation, this function must be disabled as it causes excessive latencies. For performance only Programming mode: Quasi-dynamic Group 3
$ff000000 constant DDRCTRL_DDRCTRL_PERFLPR1_LPR_XACT_RUN_LENGTH     \ Number of transactions that are serviced once the LPR queue goes critical is the smaller of: - (a) This number - (b) Number of transactions available. Unit: Transaction. For performance only Programming mode: Quasi-dynamic group 3


\
\ @brief DDRCTRL write CAM register 1
\ Address offset: 0x26C
\ Reset value: 0x0F00007F
\

$0000ffff constant DDRCTRL_DDRCTRL_PERFWR1_W_MAX_STARVE             \ Number of DFI clocks that the WR queue can be starved before it goes critical. The minimum valid functional value for this register is 0x1. Programming it to 0x0 disables the starvation functionality; during normal operation, this function must not be disabled as it causes excessive latencies. For performance only. Programming mode: Quasi-dynamic Group 3.
$ff000000 constant DDRCTRL_DDRCTRL_PERFWR1_W_XACT_RUN_LENGTH        \ Number of transactions that are serviced once the WR queue goes critical is the smaller of: - (a) This number - (b) Number of transactions available. Unit: Transaction. For performance only. Programming mode: Quasi-dynamic Group 3.


\
\ @brief DDRCTRL debug register 0
\ Address offset: 0x300
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBG0_DIS_WC                      \ When 1, disable write combine. FOR DEBUG ONLY Programming mode: Static
$00000010 constant DDRCTRL_DDRCTRL_DBG0_DIS_COLLISION_PAGE_OPT      \ When this is set to '0', auto-precharge is disabled for the flushed command in a collision case. Collision cases are write followed by read to same address, read followed by write to same address, or write followed by write to same address with DBG0.dis_wc bit = 1 (where same address comparisons exclude the two address bits representing critical word). FOR DEBUG ONLY. Programming mode: Static


\
\ @brief DDRCTRL debug register 1
\ Address offset: 0x304
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBG1_DIS_DQ                      \ When 1, DDRCTRL does not de-queue any transactions from the CAM. Bypass is also disabled. All transactions are queued in the CAM. No reads or writes are issued to SDRAM as long as this is asserted. This bit may be used to prevent reads or writes being issued by the DDRCTRL, which makes it safe to modify certain register fields associated with reads and writes (see User Guide for details). After setting this bit, it is strongly recommended to poll DBGCAM.wr_data_pipeline_empty and DBGCAM.rd_data_pipeline_empty, before making changes to any registers which affect reads and writes. This ensures that the relevant logic in the DDRC is idle. This bit is intended to be switched on-the-fly. Programming mode: Dynamic
$00000002 constant DDRCTRL_DDRCTRL_DBG1_DIS_HIF                     \ When 1, DDRCTRL asserts the HIF command signal hif_cmd_stall. DDRCTRL ignores the hif_cmd_valid and all other associated request signals. This bit is intended to be switched on-the-fly. Programming mode: Dynamic


\
\ @brief DDRCTRL CAM debug register
\ Address offset: 0x308
\ Reset value: 0x00000000
\

$0000001f constant DDRCTRL_DDRCTRL_DBGCAM_DBG_HPR_Q_DEPTH           \ High priority read queue depth For debug only. Programming mode: Dynamic
$00001f00 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_LPR_Q_DEPTH           \ Low priority read queue depth The last entry of Lpr queue is reserved for ECC SCRUB operation. This entry is not included in the calculation of the queue depth. For debug only. Programming mode: Dynamic
$001f0000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_W_Q_DEPTH             \ Write queue depth The last entry of WR queue is reserved for ECC SCRUB operation. This entry is not included in the calculation of the queue depth. For debug only. Programming mode: Dynamic
$01000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_STALL                 \ Stall For debug only. Programming mode: Dynamic
$02000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_RD_Q_EMPTY            \ When 1, all the Read command queues and Read data buffers inside DDRC are empty. This register is to be used for debug purpose. An example use-case scenario: When Controller enters Self-Refresh using the Low-Power entry sequence, Controller is expected to have executed all the commands in its queues and the write and read data drained. Hence this register should be 1 at that time. For debug only. Programming mode: Dynamic
$04000000 constant DDRCTRL_DDRCTRL_DBGCAM_DBG_WR_Q_EMPTY            \ When 1, all the Write command queues and Write data buffers inside DDRC are empty. This register is to be used for debug purpose. An example use-case scenario: When Controller enters Self-Refresh using the Low-Power entry sequence, Controller is expected to have executed all the commands in its queues and the write and read data drained. Hence this register should be 1 at that time. For debug only. Programming mode: Dynamic.
$10000000 constant DDRCTRL_DDRCTRL_DBGCAM_RD_DATA_PIPELINE_EMPTY    \ This bit indicates that the read data pipeline on the DFI interface is empty. This register is intended to be polled at least twice after setting DBG1.dis_dq, to ensure that all remaining commands/data have completed. Programming mode: Dynamic.
$20000000 constant DDRCTRL_DDRCTRL_DBGCAM_WR_DATA_PIPELINE_EMPTY    \ This bit indicates that the write data pipeline on the DFI interface is empty. This register is intended to be polled at least twice after setting DBG1.dis_dq, to ensure that all remaining commands/data have completed. Programming mode: Dynamic.


\
\ @brief DDRCTRL command debug register
\ Address offset: 0x30C
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBGCMD_RANK0_REFRESH             \ Setting this register bit to 1 indicates to the DDRCTRL to issue a refresh to rank 0. Writing to this bit causes DBGSTAT.rank0_refresh_busy to be set. When DBGSTAT.rank0_refresh_busy is cleared, the command has been stored in DDRCTRL. For 3DS configuration, refresh is sent to rank index 0. This operation can be performed only when RFSHCTL3.dis_auto_refresh=1. It is recommended NOT to set this register bit if in Init or Deep power-down operating modes or Maximum Power Saving Mode. Programming mode: Dynamic.
$00000010 constant DDRCTRL_DDRCTRL_DBGCMD_ZQ_CALIB_SHORT            \ Setting this register bit to 1 indicates to the DDRCTRL to issue a ZQCS (ZQ calibration short)/MPC(ZQ calibration) command to the SDRAM. When this request is stored in the DDRCTRL, the bit is automatically cleared. This operation can be performed only when ZQCTL0.dis_auto_zq=1. It is recommended NOT to set this register bit if in Init, in Self-Refresh(except LPDDR4) or SR-Powerdown(LPDDR4) or Deep power-down operating modes or maximum power saving mode. For self-refresh(except LPDDR4) or SR-powerdown(LPDDR4) it is scheduled after SR(except LPDDR4) or SPRD(LPDDR4) has been exited. For Deep power down and maximum power saving mode, it is not scheduled, although DBGSTAT.zq_calib_short_busy is de-asserted. Programming mode: Dynamic.
$00000020 constant DDRCTRL_DDRCTRL_DBGCMD_CTRLUPD                   \ Setting this register bit to 1 indicates to the DDRCTRL to issue a dfi_ctrlupd_req to the PHY. When this request is stored in the DDRCTRL, the bit is automatically cleared. This operation must only be performed when DFIUPD0.dis_auto_ctrlupd=1. Programming mode: Dynamic.


\
\ @brief DDRCTRL status debug register
\ Address offset: 0x310
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_DBGSTAT_RANK0_REFRESH_BUSY       \ SoC core may initiate a rank0_refresh operation (refresh operation to rank 0) only if this signal is low. This signal goes high in the clock after DBGCMD.rank0_refresh is set to one. It goes low when the rank0_refresh operation is stored in the DDRCTRL. It is recommended not to perform rank0_refresh operations when this signal is high. - 0 - Indicates that the SoC core can initiate a rank0_refresh operation - 1 - Indicates that rank0_refresh operation has not been stored yet in the DDRCTRL Programming mode: Dynamic
$00000010 constant DDRCTRL_DDRCTRL_DBGSTAT_ZQ_CALIB_SHORT_BUSY      \ SoC core may initiate a ZQCS (ZQ calibration short) operation only if this signal is low. This signal goes high in the clock after the DDRCTRL accepts the ZQCS request. It goes low when the ZQCS operation is initiated in the DDRCTRL. It is recommended not to perform ZQCS operations when this signal is high. - 0 - Indicates that the SoC core can initiate a ZQCS operation - 1 - Indicates that ZQCS operation has not been initiated yet in the DDRCTRL Programming mode: Dynamic
$00000020 constant DDRCTRL_DDRCTRL_DBGSTAT_CTRLUPD_BUSY             \ SoC core may initiate a ctrlupd operation only if this signal is low. This signal goes high in the clock after the DDRCTRL accepts the ctrlupd request. It goes low when the ctrlupd operation is initiated in the DDRCTRL. It is recommended not to perform ctrlupd operations when this signal is high. - 0 - Indicates that the SoC core can initiate a ctrlupd operation - 1 - Indicates that ctrlupd operation has not been initiated yet in the DDRCTRL Programming mode: Dynamic


\
\ @brief DDRCTRL software register programming control enable
\ Address offset: 0x320
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_SWCTL_SW_DONE                    \ Enable quasi-dynamic register programming outside reset. Program register to 0 to enable quasi-dynamic programming. Set back register to 1 once programming is done. Programming mode: Dynamic


\
\ @brief DDRCTRL software register programming control status
\ Address offset: 0x324
\ Reset value: 0x00000001
\

$00000001 constant DDRCTRL_DDRCTRL_SWSTAT_SW_DONE_ACK               \ Register programming done. This register is the echo of SWCTL.sw_done. Wait for sw_done value 1 to propagate to sw_done_ack at the end of the programming sequence to ensure that the correct registers values are propagated to the destination clock domains. Programming mode: Static


\
\ @brief DDRCTRL AXI Poison configuration register
\ Address offset: 0x36C
\ Reset value: 0x00110011
\

$00000001 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_SLVERR_EN    \ If set to 1, enables SLVERR response for write transaction poisoning Programming mode: Dynamic
$00000010 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_INTR_EN      \ If set to 1, enables interrupts for write transaction poisoning Programming mode: Dynamic
$00000100 constant DDRCTRL_DDRCTRL_POISONCFG_WR_POISON_INTR_CLR     \ Interrupt clear for write transaction poisoning. Allow 2/3 clock cycles for correct value to propagate to core logic and clear the interrupts. Programming mode: Dynamic
$00010000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_SLVERR_EN    \ If set to 1, enables SLVERR response for read transaction poisoning Programming mode: Dynamic
$00100000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_INTR_EN      \ If set to 1, enables interrupts for read transaction poisoning Programming mode: Dynamic
$01000000 constant DDRCTRL_DDRCTRL_POISONCFG_RD_POISON_INTR_CLR     \ Interrupt clear for read transaction poisoning. Allow 2/3 clock cycles for correct value to propagate to core logic and clear the interrupts. Programming mode: Dynamic


\
\ @brief DDRCTRL AXI Poison status register
\ Address offset: 0x370
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_POISONSTAT_WR_POISON_INTR_0      \ Write transaction poisoning error interrupt for port 0. This register is a APB clock copy (double register synchronizer) of the interrupt asserted when a transaction is poisoned on the corresponding AXI port's write address channel. Bit 0 corresponds to Port 0, and so on. Interrupt is cleared by register wr_poison_intr_clr, then value propagated to APB clock. Programming mode: Dynamic
$00010000 constant DDRCTRL_DDRCTRL_POISONSTAT_RD_POISON_INTR_0      \ Read transaction poisoning error interrupt for port 0. This register is a APB clock copy (double register synchronizer) of the interrupt asserted when a transaction is poisoned on the corresponding AXI port's read address channel. Bit 0 corresponds to Port 0, and so on. Interrupt is cleared by register rd_poison_intr_clr, then value propagated to APB clock. Programming mode: Dynamic


\
\ @brief DDRCTRL port status register
\ Address offset: 0x3FC
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PSTAT_RD_PORT_BUSY_0             \ Indicates if there are outstanding reads for AXI port 0. Programming mode: Dynamic
$00010000 constant DDRCTRL_DDRCTRL_PSTAT_WR_PORT_BUSY_0             \ Indicates if there are outstanding writes for AXI port 0. Programming mode: Dynamic


\
\ @brief DDRCTRL port common configuration register
\ Address offset: 0x400
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PCCFG_GO2CRITICAL_EN             \ If set to 1 (enabled), sets co_gs_go2critical_wr and co_gs_go2critical_lpr/co_gs_go2critical_hpr signals going to DDRC based on urgent input (awurgent, arurgent) coming from AXI master. If set to 0 (disabled), co_gs_go2critical_wr and co_gs_go2critical_lpr/co_gs_go2critical_hpr signals at DDRC are driven to 1b'0. Programming mode: Static.
$00000010 constant DDRCTRL_DDRCTRL_PCCFG_PAGEMATCH_LIMIT            \ Page match four limit. If set to 1, limits the number of consecutive same page DDRC transactions that can be granted by the Port Arbiter to four when Page Match feature is enabled. If set to 0, there is no limit imposed on number of consecutive same page DDRC transactions. Programming mode: Static.
$00000100 constant DDRCTRL_DDRCTRL_PCCFG_BL_EXP_MODE                \ Burst length expansion mode. By default (i.e. bl_exp_mode==0) XPI expands every AXI burst into multiple HIF commands, using the memory burst length as a unit. If set to 1, then XPI uses half of the memory burst length as a unit. This applies to both reads and writes. When MSTR.data_bus_width==00, setting bl_exp_mode to 1 has no effect. This can be used in cases where Partial Writes is enabled (UMCTL2_PARTIAL_WR=1), in order to avoid or minimize t_ccd_l penalty in DDR4 and t_ccd_mw penalty in LPDDR4. Hence, bl_exp_mode=1 is only recommended if DDR4 or LPDDR4. Note that if DBICTL.dm_en=0, functionality is not supported in the following cases: - UMCTL2_PARTIAL_WR=0 - UMCTL2_PARTIAL_WR=1, MSTR.data_bus_width=01, MEMC_BURST_LENGTH=8 and MSTR.burst_rdwr=1000 (LPDDR4 only) - UMCTL2_PARTIAL_WR=1, MSTR.data_bus_width=01, MEMC_BURST_LENGTH=4 and MSTR.burst_rdwr=0100 (DDR4 only), with either MSTR.burstchop=0 or CRCPARCTL1.crc_enable=1 Functionality is also not supported if Data Channel Interleave is enabled. Programming mode: Static.


\
\ @brief DDRCTRL port x configuration read register
\ Address offset: 0x404
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_PRIORITY         \ Determines the initial load value of read aging counters. These counters are parallel loaded after reset, or after each grant to the corresponding port. The aging counters down-count every clock cycle where the port is requesting but not granted. The higher significant 5-bits of the read aging counter sets the priority of the read channel of a given port. Port's priority increases as the higher significant 5-bits of the counter starts to decrease. When the aging counter becomes 0, the corresponding port channel has the highest priority level (timeout condition - Priority0). For multi-port configurations, the aging counters cannot be used to set port priorities when external dynamic priority inputs (arqos) are enabled (timeout is still applicable). For single port configurations, the aging counters are only used when they timeout (become 0) to force read-write direction switching. In this case, external dynamic priority input, arqos (for reads only) can still be used to set the DDRC read priority (2 priority levels: low priority read - LPR, high priority read - HPR) on a command by command basis. Note: The two LSBs of this register field are tied internally to 2'b00. Programming mode: Static
$00001000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_AGING_EN         \ If set to 1, enables aging function for the read channel of the port. Programming mode: Static
$00002000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_URGENT_EN        \ If set to 1, enables the AXI urgent sideband signal (arurgent). When enabled and arurgent is asserted by the master, that port becomes the highest priority and co_gs_go2critical_lpr/co_gs_go2critical_hpr signal to DDRC is asserted if enabled in PCCFG.go2critical_en register. Note that arurgent signal can be asserted anytime and as long as required which is independent of address handshaking (it is not associated with any particular command). Programming mode: Static
$00004000 constant DDRCTRL_DDRCTRL_PCFGR_0_RD_PORT_PAGEMATCH_EN     \ If set to 1, enables the Page Match feature. If enabled, once a requesting port is granted, the port is continued to be granted if the following immediate commands are to the same memory page (same bank and same row). See also related PCCFG.pagematch_limit register. Programming mode: Static
$00010000 constant DDRCTRL_DDRCTRL_PCFGR_0_RDWR_ORDERED_EN          \ Enables ordered read/writes. If set to 1, preserves the ordering between read transaction and write transaction issued to the same address, on a given port. In other words, the controller ensures that all same address read and write commands from the application port interface are transported to the DFI interface in the order of acceptance. This feature is useful in cases where software coherency is desired for masters issuing back-to-back read/write transactions without waiting for write/read responses. Note that this register has an effect only if necessary logic is instantiated via the UMCTL2_RDWR_ORDERED_n parameter. Programming mode: Static.


\
\ @brief DDRCTRL port x configuration write register
\ Address offset: 0x408
\ Reset value: 0x00004000
\

$000003ff constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_PRIORITY         \ Determines the initial load value of write aging counters. These counters are parallel loaded after reset, or after each grant to the corresponding port. The aging counters down-count every clock cycle where the port is requesting but not granted. The higher significant 5-bits of the write aging counter sets the initial priority of the write channel of a given port. Port's priority increases as the higher significant 5-bits of the counter starts to decrease. When the aging counter becomes 0, the corresponding port channel has the highest priority level. For multi-port configurations, the aging counters cannot be used to set port priorities when external dynamic priority inputs (awqos) are enabled (timeout is still applicable). For single port configurations, the aging counters are only used when they timeout (become 0) to force read-write direction switching. Note: The two LSBs of this register field are tied internally to 2'b00. Programming mode: Static
$00001000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_AGING_EN         \ If set to 1, enables aging function for the write channel of the port. Programming mode: Static
$00002000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_URGENT_EN        \ If set to 1, enables the AXI urgent sideband signal (awurgent). When enabled and awurgent is asserted by the master, that port becomes the highest priority and co_gs_go2critical_wr signal to DDRC is asserted if enabled in PCCFG.go2critical_en register. Note that awurgent signal can be asserted anytime and as long as required which is independent of address handshaking (it is not associated with any particular command). Programming mode: Static
$00004000 constant DDRCTRL_DDRCTRL_PCFGW_0_WR_PORT_PAGEMATCH_EN     \ If set to 1, enables the Page Match feature. If enabled, once a requesting port is granted, the port is continued to be granted if the following immediate commands are to the same memory page (same bank and same row). See also related PCCFG.pagematch_limit register. Programming mode: Static


\
\ @brief DDRCTRL port x control register
\ Address offset: 0x490
\ Reset value: 0x00000000
\

$00000001 constant DDRCTRL_DDRCTRL_PCTRL_0_PORT_EN                  \ Enables AXI port n. Programming mode: Dynamic


\
\ @brief DDRCTRL port x read Q0S configuration register 0
\ Address offset: 0x494
\ Reset value: 0x02000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_LEVEL1       \ Separation level1 indicating the end of region0 mapping; start of region0 is 0. Possible values for level1 are 0 to 13 (for dual RAQ) or 0 to 14 (for single RAQ) which corresponds to arqos. Note that for PA, arqos values are used directly as port priorities, where the higher the value corresponds to higher port priority. All of the map_level* registers must be set to distinct values. Programming mode: Quasi-dynamic Group 3
$00030000 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_REGION0      \ This bitfield indicates the traffic class of region 0. Valid values are: -0: LPR, 1: VPR, 2: HPR. For dual address queue configurations, region 0 maps to the blue address queue. In this case, valid values are: -0: LPR and 1: VPR only. When VPR support is disabled (UMCTL2_VPR_EN = 0) and traffic class of region0 is set to 1 (VPR), VPR traffic is aliased to LPR traffic. Programming mode: Quasi-dynamic Group 3
$00300000 constant DDRCTRL_DDRCTRL_PCFGQOS0_0_RQOS_MAP_REGION1      \ This bitfield indicates the traffic class of region 1. Valid values are: -0: LPR, -1: VPR, - 2: HPR. For dual address queue configurations, region1 maps to the blue address queue. In this case, valid values are -0: LPR and -1: VPR only. When VPR support is disabled (UMCTL2_VPR_EN = 0) and traffic class of region 1 is set to 1 (VPR), VPR traffic is aliased to LPR traffic. Programming mode: Quasi-dynamic Group 3


\
\ @brief DDRCTRL port x read Q0S configuration register 1
\ Address offset: 0x498
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGQOS1_0_RQOS_MAP_TIMEOUTB     \ Specifies the timeout value for transactions mapped to the blue address queue. Programming mode: Quasi-dynamic Group 3.
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGQOS1_0_RQOS_MAP_TIMEOUTR     \ Specifies the timeout value for transactions mapped to the red address queue. With single read address queue, there is no red queue and this value has no effect. Programming mode: Quasi-dynamic Group 3


\
\ @brief DDRCTRL port x write Q0S configuration register 0
\ Address offset: 0x49C
\ Reset value: 0x00000E00
\

$0000000f constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_LEVEL1      \ Separation level indicating the end of region0 mapping; start of region0 is 0. Possible values for level1 are 0 to 13 which corresponds to awqos. Note that for PA, awqos values are used directly as port priorities, where the higher the value corresponds to higher port priority. All of the map_level* registers must be set to distinct values. Programming mode: Quasi-dynamic Group 3
$00000f00 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_LEVEL2      \ Separation level2 indicating the end of region1 mapping; start of region1 is (level1 + 1). Possible values for level2 are (level1 + 1) to 14 which corresponds to awqos. Region2 starts from (level2 + 1) up to 15. Note that for PA, awqos values are used directly as port priorities, where the higher the value corresponds to higher port priority. All of the map_level* registers must be set to distinct values. Programming mode: Quasi-dynamic Group 3
$00030000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION0     \ This bitfield indicates the traffic class of region 0. Valid values are: When VPW support is disabled (UMCTL2_VPW_EN = 0) and traffic class of region 0 is set to 1 (VPW), VPW traffic is aliased to NPW traffic. Programming mode: Quasi-dynamic Group 3
$00300000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION1     \ This bitfield indicates the traffic class of region 1. Valid values are: When VPW support is disabled (UMCTL2_VPW_EN = 0) and traffic class of region 1 is set to 1 (VPW), VPW traffic is aliased to NPW traffic. Programming mode: Quasi-dynamic Group 3
$03000000 constant DDRCTRL_DDRCTRL_PCFGWQOS0_0_WQOS_MAP_REGION2     \ This bitfield indicates the traffic class of region 2. Valid values are: When VPW support is disabled (UMCTL2_VPW_EN = 0) and traffic class of region 2 is set to 1 (VPW), VPW traffic is aliased to NPW traffic. Programming mode: Quasi-dynamic Group 3


\
\ @brief DDRCTRL port x write Q0S configuration register 1
\ Address offset: 0x4A0
\ Reset value: 0x00000000
\

$000007ff constant DDRCTRL_DDRCTRL_PCFGWQOS1_0_WQOS_MAP_TIMEOUT1    \ Specifies the timeout value for write transactions in region 0 and 1. Programming mode: Quasi-dynamic Group 3.
$07ff0000 constant DDRCTRL_DDRCTRL_PCFGWQOS1_0_WQOS_MAP_TIMEOUT2    \ Specifies the timeout value for write transactions in region 2. Programming mode: Quasi-dynamic Group 3.


\
\ @brief DDRCTRL
\
$5a003000 constant DDRCTRL_DDRCTRL_MSTR  \ offset: 0x00 : DDRCTRL master register 0
$5a003004 constant DDRCTRL_DDRCTRL_STAT  \ offset: 0x04 : DDRCTRL operating mode status register
$5a003010 constant DDRCTRL_DDRCTRL_MRCTRL0  \ offset: 0x10 : DDRCTRL mode register read/write control register 0
$5a003014 constant DDRCTRL_DDRCTRL_MRCTRL1  \ offset: 0x14 : DDRCTRL mode register read/write control register 1
$5a003018 constant DDRCTRL_DDRCTRL_MRSTAT  \ offset: 0x18 : DDRCTRL mode register read/write status register
$5a003020 constant DDRCTRL_DDRCTRL_DERATEEN  \ offset: 0x20 : DDRCTRL temperature derate enable register
$5a003024 constant DDRCTRL_DDRCTRL_DERATEINT  \ offset: 0x24 : DDRCTRL temperature derate interval register
$5a003030 constant DDRCTRL_DDRCTRL_PWRCTL  \ offset: 0x30 : DDRCTRL low power control register
$5a003034 constant DDRCTRL_DDRCTRL_PWRTMG  \ offset: 0x34 : DDRCTRL low power timing register
$5a003038 constant DDRCTRL_DDRCTRL_HWLPCTL  \ offset: 0x38 : DDRCTRL hardware low power control register
$5a003050 constant DDRCTRL_DDRCTRL_RFSHCTL0  \ offset: 0x50 : DDRCTRL refresh control register 0
$5a003060 constant DDRCTRL_DDRCTRL_RFSHCTL3  \ offset: 0x60 : DDRCTRL refresh control register 3
$5a003064 constant DDRCTRL_DDRCTRL_RFSHTMG  \ offset: 0x64 : DDRCTRL refresh timing register
$5a0030c0 constant DDRCTRL_DDRCTRL_CRCPARCTL0  \ offset: 0xC0 : DDRCTRL CRC parity control register 0
$5a0030cc constant DDRCTRL_DDRCTRL_CRCPARSTAT  \ offset: 0xCC : DDRCTRL CRC parity status register
$5a0030d0 constant DDRCTRL_DDRCTRL_INIT0  \ offset: 0xD0 : DDRCTRL SDRAM initialization register 0
$5a0030d4 constant DDRCTRL_DDRCTRL_INIT1  \ offset: 0xD4 : DDRCTRL SDRAM initialization register 1
$5a0030d8 constant DDRCTRL_DDRCTRL_INIT2  \ offset: 0xD8 : DDRCTRL SDRAM initialization register 2
$5a0030dc constant DDRCTRL_DDRCTRL_INIT3  \ offset: 0xDC : DDRCTRL SDRAM initialization register 3
$5a0030e0 constant DDRCTRL_DDRCTRL_INIT4  \ offset: 0xE0 : DDRCTRL SDRAM initialization register 4
$5a0030e4 constant DDRCTRL_DDRCTRL_INIT5  \ offset: 0xE4 : DDRCTRL SDRAM initialization register 5
$5a0030f0 constant DDRCTRL_DDRCTRL_DIMMCTL  \ offset: 0xF0 : DDRCTRL DIMM control register
$5a003100 constant DDRCTRL_DDRCTRL_DRAMTMG0  \ offset: 0x100 : DDRCTRL SDRAM timing register 0
$5a003104 constant DDRCTRL_DDRCTRL_DRAMTMG1  \ offset: 0x104 : DDRCTRL SDRAM timing register 1
$5a003108 constant DDRCTRL_DDRCTRL_DRAMTMG2  \ offset: 0x108 : DDRCTRL SDRAM timing register 2
$5a00310c constant DDRCTRL_DDRCTRL_DRAMTMG3  \ offset: 0x10C : DDRCTRL SDRAM timing register 3
$5a003110 constant DDRCTRL_DDRCTRL_DRAMTMG4  \ offset: 0x110 : DDRCTRL SDRAM timing register 4
$5a003114 constant DDRCTRL_DDRCTRL_DRAMTMG5  \ offset: 0x114 : DDRCTRL SDRAM timing register 5
$5a003118 constant DDRCTRL_DDRCTRL_DRAMTMG6  \ offset: 0x118 : DDRCTRL SDRAM timing register 6
$5a00311c constant DDRCTRL_DDRCTRL_DRAMTMG7  \ offset: 0x11C : DDRCTRL SDRAM timing register 7
$5a003120 constant DDRCTRL_DDRCTRL_DRAMTMG8  \ offset: 0x120 : DDRCTRL SDRAM timing register 8
$5a003138 constant DDRCTRL_DDRCTRL_DRAMTMG14  \ offset: 0x138 : DDRCTRL SDRAM timing register 14
$5a00313c constant DDRCTRL_DDRCTRL_DRAMTMG15  \ offset: 0x13C : DDRCTRL SDRAM timing register 15
$5a003180 constant DDRCTRL_DDRCTRL_ZQCTL0  \ offset: 0x180 : DDRCTRL ZQ control register 0
$5a003184 constant DDRCTRL_DDRCTRL_ZQCTL1  \ offset: 0x184 : DDRCTRL ZQ control register 1
$5a003188 constant DDRCTRL_DDRCTRL_ZQCTL2  \ offset: 0x188 : DDRCTRL ZQ control register 2
$5a00318c constant DDRCTRL_DDRCTRL_ZQSTAT  \ offset: 0x18C : DDRCTRL ZQ status register
$5a003190 constant DDRCTRL_DDRCTRL_DFITMG0  \ offset: 0x190 : DDRCTRL DFI timing register 0
$5a003194 constant DDRCTRL_DDRCTRL_DFITMG1  \ offset: 0x194 : DDRCTRL DFI timing register 1
$5a003198 constant DDRCTRL_DDRCTRL_DFILPCFG0  \ offset: 0x198 : DDRCTRL low power configuration register 0
$5a0031a0 constant DDRCTRL_DDRCTRL_DFIUPD0  \ offset: 0x1A0 : DDRCTRL DFI update register 0
$5a0031a4 constant DDRCTRL_DDRCTRL_DFIUPD1  \ offset: 0x1A4 : DDRCTRL DFI update register 1
$5a0031a8 constant DDRCTRL_DDRCTRL_DFIUPD2  \ offset: 0x1A8 : DDRCTRL DFI update register 2
$5a0031b0 constant DDRCTRL_DDRCTRL_DFIMISC  \ offset: 0x1B0 : DDRCTRL DFI miscellaneous control register
$5a0031bc constant DDRCTRL_DDRCTRL_DFISTAT  \ offset: 0x1BC : DDRCTRL DFI status register
$5a0031c4 constant DDRCTRL_DDRCTRL_DFIPHYMSTR  \ offset: 0x1C4 : DDRCTRL DFI PHY master register
$5a003204 constant DDRCTRL_DDRCTRL_ADDRMAP1  \ offset: 0x204 : DDRCTRL address map register 1
$5a003208 constant DDRCTRL_DDRCTRL_ADDRMAP2  \ offset: 0x208 : DDRCTRL address map register 2
$5a00320c constant DDRCTRL_DDRCTRL_ADDRMAP3  \ offset: 0x20C : DDRCTRL address map register 3
$5a003210 constant DDRCTRL_DDRCTRL_ADDRMAP4  \ offset: 0x210 : DDRCTRL address map register 4
$5a003214 constant DDRCTRL_DDRCTRL_ADDRMAP5  \ offset: 0x214 : DDRCTRL address map register 5
$5a003218 constant DDRCTRL_DDRCTRL_ADDRMAP6  \ offset: 0x218 : DDRCTRL address register 6
$5a003224 constant DDRCTRL_DDRCTRL_ADDRMAP9  \ offset: 0x224 : DDRCTRL address map register 9
$5a003228 constant DDRCTRL_DDRCTRL_ADDRMAP10  \ offset: 0x228 : DDRCTRL address map register 10
$5a00322c constant DDRCTRL_DDRCTRL_ADDRMAP11  \ offset: 0x22C : DDRCTRL address map register 11
$5a003240 constant DDRCTRL_DDRCTRL_ODTCFG  \ offset: 0x240 : DDRCTRL ODT configuration register
$5a003244 constant DDRCTRL_DDRCTRL_ODTMAP  \ offset: 0x244 : DDRCTRL ODT/Rank map register
$5a003250 constant DDRCTRL_DDRCTRL_SCHED  \ offset: 0x250 : DDRCTRL scheduler control register
$5a003254 constant DDRCTRL_DDRCTRL_SCHED1  \ offset: 0x254 : DDRCTRL scheduler control register 1
$5a00325c constant DDRCTRL_DDRCTRL_PERFHPR1  \ offset: 0x25C : DDRCTRL high priority read CAM register 1
$5a003264 constant DDRCTRL_DDRCTRL_PERFLPR1  \ offset: 0x264 : DDRCTRL low priority read CAM register 1
$5a00326c constant DDRCTRL_DDRCTRL_PERFWR1  \ offset: 0x26C : DDRCTRL write CAM register 1
$5a003300 constant DDRCTRL_DDRCTRL_DBG0  \ offset: 0x300 : DDRCTRL debug register 0
$5a003304 constant DDRCTRL_DDRCTRL_DBG1  \ offset: 0x304 : DDRCTRL debug register 1
$5a003308 constant DDRCTRL_DDRCTRL_DBGCAM  \ offset: 0x308 : DDRCTRL CAM debug register
$5a00330c constant DDRCTRL_DDRCTRL_DBGCMD  \ offset: 0x30C : DDRCTRL command debug register
$5a003310 constant DDRCTRL_DDRCTRL_DBGSTAT  \ offset: 0x310 : DDRCTRL status debug register
$5a003320 constant DDRCTRL_DDRCTRL_SWCTL  \ offset: 0x320 : DDRCTRL software register programming control enable
$5a003324 constant DDRCTRL_DDRCTRL_SWSTAT  \ offset: 0x324 : DDRCTRL software register programming control status
$5a00336c constant DDRCTRL_DDRCTRL_POISONCFG  \ offset: 0x36C : DDRCTRL AXI Poison configuration register
$5a003370 constant DDRCTRL_DDRCTRL_POISONSTAT  \ offset: 0x370 : DDRCTRL AXI Poison status register
$5a0033fc constant DDRCTRL_DDRCTRL_PSTAT  \ offset: 0x3FC : DDRCTRL port status register
$5a003400 constant DDRCTRL_DDRCTRL_PCCFG  \ offset: 0x400 : DDRCTRL port common configuration register
$5a003404 constant DDRCTRL_DDRCTRL_PCFGR_0  \ offset: 0x404 : DDRCTRL port x configuration read register
$5a003408 constant DDRCTRL_DDRCTRL_PCFGW_0  \ offset: 0x408 : DDRCTRL port x configuration write register
$5a003490 constant DDRCTRL_DDRCTRL_PCTRL_0  \ offset: 0x490 : DDRCTRL port x control register
$5a003494 constant DDRCTRL_DDRCTRL_PCFGQOS0_0  \ offset: 0x494 : DDRCTRL port x read Q0S configuration register 0
$5a003498 constant DDRCTRL_DDRCTRL_PCFGQOS1_0  \ offset: 0x498 : DDRCTRL port x read Q0S configuration register 1
$5a00349c constant DDRCTRL_DDRCTRL_PCFGWQOS0_0  \ offset: 0x49C : DDRCTRL port x write Q0S configuration register 0
$5a0034a0 constant DDRCTRL_DDRCTRL_PCFGWQOS1_0  \ offset: 0x4A0 : DDRCTRL port x write Q0S configuration register 1

