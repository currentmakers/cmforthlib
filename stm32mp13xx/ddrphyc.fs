\
\ @file ddrphyc.fs
\ @brief DDRPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief DDRPHYC revision ID register
\ Address offset: 0x00
\ Reset value: 0x00200200
\

$0000000f constant DDRPHYC_DDRPHYC_RIDR_PUBMNR                      \ PUB minor rev
$000000f0 constant DDRPHYC_DDRPHYC_RIDR_PUBMDR                      \ PUB moderate rev
$00000f00 constant DDRPHYC_DDRPHYC_RIDR_PUBMJR                      \ PUB maj rev
$0000f000 constant DDRPHYC_DDRPHYC_RIDR_PHYMNR                      \ PHY minor rev
$000f0000 constant DDRPHYC_DDRPHYC_RIDR_PHYMDR                      \ PHY moderate rev
$00f00000 constant DDRPHYC_DDRPHYC_RIDR_PHYMJR                      \ PHY maj rev
$ff000000 constant DDRPHYC_DDRPHYC_RIDR_UDRID                       \ User-defined rev ID


\
\ @brief DDRPHYC PHY initialization register
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_PIR_INIT                         \ Initialization trigger A write of '1' to this bit triggers the DDR system initialization, including PHY initialization, DRAM initialization, and PHY training. The exact initialization steps to be executes are specified in bits 1 to 6 of this register. A bit setting of 1 means the step is executed as part of the initialization sequence, while a setting of '0â means the step is bypassed. The initialization trigger bit is self-clearing.
$00000002 constant DDRPHYC_DDRPHYC_PIR_DLLSRST                      \ DLL soft reset Soft resets all PHY DLLs by driving the DLL soft reset pin. Note: - Requires that ctl_clk be toggling for the DLL soft reset signal to be output from the DLL. If ctl_clk (AC DLL's cclk_0) is not guaranteed to be toggling, it is recommended to use the manual DLL soft reset bit DLLSRST of DDRPHYC_ACDLLCR, and not bit DLLSRST of DDRPHYC_PIR. - Ensure that the minimum requirements for DLL bypass and DLL reset are observed while asserting this bit.
$00000004 constant DDRPHYC_DDRPHYC_PIR_DLLLOCK                      \ DLL lock Waits for the PHY DLLs to lock.
$00000008 constant DDRPHYC_DDRPHYC_PIR_ZCAL                         \ Impedance calibration (Driver and ODT) Performs PHY impedance calibration.
$00000010 constant DDRPHYC_DDRPHYC_PIR_ITMSRST                      \ ITM reset Soft resets the interface timing modules for the data and data strobes, i.e., it asserts the ITM soft reset (srstb) signal.
$00000020 constant DDRPHYC_DDRPHYC_PIR_DRAMRST                      \ DRAM reset (DDR3 only) Issues a reset to the DRAM (by driving the DRAM reset pin low) and wait 200us. This can be triggered in isolation or with the full DRAM initialization (DRAMINIT). For the latter case, the reset is issued and 200us is waited before starting the full initialization sequence.
$00000040 constant DDRPHYC_DDRPHYC_PIR_DRAMINIT                     \ DRAM initialization Executes the DRAM initialization sequence
$00000080 constant DDRPHYC_DDRPHYC_PIR_QSTRN                        \ Read DQS training Executes a PUBL training routine to determine the optimum position of the read data DQS strobe for maximum system timing margins.
$00000100 constant DDRPHYC_DDRPHYC_PIR_RVTRN                        \ Read DQS gate training DQSTRN) and RV training (RVTRN) should normally be run together. It is expected RVTRN is normally set whenever bit QSTRN is set. If RVTRN=1 and bit QSTRN=0, when bit INIT=1 (triggering the init process) the read DQS gate training algorithm still runs (as if bit QSTRN in DDRPHYC_PIR register was actually set to 1). If it is necessary to run only RV training stand-alone, with no read DQS gate training, you can prevent the read DQS gate training from running by setting bit LBGDQS=1 in DDRPHYC_PGCR register. Note: RV training cannot use multi-purpose register (MPR) and must use the user data programmed in DTDR0-1. Note: RVTRN is not applicable to this version of PUBL.
$00010000 constant DDRPHYC_DDRPHYC_PIR_ICPC                         \ Initialization complete pin configuration Specifies how the DFI 2.1 initialization complete output pin should be used to indicate the status of initialization.
$00020000 constant DDRPHYC_DDRPHYC_PIR_DLLBYP                       \ DLL bypass A setting of 1 on this bit puts all PHY DLLs in bypass mode. A bypassed DLL is also powered down (disabled).
$00040000 constant DDRPHYC_DDRPHYC_PIR_CTLDINIT                     \ Controller DRAM initialization Indicates if set that DRAM initialization is performed by the controller. Otherwise if not set it indicates that DRAM initialization is performed using the built-in initialization sequence or using software through the configuration port.
$10000000 constant DDRPHYC_DDRPHYC_PIR_CLRSR                        \ clear status register Writing 1 to this bits does the following: Auto-clears itself. This means a following read to bit CLRSR returns 0 Clears the DXnGSR0 bits for DTDONE, DTERR, DTIERR Clears bit DFTERR in DDRPHYC_PGSR register and bit DFTERR in DDRPHYC_DXnGSR1 register This bit is primarily for debug purposes and is typically not needed during normal functional operation. It can be used when bit IDONE=1 in PGSR register, to manually clear the PGSR status bits, however, the PGSR status bits (except for the DFTRR and TQ bits) are automatically cleared by starting a new init process. The bit can also be used to manually clear the DXnGSR status bits, however, starting a new data training process automatically clears the DXnGSR status bits.
$20000000 constant DDRPHYC_DDRPHYC_PIR_LOCKBYP                      \ DLL lock bypass Bypasses or stops, if set, the waiting of DLLs to lock. DLL lock wait is automatically triggers after reset. DLL lock wait may be triggered manually using INIT and DLLLOCK bits of the DDRPHYC_PIR register. This bit is self-clearing.
$40000000 constant DDRPHYC_DDRPHYC_PIR_ZCALBYP                      \ zcal bypass Bypasses or stops, if set, impedance calibration of all ZQ control blocks that automatically triggers after reset. Impedance calibration may be triggered manually using INIT and ZCAL bits of the DDRPHYC_PIR register. This bit is self-clearing.
$80000000 constant DDRPHYC_DDRPHYC_PIR_INITBYP                      \ Initialization bypass Bypasses or stops, if set, all initialization routines currently running, including PHY initialization, DRAM initialization, and PHY training. Initialization may be triggered manually using INIT and the other relevant bits of the DDRPHYC_PIR register. This bit is self-clearing.


\
\ @brief DDRPHYC PHY global control register
\ Address offset: 0x08
\ Reset value: 0x01842E04
\

$00000001 constant DDRPHYC_DDRPHYC_PGCR_ITMDMD                      \ ITM DDR mode Selects whether ITMS uses DQS and DQS# or it only uses DQS. Valid values are: Note: The correct setting is always DQS and DQS#.
$00000002 constant DDRPHYC_DDRPHYC_PGCR_DQSCFG                      \ DQS gating configuration Selects one of the two DQS gating schemes: Note: Passive windowing must be used for LPDDR2/3.
$00000004 constant DDRPHYC_DDRPHYC_PGCR_DFTCMP                      \ DQS drift compensation Enables or disables DQS drift compensation. Valid values are: By default, drift compensation is enabled. Note: Drift compensation is not supported under any of the following situations: - LPDDR2/3 (bit DDRMD set to LPDDR2 in DDRPHYC_DCR register) - Burst length 2 (bit BL in DDRPHYC_MR0 register set to burst length of 2) - Read DQS gating using passive windowing (bit DQSCFG in DDRPHYC_PGCR register set to passive windowing) Drift compensation must be set to disabled if any of the above are set.
$00000018 constant DDRPHYC_DDRPHYC_PGCR_DFTLMT                      \ DQS drift limit Specifies the expected limit of drift on read data strobes. A drift of this value or greater is reported as a drift error through the host port error flag. Valid values are: Note: Although reported through the error flag, this is not an error requiring any action. It is simply an indicator that the drift is greater than expected.
$000001e0 constant DDRPHYC_DDRPHYC_PGCR_DTOSEL                      \ Digital test output select Digital Test Output Select: Selects the PHY digital test output that should be driven onto PHY digital test output (phy_dto) pin: Valid values are: Other: Reserved
$00000e00 constant DDRPHYC_DDRPHYC_PGCR_CKEN                        \ CK enable Controls whether the CK going to the SDRAM is enabled (toggling) or disabled (static value defined by CKDV). One bit for each of the three CK pairs.
$00003000 constant DDRPHYC_DDRPHYC_PGCR_CKDV                        \ CK disable value Specifies the static value that should be driven on CK/CK# pair(s) when the pair(s) is disabled. CKDV[0] specifies the value for CK and CKDV[1] specifies the value for CK#.
$00004000 constant DDRPHYC_DDRPHYC_PGCR_CKINV                       \ CK invert Specifies if set that CK/CK# should be inverted. Otherwise CK/CK# toggles with normal polarity.
$00008000 constant DDRPHYC_DDRPHYC_PGCR_IOLB                        \ I/O loop back select Selects where inside the I/O the loop-back of signals happens. Not applicable to D3A I/Os. Valid values are:
$00030000 constant DDRPHYC_DDRPHYC_PGCR_IODDRM                      \ I/O DDR mode Selects the DDR mode for the I/Os.
$003c0000 constant DDRPHYC_DDRPHYC_PGCR_RANKEN                      \ Rank enable Specifies the ranks that are enabled for data-training. only Bit 0 is used and controls rank 0. Setting the bit to '1â enables the rank, and setting it to '0â disables the rank.
$00c00000 constant DDRPHYC_DDRPHYC_PGCR_ZKSEL                       \ Impedance clock divider selection Selects the divide ratio for the clock used by the impedance control logic. The source clock for the divider is the configuration port clock signal (pclk), depending on which configuration port type used (see âImpedance Calibrationâ on page tbc). Valid values are:
$01000000 constant DDRPHYC_DDRPHYC_PGCR_PDDISDX                     \ Power down disabled byte Indicates if set that the DLL and I/Os of a disabled byte should be powered down.
$1e000000 constant DDRPHYC_DDRPHYC_PGCR_RFSHDT                      \ Refresh during training A non-zero value specifies that a burst of refreshes equal to the number specified in this field should be sent to the SDRAM after training each rank except the last rank.
$20000000 constant DDRPHYC_DDRPHYC_PGCR_LBDQSS                      \ Loop back DQS shift Selects how the read DQS is shifted during loopback to ensure that the read DQS is centered into the read data eye. Valid values are:
$40000000 constant DDRPHYC_DDRPHYC_PGCR_LBGDQS                      \ Loop back DQS gating Selects the DQS gating mode that should be used when the PHY is in loopback mode. Valid values are:
$80000000 constant DDRPHYC_DDRPHYC_PGCR_LBMODE                      \ Loop back mode Indicates if set that the PHY/PUB is in loopback mode


