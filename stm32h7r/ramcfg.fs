\
\ @file ramcfg.fs
\ @brief RAMs configuration controller
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief RAMECC interrupt enable register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_IER_GIE                            \ Global interrupt enable When GIE bit is set to 1, an interrupt is generated when an enabled global ECC error (GECCDEBWIE, GECCDEIE or GECCSEIE) occurs.
$00000002 constant RAMCFG_RAMECC_IER_GECCSEIE                       \ Global ECC single error interrupt enable When GECCSEIE bit is set to 1, an interrupt is generated when an ECC single error occurs during a read operation from RAM.
$00000004 constant RAMCFG_RAMECC_IER_GECCDEIE                       \ Global ECC double error interrupt enable When GECCDEIE bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_IER_GECCDEBWIE                     \ Global ECC double error on byte write (BW) interrupt enable When GECCDEBWIE bit is set to 1, an interrupt is generated when an ECC double detection error occurs during a byte write operation to RAM (incomplete word write).


\
\ @brief RAMECC monitor 1 configuration register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000004 constant RAMCFG_RAMECC_M1CR_ECCSEIE                       \ ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_M1CR_ECCDEIE                       \ ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
$00000010 constant RAMCFG_RAMECC_M1CR_ECCDEBWIE                     \ ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
$00000020 constant RAMCFG_RAMECC_M1CR_ECCELEN                       \ ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
$00000040 constant RAMCFG_RAMECC_M1CR_ECCSECEN                      \ ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
$00000080 constant RAMCFG_RAMECC_M1CR_ECCDECEN                      \ ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
$00000100 constant RAMCFG_RAMECC_M1CR_ECCDEBWCEN                    \ ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
$00030000 constant RAMCFG_RAMECC_M1CR_ECCTEA                        \ ECC Test ECC access


\
\ @brief RAMECC monitor 1 status register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_M1SR_SEDCF                         \ ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000002 constant RAMCFG_RAMECC_M1SR_DEDF                          \ ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000004 constant RAMCFG_RAMECC_M1SR_DEBWDF                        \ ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0


\
\ @brief RAMECC monitor 1 failing address register
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M1FAR_FADD                         \ ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.


\
\ @brief RAMECC monitor 1 failing data low register
\ Address offset: 0x2C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M1FDRL_FDATAL                      \ Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.


\
\ @brief RAMECC monitor 1 failing data high register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M1FDRH_FDATAH                      \ Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.


\
\ @brief RAMECC monitor 1 failing ECC error code register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M1FECR_FEC                         \ Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.


\
\ @brief RAMECC monitor 2 configuration register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000004 constant RAMCFG_RAMECC_M2CR_ECCSEIE                       \ ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_M2CR_ECCDEIE                       \ ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
$00000010 constant RAMCFG_RAMECC_M2CR_ECCDEBWIE                     \ ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
$00000020 constant RAMCFG_RAMECC_M2CR_ECCELEN                       \ ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
$00000040 constant RAMCFG_RAMECC_M2CR_ECCSECEN                      \ ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
$00000080 constant RAMCFG_RAMECC_M2CR_ECCDECEN                      \ ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
$00000100 constant RAMCFG_RAMECC_M2CR_ECCDEBWCEN                    \ ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
$00030000 constant RAMCFG_RAMECC_M2CR_ECCTEA                        \ ECC Test ECC access


\
\ @brief RAMECC monitor 2 status register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_M2SR_SEDCF                         \ ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000002 constant RAMCFG_RAMECC_M2SR_DEDF                          \ ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000004 constant RAMCFG_RAMECC_M2SR_DEBWDF                        \ ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0


\
\ @brief RAMECC monitor 2 failing address register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M2FAR_FADD                         \ ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.


\
\ @brief RAMECC monitor 2 failing data low register
\ Address offset: 0x4C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M2FDRL_FDATAL                      \ Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.