\
\ @brief DDRPHYC PHY global status register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_PGSR_IDONE                       \ Initialization done Indicates if set that the DDR system initialization has completed. This bit is set after all the selected initialization routines in DDRPHYC_PIR register have completed.
$00000002 constant DDRPHYC_DDRPHYC_PGSR_DLDONE                      \ DLL lock done Indicates if set that DLL locking has completed.
$00000004 constant DDRPHYC_DDRPHYC_PGSR_ZCDDONE                     \ zcal done Indicates if set that impedance calibration has completed.
$00000008 constant DDRPHYC_DDRPHYC_PGSR_DIDONE                      \ DRAM initialization done Indicates if set that DRAM initialization has completed.
$00000010 constant DDRPHYC_DDRPHYC_PGSR_DTDONE                      \ Data training done Indicates, if set, that the PHY has finished doing data training.
$00000020 constant DDRPHYC_DDRPHYC_PGSR_DTERR                       \ DQS gate training error If set, indicates that a valid DQS gating window could not be found during DQS gate training.
$00000040 constant DDRPHYC_DDRPHYC_PGSR_DTIERR                      \ DQS gate training intermittent error If set, indicates that there was an intermittent error during DQS gate training, such as a pass was followed by a fail then followed by another pass.
$00000080 constant DDRPHYC_DDRPHYC_PGSR_DFTERR                      \ DQS drift error If set, indicates that at least one of the read data strobes has drifted by more than or equal to the drift limit set in the PHY General Configuration Register (PGCR).
$00000100 constant DDRPHYC_DDRPHYC_PGSR_RVERR                       \ Read valid training error If set, indicates that a valid read valid placement could not be found during read valid training. Note: RVTRN is not applicable to this version of PUBL
$00000200 constant DDRPHYC_DDRPHYC_PGSR_RVEIRR                      \ Read valid training intermittent error If set, indicates that there was an intermittent error during read valid training, such as a pass was followed by a fail then followed by another pass. Note: RVTRN is not applicable to this version of PUBL
$80000000 constant DDRPHYC_DDRPHYC_PGSR_TQ                          \ Temperature output (LPDDR only) N/A


\
\ @brief DDRPHYC DDR DLL global control register
\ Address offset: 0x10
\ Reset value: 0x03737000
\

$00000003 constant DDRPHYC_DDRPHYC_DLLGCR_DRES                      \ Trim reference current versus resistor value variation 1x: Rnom + 20% Note: For a few processes this field is reserved and is not used by the DLL.
$0000001c constant DDRPHYC_DDRPHYC_DLLGCR_IPUMP                     \ Charge pump current trim Note: If DWC_DDR3PHY_DLL_TYPEA Verilog macro is defined then the default value for this field is 011.
$00000020 constant DDRPHYC_DDRPHYC_DLLGCR_TESTEN                    \ Test enable Enables digital and analog test outputs selected by DTC and ATC respectively.
$000001c0 constant DDRPHYC_DDRPHYC_DLLGCR_DTC                       \ Digital test control Selects the digital signal to be output on the DLL digital test output (test_out_d[1]) when TESTEN is high (Output is '0' when TESTEN is low). Valid settings for master DLL (such as, when TESTSW = '0'): -000: 0 output clock (clk_0) -001: 90 output clock (clk_90) -010: 180 output clock (clk_180) -011: 270 output clock (clk_270) -100: 360 internal clock (clk_360_int) -101: Speed-up pulse (spdup) -110: Slow-down pulse (slwdn) -111: 0 MCTL logic clock (cclk_0) Valid settings for slave DLL (such as when TESTSW = '1'): -000: Input DQS strobe (dqs) -001: Input clock reference (clk_90_in) -010: Internal feedback clock (clk_0_out) -011: 90 output DQS# strobe (dqsb_90) -100: 90 output DQS strobe (dqs_90) -101: Speed-up pulse (spdup) -110: Slow-down pulse (slwdn) -111: Auto-lock enable signal
$00000600 constant DDRPHYC_DDRPHYC_DLLGCR_ATC                       \ Analog test control Selects the analog signal to be output on the DLL analog test output (test_out_a) when TESTEN is high (Output is Vss when TESTEN is low). The test output either comes from the master DLL or the slave DLL, depending on the setting of the test switch (TESTSW). Both master DLL and slave DLL output similar analog test signals. Valid settings for analog test control are:
$00000800 constant DDRPHYC_DDRPHYC_DLLGCR_TESTSW                    \ Test switch Selects the test signals of either the master DLL, set to 0, or the slave DLL, set to 1.
$000ff000 constant DDRPHYC_DDRPHYC_DLLGCR_MBIAS                     \ Master bias trim Used to trim the bias for the master DLL. Note: If DWC_DDR3PHY_DLL_TYPEA Verilog macro is defined then the default value for this field is 0x00.
$00700000 constant DDRPHYC_DDRPHYC_DLLGCR_SBIAS2_0                  \ Slave bias trim Used to trim the bias for the slave DLL. Note: If DWC_DDR3PHY_DLL_TYPEA Verilog macro is defined then the default value for this field is 0x00.
$00800000 constant DDRPHYC_DDRPHYC_DLLGCR_BPS200                    \ Bypass mode frequency range
$07000000 constant DDRPHYC_DDRPHYC_DLLGCR_SBIAS5_3                  \ Slave bias trim Used to trim the bias for the slave DLL. Note: If DWC_DDR3PHY_DLL_TYPEA Verilog macro is defined then the default value for this field is 0x00.
$18000000 constant DDRPHYC_DDRPHYC_DLLGCR_FDTRMSL                   \ Slave bypass fixed delay trim
$20000000 constant DDRPHYC_DDRPHYC_DLLGCR_LOCKDET                   \ Master lock detect enable Note: This field is only valid for a few processes. For all other processes this field is reserved.
$c0000000 constant DDRPHYC_DDRPHYC_DLLGCR_DLLRSVD2                  \ These bit are connected to the DLL control bus and reserved for future use.


\
\ @brief DDRPHYC AC DLL control register
\ Address offset: 0x14
\ Reset value: 0x40000000
\

$000001c0 constant DDRPHYC_DDRPHYC_ACDLLCR_MFBDLY                   \ Master DLL feed-back delay trim Used to trim the delay in the master DLL feed-back path:
$00000e00 constant DDRPHYC_DDRPHYC_ACDLLCR_MFWDLY                   \ Master DLL feed-forward delay trim Used to trim the delay in the master DLL feed-forward path:
$00040000 constant DDRPHYC_DDRPHYC_ACDLLCR_ATESTEN                  \ Analog test enable Enables the analog test signal to be output on the DLL analog test output (ATO pin). The DLL analog test output is tri-stated when this bit is '0'.
$40000000 constant DDRPHYC_DDRPHYC_ACDLLCR_DLLSRST                  \ DLL soft reset Soft resets the AC DLL by driving the DLL soft reset pin.
$80000000 constant DDRPHYC_DDRPHYC_ACDLLCR_DLLDIS                   \ DLL disable A disabled DLL is bypassed. By default DLL is enabled.


\
\ @brief DDRPHYC PT register 0
\ Address offset: 0x18
\ Reset value: 0x0022AF9B
\

$0000003f constant DDRPHYC_DDRPHYC_PTR0_TDLLSRST                    \ DLL soft reset Number of configuration clock cycles that the DLL soft reset pin must remain asserted when the soft reset is triggered through the PHY initialization register (DDRPHYC_PIR). This must correspond to a value that is equal to or more than 50ns or 8 controller clock cycles, whichever is bigger. Default value corresponds to 50Â ns at 533Â MHz.
$0003ffc0 constant DDRPHYC_DDRPHYC_PTR0_TDLLLOCK                    \ DLL lock time Number of configuration clock cycles for the DLL to stabilize and lock, i.e. number of clock cycles from when the DLL reset pin is de-asserted to when the DLL has locked and is ready for use. Default value corresponds to 5.12us at 533MHz.
$003c0000 constant DDRPHYC_DDRPHYC_PTR0_TITMSRST                    \ ITM soft reset Number of configuration clock cycles that the ITM soft reset pin must remain asserted when the soft reset is applied to the ITMs. This must correspond to a value that is equal to or more than 8 controller clock cycles. Default value corresponds to 8 controller clock cycles.


\
\ @brief DDRPHYC PT register 1
\ Address offset: 0x1C
\ Reset value: 0x0604111D
\

$0007ffff constant DDRPHYC_DDRPHYC_PTR1_TDINIT0                     \ tDINIT0 DRAM initialization time corresponding to the following: DDR3 = CKE low time with power and clock stable (500 us) LPDDR2 = CKE high time to first command (200 us) LPDDR3 = CKE high time to first command (200us) Default value corresponds to DDR3 500 us at 533MHz.
$07f80000 constant DDRPHYC_DDRPHYC_PTR1_TDINIT1                     \ tDINIT1 DRAM initialization time corresponding to the following: DDR3 = CKE high time to first command (tRFC +10 ns or 5 tCK, whichever value is larger) LPDDR2 = CKE low time with power and clock stable (100 ns) LPDDR3 = CKE low time with power and clock stable (100 ns) Default value corresponds to DDR3 360ns at 533MHz.


\
\ @brief DDRPHYC PT register 2
\ Address offset: 0x20
\ Reset value: 0x042DA072
\

$0001ffff constant DDRPHYC_DDRPHYC_PTR2_TDINIT2                     \ tDINIT2 DRAM initialization time corresponding to the following: DDR3 = Reset low time (200 us on power-up or 100 ns after power-up) LPDDR2 = Time from reset command to end of auto initialization (1 us + 10 us = 11us) LPDDR3 = Time from reset command to end of auto initialization (11us) Default value corresponds to DDR3 200 us at 533MHz
$07fe0000 constant DDRPHYC_DDRPHYC_PTR2_TDINIT3                     \ tDINIT3 DRAM initialization time corresponding to the following: LPDDR2 = Time from ZQ initialization command to first command (1 us) LPDDR3 = Time from ZQ initialization command to first command (1us) Default value corresponds to the LPDDR2/3 1 us at 533MHz.


\
\ @brief DDRPHYC ACIOC register
\ Address offset: 0x24
\ Reset value: 0x30400812
\

$00000001 constant DDRPHYC_DDRPHYC_ACIOCR_ACIOM                     \ AC pins I/O mode Selects SSTL mode (when set to 0) or CMOS mode (when set to 1) of the I/O for all address and command pins,
$00000002 constant DDRPHYC_DDRPHYC_ACIOCR_ACOE                      \ AC pins output enable Enables, when set, the output driver on the I/O for all address and command pins
$00000004 constant DDRPHYC_DDRPHYC_ACIOCR_ACODT                     \ AC pins ODT Enables, when set, the on-die termination on the I/O for RAS#, CAS#, WE#, BA[2:0], and A[15:0] pins
$00000008 constant DDRPHYC_DDRPHYC_ACIOCR_ACPDD                     \ AC pins power down drivers Powers down, when set, the output driver on the I/O for RAS#, CAS#, WE#, BA[2:0], and A[15:0] pins
$00000010 constant DDRPHYC_DDRPHYC_ACIOCR_ACPDR                     \ AC pins power down receivers Powers down, when set, the input receiver on the I/O for RAS#, CAS#, WE#, BA[2:0], and A[15:0] pins.
$000000e0 constant DDRPHYC_DDRPHYC_ACIOCR_CKODT                     \ CK pin ODT Enables, when set, the on-die termination on the I/O for CK[0], CK[1], and CK[2] pins, respectively.
$00000700 constant DDRPHYC_DDRPHYC_ACIOCR_CKPDD                     \ CK pin power down driver Powers down, when set, the output driver on the I/O for CK[0], CK[1], and CK[2] pins, respectively.
$00003800 constant DDRPHYC_DDRPHYC_ACIOCR_CKPDR                     \ CK pin power down receiver Powers down, when set, the input receiver on the I/O for CK[0], CK[1], and CK[2] pins, respectively
$00004000 constant DDRPHYC_DDRPHYC_ACIOCR_RANKODT                   \ Rank ODT Enables, when set, the on-die termination on the I/O for CKE, ODT, and CS# pins.
$00040000 constant DDRPHYC_DDRPHYC_ACIOCR_CSPDD                     \ CS power down driver Powers down, when set, the output driver on the I/O for CS# pins. Only PDD[0] is used for single rank. CKE and ODT driver power down is controlled by DSGCR register.
$00400000 constant DDRPHYC_DDRPHYC_ACIOCR_RANKPDR                   \ Rank power down receiver Powers down, when set, the input receiver on the I/O CKE, ODT, and CS# pins. Only RANKPDR[0] is used for single rank
$04000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTODT                    \ RST pin ODT Enables, when set, the on-die termination on the I/O for SDRAM RST# pin.
$08000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTPDD                    \ RST pin power down driver Powers down, when set, the output driver on the I/O for SDRAM RST# pin.
$10000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTPDR                    \ RST pin power down receiver Powers down, when set, the input receiver on the I/O for SDRAM RST# pin.
$20000000 constant DDRPHYC_DDRPHYC_ACIOCR_RSTIOM                    \ Reset I/O mode Selects SSTL mode (when set to 0) or CMOS mode (when set to 1) of the I/O for SDRAM Reset.
$c0000000 constant DDRPHYC_DDRPHYC_ACIOCR_ACSR                      \ AC slew rate Selects slew rate of the I/O for all address and command pins.


\
\ @brief DDRPHYC DXCC register
\ Address offset: 0x28
\ Reset value: 0x00000800
\

$00000001 constant DDRPHYC_DDRPHYC_DXCCR_DXODT                      \ Data on die termination Enables, when set, the on-die termination on the I/O for DQ, DM, and DQS/DQS# pins of all DATX8 macros. This bit is ORed with the ODT configuration bit of the individual DATX8.
$00000002 constant DDRPHYC_DDRPHYC_DXCCR_DXIOM                      \ Data I/O mode Selects SSTL mode (when set to 0) or CMOS mode (when set to 1) of the I/O for DQ, DM, and DQS/DQS# pins of all DATX8 macros. This bit is ORed with the IOM configuration bit of the individual DATX8.
$00000004 constant DDRPHYC_DDRPHYC_DXCCR_DXPDD                      \ Data power down driver Powers down, when set, the output driver on I/O for DQ, DM, and DQS/DQS# pins of all DATX8 macros. This bit is ORed with the PDD configuration bit of the individual DATX8.
$00000008 constant DDRPHYC_DDRPHYC_DXCCR_DXPDR                      \ Data power down receiver Powers down, when set, the input receiver on I/O for DQ, DM, and DQS/DQS# pins of all DATX8 macros. It also powers down the PDQSR cell of all DAXT8 macros. This bit is ORed with the PDR and DQSRPD configuration bits of the individual DATX8
$000000f0 constant DDRPHYC_DDRPHYC_DXCCR_DQSRES                     \ DQS resistor Selects the on-die pull-down/pull-up resistor for DQS pins. DQSRES[3] selects pull-down (when set to 0) or pull-up (when set to 1). DQSRES[2:0] selects the resistor value as follows: Note: DQS resistor must be connected for LPDDR2
$00000f00 constant DDRPHYC_DDRPHYC_DXCCR_DQSNRES                    \ DQS# resistor Selects the on-die pull-up/pull-down resistor for DQS# pins. Same encoding as DQSRES. Note: DQS# resistor must be connected for LPDDR2.
$00004000 constant DDRPHYC_DDRPHYC_DXCCR_DQSNRST                    \ DQS reset Indicates, if set, that the ITMS of DQS# should always be put in reset such that its output enable is always '1' and its data output is always '0'. This is done by driving the oe_set_b and do_rst_b pins of this ITMS to '0' in order to force the unused DQS# PAD to a known state of '0' in applications that don't use DQS#.
$00008000 constant DDRPHYC_DDRPHYC_DXCCR_RVSEL                      \ ITMD read valid select Selects the scheme used for ITMD read valid. Valid values are:
$00010000 constant DDRPHYC_DDRPHYC_DXCCR_AWDT                       \ Active window data train Indicates if set that data training (DQS gate training and read valid training) should be performed with active DQS gate window. This is just for debug purposes. The default is to perform training with passive windowing.


\
\ @brief DDRPHYC DSGC register
\ Address offset: 0x2C
\ Reset value: 0xFA00001F
\