\
\ @brief RAMECC monitor 2 failing data high register
\ Address offset: 0x50
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M2FDRH_FDATAH                      \ Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.


\
\ @brief RAMECC monitor 2 failing ECC error code register
\ Address offset: 0x54
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M2FECR_FEC                         \ Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.


\
\ @brief RAMECC monitor 3 configuration register
\ Address offset: 0x60
\ Reset value: 0x00000000
\

$00000004 constant RAMCFG_RAMECC_M3CR_ECCSEIE                       \ ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_M3CR_ECCDEIE                       \ ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
$00000010 constant RAMCFG_RAMECC_M3CR_ECCDEBWIE                     \ ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
$00000020 constant RAMCFG_RAMECC_M3CR_ECCELEN                       \ ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
$00000040 constant RAMCFG_RAMECC_M3CR_ECCSECEN                      \ ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
$00000080 constant RAMCFG_RAMECC_M3CR_ECCDECEN                      \ ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
$00000100 constant RAMCFG_RAMECC_M3CR_ECCDEBWCEN                    \ ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
$00030000 constant RAMCFG_RAMECC_M3CR_ECCTEA                        \ ECC Test ECC access


\
\ @brief RAMECC monitor 3 status register
\ Address offset: 0x64
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_M3SR_SEDCF                         \ ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000002 constant RAMCFG_RAMECC_M3SR_DEDF                          \ ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000004 constant RAMCFG_RAMECC_M3SR_DEBWDF                        \ ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0


\
\ @brief RAMECC monitor 3 failing address register
\ Address offset: 0x68
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M3FAR_FADD                         \ ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.


\
\ @brief RAMECC monitor 3 failing data low register
\ Address offset: 0x6C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M3FDRL_FDATAL                      \ Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.


\
\ @brief RAMECC monitor 3 failing data high register
\ Address offset: 0x70
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M3FDRH_FDATAH                      \ Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.


\
\ @brief RAMECC monitor 3 failing ECC error code register
\ Address offset: 0x74
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M3FECR_FEC                         \ Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.


\
\ @brief RAMECC monitor 4 configuration register
\ Address offset: 0x80
\ Reset value: 0x00000000
\

$00000004 constant RAMCFG_RAMECC_M4CR_ECCSEIE                       \ ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_M4CR_ECCDEIE                       \ ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
$00000010 constant RAMCFG_RAMECC_M4CR_ECCDEBWIE                     \ ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
$00000020 constant RAMCFG_RAMECC_M4CR_ECCELEN                       \ ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
$00000040 constant RAMCFG_RAMECC_M4CR_ECCSECEN                      \ ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
$00000080 constant RAMCFG_RAMECC_M4CR_ECCDECEN                      \ ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
$00000100 constant RAMCFG_RAMECC_M4CR_ECCDEBWCEN                    \ ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
$00030000 constant RAMCFG_RAMECC_M4CR_ECCTEA                        \ ECC Test ECC access


\
\ @brief RAMECC monitor 4 status register
\ Address offset: 0x84
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_M4SR_SEDCF                         \ ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000002 constant RAMCFG_RAMECC_M4SR_DEDF                          \ ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000004 constant RAMCFG_RAMECC_M4SR_DEBWDF                        \ ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0


\
\ @brief RAMECC monitor 4 failing address register
\ Address offset: 0x88
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M4FAR_FADD                         \ ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.


\
\ @brief RAMECC monitor 4 failing data low register
\ Address offset: 0x8C
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M4FDRL_FDATAL                      \ Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.


\
\ @brief RAMECC monitor 4 failing data high register
\ Address offset: 0x90
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M4FDRH_FDATAH                      \ Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.


\
\ @brief RAMECC monitor 4 failing ECC error code register
\ Address offset: 0x94
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M4FECR_FEC                         \ Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.


\
\ @brief RAMECC monitor 5 configuration register
\ Address offset: 0xA0
\ Reset value: 0x00000000
\

$00000004 constant RAMCFG_RAMECC_M5CR_ECCSEIE                       \ ECC single error interrupt enable When ECCSEIE bit is set to 1, monitor x generates an interrupt when an ECC single error occurs during a read operation from RAM.
$00000008 constant RAMCFG_RAMECC_M5CR_ECCDEIE                       \ ECC double error interrupt enable When ECCDEIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a read operation from RAM.
$00000010 constant RAMCFG_RAMECC_M5CR_ECCDEBWIE                     \ ECC double error on byte write (BW) interrupt enable When ECCDEBWIE bit is set to 1, monitor x generates an interrupt when an ECC double detection error occurs during a byte write operation to RAM.
$00000020 constant RAMCFG_RAMECC_M5CR_ECCELEN                       \ ECC error latching enable When ECCELEN bit is set to 1, if an ECC error occurs (both for single error correction or double detection) during a read operation, the context (address, data and ECC code) that generated the error are latched to their respective registers.
$00000040 constant RAMCFG_RAMECC_M5CR_ECCSECEN                      \ ECC single error counter enable When ECCSECEN bit is set to 1, the occurrence counter is incremented when an ECC single error occurs during a read operation from RAM.
$00000080 constant RAMCFG_RAMECC_M5CR_ECCDECEN                      \ ECC double error counter enable When ECCDECEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a read operation from RAM.
$00000100 constant RAMCFG_RAMECC_M5CR_ECCDEBWCEN                    \ ECC double error on byte write (BW) counter enable When ECCDEBWCEN bit is set to 1, the occurrence counter is incremented when an ECC double detection error occurs during a byte write operation to RAM.
$00030000 constant RAMCFG_RAMECC_M5CR_ECCTEA                        \ ECC Test ECC access


\
\ @brief RAMECC monitor 5 status register
\ Address offset: 0xA4
\ Reset value: 0x00000000
\

$00000001 constant RAMCFG_RAMECC_M5SR_SEDCF                         \ ECC single error detected and corrected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000002 constant RAMCFG_RAMECC_M5SR_DEDF                          \ ECC double error detected flag This bit is set by hardware. It is cleared by software by writing a 0
$00000004 constant RAMCFG_RAMECC_M5SR_DEBWDF                        \ ECC double error on byte write (BW) detected flag This bit is set by hardware. It is cleared by software by writing a 0


\
\ @brief RAMECC monitor 5 failing address register
\ Address offset: 0xA8
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M5FAR_FADD                         \ ECC error failing address When an ECC error occurs the FADD bitfield contains the address that generated the ECC error.


\
\ @brief RAMECC monitor 5 failing data low register
\ Address offset: 0xAC
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M5FDRL_FDATAL                      \ Failing data low When an ECC error occurs the FDATAL bitfield contains the LSB part of the data that generated the error. For 32-bit word SRAM, this bitfield contains the full memory word that generated the error.


\
\ @brief RAMECC monitor 5 failing data high register
\ Address offset: 0xB0
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M5FDRH_FDATAH                      \ Failing data high (64-bit memory) When an ECC error occurs the FDATAH bitfield contains the MSB part of the data that generated the error.


\
\ @brief RAMECC monitor 5 failing ECC error code register
\ Address offset: 0xB4
\ Reset value: 0x00000000
\

$00000000 constant RAMCFG_RAMECC_M5FECR_FEC                         \ Failing error code When an ECC error occurs the FEC bitfield contains the ECC failing code that generated the error.