$00000001 constant DDRPHYC_DDRPHYC_DSGCR_PUREN                      \ PHY update request enable Specifies if set, that the PHY should issue PHY initiated DFI update request when there is DQS drift of more than Â¾ of a clock cycle within one continuous (back-to-back) read burst. By default the PHY issues PHY initiated update requests and the controller should respond otherwise the PHY may return erroneous values. The option to disable it is provided only for silicon evaluation and testing.
$00000002 constant DDRPHYC_DDRPHYC_DSGCR_BDISEN                     \ Byte disable enable Specifies if set that the PHY should respond to DFI byte disable request. Otherwise the byte disable from the DFI is ignored in which case bytes can only be disabled using the DXnGCR register
$00000004 constant DDRPHYC_DDRPHYC_DSGCR_ZUEN                       \ zcal on DFI update request Specifies if set that the PHY should perform impedance calibration (update) whenever there is a controller initiated DFI update request. Otherwise the PHY ignores an update request from the controller.
$00000008 constant DDRPHYC_DDRPHYC_DSGCR_LPIOPD                     \ Low power I/O power down Specifies if set that the PHY should respond to the DFI low power opportunity request and power down the I/Os of the PHY.
$00000010 constant DDRPHYC_DDRPHYC_DSGCR_LPDLLPD                    \ Low power DLL power down Specifies if set that the PHY should respond to the DFI low power opportunity request and power down the DLL of the PHY if the wakeup time request satisfies the DLL lock time. For more information on requirements when enabling and disabling the DLL, refer to âbypass mode register controlâ
$000000e0 constant DDRPHYC_DDRPHYC_DSGCR_DQSGX                      \ DQS gate extension Specifies the number of clock cycles for which the DQS gating must be extended beyond the normal burst length width. Only applicable when using PDQSR I/O cell, passive DQS gating and no drift compensation. This field is recommended to be set to zero for all DDR types other than LPDDR2/LPDDR3. For LPDDR2/LPDDR3 it should be set to (tDQSCKmax- tDQSCKmin) divide by clock period and rounded up. tDQSCKmax and tDQSCKmin can be found in the LPDDR2 vendor datasheet.
$00000700 constant DDRPHYC_DDRPHYC_DSGCR_DQSGE                      \ DQS gate early Specifies the number of clock cycles for which the DQS gating must be enable dearlier than its normal position. Only applicable when using PDQSR I/O cell, passive DQS gating and no drift compensation. This field is recommended to be set to zero for all DDR types other than LPDDR2/LPDDR3. For LPDDR2/LPDDR3 it should be set to (tDQSCKmax - tDQSCKmin) divide by clock period and rounded up. tDQSCKmax and tDQSCKmin can be found in the LPDDR/LPDDR2 vendor datasheet.
$00000800 constant DDRPHYC_DDRPHYC_DSGCR_NOBUB                      \ No bubble Specified whether reads should be returned to the controller with no bubbles. Enabling no-bubble reads increases the read latency. Valid values are:
$00001000 constant DDRPHYC_DDRPHYC_DSGCR_FXDLAT                     \ Fixed latency Specified whether all reads should be returned to the controller with a fixed read latency. Enabling fixed read latency increases the read latency. Valid values are:
$00010000 constant DDRPHYC_DDRPHYC_DSGCR_CKEPDD                     \ CKE power down driver Powers down, when set, the output driver on the I/O for CKE pin.
$00100000 constant DDRPHYC_DDRPHYC_DSGCR_ODTPDD                     \ ODT power down driver Powers down, when set, the output driver on the I/O for ODT pin.
$01000000 constant DDRPHYC_DDRPHYC_DSGCR_NL2PD                      \ Non LPDDR2 power down Powers down, when set, the output driver and the input receiver on the I/O for non-LPDDR2/LPDDR3 (ODT, RAS#, CAS#, WE#, and BA) pins. This may be used when a chip that is designed for both LPDDR2/LPDDR3 and other DDR modes is being used in LPDDR2/LPDDR3 mode. For these pins, the I/O power down signal (PDD or PDR) is an OR of this bit and the respective power-down bit in ACIOCR register.
$02000000 constant DDRPHYC_DDRPHYC_DSGCR_NL2OE                      \ Non LPDDR2 output enable Enables, when set, the output driver on the I/O for non-LPDDR2/LPDDR3 (ODT, RAS#, CAS#, WE#, and BA) pins. This may be used when a chip that is designed for both LPDDR2/LPDDR3 and other DDR modes is being used in LPDDR2/LPDDR3 mode. For these pins, the I/O output enable signal (OE) is an AND of this bit and the respective output enable bit in ACIOCR or DSGCR registers.
$04000000 constant DDRPHYC_DDRPHYC_DSGCR_TPDPD                      \ TPD power down driver (N/A LPDDR only)
$08000000 constant DDRPHYC_DDRPHYC_DSGCR_TPDOE                      \ TPD output enable (N/A LPDDR only)
$10000000 constant DDRPHYC_DDRPHYC_DSGCR_CKOE                       \ CK output enable Enables, when set, the output driver on the I/O for SDRAM CK/CK# pins.
$20000000 constant DDRPHYC_DDRPHYC_DSGCR_ODTOE                      \ ODT output enable Enables, when set, the output driver on the I/O for SDRAM ODT pins.
$40000000 constant DDRPHYC_DDRPHYC_DSGCR_RSTOE                      \ RST output enable Enables, when set, the output driver on the I/O for SDRAM RST# pin
$80000000 constant DDRPHYC_DDRPHYC_DSGCR_CKEOE                      \ CKE output enable Sets the output driver on the I/O for SDRAM CKE pins.


\
\ @brief DDRPHYC DC register
\ Address offset: 0x30
\ Reset value: 0x0000000B
\

$00000007 constant DDRPHYC_DDRPHYC_DCR_DDRMD                        \ SDRAM DDR mode Others: Reserved
$00000008 constant DDRPHYC_DDRPHYC_DCR_DDR8BNK                      \ DDR 8 banks Indicates if set that the SDRAM used has 8 banks. tRPA = tRP+1 and tFAW are used for 8-bank DRAMs, other tRPA = tRP and no tFAW is used. Note: A setting of 1 for DRAMs that have fewer than 8 banks still results in correct functionality but less tighter DRAM command spacing for the parameters described here.
$00000070 constant DDRPHYC_DDRPHYC_DCR_PDQ                          \ Primary DQ(DDR3 Only) Specifies the DQ pin in a byte that is designated as a primary pin for Multi-Purpose Register (MPR) reads. Valid values are 0 to 7 for DQ[0] to DQ[7], respectively
$00000080 constant DDRPHYC_DDRPHYC_DCR_MPRDQ                        \ MPR DQ Specifies the value that is driven on non-primary DQ pins during MPR reads. Valid values are:
$00000300 constant DDRPHYC_DDRPHYC_DCR_DDRTYPE                      \ DDR type (LPDDR2 S4) Selects the DDR type for the specified LPDDR mode. Valid values for LPDDR2 are: Others: Reserved
$08000000 constant DDRPHYC_DDRPHYC_DCR_NOSRA                        \ No simultaneous rank access Specifies if set that simultaneous rank access on the same clock cycle is not allowed. This means that multiple chip select signals should not be asserted at the same time. This may be required on some DIMM systems.
$10000000 constant DDRPHYC_DDRPHYC_DCR_DDR2T                        \ 2T timing Indicates if set that 2T timing should be used by PUB internally generated SDRAM transactions.
$20000000 constant DDRPHYC_DDRPHYC_DCR_UDIMM                        \ Unbuffered DIMM Indicates if set that there is address mirroring on the second rank of an un-buffered DIMM (the rank connected to CS#[1]). In this case, the PUBL re-scrambles the bank and address when sending mode register commands to the second rank. This only applies to PUBL internal SDRAM transactions. Transactions generated by the controller must make its own adjustments when using an un-buffered DIMM. DCR[NOSRA] must be set if address mirroring is enabled.
$40000000 constant DDRPHYC_DDRPHYC_DCR_RDIMM                        \ Registered DIMM Indicates if set that a registered DIMM is used. In this case, the PUBL increases the SDRAM write and read latencies (WL/RL) by 1. This only applies to PUBL internal SDRAM transactions. Transactions generated by the controller must make its own adjustments to WL/RL when using a registered DIMM
$80000000 constant DDRPHYC_DDRPHYC_DCR_TPD                          \ Test power down (N/A LPDDR only) If set it places the DRAM in deep power down mode.


\
\ @brief DDRPHYC DTP register 0
\ Address offset: 0x34
\ Reset value: 0x3092666E
\

$00000003 constant DDRPHYC_DDRPHYC_DTPR0_TMRD                       \ tMRD Load mode cycle time: The minimum time between a load mode register command and any other command. For DDR3 this is the minimum time between two load mode register commands. For DDR3, the value used for tMRD is 4 plus the value programmed in these bits, i.e. tMRD value for DDR3 ranges from 4 to 7. For LPDDR3, the value used for tMRD is 8 plus the value programmed in these bits.
$0000001c constant DDRPHYC_DDRPHYC_DTPR0_TRTP                       \ tRTP Internal read to precharge command delay. Valid values are 2 to 6. Note that even though RTP does not apply to JEDEC DDR devices, this parameter must still be set to a minimum value of 2 for DDR because the Controller always uses the DDR2 equation, AL + BL/2 + max(RTP,2) â 2, to compute the read to precharge timing (which is BL/2 for JEDEC DDR).
$000000e0 constant DDRPHYC_DDRPHYC_DTPR0_TWTR                       \ tWTR Internal write to read command delay. Valid values are 1 to 6.
$00000f00 constant DDRPHYC_DDRPHYC_DTPR0_TRP                        \ tRP Precharge command period: The minimum time between a precharge command and any other command. Note: Note that the controller automatically derives tRPA for 8-bank DDR2 devices by adding 1 to tRP. Valid values are 2 to 11.
$0000f000 constant DDRPHYC_DDRPHYC_DTPR0_TRCD                       \ tRCD Activate to read or write delay. Minimum time from when an activate command is issued to when a read or write to the activated row can be issued. Valid values are 2 to 11.
$001f0000 constant DDRPHYC_DDRPHYC_DTPR0_TRAS                       \ tRAS Activate to precharge command delay. Valid values are 2 to 31.
$01e00000 constant DDRPHYC_DDRPHYC_DTPR0_TRRD                       \ tRRD Activate to activate command delay (different banks). Valid values are 1 to 8.
$7e000000 constant DDRPHYC_DDRPHYC_DTPR0_TRC                        \ tRC Activate to activate command delay (same bank). Valid values are 2 to 42.
$80000000 constant DDRPHYC_DDRPHYC_DTPR0_TCCD                       \ tCCDRead to read and write to write command delay


\
\ @brief DDRPHYC DTP register 1
\ Address offset: 0x38
\ Reset value: 0x09830090
\

$00000003 constant DDRPHYC_DDRPHYC_DTPR1_TAOND                      \ tAOND/tAOFD ODT turn-on/turn-off delays (DDR2 only). The delays are in clock cycles. Valid values are: Most DDR2 devices utilize a fixed value of 2/2.5. For non-standard SDRAMs, the user must ensure that the operational Write Latency is always greater than or equal to the ODT turn-on delay. For example, a DDR2 SDRAM with CAS latency set to 3 and CAS additive latency set to 0 has a Write Latency of 2. Thus 2/2.5 can be used, but not 3/3.5 or higher.
$00000004 constant DDRPHYC_DDRPHYC_DTPR1_TRTW                       \ tRTW Read to Write command delay. Valid values are: This parameter allows the user to increase the delay between issuing Write commands to the SDRAM when preceded by Read commands. This provides an option to increase bus turn-around margin for high frequency systems.
$000001f8 constant DDRPHYC_DDRPHYC_DTPR1_TFAW                       \ tFAW 4-bank activate period. No more than 4-bank activate commands may be issued in a given tFAW period. Only applies to 8-bank devices. Valid values are 2 to 31.
$00000600 constant DDRPHYC_DDRPHYC_DTPR1_TMOD                       \ tMOD Load mode update delay (DDR3 only). The minimum time between a load mode register command and a non-load mode register command. Valid values are:
$00000800 constant DDRPHYC_DDRPHYC_DTPR1_TRTODT                     \ tRTODT Read to ODT delay (DDR3 only). Specifies whether ODT can be enabled immediately after the read post-amble or one clock delay has to be added. Valid values are: If tRTODT is set to 1, then the read-to-write latency is increased by 1 if ODT is enabled.
$00ff0000 constant DDRPHYC_DDRPHYC_DTPR1_TRFC                       \ tRFC Refresh-to-Refresh: Indicates the minimum time, in clock cycles, between two refresh commands or between a refresh and an active command. This is derived from the minimum refresh interval from the datasheet, tRFC(min), divided by the clock cycle time. The default number of clock cycles is for the largest JEDEC tRFC(min parameter value supported.
$07000000 constant DDRPHYC_DDRPHYC_DTPR1_TDQSCKMIN                  \ tDQSCKmin DQS output access time from CK/CK# (LPDDR2/3 only). This value is used for computing the read latency. Valid values are 0 to 7. This value is derived from the corresponding parameter in the SDRAM datasheet divided by the clock cycle time without rounding up. The fractional remainder is automatically adjusted for by data training in quarter clock cycle units. If data training is not performed then this fractional remainder must be converted to quarter clock cycle units and the gating registers (DXnDQSTR) adjusted accordingly.
$38000000 constant DDRPHYC_DDRPHYC_DTPR1_TDQSCKMAX                  \ tDQSCKmax Maximum DQS output access time from CK/CK# (LPDDR2 only). This value is used for implementing read-to-write spacing. Valid values are 1 to 7.


\
\ @brief DDRPHYC DTP register 2
\ Address offset: 0x3C
\ Reset value: 0x1001A0C8
\

$000003ff constant DDRPHYC_DDRPHYC_DTPR2_TXS                        \ tXS Self refresh exit delay. The minimum time between a self refresh exit command and any other command. This parameter must be set to the maximum of the various minimum self refresh exit delay parameters specified in the SDRAM datasheet, i.e. max(tXSNR, tXSRD) for DDR2 and max(tXS, tXSDLL) for DDR3. Valid values are 2 to 1023.
$00007c00 constant DDRPHYC_DDRPHYC_DTPR2_TXP                        \ tXP Power down exit delay. The minimum time between a power down exit command and any other command. This parameter must be set to the maximum of the various minimum power down exit delay parameters specified in the SDRAM datasheet, i.e. max(tXP, tXARD, tXARDS) for DDR2 and max(tXP, tXPDLL) for DDR3. Valid values are 2 to 31.
$00078000 constant DDRPHYC_DDRPHYC_DTPR2_TCKE                       \ tCKE CKE minimum pulse width. Also specifies the minimum time that the SDRAM must remain in power down or self refresh mode. For DDR3 this parameter must be set to the value of tCKESR which is usually bigger than the value of tCKE. Valid values are 2 to 15.
$1ff80000 constant DDRPHYC_DDRPHYC_DTPR2_TDLLK                      \ tDLLK DLL locking time. Valid values are 2 to 1023.


\
\ @brief DDRPHYC MR0 register for DDR3
\ Address offset: 0x40
\ Reset value: 0x00000A52
\

$00000003 constant DDRPHYC_DDRPHYC_DDR3_MR0_BL                      \ Burst length Determines the maximum number of column locations that can be accessed during a given read or write command. Valid values for DDR3 are:
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR0_CL0                     \ CAS latency The delay, in clock cycles, between when the SDRAM registers a read command to when data is available. Valid values for CL[3:0] are: Others: Reserved
$00000008 constant DDRPHYC_DDRPHYC_DDR3_MR0_BT                      \ Burst type Indicates whether a burst is sequential (0) or interleaved (1).
$00000070 constant DDRPHYC_DDRPHYC_DDR3_MR0_CL                      \ CAS latency The delay, in clock cycles, between when the SDRAM registers a read command to when data is available. Valid values for CL[3:0] are: Others: Reserved
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR0_TM                      \ Operating mode Selects either normal operating mode (0) or test mode (1). Test mode is reserved for the manufacturer and should not be used.
$00000100 constant DDRPHYC_DDRPHYC_DDR3_MR0_DR                      \ DLL reset (autoclear) Writing a '1â to this bit resets the SDRAM DLL. This bit is self clearing, i.e. it returns back to '0â after the DLL reset has been issued.
$00000e00 constant DDRPHYC_DDRPHYC_DDR3_MR0_WR                      \ Write recovery This is the value of the write recovery in clock cycles. It is calculated by dividing the data sheet write recovery time, tWR (ns) by the data sheet clock cycle time, tCK (ns) and rounding up a non-integer value to the next integer. Valid values are: All other settings are reserved and should not be used. Note: tWR (ns) is the time from the first SDRAM positive clock edge after the last data-in pair of a write command, to when a precharge of the same bank can be issued.
$00001000 constant DDRPHYC_DDRPHYC_DDR3_MR0_PD                      \ Power-down control Controls the exit time for power-down modes. Refer to SDRAM datasheet for details on power-down modes. Valid values are:
$0000e000 constant DDRPHYC_DDRPHYC_DDR3_MR0_RSVD                    \ JEDEC reserved.


\
\ @brief DDRPHYC MR1 register for DDR3
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DDR3_MR1_DE                      \ DLL enable/disable Enable (0) or disable (1) the DLL. DLL must be enabled for normal operation.
$00000002 constant DDRPHYC_DDRPHYC_DDR3_MR1_DIC0                    \ Output driver impedance control Controls the output drive strength. Valid values for {DIC1,DIC0} are:
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT0                    \ On die termination Selects the effective resistance for SDRAM on die termination. Valid values for {RTT2,RTT1,RTT0} are: Others: Reserved
$00000018 constant DDRPHYC_DDRPHYC_DDR3_MR1_AL                      \ Posted CAS Additive Latency: Setting additive latency that allows read and write commands to be issued to the SDRAM earlier than normal (refer to SDRAM datasheet for details). Valid values are:
$00000020 constant DDRPHYC_DDRPHYC_DDR3_MR1_DIC1                    \ Output driver impedance control Controls the output drive strength. Valid values for {DIC1,DIC0} are:
$00000040 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT1                    \ On die termination Selects the effective resistance for SDRAM on die termination. Valid values for {RTT2,RTT1,RTT0} are: Others: Reserved
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR1_LEVEL                   \ Write leveling enable (N/A)
$00000200 constant DDRPHYC_DDRPHYC_DDR3_MR1_RTT2                    \ On die termination Selects the effective resistance for SDRAM on die termination. Valid values for {RTT2,RTT1,RTT0} are: Others: Reserved
$00000800 constant DDRPHYC_DDRPHYC_DDR3_MR1_TDQS                    \ Termination data strobe When enabled ('1â) TDQS provides additional termination resistance outputs that may be useful in some system configurations. (N/A)
$00001000 constant DDRPHYC_DDRPHYC_DDR3_MR1_QOFF                    \ Output enable/disable This feature is intended to be used for IDD characterization of read current and should not be used in normal operation.


\
\ @brief DDRPHYC_LPDDR2_MR1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_LPDDR2_MR1_BL                    \ Burst length Determines the maximum number of column locations that can be accessed during a given read or write command. Valid values are: Others: Reserved
$00000008 constant DDRPHYC_DDRPHYC_LPDDR2_MR1_BT                    \ Burst Type: Indicates whether a burst is sequential (0) or interleaved (1). ,
$00000010 constant DDRPHYC_DDRPHYC_LPDDR2_MR1_WC                    \ Wrap control
$000000e0 constant DDRPHYC_DDRPHYC_LPDDR2_MR1_NWR                   \ Write recovery Others: Reserved


\
\ @brief DDRPHYC_LPDDR3_MR1
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_LPDDR3_MR1_BL                    \ Burst length Determines the maximum number of column locations that can be accessed during a given read or write command. Others: Reserved
$000000e0 constant DDRPHYC_DDRPHYC_LPDDR3_MR1_NWR                   \ Write recovery If nWRE (MR2 [4]) = 0: -001: nWR=3 -100: nWR=6 -110: nWR=8 -111: nWR=9 If nWRE (MR2[4]) = 1: -000: nWR=10 -001: nWR=11 -010: nWR=12 Others: Reserved


\
\ @brief DDRPHYC MR2 register for DDR3
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_DDR3_MR2_PASR                    \ Partial array self-refresh Specifies that data located in areas of the array beyond the specified location are lost if self refresh is entered. Valid settings for 8 banks are:
$00000038 constant DDRPHYC_DDRPHYC_DDR3_MR2_CWL                     \ CAS write latency The delay, in clock cycles, between when the SDRAM registers a write command to when write data is available. Others: Reserved
$00000040 constant DDRPHYC_DDRPHYC_DDR3_MR2_ASR                     \ Auto self-refresh When enabled ('1â), SDRAM automatically provides self-refresh power management functions for all supported operating temperature values. Otherwise the SRT bit must be programmed to indicate the temperature range.
$00000080 constant DDRPHYC_DDRPHYC_DDR3_MR2_SRT                     \ Self-refresh temperature range Selects either normal ('0â) or extended ('1â) operating temperature range during self-refresh.
$00000600 constant DDRPHYC_DDRPHYC_DDR3_MR2_RTTWR                   \ Dynamic ODT Selects RTT for dynamic ODT.


\
\ @brief DDRPHYC MR2 register for LPDDR2
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_LPDDR2_MR2_RLWL                  \ Read and write latency Others: Reserved


\
\ @brief DDRPHYC MR2 register for LPDDR3
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant DDRPHYC_DDRPHYC_LPDDR3_MR2_RLWL                  \ Read and write latency Others: Reserved
$00000010 constant DDRPHYC_DDRPHYC_LPDDR3_MR2_NWRE                  \ New for LPDDR3 (not used by this PHY, leave at zero)
$00000040 constant DDRPHYC_DDRPHYC_LPDDR3_MR2_WL                    \ New for LPDDR3 (not used by this PHY, leave at zero)
$00000080 constant DDRPHYC_DDRPHYC_LPDDR3_MR2_WR                    \ New for LPDDR3 (not used by this PHY, leave at zero)


\
\ @brief DDRPHYC MR3 register for DDR3
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000003 constant DDRPHYC_DDRPHYC_DDR3_MR3_MPRLOC                  \ Multi-purpose register (MPR) location Selects MPR data location. Others: Reserved
$00000004 constant DDRPHYC_DDRPHYC_DDR3_MR3_MPR                     \ Multi-purpose register enable Enables, if set, that read data should come from the Multi-Purpose Register. Otherwise read data come from the DRAM array.


\
\ @brief DDRPHYC ODTC register
\ Address offset: 0x50
\ Reset value: 0x00010000
\

$00000001 constant DDRPHYC_DDRPHYC_ODTCR_RDODT                      \ Specifies whether ODT should be enabled ('1â) or disabled ('0â) on read
$00010000 constant DDRPHYC_DDRPHYC_ODTCR_WRODT                      \ Specifies whether ODT should be enabled ('1â) or disabled ('0â) on write


\
\ @brief DDRPHYC DTA register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000fff constant DDRPHYC_DDRPHYC_DTAR_DTCOL                       \ Data training column address: Selects the SDRAM column address to be used during data training. The lower four bits of this address must always be â0000â.
$0ffff000 constant DDRPHYC_DDRPHYC_DTAR_DTROW                       \ Data training row address: Selects the SDRAM row address to be used during data training.
$70000000 constant DDRPHYC_DDRPHYC_DTAR_DTBANK                      \ Data training bank address: Selects the SDRAM bank address to be used during data training.
$80000000 constant DDRPHYC_DDRPHYC_DTAR_DTMPR                       \ Data training using MPR (DDR3 Only): Specifies, if set, that data-training should use the SDRAM Multi-Purpose Register (MPR) register. Otherwise data-training is performed by first writing to some locations in the SDRAM and then reading the back.


\
\ @brief DDRPHYC DTD register 0
\ Address offset: 0x58
\ Reset value: 0xDD22EE11
\

$000000ff constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE0                    \ Data Training Data
$0000ff00 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE1                    \ Data Training Data
$00ff0000 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE2                    \ Data Training Data
$ff000000 constant DDRPHYC_DDRPHYC_DTDR0_DTBYTE3                    \ Data training data The first 4 bytes (e.g. shifted as Byte 0,1,2,3) of data used during data training. This same data byte is used for each Byte Lane. Default sequence is a walking 1 while toggling data every data cycle.


\
\ @brief DDRPHYC DTD register 1
\ Address offset: 0x5C
\ Reset value: 0x7788BB44
\

$000000ff constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE4                    \ Data Training Data
$0000ff00 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE5                    \ Data Training Data
$00ff0000 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE6                    \ Data Training Data
$ff000000 constant DDRPHYC_DDRPHYC_DTDR1_DTBYTE7                    \ Data training data: The second 4 bytes (e.g. shifted as Byte 4,5,6,7) of data used during data training. This same data byte is used for each Byte Lane. Default sequence is a walking 1 while toggling data every data cycle.


\
\ @brief DDRPHYC general purpose register 0
\ Address offset: 0x178
\ Reset value: 0x00000000
\

$00000000 constant DDRPHYC_DDRPHYC_GPR0_GPR0                        \ General purpose register 0 bits


\
\ @brief DDRPHYC general purpose register 1
\ Address offset: 0x17C
\ Reset value: 0x00000000
\

$00000000 constant DDRPHYC_DDRPHYC_GPR1_GPR1                        \ General purpose register 1 bits


\
\ @brief DDRPHYC ZQ0C register 0
\ Address offset: 0x180
\ Reset value: 0x0000014A
\

$000fffff constant DDRPHYC_DDRPHYC_ZQ0CR0_ZDATA                     \ Impedance override Impedance Over-Ride Data: Data used to directly drive the impedance control. ZDATA field mapping for D3R I/Os is as follows: ZDATA[27:20] is reserved and returns zeros on reads ZDATA[19:15] is used to select the pull-up on-die termination impedance ZDATA[14:10] is used to select the pull-down on-die termination impedance ZDATA[9:5] is used to select the pull-up output impedance ZDATA[4:0] is used to select the pull-down output impedance Note: See mPHY ST40c25 Datasheet for ZDATA encoding, default value is: ODT pulp-up/down set to hi-impedance and pull-up/down set to ~44.5Â â¦ for DDR3, 48.8Â â¦ for DDR3L, 55.5Â â¦ for LPDDR2 typical corner 25C
$10000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZDEN                      \ Impedance override enable Impedance Over-ride Enable: When this bit is set, it allows users to directly drive the impedance control using the data programmed in the ZQDATA field. Otherwise, the control is generated automatically by the impedance control logic. Note: If ZDEN is set, then the ZCAL bit should be set to 0.
$20000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZCALBYP                   \ Impedance calibration bypass Impedance Calibration Bypass: Disables, if set, impedance calibration of this ZQ control block when impedance calibration is triggered globally using the ZCAL bit of DDRPHYC_PIR. Impedance calibration of this ZQ block may be triggered manually using ZCAL.
$40000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZCAL                      \ ZCAL trigger Impedance Calibration Trigger: A write of '1' to this bit triggers impedance calibration to be performed by the impedance control logic. The impedance calibration trigger bit is self-clearing and returns back to '0' when the calibration is complete. Note: If ZDEN is set, then the ZCAL bit should be set to 0.
$80000000 constant DDRPHYC_DDRPHYC_ZQ0CR0_ZQPD                      \ ZCAL power down Powers down, if set, the PZQ cell.


\
\ @brief DDRPHYC ZQ0CR1 register
\ Address offset: 0x184
\ Reset value: 0x0000007B
\

$000000ff constant DDRPHYC_DDRPHYC_ZQ0CR1_ZPROG                     \ Impedance divide ratio to ext R Impedance divide ratio: selects the external resistor divide ratio to be used to set the output impedance and the on-die termination as follows: nullÂ Î© Â±1%) - 0x0: Reserved - 0x1: 120Â Î© - 0x2: 96Â Î© - 0x3: 80Â Î© - 0x4: 69Â Î© - 0x5: 60Â Î© - 0x6: 52Î© - 0x7: 46Â Î© - 0x8: 40Â Î© - 0x9: 37Â Î© - 0xA: 34Â Î© - 0xB: 32Â Î© - 0xC: 30Â Î© - 0xD: 28Â Î© - 0xE: 26.5Â Î© - 0xF: 25Â Î© nullImpedance divide ratio to ext R Impedance divide ratio: selects the external resistor divide ratio to be used to set the output impedance and the on-die termination as follows: nullÂ Î© Â±1%) - 0x0 to 0x4: Reserved - 0x5: 80Â Î© - 0x6: 69Â Î© - 0x7: 60Â Î© - 0x8: 53Â Î© - 0x9: 48Â Î© - 0xA: 44Â Î© - 0xB: 40Â Î© - 0xC: 37Â Î© - 0xD: 34Â Î© - 0xE: 32Â Î© - 0xF: 30Â Î©


\
\ @brief DDRPHYC ZQ0S register 0
\ Address offset: 0x188
\ Reset value: 0x0000014A
\

$000fffff constant DDRPHYC_DDRPHYC_ZQ0SR0_ZCTRL                     \ Impedance control Impedance Control: Current value of impedance control. ZZCTRL field mapping for D3R I/Os is as follows: ZCTRL[27:20] is reserved and returns zeros on reads ZCTRL[19:15] is used to select the pull-up on-die termination impedance ZCTRL[14:10] is used to select the pull-down on-die termination impedance ZCTRL[9:5] is used to select the pull-up output impedance ZCTRL[4:0] is used to select the pull-down output impedance
$40000000 constant DDRPHYC_DDRPHYC_ZQ0SR0_ZERR                      \ Impedance calibration error If set, indicates that there was an error during impedance calibration.
$80000000 constant DDRPHYC_DDRPHYC_ZQ0SR0_ZDONE                     \ Impedance calibration done Indicates that impedance calibration has completed.


\
\ @brief DDRPHYC ZQ0S register 1
\ Address offset: 0x18C
\ Reset value: 0x00000000
\

$00000003 constant DDRPHYC_DDRPHYC_ZQ0SR1_ZPD                       \ zpd calibration status Output impedance pull-down calibration status. Valid status encodings are:
$0000000c constant DDRPHYC_DDRPHYC_ZQ0SR1_ZPU                       \ zpu calibration status Output impedance pull-up calibration status. Valid status encodings are:
$00000030 constant DDRPHYC_DDRPHYC_ZQ0SR1_OPD                       \ opd calibration status On-Die termination (ODT) pull-down calibration status.
$000000c0 constant DDRPHYC_DDRPHYC_ZQ0SR1_OPU                       \ opu calibration status On-Die termination (ODT) pull-up calibration status.


\
\ @brief DDRPHYC byte lane 0 GC register
\ Address offset: 0x1C0
\ Reset value: 0x00010E81
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GCR_DXEN                      \ DATA byte enable Enables, if set, the DATX8 and SSTL I/Os used on the data byte. Setting this bit to '0â disables the byte, i.e. the byte SSTL I/Os are put in power-down mode and the DLL in the DATX8 is put in bypass mode. After changing a Byte Lane from disabled to enabled, the DLL for that Byte Lane must be reset and re-locked. Software can use bits DLLSRST and DLLLOCK of DDRPHYC_PIR register to accomplish this (reset and re-locks all DLLs in the DDR PHY).
$00000002 constant DDRPHYC_DDRPHYC_DX0GCR_DQSODT                    \ DQS ODT enable Enables, when set, the on-die termination on the I/O for DQS/DQS# pin of the byte. This bit is ORed with the common DATX8 ODT configuration bit
$00000004 constant DDRPHYC_DDRPHYC_DX0GCR_DQODT                     \ DQ ODT enable Enables, when set, the on-die termination on the I/O for DQ and DM pins of the byte. This bit is ORed with the common DATX8 ODT configuration bit
$00000008 constant DDRPHYC_DDRPHYC_DX0GCR_DXIOM                     \ Data I/O mode Selects SSTL mode (when set to 0) or CMOS mode (when set to 1) for the I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the IOM configuration bit of the individual DATX8
$00000010 constant DDRPHYC_DDRPHYC_DX0GCR_DXPDD                     \ Data power-down driver Powers down, when set, the output driver on I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the common PDD configuration bit
$00000020 constant DDRPHYC_DDRPHYC_DX0GCR_DXPDR                     \ Data power-down receiver Powers down, when set, the input receiver on I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the common PDR configuration bit
$00000040 constant DDRPHYC_DDRPHYC_DX0GCR_DQSRPD                    \ DQSR power-down Powers down, if set, the PDQSR cell. This bit is ORed with the common PDR configuration bit
$00000180 constant DDRPHYC_DDRPHYC_DX0GCR_DSEN                      \ Write DQS enable Controls whether the write DQS going to the SDRAM is enabled (toggling) or disabled (static value) and whether the DQS is inverted. DQS# is always the inversion of DQS. These values are valid only when DQS/DQS# output enable is on, otherwise the DQS/DQS# is tristated. Valid settings are:
$00000200 constant DDRPHYC_DDRPHYC_DX0GCR_DQSRTT                    \ DQS dynamic RTT control Indicates, if set, that the ODT control of DQS SSTL I/Os be dynamically controlled by setting it to the value in DQSODT during reads and disabling it (setting it to '0â) during any other cycle. If this bit is not set, then the ODT control of DQS SSTL I/Os is always set to the value in DQSODT field. Since dynamic ODT is on by default, when using LPDDR2/LPDDR3 this bit must be set to 0 since LPDDR2/LPDDR3 does not require ODT to be on.
$00000400 constant DDRPHYC_DDRPHYC_DX0GCR_DQRTT                     \ DQ dynamic RTT control Indicates, if set, that the ODT control of DQ/DM SSTL I/Os be dynamically controlled by setting it to the value in DQODT during reads and disabling it (setting it to '0â) during any other cycle. If this bit is not set, then the ODT control of DQ SSTL I/Os is always set to the value in DQODT. Since dynamic ODT is on by default, when using LPDDR2/LPDDR3 this bit must be set to 0 since LPDDR2/LPDDR3 does not require ODT to be on.`
$00001800 constant DDRPHYC_DDRPHYC_DX0GCR_RTTOH                     \ RTT output hold Indicates the number of clock cycles (from 0 to 3) after the read data postamble for which ODT control should remain set to DQSODT for DQS or DQODT for DQ/DM before disabling it (setting it to '0â) when using dynamic ODT control. ODT is disabled almost RTTOH clock cycles after the read postamble
$00002000 constant DDRPHYC_DDRPHYC_DX0GCR_RTTOAL                    \ RTT ON additive latency Indicates when the ODT control of DQ/DQS SSTL I/Os is set to the value in DQODT/DQSODT during read cycles. Valid values are:
$0001c000 constant DDRPHYC_DDRPHYC_DX0GCR_R0RVSL                    \ Read valid system latency in steps Used to specify the read valid system latency relative to the ideal placement of the ITMD read valid signal when bit RVSEL in DDRPHYC_DXCCR register is set to 0. Power-up default is 011 (i.e. ideal placement of the read valid signal). The RVSL fields are initially set by the PUB during automatic read valid training but these values can be overwritten by a direct write to this register. Valid values are: Others: Reserved


\
\ @brief DDRPHYC byte lane 0 GS register 0
\ Address offset: 0x1C4
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GSR0_DTDONE                   \ Data training done Indicates, if set, that the byte has finished doing data training.
$00000010 constant DDRPHYC_DDRPHYC_DX0GSR0_DTERR                    \ DQS gate training error If set, indicates that a valid DQS gating window could not be found during DQS gate training of the byte.
$00000100 constant DDRPHYC_DDRPHYC_DX0GSR0_DTIERR                   \ DQS gate training intermittent error If set, indicates that there was an intermittent error during DQS gate training of the byte, such as a pass was followed by a fail then followed by another pass.
$0000e000 constant DDRPHYC_DDRPHYC_DX0GSR0_DTPASS                   \ DQS training pass count The number of passing configurations during DQS gate training.


\
\ @brief DDRPHYC byte lane 0 GS register 1
\ Address offset: 0x1C8
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX0GSR1_DFTERR                   \ DQS drift error If set, indicates that the byte read data strobe has drifted by more than or equal to the drift limit set in the PHY General Configuration Register (PGCR).
$00000030 constant DDRPHYC_DDRPHYC_DX0GSR1_DQSDFT                   \ DQS drift value Used to report the drift on the read data strobe of the data byte. Valid settings are:
$00001000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVERR                    \ RV training error If set, indicates that a valid read valid placement could not be found during read valid training of the byte
$00010000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVIERR                   \ RV intermittent error for rank If set, indicates that there was an intermittent error during read valid training of the byte, such as a pass was followed by a fail then followed by another pass.
$00700000 constant DDRPHYC_DDRPHYC_DX0GSR1_RVPASS                   \ Read valid training pass count The number of passing configurations during read valid training.


\
\ @brief DDRPHYC byte lane 0 DLLC register
\ Address offset: 0x1CC
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX0DLLCR_SFBDLY                  \ Slave DLL feed-back trim Slave Feed-Back Delay Trim: Used to trim the delay in the slave DLL feedback path: ...
$00000038 constant DDRPHYC_DDRPHYC_DX0DLLCR_SFWDLY                  \ Slave DLL feed-forward trim Slave Feed-Forward Delay Trim: Used to trim the delay in the slave DLL feedforward path: ...
$000001c0 constant DDRPHYC_DDRPHYC_DX0DLLCR_MFBDLY                  \ Master DLL feed-back trim Used to trim the delay in the master DLL feedback path: ...
$00000e00 constant DDRPHYC_DDRPHYC_DX0DLLCR_MFWDLY                  \ Master DLL feed-forward trim Used to trim the delay in the master DLL feedforward path: ...
$00003000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SSTART                  \ Slave DLL autostart Used to control how the slave DLL starts up relative to the master DLL locking: 0X: Slave DLL automatically starts up once the master DLL has achieved lock. disabled. enabled.
$0003c000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SDPHASE                 \ Slave DLL phase Selects the phase difference between the input clock and the corresponding output clock of the slave DLL. Valid settings:
$00040000 constant DDRPHYC_DDRPHYC_DX0DLLCR_ATESTEN                 \ Enable path to pin 'ATO' Enables the analog test signal to be output on the DLL analog test output (test_out_a). The DLL analog test output is tri-stated when this bit is '0'.
$00080000 constant DDRPHYC_DDRPHYC_DX0DLLCR_SDLBMODE                \ Bypass slave DLL during loopback If this bit is set, the slave DLL is put in loopback mode in which there is no 90 degrees phase shift on read DQS/DQS#. This bit must be set when operating the byte PHYs in loopback mode.
$40000000 constant DDRPHYC_DDRPHYC_DX0DLLCR_DLLSRST                 \ DLL reset Soft resets the byte DLL by driving the DLL soft reset pin
$80000000 constant DDRPHYC_DDRPHYC_DX0DLLCR_DLLDIS                  \ DLL bypass A disabled DLL is bypassed. Default ('0') is DLL enabled


\
\ @brief DDRPHYC byte lane 0 DQT register
\ Address offset: 0x1D0
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY0                   \ DQ delay for bit 0 Idem
$000000f0 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY1                   \ DQ delay for bit 1 Idem
$00000f00 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY2                   \ DQ delay for bit 2 Idem
$0000f000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY3                   \ DQ delay for bit 3 Idem
$000f0000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY4                   \ DQ delay for bit 4 Idem
$00f00000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY5                   \ DQ delay for bit 5 Idem
$0f000000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY6                   \ DQ delay for bit 6 idem
$f0000000 constant DDRPHYC_DDRPHYC_DX0DQTR_DQDLY7                   \ DQ delay for bit 7 Used to adjust the delay of the data relative to the nominal delay that is matched to the delay of the data strobes through the slave DLL and clock tree. The lower two bits of the DQDLY for each DQ bit controls the delay for the data clocked by DQS, while the higher two bits control the delay for the data clocked by DQS_b. Valid settings for each 2-bit control field are:


\
\ @brief DDRPHYC byte lane 0 DQST register
\ Address offset: 0x1D4
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX0DQSTR_R0DGSL                  \ Rank 0 DQS gating system latency Used to increase the number of clock cycles needed to expect valid DDR read data by up to five extra clock cycles. This is used to compensate for board delays and other system delays. Power-up default is 000 (i.e. no extra clock cycles required). The SL fields are initially set by the PUBL during automatic DQS data training but these values can be overwritten by a direct write to this register. Valid values are: Others: Reserved
$00003000 constant DDRPHYC_DDRPHYC_DX0DQSTR_R0DGPS                  \ Rank 0 DQS gating phase select Selects the clock used to enable the data strobes during read so that the value of the data strobes before and after the preamble/postamble are filtered out. R0DGPS is initially set by the PUBL during automatic DQS data training and subsequently updated during data strobe drift compensation. However, these values can be overwritten by a direct write to this register, and the automatic update during DQS drift compensation can be disabled using the PHY General Configuration Register (PGCR). Valid values are:
$00700000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DQSDLY                  \ DQS delay Used to adjust the delay of the data strobes relative to the nominal delay that is matched to the delay of the data bit through the slave DLL and clock tree. Valid values are: Note: - After changing this value, an ITM soft reset (bit ITMSRST=1 and bit INIT=1 in DDRPHYC_PIR register) must be issued.
$03800000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DQSNDLY                 \ DQS# delay Used to adjust the delay of the data strobes relative to the nominal delay that is matched to the delay of the data bit through the slave DLL and clock tree. Valid values are: Note: - After changing this value, an ITM soft reset must be issued: bit ITMSRST=1 and bit INIT=1 in DDRPHYC_PIR register.
$3c000000 constant DDRPHYC_DDRPHYC_DX0DQSTR_DMDLY                   \ DM delay Used to adjust the delay of the data relative to the nominal delay that is matched to the delay of the data strobes through the slave DLL and clock tree. The lower two bits of the DQDLY for each DQ bit controls the delay for the data clocked by DQS, while the higher two bits control the delay for the data clocked by DQS_b. Valid settings for each 2-bit control field are:


\
\ @brief DDRPHYC byte lane 1 GC register
\ Address offset: 0x200
\ Reset value: 0x00010E81
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GCR_DXEN                      \ DATA byte enable Enables, if set, the DATX8 and SSTL I/Os used on the data byte. Setting this bit to '0â disables the byte, i.e. the byte SSTL I/Os are put in power-down mode and the DLL in the DATX8 is put in bypass mode. After changing a Byte Lane from disabled to enabled, the DLL for that Byte Lane must be reset and re-locked. Software can use bits DLLSRST and DLLLOCK of DDRPHYC_PIR register to accomplish this (reset and re-locks all DLLs in the DDR PHY).
$00000002 constant DDRPHYC_DDRPHYC_DX1GCR_DQSODT                    \ DQS ODT enable Enables, when set, the on-die termination on the I/O for DQS/DQS# pin of the byte. This bit is ORed with the common DATX8 ODT configuration bit
$00000004 constant DDRPHYC_DDRPHYC_DX1GCR_DQODT                     \ DQ ODT enable Enables, when set, the on-die termination on the I/O for DQ and DM pins of the byte. This bit is ORed with the common DATX8 ODT configuration bit
$00000008 constant DDRPHYC_DDRPHYC_DX1GCR_DXIOM                     \ Data I/O mode Selects SSTL mode (when set to 0) or CMOS mode (when set to 1) for the I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the IOM configuration bit of the individual DATX8
$00000010 constant DDRPHYC_DDRPHYC_DX1GCR_DXPDD                     \ Data power-down driver Powers down, when set, the output driver on I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the common PDD configuration bit
$00000020 constant DDRPHYC_DDRPHYC_DX1GCR_DXPDR                     \ Data power-down receiver Powers down, when set, the input receiver on I/O for DQ, DM, and DQS/DQS# pins of the byte. This bit is ORed with the common PDR configuration bit
$00000040 constant DDRPHYC_DDRPHYC_DX1GCR_DQSRPD                    \ DQSR power-down Powers down, if set, the PDQSR cell. This bit is ORed with the common PDR configuration bit
$00000180 constant DDRPHYC_DDRPHYC_DX1GCR_DSEN                      \ Write DQS enable Controls whether the write DQS going to the SDRAM is enabled (toggling) or disabled (static value) and whether the DQS is inverted. DQS# is always the inversion of DQS. These values are valid only when DQS/DQS# output enable is on, otherwise the DQS/DQS# is tristated. Valid settings are:
$00000200 constant DDRPHYC_DDRPHYC_DX1GCR_DQSRTT                    \ DQS dynamic RTT control Indicates, if set, that the ODT control of DQS SSTL I/Os be dynamically controlled by setting it to the value in DQSODT during reads and disabling it (setting it to '0â) during any other cycle. If this bit is not set, then the ODT control of DQS SSTL I/Os is always set to the value in DQSODT field. Since dynamic ODT is on by default, when using LPDDR2/LPDDR3 this bit must be set to 0 since LPDDR2/LPDDR3 does not require ODT to be on.
$00000400 constant DDRPHYC_DDRPHYC_DX1GCR_DQRTT                     \ DQ dynamic RTT control Indicates, if set, that the ODT control of DQ/DM SSTL I/Os be dynamically controlled by setting it to the value in DQODT during reads and disabling it (setting it to '0â) during any other cycle. If this bit is not set, then the ODT control of DQ SSTL I/Os is always set to the value in DQODT. Since dynamic ODT is on by default, when using LPDDR2/LPDDR3 this bit must be set to 0 since LPDDR2/LPDDR3 does not require ODT to be on.`
$00001800 constant DDRPHYC_DDRPHYC_DX1GCR_RTTOH                     \ RTT output hold Indicates the number of clock cycles (from 0 to 3) after the read data postamble for which ODT control should remain set to DQSODT for DQS or DQODT for DQ/DM before disabling it (setting it to '0â) when using dynamic ODT control. ODT is disabled almost RTTOH clock cycles after the read postamble
$00002000 constant DDRPHYC_DDRPHYC_DX1GCR_RTTOAL                    \ RTT ON additive latency Indicates when the ODT control of DQ/DQS SSTL I/Os is set to the value in DQODT/DQSODT during read cycles. Valid values are:
$0001c000 constant DDRPHYC_DDRPHYC_DX1GCR_R0RVSL                    \ Read valid system latency in steps Used to specify the read valid system latency relative to the ideal placement of the ITMD read valid signal when bit RVSEL in DDRPHYC_DXCCR register is set to 0. Power-up default is 011 (i.e. ideal placement of the read valid signal). The RVSL fields are initially set by the PUB during automatic read valid training but these values can be overwritten by a direct write to this register. Valid values are: Others: Reserved


\
\ @brief DDRPHYC byte lane 1 GS register 0
\ Address offset: 0x204
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GSR0_DTDONE                   \ Data training done Indicates, if set, that the byte has finished doing data training.
$00000010 constant DDRPHYC_DDRPHYC_DX1GSR0_DTERR                    \ DQS gate training error If set, indicates that a valid DQS gating window could not be found during DQS gate training of the byte.
$00000100 constant DDRPHYC_DDRPHYC_DX1GSR0_DTIERR                   \ DQS gate training intermittent error If set, indicates that there was an intermittent error during DQS gate training of the byte, such as a pass was followed by a fail then followed by another pass.
$0000e000 constant DDRPHYC_DDRPHYC_DX1GSR0_DTPASS                   \ DQS training pass count The number of passing configurations during DQS gate training.


\
\ @brief DDRPHYC byte lane 1 GS register 1
\ Address offset: 0x208
\ Reset value: 0x00000000
\

$00000001 constant DDRPHYC_DDRPHYC_DX1GSR1_DFTERR                   \ DQS drift error If set, indicates that the byte read data strobe has drifted by more than or equal to the drift limit set in the PHY General Configuration Register (PGCR).
$00000030 constant DDRPHYC_DDRPHYC_DX1GSR1_DQSDFT                   \ DQS drift value Used to report the drift on the read data strobe of the data byte. Valid settings are:
$00001000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVERR                    \ RV training error If set, indicates that a valid read valid placement could not be found during read valid training of the byte
$00010000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVIERR                   \ RV intermittent error for rank If set, indicates that there was an intermittent error during read valid training of the byte, such as a pass was followed by a fail then followed by another pass.
$00700000 constant DDRPHYC_DDRPHYC_DX1GSR1_RVPASS                   \ Read valid training pass count The number of passing configurations during read valid training.


\
\ @brief DDRPHYC byte lane 1 DLLC register
\ Address offset: 0x20C
\ Reset value: 0x40000000
\

$00000007 constant DDRPHYC_DDRPHYC_DX1DLLCR_SFBDLY                  \ Slave DLL feed-back trim Slave Feed-Back Delay Trim: Used to trim the delay in the slave DLL feedback path: ...
$00000038 constant DDRPHYC_DDRPHYC_DX1DLLCR_SFWDLY                  \ Slave DLL feed-forward trim Slave Feed-Forward Delay Trim: Used to trim the delay in the slave DLL feedforward path: ...
$000001c0 constant DDRPHYC_DDRPHYC_DX1DLLCR_MFBDLY                  \ Master DLL feed-back trim Used to trim the delay in the master DLL feedback path: ...
$00000e00 constant DDRPHYC_DDRPHYC_DX1DLLCR_MFWDLY                  \ Master DLL feed-forward trim Used to trim the delay in the master DLL feedforward path: ...
$00003000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SSTART                  \ Slave DLL autostart Used to control how the slave DLL starts up relative to the master DLL locking: 0X: Slave DLL automatically starts up once the master DLL has achieved lock. disabled. enabled.
$0003c000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SDPHASE                 \ Slave DLL phase Selects the phase difference between the input clock and the corresponding output clock of the slave DLL. Valid settings:
$00040000 constant DDRPHYC_DDRPHYC_DX1DLLCR_ATESTEN                 \ Enable path to pin 'ATO' Enables the analog test signal to be output on the DLL analog test output (test_out_a). The DLL analog test output is tri-stated when this bit is '0'.
$00080000 constant DDRPHYC_DDRPHYC_DX1DLLCR_SDLBMODE                \ Bypass slave DLL during loopback If this bit is set, the slave DLL is put in loopback mode in which there is no 90 degrees phase shift on read DQS/DQS#. This bit must be set when operating the byte PHYs in loopback mode.
$40000000 constant DDRPHYC_DDRPHYC_DX1DLLCR_DLLSRST                 \ DLL reset Soft resets the byte DLL by driving the DLL soft reset pin
$80000000 constant DDRPHYC_DDRPHYC_DX1DLLCR_DLLDIS                  \ DLL bypass A disabled DLL is bypassed. Default ('0') is DLL enabled


\
\ @brief DDRPHYC byte lane 1 DQT register
\ Address offset: 0x210
\ Reset value: 0xFFFFFFFF
\

$0000000f constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY0                   \ DQ delay for bit 0 Idem
$000000f0 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY1                   \ DQ delay for bit 1 Idem
$00000f00 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY2                   \ DQ delay for bit 2 Idem
$0000f000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY3                   \ DQ delay for bit 3 Idem
$000f0000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY4                   \ DQ delay for bit 4 Idem
$00f00000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY5                   \ DQ delay for bit 5 Idem
$0f000000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY6                   \ DQ delay for bit 6 idem
$f0000000 constant DDRPHYC_DDRPHYC_DX1DQTR_DQDLY7                   \ DQ delay for bit 7 Used to adjust the delay of the data relative to the nominal delay that is matched to the delay of the data strobes through the slave DLL and clock tree. The lower two bits of the DQDLY for each DQ bit controls the delay for the data clocked by DQS, while the higher two bits control the delay for the data clocked by DQS_b. Valid settings for each 2-bit control field are:


\
\ @brief DDRPHYC byte lane 1 DQST register
\ Address offset: 0x214
\ Reset value: 0x3DB02000
\

$00000007 constant DDRPHYC_DDRPHYC_DX1DQSTR_R0DGSL                  \ Rank 0 DQS gating system latency Used to increase the number of clock cycles needed to expect valid DDR read data by up to five extra clock cycles. This is used to compensate for board delays and other system delays. Power-up default is 000 (i.e. no extra clock cycles required). The SL fields are initially set by the PUBL during automatic DQS data training but these values can be overwritten by a direct write to this register. Valid values are: Others: Reserved
$00003000 constant DDRPHYC_DDRPHYC_DX1DQSTR_R0DGPS                  \ Rank 0 DQS gating phase select Selects the clock used to enable the data strobes during read so that the value of the data strobes before and after the preamble/postamble are filtered out. R0DGPS is initially set by the PUBL during automatic DQS data training and subsequently updated during data strobe drift compensation. However, these values can be overwritten by a direct write to this register, and the automatic update during DQS drift compensation can be disabled using the PHY General Configuration Register (PGCR). Valid values are:
$00700000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DQSDLY                  \ DQS delay Used to adjust the delay of the data strobes relative to the nominal delay that is matched to the delay of the data bit through the slave DLL and clock tree. Valid values are: Note: - After changing this value, an ITM soft reset (bit ITMSRST=1 and bit INIT=1 in DDRPHYC_PIR register) must be issued.
$03800000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DQSNDLY                 \ DQS# delay Used to adjust the delay of the data strobes relative to the nominal delay that is matched to the delay of the data bit through the slave DLL and clock tree. Valid values are: Note: - After changing this value, an ITM soft reset must be issued: bit ITMSRST=1 and bit INIT=1 in DDRPHYC_PIR register.
$3c000000 constant DDRPHYC_DDRPHYC_DX1DQSTR_DMDLY                   \ DM delay Used to adjust the delay of the data relative to the nominal delay that is matched to the delay of the data strobes through the slave DLL and clock tree. The lower two bits of the DQDLY for each DQ bit controls the delay for the data clocked by DQS, while the higher two bits control the delay for the data clocked by DQS_b. Valid settings for each 2-bit control field are:


\
\ @brief DDRPHYC
\
$5a004000 constant DDRPHYC_DDRPHYC_RIDR  \ offset: 0x00 : DDRPHYC revision ID register
$5a004004 constant DDRPHYC_DDRPHYC_PIR  \ offset: 0x04 : DDRPHYC PHY initialization register
$5a004008 constant DDRPHYC_DDRPHYC_PGCR  \ offset: 0x08 : DDRPHYC PHY global control register
$5a00400c constant DDRPHYC_DDRPHYC_PGSR  \ offset: 0x0C : DDRPHYC PHY global status register
$5a004010 constant DDRPHYC_DDRPHYC_DLLGCR  \ offset: 0x10 : DDRPHYC DDR DLL global control register
$5a004014 constant DDRPHYC_DDRPHYC_ACDLLCR  \ offset: 0x14 : DDRPHYC AC DLL control register
$5a004018 constant DDRPHYC_DDRPHYC_PTR0  \ offset: 0x18 : DDRPHYC PT register 0
$5a00401c constant DDRPHYC_DDRPHYC_PTR1  \ offset: 0x1C : DDRPHYC PT register 1
$5a004020 constant DDRPHYC_DDRPHYC_PTR2  \ offset: 0x20 : DDRPHYC PT register 2
$5a004024 constant DDRPHYC_DDRPHYC_ACIOCR  \ offset: 0x24 : DDRPHYC ACIOC register
$5a004028 constant DDRPHYC_DDRPHYC_DXCCR  \ offset: 0x28 : DDRPHYC DXCC register
$5a00402c constant DDRPHYC_DDRPHYC_DSGCR  \ offset: 0x2C : DDRPHYC DSGC register
$5a004030 constant DDRPHYC_DDRPHYC_DCR  \ offset: 0x30 : DDRPHYC DC register
$5a004034 constant DDRPHYC_DDRPHYC_DTPR0  \ offset: 0x34 : DDRPHYC DTP register 0
$5a004038 constant DDRPHYC_DDRPHYC_DTPR1  \ offset: 0x38 : DDRPHYC DTP register 1
$5a00403c constant DDRPHYC_DDRPHYC_DTPR2  \ offset: 0x3C : DDRPHYC DTP register 2
$5a004040 constant DDRPHYC_DDRPHYC_DDR3_MR0  \ offset: 0x40 : DDRPHYC MR0 register for DDR3
$5a004044 constant DDRPHYC_DDRPHYC_DDR3_MR1  \ offset: 0x44 : DDRPHYC MR1 register for DDR3
$5a004044 constant DDRPHYC_DDRPHYC_LPDDR2_MR1  \ offset: 0x44 : DDRPHYC_LPDDR2_MR1
$5a004044 constant DDRPHYC_DDRPHYC_LPDDR3_MR1  \ offset: 0x44 : DDRPHYC_LPDDR3_MR1
$5a004048 constant DDRPHYC_DDRPHYC_DDR3_MR2  \ offset: 0x48 : DDRPHYC MR2 register for DDR3
$5a004048 constant DDRPHYC_DDRPHYC_LPDDR2_MR2  \ offset: 0x48 : DDRPHYC MR2 register for LPDDR2
$5a004048 constant DDRPHYC_DDRPHYC_LPDDR3_MR2  \ offset: 0x48 : DDRPHYC MR2 register for LPDDR3
$5a00404c constant DDRPHYC_DDRPHYC_DDR3_MR3  \ offset: 0x4C : DDRPHYC MR3 register for DDR3
$5a004050 constant DDRPHYC_DDRPHYC_ODTCR  \ offset: 0x50 : DDRPHYC ODTC register
$5a004054 constant DDRPHYC_DDRPHYC_DTAR  \ offset: 0x54 : DDRPHYC DTA register
$5a004058 constant DDRPHYC_DDRPHYC_DTDR0  \ offset: 0x58 : DDRPHYC DTD register 0
$5a00405c constant DDRPHYC_DDRPHYC_DTDR1  \ offset: 0x5C : DDRPHYC DTD register 1
$5a004178 constant DDRPHYC_DDRPHYC_GPR0  \ offset: 0x178 : DDRPHYC general purpose register 0
$5a00417c constant DDRPHYC_DDRPHYC_GPR1  \ offset: 0x17C : DDRPHYC general purpose register 1
$5a004180 constant DDRPHYC_DDRPHYC_ZQ0CR0  \ offset: 0x180 : DDRPHYC ZQ0C register 0
$5a004184 constant DDRPHYC_DDRPHYC_ZQ0CR1  \ offset: 0x184 : DDRPHYC ZQ0CR1 register
$5a004188 constant DDRPHYC_DDRPHYC_ZQ0SR0  \ offset: 0x188 : DDRPHYC ZQ0S register 0
$5a00418c constant DDRPHYC_DDRPHYC_ZQ0SR1  \ offset: 0x18C : DDRPHYC ZQ0S register 1
$5a0041c0 constant DDRPHYC_DDRPHYC_DX0GCR  \ offset: 0x1C0 : DDRPHYC byte lane 0 GC register
$5a0041c4 constant DDRPHYC_DDRPHYC_DX0GSR0  \ offset: 0x1C4 : DDRPHYC byte lane 0 GS register 0
$5a0041c8 constant DDRPHYC_DDRPHYC_DX0GSR1  \ offset: 0x1C8 : DDRPHYC byte lane 0 GS register 1
$5a0041cc constant DDRPHYC_DDRPHYC_DX0DLLCR  \ offset: 0x1CC : DDRPHYC byte lane 0 DLLC register
$5a0041d0 constant DDRPHYC_DDRPHYC_DX0DQTR  \ offset: 0x1D0 : DDRPHYC byte lane 0 DQT register
$5a0041d4 constant DDRPHYC_DDRPHYC_DX0DQSTR  \ offset: 0x1D4 : DDRPHYC byte lane 0 DQST register
$5a004200 constant DDRPHYC_DDRPHYC_DX1GCR  \ offset: 0x200 : DDRPHYC byte lane 1 GC register
$5a004204 constant DDRPHYC_DDRPHYC_DX1GSR0  \ offset: 0x204 : DDRPHYC byte lane 1 GS register 0
$5a004208 constant DDRPHYC_DDRPHYC_DX1GSR1  \ offset: 0x208 : DDRPHYC byte lane 1 GS register 1
$5a00420c constant DDRPHYC_DDRPHYC_DX1DLLCR  \ offset: 0x20C : DDRPHYC byte lane 1 DLLC register
$5a004210 constant DDRPHYC_DDRPHYC_DX1DQTR  \ offset: 0x210 : DDRPHYC byte lane 1 DQT register
$5a004214 constant DDRPHYC_DDRPHYC_DX1DQSTR  \ offset: 0x214 : DDRPHYC byte lane 1 DQST register