\
\ @brief RAMs configuration controller
\
$58027000 constant RAMCFG_RAMECC_IER  \ offset: 0x00 : RAMECC interrupt enable register
$58027020 constant RAMCFG_RAMECC_M1CR  \ offset: 0x20 : RAMECC monitor 1 configuration register
$58027024 constant RAMCFG_RAMECC_M1SR  \ offset: 0x24 : RAMECC monitor 1 status register
$58027028 constant RAMCFG_RAMECC_M1FAR  \ offset: 0x28 : RAMECC monitor 1 failing address register
$5802702c constant RAMCFG_RAMECC_M1FDRL  \ offset: 0x2C : RAMECC monitor 1 failing data low register
$58027030 constant RAMCFG_RAMECC_M1FDRH  \ offset: 0x30 : RAMECC monitor 1 failing data high register
$58027034 constant RAMCFG_RAMECC_M1FECR  \ offset: 0x34 : RAMECC monitor 1 failing ECC error code register
$58027040 constant RAMCFG_RAMECC_M2CR  \ offset: 0x40 : RAMECC monitor 2 configuration register
$58027044 constant RAMCFG_RAMECC_M2SR  \ offset: 0x44 : RAMECC monitor 2 status register
$58027048 constant RAMCFG_RAMECC_M2FAR  \ offset: 0x48 : RAMECC monitor 2 failing address register
$5802704c constant RAMCFG_RAMECC_M2FDRL  \ offset: 0x4C : RAMECC monitor 2 failing data low register
$58027050 constant RAMCFG_RAMECC_M2FDRH  \ offset: 0x50 : RAMECC monitor 2 failing data high register
$58027054 constant RAMCFG_RAMECC_M2FECR  \ offset: 0x54 : RAMECC monitor 2 failing ECC error code register
$58027060 constant RAMCFG_RAMECC_M3CR  \ offset: 0x60 : RAMECC monitor 3 configuration register
$58027064 constant RAMCFG_RAMECC_M3SR  \ offset: 0x64 : RAMECC monitor 3 status register
$58027068 constant RAMCFG_RAMECC_M3FAR  \ offset: 0x68 : RAMECC monitor 3 failing address register
$5802706c constant RAMCFG_RAMECC_M3FDRL  \ offset: 0x6C : RAMECC monitor 3 failing data low register
$58027070 constant RAMCFG_RAMECC_M3FDRH  \ offset: 0x70 : RAMECC monitor 3 failing data high register
$58027074 constant RAMCFG_RAMECC_M3FECR  \ offset: 0x74 : RAMECC monitor 3 failing ECC error code register
$58027080 constant RAMCFG_RAMECC_M4CR  \ offset: 0x80 : RAMECC monitor 4 configuration register
$58027084 constant RAMCFG_RAMECC_M4SR  \ offset: 0x84 : RAMECC monitor 4 status register
$58027088 constant RAMCFG_RAMECC_M4FAR  \ offset: 0x88 : RAMECC monitor 4 failing address register
$5802708c constant RAMCFG_RAMECC_M4FDRL  \ offset: 0x8C : RAMECC monitor 4 failing data low register
$58027090 constant RAMCFG_RAMECC_M4FDRH  \ offset: 0x90 : RAMECC monitor 4 failing data high register
$58027094 constant RAMCFG_RAMECC_M4FECR  \ offset: 0x94 : RAMECC monitor 4 failing ECC error code register
$580270a0 constant RAMCFG_RAMECC_M5CR  \ offset: 0xA0 : RAMECC monitor 5 configuration register
$580270a4 constant RAMCFG_RAMECC_M5SR  \ offset: 0xA4 : RAMECC monitor 5 status register
$580270a8 constant RAMCFG_RAMECC_M5FAR  \ offset: 0xA8 : RAMECC monitor 5 failing address register
$580270ac constant RAMCFG_RAMECC_M5FDRL  \ offset: 0xAC : RAMECC monitor 5 failing data low register
$580270b0 constant RAMCFG_RAMECC_M5FDRH  \ offset: 0xB0 : RAMECC monitor 5 failing data high register
$580270b4 constant RAMCFG_RAMECC_M5FECR  \ offset: 0xB4 : RAMECC monitor 5 failing ECC error code register

